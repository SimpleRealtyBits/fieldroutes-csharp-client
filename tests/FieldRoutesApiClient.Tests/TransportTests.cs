using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using FieldRoutesApiClient.Core;
using FieldRoutesApiClient.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace FieldRoutesApiClient.Tests;

public sealed class FakeHandler : HttpMessageHandler
{
    public List<HttpRequestMessage> Requests { get; } = new();
    public Func<HttpRequestMessage, HttpResponseMessage> OnSend { get; set; } = _ => new HttpResponseMessage(HttpStatusCode.OK);

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct)
    {
        Requests.Add(request);
        return Task.FromResult(OnSend(request));
    }
}

internal static class TestHelpers
{
    public static async Task<JsonElement> ReadBody(HttpRequestMessage request)
    {
        var json = await request.Content!.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(json);
        return doc.RootElement.Clone();
    }

    public static HttpResponseMessage JsonResponse(string json) =>
        new(HttpStatusCode.OK) { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
}

public sealed class TransportTests
{
    private static (FieldRoutesApi Api, FakeHandler Handler) Create(Func<HttpRequestMessage, HttpResponseMessage> onSend)
    {
        var handler = new FakeHandler { OnSend = onSend };
        var http = new HttpClient(handler) { BaseAddress = new Uri("https://demo.pestroutes.com/api/") };
        var options = new FieldRoutesOptions
        {
            BaseUrl = "https://demo.pestroutes.com/api/",
            AuthenticationKey = "key123",
            AuthenticationToken = "tok456",
        };
        return (new FieldRoutesApi(http, options), handler);
    }

    private static async Task<JsonElement> ReadBody(HttpRequestMessage request)
        => await TestHelpers.ReadBody(request);

