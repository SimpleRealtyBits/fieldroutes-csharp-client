using System.Text.Json;
using FieldRoutesApiClient.Core;
using FieldRoutesApiClient.Entities;
using Xunit;

namespace FieldRoutesApiClient.Tests;

/// <summary>
/// Guards the model property types that the audit proved are mis-declared in
/// api.md: FieldRoutes returns strings where the doc says integer, and JSON
/// arrays (or comma-separated strings) where the doc says integer. These tests
/// deserialize realistic wire data and assert the values land in the right
/// typed properties without throwing JsonException.
/// </summary>
public sealed class ModelWireTypeTests
{
    private static T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json, FrJson.Options)!;

    [Fact]
    public void Route_StringTitleGroupTitleDayNotes_DoNotThrow()
    {
        var route = Deserialize<FieldRoutesRoute>("""
            {
              "routeID": 12,
              "title": "Route 3 - North Austin",
              "templateID": 7,
              "groupID": 2,
              "groupTitle": "Weekday Team",
              "date": "2024-05-01",
              "dayNotes": "Tight schedule, start at 8am",
              "dayAlert": 1,
              "assignedTech": 0,
              "averageDistance": "12.50"
            }
            """);

        Assert.Equal(12, route.RouteID);
        Assert.Equal("Route 3 - North Austin", route.Title);
        Assert.Equal("Weekday Team", route.GroupTitle);
        Assert.Equal("Tight schedule, start at 8am", route.DayNotes);
        Assert.Equal(12.50m, route.AverageDistance); // dirty numeric still tolerated
    }

    [Fact]
    public void Employee_StringEmail_DoNotThrow()
    {
        var employee = Deserialize<FieldRoutesEmployee>("""
            {
              "employeeID": 101,
              "officeID": 1,
              "fname": "Jane",
              "lname": "Doe",
              "type": 1,
              "email": "jane.doe@example.com",
              "username": "jdoe",
              "experience": ""
            }
            """);

        Assert.Equal(101, employee.EmployeeID);
        Assert.Equal("jane.doe@example.com", employee.Email);
        Assert.Null(employee.Experience); // dirty numeric "" -> null
    }

    [Fact]
    public void Customer_ArrayIdLists_ParseCorrectly()
    {
        var customer = Deserialize<FieldRoutesCustomer>("""
            {
              "customerID": 42,
              "fname": "Grace",
              "lname": "Hopper",
              "subscriptionIDs": [501, 502, 503],
              "appointmentIDs": [901, 902],
              "ticketIDs": [701],
              "paymentIDs": [601, 602, 603, 604],
              "unitIDs": [11, 12]
            }
            """);

        Assert.Equal([501, 502, 503], customer.SubscriptionIDs!);
        Assert.Equal([901, 902], customer.AppointmentIDs!);
        Assert.Equal([701], customer.TicketIDs!);
        Assert.Equal([601, 602, 603, 604], customer.PaymentIDs!);
        Assert.Equal([11, 12], customer.UnitIDs!);
    }

    [Fact]
    public void Customer_CommaSeparatedStringIdLists_DoNotThrow()
    {
        // FieldRoutes has been observed emitting these as comma-separated strings.
        var customer = Deserialize<FieldRoutesCustomer>("""
            {
              "customerID": 43,
              "subscriptionIDs": "501,502",
              "appointmentIDs": "901",
              "ticketIDs": "701,702,703",
              "paymentIDs": "",
              "unitIDs": null
            }
            """);

        Assert.Equal([501, 502], customer.SubscriptionIDs!);
        Assert.Equal([901], customer.AppointmentIDs!);
        Assert.Equal([701, 702, 703], customer.TicketIDs!);
        Assert.Null(customer.PaymentIDs);
        Assert.Null(customer.UnitIDs);
    }

    [Fact]
    public void Customer_ArrayWithNumericStrings_DoNotThrow()
    {
        var customer = Deserialize<FieldRoutesCustomer>("""
            {
              "customerID": 44,
              "subscriptionIDs": ["501", "502", "abc"],
              "appointmentIDs": 999
            }
            """);

        Assert.Equal([501, 502, 0], customer.SubscriptionIDs!); // garbage element -> 0, consistent with TolerantInt32Converter
        Assert.Equal([999], customer.AppointmentIDs!);          // single value tolerated as single-element array
    }

    [Fact]
    public void Appointment_ArrayUnitIDs_DoNotThrow()
    {
        var appointment = Deserialize<FieldRoutesAppointment>("""
            {
              "appointmentID": 55,
              "customerID": 42,
              "unitIDs": [11, 12, 13],
              "status": "7",
              "amountCollected": "0"
            }
            """);

        Assert.Equal(55, appointment.AppointmentID);
        Assert.Equal([11, 12, 13], appointment.UnitIDs!);
        Assert.Equal(7, appointment.Status); // dirty numeric string still tolerated
        Assert.Equal(0m, appointment.AmountCollected);
    }

    [Fact]
    public void SiblingModels_DirtyNumerics_DoNotThrow()
    {
        var spot = Deserialize<FieldRoutesSpot>("""
            { "spotID": 1, "spotCapacity": "N/A", "distanceToPrevious": "5.0", "currentAppointment": null }
            """);
        Assert.Equal(1, spot.SpotID);
        Assert.Null(spot.SpotCapacity);
        Assert.Equal(5.0m, spot.DistanceToPrevious);

        var serviceType = Deserialize<FieldRoutesServiceType>("""
            { "typeID": 2, "frequency": "", "defaultCharge": "19.99" }
            """);
        Assert.Equal(2, serviceType.TypeID);
        Assert.Null(serviceType.Frequency);
        Assert.Equal(19.99m, serviceType.DefaultCharge);

        var route = Deserialize<FieldRoutesRoute>("""
            { "routeID": 3, "dayAlert": "1", "distanceScore": "4.0" }
            """);
        Assert.Equal(1, route.DayAlert);
        Assert.Equal(4, route.DistanceScore);

        var employee = Deserialize<FieldRoutesEmployee>("""
            { "employeeID": 4, "type": "0", "roamingRep": "N/A" }
            """);
        Assert.Equal(0, employee.Type);
        Assert.Null(employee.RoamingRep);
    }

    [Fact]
    public void TolerantString_ArrayOrNumberIntoStringProperty_DoesNotThrow()
    {
        // Mirrors the live failure: a string-typed property receiving a JSON array.
        var customer = Deserialize<FieldRoutesCustomer>("""
            {
              "customerID": 1,
              "customerLink": ["ext-1","ext-2"],
              "masterAccount": 55,
              "billingCountryID": true
            }
            """);

        Assert.Equal(1, customer.CustomerID);
        Assert.Equal("""["ext-1","ext-2"]""", customer.CustomerLink); // raw JSON text, no throw
        Assert.Equal("55", customer.MasterAccount);
        Assert.Equal("true", customer.BillingCountryID);
        Assert.Null(customer.SpecialScheduling); // untouched string remains null
    }

    [Fact]
    public void Route_AdditionalTechsScheduleTeamsScheduleTypes_AreArrays()
    {
        var route = Deserialize<FieldRoutesRoute>("""
            { "routeID": 7, "additionalTechs": [123, 456], "scheduleTeams": [1, 2], "scheduleTypes": [0, 3] }
            """);

        Assert.Equal([123, 456], route.AdditionalTechs!);
        Assert.Equal([1, 2], route.ScheduleTeams!);
        Assert.Equal([0, 3], route.ScheduleTypes!);
    }

    [Fact]
    public void Appointment_AdditionalTechs_IsArray()
    {
        var appointment = Deserialize<FieldRoutesAppointment>("""
            { "appointmentID": 1, "additionalTechs": [5, 6] }
            """);

        Assert.Equal([5, 6], appointment.AdditionalTechs!);
    }

    [Fact]
    public void Payment_InvoiceIDsAndPaymentApplications_AreArrays()
    {
        var payment = Deserialize<FieldRoutesPayment>("""
            {
              "paymentID": 1,
              "invoiceIDs": [10, 11],
              "paymentApplications": [{"appliedAmount": 5.00, "invoiceID": 10}]
            }
            """);

        Assert.Equal([10, 11], payment.InvoiceIDs!);
        Assert.Single(payment.PaymentApplications!);
    }

    [Fact]
    public void Ticket_Items_IsArrayOfObjects()
    {
        var ticket = Deserialize<FieldRoutesTicket>("""
            { "ticketID": 1, "items": [{"description": "Service"}, {"description": "Addon"}] }
            """);

        Assert.Equal(2, ticket.Items!.Count);
    }

    [Fact]
    public void ServicePlan_AddOnsAndCompletedAppointmentIDs_AreArrays()
    {
        var plan = Deserialize<FieldRoutesServicePlan>("""
            { "completedAppointmentIDs": [1, 2, 3], "addOns": [{"productID": 9}] }
            """);
        Assert.Equal([1, 2, 3], plan.CompletedAppointmentIDs!);
        Assert.Single(plan.AddOns!);

        var sub = Deserialize<FieldRoutesSubscription>("""
            { "completedAppointmentIDs": [4], "addOns": [] }
            """);
        Assert.Equal([4], sub.CompletedAppointmentIDs!);
        Assert.Empty(sub.AddOns!);

        var round = Deserialize<FieldRoutesServicePlanRound>("""
            { "completedAppointmentIDs": [5, 6], "addOns": null }
            """);
        Assert.Equal([5, 6], round.CompletedAppointmentIDs!);
        Assert.Null(round.AddOns);
    }

    [Fact]
    public void Employee_SkillArrays_AreArrays()
    {
        var employee = Deserialize<FieldRoutesEmployee>("""
            {
              "employeeID": 1,
              "skillIDs": [1, 2],
              "skillDescriptions": ["Pest", "Termite"],
              "regionalManagerOfficeIDs": [3]
            }
            """);

        Assert.Equal([1, 2], employee.SkillIDs!);
        Assert.Equal(new[] { "Pest", "Termite" }, employee.SkillDescriptions!);
        Assert.Equal([3], employee.RegionalManagerOfficeIDs!);
    }

    [Fact]
    public void Spot_OpenFlag_ParsesIntAndStringVariants()
    {
        var open = Deserialize<FieldRoutesSpot>("""
            { "spotID": 1, "open": 1, "currentAppointment": 0 }
            """);
        Assert.Equal(1, open.Open);

        var blocked = Deserialize<FieldRoutesSpot>("""
            { "spotID": 2, "open": 0, "currentAppointment": 0 }
            """);
        Assert.Equal(0, blocked.Open);

        // Dirty/string variants via the tolerant nullable-int converter.
        var dirty = Deserialize<FieldRoutesSpot>("""
            { "spotID": 3, "open": "1", "currentAppointment": "" }
            """);
        Assert.Equal(1, dirty.Open);
        Assert.Null(dirty.CurrentAppointment);

        var empty = Deserialize<FieldRoutesSpot>("""
            { "spotID": 4, "open": "", "currentAppointment": null }
            """);
        Assert.Null(empty.Open);

        var omitted = Deserialize<FieldRoutesSpot>("""
            { "spotID": 5 }
            """);
        Assert.Null(omitted.Open); // absent on the wire -> null, consumers treat as not-open
    }

    [Fact]
    public void Employee_TeamIDsAndLinkedEmployeeIDs_AreArrays()
    {
        // Live employee/get returned teamIDs as an array (Path: $[0].teamIDs).
        var employee = Deserialize<FieldRoutesEmployee>("""
            {
              "employeeID": 1,
              "teamIDs": [1, 2],
              "linkedEmployeeIDs": [3]
            }
            """);

        Assert.Equal([1, 2], employee.TeamIDs!);
        Assert.Equal([3], employee.LinkedEmployeeIDs!);
        Assert.Equal(1, employee.EmployeeID);
    }

    [Fact]
    public void Employee_TeamIDs_CommaSeparatedString_AlsoParses()
    {
        // TolerantInt32ArrayConverter accepts the comma-separated-string variant too.
        var employee = Deserialize<FieldRoutesEmployee>("""
            { "employeeID": 2, "teamIDs": "4,5", "linkedEmployeeIDs": null }
            """);

        Assert.Equal([4, 5], employee.TeamIDs!);
        Assert.Null(employee.LinkedEmployeeIDs);
    }
}

public sealed class RoundTwoTransportTests
{
    [Fact]
    public async Task BulkGet_JsonException_WrapsWithEntityActionAndPath()
    {
        var handler = new FakeHandler
        {
            OnSend = _ => TestHelpers.JsonResponse("""
                {"success":true,"result":[{"appointmentID":1,"amountCollected":[]}]}
                """),
        };
        var http = new HttpClient(handler) { BaseAddress = new Uri("https://demo.pestroutes.com/api/") };
        var api = new FieldRoutesApi(http, new FieldRoutesOptions
        {
            BaseUrl = "https://demo.pestroutes.com/api/",
            AuthenticationKey = "key123",
            AuthenticationToken = "tok456",
        });

        var ex = await Assert.ThrowsAsync<FieldRoutesApiException>(
            () => api.Appointments.GetBulkAsync(new[] { 1 }));

        Assert.Contains("appointment/get", ex.Message);
        Assert.Contains("amountCollected", ex.Message); // wire-cased property name in Path
        Assert.Contains("$[0]", ex.Message);
        Assert.Equal(200, ex.StatusCode);
        Assert.Contains("amountCollected", ex.ResponseBody);
    }
}
