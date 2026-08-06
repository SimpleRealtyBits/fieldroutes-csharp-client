# FieldRoutesApiClient

Typed .NET 10 client for the [FieldRoutes](https://fieldroutes.com) (PestRoutes) API. The entity surface was originally derived from the official API reference (`api.md`) and is now **hand-maintained** — `api.md` is reference-only and is never regenerated from. See `AGENTS.md` for the maintenance policy. Every entity, endpoint, parameter, and response field in the current API docs is covered.

Credentials are supplied per client instance, so one process can talk to any number of FieldRoutes accounts (each with its own subdomain and API key pair) without restarting or reconfiguration. Clients are created at runtime via `IFieldRoutesClientFactory`; nothing is bound at startup.

## How the FieldRoutes API works

The FieldRoutes API is not a standard REST API. The client follows the official conventions:

- **Every call is a POST** to `{baseUrl}/api/{entity}/{action}` — including reads like `customer/search` and `customer/get`.
- **Authentication travels in the request body** as `authenticationKey` and `authenticationToken` — never in headers.
- **Responses are wrapped** in a `{ success, result, errorMessage }` envelope. A call can return HTTP 200 with `success: false`.
- **Search responses use dynamic keys.** The API echoes `idName`, `propertyName`, and `propertyNameData` fields that tell you where the ID array and the resolved data array live. The client reads these instead of hardcoding names.
- **Base URL is per-account:** `https://{subdomain}.pestroutes.com/api/` — each account has its own subdomain.

These decisions are handled inside the client; callers don't see any of it.

## Install
```sh
dotnet add package FieldRoutesApiClient --version 1.0.0 --source https://nuget.pkg.github.com/SimpleRealtyBits/index.json
```

Developing against the source instead, add a project reference:

```xml
<ItemGroup>
  <ProjectReference Include="../fieldroutes-api-client/fieldroutes-api-client.csproj" />
</ItemGroup>
```

## Quick start

Register the client factory in your `Program.cs`:

```csharp
using FieldRoutesApiClient.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFieldRoutesClient();
```

Inject `IFieldRoutesClientFactory` anywhere, create a client for an account's credentials, and call:

```csharp
public class FieldRoutesWorker(IFieldRoutesClientFactory factory)
{
    public async Task RunAsync(AccountCredentials creds, CancellationToken ct)
    {
        var api = factory.Create(
            creds.BaseUrl,              // e.g. "https://acme.pestroutes.com"
            creds.AuthenticationKey,    // Settings > API in FieldRoutes
            creds.AuthenticationToken); // Settings > API in FieldRoutes

        var ids = await api.Customers.SearchAsync(
            new FieldRoutesCustomerSearchParameters { OfficeIDs = 1 }, ct: ct);

        var customers = await api.Customers.GetBulkAsync(ids.IDs, ct: ct);
        // ...
    }
}

public sealed class AccountCredentials(string baseUrl, string authenticationKey, string authenticationToken)
{
    public string BaseUrl { get; } = baseUrl;
    public string AuthenticationKey { get; } = authenticationKey;
    public string AuthenticationToken { get; } = authenticationToken;
}
```

### Using the options object

Useful when the credentials come from a config object:

```csharp
var api = factory.Create(new FieldRoutesOptions
{
    BaseUrl = creds.BaseUrl,
    AuthenticationKey = creds.AuthenticationKey,
    AuthenticationToken = creds.AuthenticationToken,
});
```

`BaseUrl` accepts any of these forms — all normalize to `https://acme.pestroutes.com/api/`:

```csharp
"https://acme.pestroutes.com"
"https://acme.pestroutes.com/api"
"https://acme.pestroutes.com/api/"
```

### Working with multiple accounts

- All 56 account clients share one `HttpClient`. This is safe because authentication is in the request body and URLs are built per account — no per-account state exists on the connection.
- **Validate credentials before storing them:** make a small request (e.g. `api.Offices.SearchAsync(new FieldRoutesOfficeSearchParameters())`) and treat a non-`FieldRoutesApiException` result as valid. These are full API credentials — encrypt them at rest wherever you persist them.
- **No disposal or eviction needed:** clients are stateless; create one per request/job without pooling, and drop the reference when done.

### Without DI

The client also works without a container:

```csharp
var api = new FieldRoutesApi(new FieldRoutesOptions
{
    BaseUrl = "https://demo.pestroutes.com",
    AuthenticationKey = "key",
    AuthenticationToken = "token",
});
```

## API surface

Every entity in the API docs has several pieces. Data types (models, requests, search parameters, results) are prefixed `FieldRoutes` so they coexist with your own domain models (`Customer` vs `FieldRoutesCustomer`). Clients use the plain plural entity name.

| Piece | Example | Location |
|---|---|---|
| Model (response record) | `FieldRoutesCustomer` | `src/Entities/Models/` |
| Request (create/update/action params) | `FieldRoutesCustomerCreateRequest` | `src/Entities/Requests/` |
| Search parameters | `FieldRoutesCustomerSearchParameters` | `src/Entities/Search/` |
| Action result (documented actions only) | `FieldRoutesCustomerCreatePaymentProfileResult` | `src/Entities/Results/` |
| Client | `CustomersClient` | `src/Entities/Clients/` |
| Facade property | `api.Customers` | on `FieldRoutesApi` |

The facade exposes one property per entity: `api.Customers`, `api.Appointments`, `api.Spots`, `api.ServicePlans`, and 52 more.

Every client method takes an optional `CancellationToken ct = default` (omitted from examples below for brevity).

## Examples

### Get one record by ID

```csharp
var customer = await api.Customers.GetAsync(1234);
Console.WriteLine($"{customer.Fname} {customer.Lname}");
```

Some `GetAsync` calls take extra optional parameters from the docs, e.g. appointments:

```csharp
var appointment = await api.Appointments.GetAsync(99,
    new FieldRoutesAppointmentGetParameters
    {
        IncludeCancellationReason = 1,
        IncludeTargetPests = 1,
        IncludeCustomFields = 1,
    });
```

### Bulk get (max 1000 records per call)

```csharp
var customers = await api.Customers.GetBulkAsync(new[] { 1, 2, 3, 4 });
```

If an entity's `get` endpoint documents extra parameters (e.g. `spot/get` accepts `latitude`/`longitude`/`maxDistance`), pass `GetBulkParameters`:

```csharp
var spots = await api.Spots.GetBulkAsync(spotIds,
    new FieldRoutesSpotGetBulkParameters { MaxDistance = 25 });
```

### Search — IDs only

```csharp
var result = await api.Customers.SearchAsync(
    new FieldRoutesCustomerSearchParameters
    {
        OfficeIDs = 7,
        Lname = "Smith",
        DateAddedStart = "2024-01-01",
    });

// result.IDs        -> matching customer IDs
// result.Count      -> total matches (IDs can be up to 50,000)
// result.IdName     -> "customerIDs" (meta echo from the API)
```

### Search — filter operators

Every search parameter accepts either a simple value or a query object. Build query objects with `FilterValue` in `AdditionalFilters`:

```csharp
var p = new FieldRoutesCustomerSearchParameters { OfficeIDs = 7 };
p.AdditionalFilters["dateAdded"] = new FilterValue(">", "2016-01-01");
p.AdditionalFilters["dateUpdated"] = new FilterValue("BETWEEN", new[] { "2024-05-12", "2024-05-13" });

var ids = (await api.Customers.SearchAsync(p)).IDs;
```

Operators: `>`, `<`, `>=`, `<=`, `=`, `!=`, `IN`, `BETWEEN`, `LIKE`, `STARTSWITH`, `ENDSWITH`, `CONTAINS`. `BETWEEN` and `IN` take arrays.

### Search — include the records

Set `includeData: true` to have the API resolve the first 1000 records inline:

```csharp
var result = await api.Spots.SearchAsync(
    new FieldRoutesSpotSearchParameters { RouteID = 42 },
    includeData: true);

var spots = result.Data;                       // first 1000 records
var excluded = result.IDsNoDataExported;       // remaining IDs (>1000 results only)
```

When the result set exceeds 1000, `IDsNoDataExported` contains the IDs the API did not export (the `{entity}IDsNoDataExported` field). Fetch them in chunks of 1000:

```csharp
foreach (var chunk in result.IDsNoDataExported.Chunk(1000))
{
    var more = await api.Spots.GetBulkAsync(chunk);
    // ...
}
```

The field is an empty list (not null) when everything fits in `Data`.

### Create / Update / Delete

```csharp
var newCustomerId = await api.Customers.CreateAsync(
    new FieldRoutesCustomerCreateRequest
    {
        Fname = "Ada",
        Lname = "Lovelace",
        Email = "ada@example.com",
        CustomerLink = "external-id-123",   // your own primary key
    });
```

Write endpoints return the created/updated record ID (`int`) from the envelope's `result`. Actions with a documented response shape return a typed result:

```csharp
var profile = await api.Customers.CreatePaymentProfileAsync(
    new FieldRoutesCustomerCreatePaymentProfileRequest
    {
        CustomerID = newCustomerId,
        CreditCardToken = token,
        CreditCardTokenID = tokenId,
    });
// profile.ProfileID, profile.LastFour, ...
```

### Actions

Actions are methods named after the endpoint action:

```csharp
await api.Appointments.CancelAsync(
    new FieldRoutesAppointmentCancelRequest { AppointmentID = 99, CancelReason = "customer request" });

await api.Appointments.CompleteAsync(
    new FieldRoutesAppointmentCompleteRequest { AppointmentID = 99, Status = 1 });

await api.Spots.ReserveAsync(
    new FieldRoutesSpotReserveRequest { SpotID = 5, Duration = 30 });

await api.Spots.BlockAsync(
    new FieldRoutesSpotBlockRequest { SpotID = 5, SpotIDs = new[] { 6, 7 } });

await api.Spots.ReleaseAsync(
    new FieldRoutesSpotReleaseRequest { SpotID = 5 });
```

### Required parameters

Request classes throw `ArgumentException` at call time if a parameter the docs mark as Required (e.g. `appointmentID`) is null. Optional parameters are skipped entirely when null, so you only set what you send.

## Errors

All failures surface as `FieldRoutesApiException`:

```csharp
try
{
    var ids = await api.Customers.SearchAsync(p);
}
catch (FieldRoutesApiException ex)
{
    Console.WriteLine($"HTTP {ex.StatusCode}: {ex.Message}");
    Console.WriteLine(ex.ResponseBody);  // raw response for logging/diagnostics
}
```

Thrown when:
- the HTTP status is not 2xx (e.g. 401/500), or
- the API returns `success: false` — the message contains the API's `errorMessage`.

Note: do not log request bodies; they contain the account's authentication key and token.

## Project structure

```
api.md                                   # official API reference (reference-only — see AGENTS.md)
tools/generate.py                        # DEPRECATED code generator (do not run — see AGENTS.md)
src/Core/
  FieldRoutesApi.cs                      # facade: 56 entity client properties
  FieldRoutesApi.Partial.cs              # constructors
  FieldRoutesCore.cs                     # transport: POST + auth + envelope parsing
  FieldRoutesClientFactory.cs            # IFieldRoutesClientFactory (per-account clients)
  FieldRoutesOptions.cs                  # BaseUrl + credentials
  FieldRoutesApiException.cs
  FilterValue.cs                         # search query object
  SearchResponse.cs                      # IDs / Data / IDsNoDataExported / Count
  ServiceCollectionExtensions.cs         # AddFieldRoutesClient()
src/Entities/
  Models/                                # one file per class
  Requests/
  Search/
  Results/
  Clients/
tests/FieldRoutesApiClient.Tests/        # xunit smoke tests (fake HTTP handler)
```

## Model maintenance

Models are **hand-maintained**. `api.md` is reference material only — do not regenerate from it, and never run `tools/generate.py` (it is deprecated and would wipe `src/Entities/`, reverting all manual type fixes).

When a field deviates from api.md (or from the obvious wire type), the model carries a `// MANUAL FIX (YYYY-MM-DD):` comment noting what was wrong, the evidence, and the date — so anyone reading a model file can see exactly which fields differ from the docs and why. Full policy, the new-field workflow, and the documentation requirements live in `AGENTS.md`.

```sh
dotnet build                                   # 0 errors
dotnet test tests/FieldRoutesApiClient.Tests/  # all tests pass
```

## Known limitations

- **Documented vs live drift:** api.md mirrors the current docs bundle (`api.fieldroutes.com`). The docs bundle is generally authoritative, but if you hold account credentials you can diff the live spec (`POST /api/documentation/swagger`) against it to be certain.
- **Undocumented write responses:** endpoints without a documented response (most `create`/`update`/`delete`) return the envelope's `result` as `int`. If the API ever changes that shape, those methods are the ones to check.
- **Search caps:** `search` returns at most 50,000 IDs; `get`/`includeData` return at most 1,000 records per call. Paginate with `FilterValue(">", lastId)` on the ID field if you need more.