    [Fact]
    public async Task Search_PostsToEntitySearchPath_WithAuthInBody()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"idName":"customerIDs","customerIDs":[1,2],"propertyName":"customerIDs","count":2}
            """));

        var result = await api.Customers.SearchAsync(new FieldRoutesCustomerSearchParameters());

        var req = Assert.Single(handler.Requests);
        Assert.Equal(HttpMethod.Post, req.Method);
        Assert.Equal("/api/customer/search", req.RequestUri!.AbsolutePath);
        var body = await ReadBody(req);
        Assert.Equal("key123", body.GetProperty("authenticationKey").GetString());
        Assert.Equal("tok456", body.GetProperty("authenticationToken").GetString());
        Assert.Equal(2, result.IDs.Count);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public async Task Search_WithIncludeData_ParsesDynamicKeys()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"idName":"customerIDs","customerIDs":[42],"propertyName":"customers",
             "propertyNameData":"customers","customers":[{"customerID":42,"fname":"Ada","lname":"Lovelace"}],
             "customerIDsNoDataExported":[999,1000],"count":1001}
            """));

        var result = await api.Customers.SearchAsync(new FieldRoutesCustomerSearchParameters(), includeData: true);

        Assert.Equal([42], result.IDs);
        Assert.Equal([999, 1000], result.IDsNoDataExported);
        Assert.Equal("customers", result.PropertyNameData);
        var customer = Assert.Single(result.Data!);
        Assert.Equal(42, customer.CustomerID);
        Assert.Equal("Ada", customer.Fname);
        Assert.Equal(1001, result.Count);
    }

    [Fact]
    public async Task Search_IncludeData_WithEmptyNoDataExported_ReturnsEmptyList()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"idName":"spotIDs","spotIDs":[1,2],"propertyName":"spots",
             "propertyNameData":"spots","spots":[{"spotID":1},{"spotID":2}],
             "spotIDsNoDataExported":[],"count":2}
            """));

        var result = await api.Spots.SearchAsync(new FieldRoutesSpotSearchParameters(), includeData: true);

        Assert.Equal([1, 2], result.IDs);
        Assert.NotNull(result.IDsNoDataExported);
        Assert.Empty(result.IDsNoDataExported);
        Assert.Equal(2, result.Data!.Count);
    }

    [Fact]
    public async Task Search_AdditionalFilters_SentAsNestedObjects()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"idName":"customerIDs","customerIDs":[],"propertyName":"customerIDs","count":0}
            """));

        var p = new FieldRoutesCustomerSearchParameters
        {
            OfficeIDs = 7,
        };
        p.AdditionalFilters["dateAdded"] = new FilterValue(">", "2016-01-01");
        await api.Customers.SearchAsync(p);

        var body = await ReadBody(Assert.Single(handler.Requests));
        Assert.Equal(7, body.GetProperty("officeIDs").GetInt32());
        var f = body.GetProperty("dateAdded");
        Assert.Equal(">", f.GetProperty("operator").GetString());
        Assert.Equal("2016-01-01", f.GetProperty("value").GetString());
    }

    [Fact]
    public async Task Search_WrappedResultWithMeta_ParsesIds()
    {
        // Real FieldRoutes search shape: payload wrapped under "result" WITH meta keys.
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"result":{"idName":"routeIDs","routeIDs":[1,2],"propertyName":"routes","count":2}}
            """));

        var result = await api.Routes.SearchAsync(new FieldRoutesRouteSearchParameters());

        Assert.Equal([1, 2], result.IDs);
        Assert.Equal(2, result.Count);
        Assert.Equal("routeIDs", result.IdName);
        Assert.Equal("routes", result.PropertyName);
    }

    [Fact]
    public async Task Search_WrappedResultWithMetaAndData_ParsesData()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"result":{"idName":"routeIDs","routeIDs":[42],"propertyName":"routes","routes":[{"routeID":42,"title":"A"}],"count":1}}
            """));

        var result = await api.Routes.SearchAsync(new FieldRoutesRouteSearchParameters());

        Assert.Equal([42], result.IDs);
        Assert.Equal(1, result.Count);
        var route = Assert.Single(result.Data!);
        Assert.Equal(42, route.RouteID);
        Assert.Equal("A", route.Title);
    }

    [Fact]
    public async Task Search_WrappedResultWithoutIdName_FallsBackToFirstKeyEndingWith()
    {
        // Nested payload without meta keys: idName must be derived from the inner root.
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"result":{"routeIDs":[7]}}
            """));

        var result = await api.Routes.SearchAsync(new FieldRoutesRouteSearchParameters());

        Assert.Equal([7], result.IDs);
        Assert.Equal(1, result.Count);
        Assert.Equal("routeIDs", result.IdName);
    }

    [Fact]
    public async Task Search_IdsUnderPropertyNameKey_AreParsed_WithoutThrowing()
    {
        // Real serviceType/search shape: the idName key ("serviceTypeIDs") is absent
        // from the response and the ID list lives under the propertyName key
        // ("serviceTypes"). Previously the scalar array was misparsed as entity data
        // ("The JSON value could not be converted to ... Path: $[0]"), then, after the
        // data guard, it was silently skipped — leaving Count=300 with empty IDs.
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"idName":"serviceTypeIDs","propertyName":"serviceTypes",
             "serviceTypes":[1,2,3],"count":300}
            """));

        var result = await api.ServiceTypes.SearchAsync(new FieldRoutesServiceTypeSearchParameters());

        Assert.Equal([1, 2, 3], result.IDs);
        Assert.Equal(300, result.Count);
        Assert.Equal("serviceTypes", result.PropertyName);
        Assert.Null(result.Data);
    }

    [Fact]
    public async Task Search_PropertyNameKeyHoldsIdScalars_SkipsDataInsteadOfThrowing()
    {
        // If FieldRoutes duplicates the ID list under the propertyName key alongside
        // the real idName array, the scalar array must still be skipped as data.
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"idName":"serviceTypeIDs","serviceTypeIDs":[1,2],
             "propertyName":"serviceTypes","serviceTypes":[1,2],"count":2}
            """));

        var result = await api.ServiceTypes.SearchAsync(new FieldRoutesServiceTypeSearchParameters());

        Assert.Equal([1, 2], result.IDs);
        Assert.Equal(2, result.Count);
        Assert.Equal("serviceTypes", result.PropertyName);
        Assert.Null(result.Data);
    }

    [Fact]
    public async Task GetBulk_ParsesEnvelopeResultArray()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"result":[{"customerID":9,"fname":"Grace","dateUpdated":"2024-01-01"}]}
            """));

        var customers = await api.Customers.GetBulkAsync(new[] { 9 });

        var customer = Assert.Single(customers);
        Assert.Equal(9, customer.CustomerID);
        Assert.Equal("Grace", customer.Fname);
        Assert.Equal("2024-01-01", customer.DateUpdated);
    }

    [Fact]
    public async Task GetBulk_ParsesPluralKey_WhenNoResultEnvelope()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"offices":[{"officeID":1,"officeName":"Austin"},{"officeID":2,"officeName":"Dallas"}]}
            """));

        var offices = await api.Offices.GetBulkAsync(new[] { 1, 2 });

        Assert.Equal(2, offices.Count);
        Assert.Equal("Austin", offices[0].OfficeName);
        Assert.Equal(2, offices[1].OfficeID);
    }

    [Fact]
    public async Task GetBulk_DirtyNumericStrings_CoercedToNullOrDefault()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"offices":[{"officeID":"7","officeName":"Austin","licenseNumber":"","companyID":"12.0","contactNumber":"abc"}],
             "payments":[{"paymentID":"101","amount":"","unassignedAmount":"19.99"}]}
            """));

        var offices = await api.Offices.GetBulkAsync(new[] { 7 });
        var payments = await api.Payments.GetBulkAsync(new[] { 101 });

        var office = Assert.Single(offices);
        Assert.Equal(7, office.OfficeID);
        Assert.Null(office.LicenseNumber);
        Assert.Equal(12, office.CompanyID);
        Assert.Equal("abc", office.ContactNumber);

        var payment = Assert.Single(payments);
        Assert.Equal(101, payment.PaymentID);
        Assert.Null(payment.Amount);
        Assert.Equal(19.99m, payment.UnassignedAmount);
    }

    [Fact]
    public async Task Create_ReturnsResultId_FromEnvelope()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""{"success":true,"result":42}"""));

        var id = await api.Customers.CreateAsync(new FieldRoutesCustomerCreateRequest { Fname = "Alan" });

        Assert.Equal(42, id);
        var body = await ReadBody(Assert.Single(handler.Requests));
        Assert.Equal("Alan", body.GetProperty("fname").GetString());
    }

    [Fact]
    public async Task SuccessFalse_Throws_WithErrorMessage()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""{"success":false,"result":null,"errorMessage":"Bad token"}"""));

        var ex = await Assert.ThrowsAsync<FieldRoutesApiException>(
            () => api.Customers.SearchAsync(new FieldRoutesCustomerSearchParameters()));
        Assert.Contains("Bad token", ex.Message);
    }

    [Fact]
    public async Task HttpError_Throws()
    {
        var (api, handler) = Create(_ => new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("oops") });

        var ex = await Assert.ThrowsAsync<FieldRoutesApiException>(
            () => api.Customers.SearchAsync(new FieldRoutesCustomerSearchParameters()));
        Assert.Equal(500, ex.StatusCode);
        Assert.Equal("oops", ex.ResponseBody);
    }

    [Fact]
    public async Task AppointmentActions_UseEndpointPaths()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""{"success":true,"result":null}"""));
        await api.Appointments.CompleteAsync(new FieldRoutesAppointmentCompleteRequest { AppointmentID = 5 });
        await api.Spots.BlockAsync(new FieldRoutesSpotBlockRequest { SpotID = 1, SpotIDs = new[] { 2, 3 } });

        Assert.Equal("/api/appointment/complete", handler.Requests[0].RequestUri!.AbsolutePath);
        Assert.Equal("/api/spot/block", handler.Requests[1].RequestUri!.AbsolutePath);
        var body = await ReadBody(handler.Requests[1]);
        Assert.Equal(JsonSerializer.Serialize(new[] { 2, 3 }), body.GetProperty("spotIDs").GetRawText());
    }

    [Fact]
    public async Task Search_DefaultMaxResults_TrimsIdsTo100()
    {
        var manyIds = string.Join(",", Enumerable.Range(1, 200));
        var (api, _) = Create(_ => TestHelpers.JsonResponse($$$"""
            {"success":true,"idName":"customerIDs","customerIDs":[{{{manyIds}}}],"count":200}
            """));

        var result = await api.Customers.SearchAsync(new FieldRoutesCustomerSearchParameters());

        Assert.Equal(100, result.IDs.Count);
        Assert.Equal(1, result.IDs[0]);
        Assert.Equal(100, result.IDs[99]);
    }

    [Fact]
    public async Task Search_CustomMaxResults_TrimsIdsToSpecifiedLimit()
    {
        var manyIds = string.Join(",", Enumerable.Range(1, 50));
        var (api, _) = Create(_ => TestHelpers.JsonResponse($$$"""
            {"success":true,"idName":"customerIDs","customerIDs":[{{{manyIds}}}],"count":50}
            """));

        var result = await api.Customers.SearchAsync(new FieldRoutesCustomerSearchParameters { MaxResults = 10 });

        Assert.Equal(10, result.IDs.Count);
    }

    [Fact]
    public async Task Search_MaxResultsLargerThanResponse_ReturnsAll()
    {
        var (api, _) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"idName":"customerIDs","customerIDs":[1,2,3],"count":3}
            """));

        var result = await api.Customers.SearchAsync(new FieldRoutesCustomerSearchParameters { MaxResults = 500 });

        Assert.Equal(3, result.IDs.Count);
    }

    [Fact]
    public async Task GetBulk_DefaultMaxResults_LimitsIdsSentToApi()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"result":[{"customerID":1}]}
            """));

        var ids = Enumerable.Range(1, 200);
        await api.Customers.GetBulkAsync(ids);

        var body = await ReadBody(handler.Requests[0]);
        var sentIds = body.GetProperty("customerIDs").EnumerateArray().ToList();
        Assert.Equal(100, sentIds.Count);
    }

    [Fact]
    public async Task GetBulk_CustomMaxResults_LimitsIdsSentToApi()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"result":[{"customerID":1}]}
            """));

        var ids = Enumerable.Range(1, 200);
        await api.Customers.GetBulkAsync(ids, new FieldRoutesCustomerGetBulkParameters { MaxResults = 25 });

        var body = await ReadBody(handler.Requests[0]);
        var sentIds = body.GetProperty("customerIDs").EnumerateArray().ToList();
        Assert.Equal(25, sentIds.Count);
    }

    [Fact]
    public async Task GetBulk_WithoutParams_CustomMaxResults_LimitsIdsSentToApi()
    {
        var (api, handler) = Create(_ => TestHelpers.JsonResponse("""
            {"success":true,"result":[{"additionalContactID":1}]}
            """));

        var ids = Enumerable.Range(1, 200);
        await api.AdditionalContacts.GetBulkAsync(ids, maxResults: 15);

        var body = await ReadBody(handler.Requests[0]);
        var sentIds = body.GetProperty("additionalContactIDs").EnumerateArray().ToList();
        Assert.Equal(15, sentIds.Count);
    }
}

public sealed class DiTests
{
    [Fact]
    public void AddFieldRoutesClient_Resolves_FactoryAndClients()
    {
        var services = new ServiceCollection();
        services.AddFieldRoutesClient();
        using var sp = services.BuildServiceProvider();

        var factory = sp.GetRequiredService<IFieldRoutesClientFactory>();
        var api = factory.Create(new FieldRoutesOptions
        {
            BaseUrl = "https://demo.pestroutes.com",
            AuthenticationKey = "k",
            AuthenticationToken = "t",
        });
        Assert.NotNull(api.Customers);
        Assert.NotNull(api.Appointments);
        Assert.NotNull(api.ServicePlanRounds);
        Assert.Equal(api.Customers, api.Customers); // lazy caching
    }

    [Fact]
    public async Task Factory_CreatesPerTenantClients_NoCredentialLeakage()
    {
        var handler = new FakeHandler
        {
            OnSend = _ => new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("""{"success":true,"idName":"customerIDs","customerIDs":[],"propertyName":"customerIDs","count":0}"""),
            },
        };
        var services = new ServiceCollection();
        services.AddFieldRoutesClient();
        services.AddSingleton(handler);
        services.AddSingleton(sp => new HttpClient(sp.GetRequiredService<FakeHandler>()));
        using var sp = services.BuildServiceProvider();

        var factory = sp.GetRequiredService<IFieldRoutesClientFactory>();
        var tenantA = factory.Create("https://a.pestroutes.com/api/", "keyA", "tokA");
        var tenantB = factory.Create("https://b.pestroutes.com/api/", "keyB", "tokB");

        await tenantA.Customers.SearchAsync(new FieldRoutesCustomerSearchParameters());
        await tenantB.Customers.SearchAsync(new FieldRoutesCustomerSearchParameters());

        Assert.Equal(2, handler.Requests.Count);
        var bodyA = await TestHelpers.ReadBody(handler.Requests[0]);
        var bodyB = await TestHelpers.ReadBody(handler.Requests[1]);
        Assert.Equal("/api/customer/search", handler.Requests[0].RequestUri!.AbsolutePath);
        Assert.Equal("https://a.pestroutes.com", handler.Requests[0].RequestUri!.GetLeftPart(UriPartial.Authority));
        Assert.Equal("https://b.pestroutes.com", handler.Requests[1].RequestUri!.GetLeftPart(UriPartial.Authority));
        Assert.Equal("keyA", bodyA.GetProperty("authenticationKey").GetString());
        Assert.Equal("keyB", bodyB.GetProperty("authenticationKey").GetString());
        Assert.Equal("tokA", bodyA.GetProperty("authenticationToken").GetString());
        Assert.Equal("tokB", bodyB.GetProperty("authenticationToken").GetString());
    }

    [Fact]
    public void BaseUrl_Normalized_ToApiPath()
    {
        Assert.Equal("https://demo.pestroutes.com/api/", FieldRoutesCore.NormalizeBase("https://demo.pestroutes.com"));
        Assert.Equal("https://demo.pestroutes.com/api/", FieldRoutesCore.NormalizeBase("https://demo.pestroutes.com/api"));
        Assert.Equal("https://demo.pestroutes.com/api/", FieldRoutesCore.NormalizeBase("https://demo.pestroutes.com/api/"));
    }
}
