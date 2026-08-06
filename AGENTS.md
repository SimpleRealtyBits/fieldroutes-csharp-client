# AGENTS.md — FieldRoutesApiClient development rules

Rules for anyone (human or AI agent) working in this repository.

## No auto-generation — models are hand-maintained

- `src/Entities/Models/*.cs` are **hand-maintained**. Never regenerate them.
- `api.md` is **reference material only**. It is not an executable spec: it contains
  typos, wrong types, and 3-column response tables whose descriptions the legacy
  generator could not even read. Never treat it as ground truth for a property type.
- **Never run `tools/generate.py`.** Never add a build/CI step that runs it. It wipes
  `src/Entities/` and would silently revert every manual type fix documented below.
- `tools/generate.py` is **deprecated**, retained only as historical record of how the
  models were originally derived. Do not edit it except to keep the deprecation notice
  accurate.
- Ground truth for any field is a **real FieldRoutes response**. When api.md and live
  data disagree, live data wins — that is exactly what the `// MANUAL FIX` comments
  in the models document.

## New / changed fields workflow

1. Find the field in `api.md` for the entity + endpoint (response tables under the
   `[id]` / `get` endpoints).
2. Better: capture a **real response** (a live `get`/`search` call with your account
   credentials) and copy the shape from that.
3. Verify against live FieldRoutes data when possible. Assume api.md types can be
   wrong until proven (the existing `// MANUAL FIX` comments are examples of exactly
   this).
4. Update the model by hand in `src/Entities/Models/<Entity>.cs`.
5. Add a `// MANUAL FIX (YYYY-MM-DD):` comment documenting the deviation (format
   below).
6. Add/adjust a test in `tests/FieldRoutesApiClient.Tests/ModelWireTypeTests.cs` that
   deserializes the real wire shape and asserts no exception + correct values.
7. `dotnet build` and `dotnet test` must pass.

Tolerant parsing is global (see `src/Core/FrJson.cs`): numeric fields accept
`""` / `"N/A"` / `"5.0"`, string fields accept non-string tokens (stored as raw JSON
text), and ID-list fields accept arrays, numbers, and comma-separated strings. Prefer
the correct real type plus these existing converters over inventing per-property
parsing logic.

## Documentation requirement

- Every **public member** must have an XML doc comment — classes (`/// <summary>`),
  properties, methods. Summaries explain what the member is, not how it is
  implemented.
- All **non-trivial logic** needs an explanatory comment: why it exists and what wire
  quirk it handles. This applies to the converters (`FrJson.cs`), transport handling
  (`FieldRoutesCore.cs`: envelope parsing, plural-key unwrap, search dynamic keys,
  `DeserializeSafe` error wrapping), and any future parsing code.
- Name the FieldRoutes quirk explicitly (e.g. "office/get returns records under the
  plural key") so the reason survives after the original context is forgotten.

## Manual fix annotation convention

Every manual deviation from the api.md-generated shape (or from the obvious wire type)
MUST carry a `// MANUAL FIX:` comment noting:

- what was wrong (old type vs real wire type),
- evidence (api.md line/description, or observed live data),
- date,
- FieldRoutes entity/endpoint affected (if known).

Format:

```csharp
// MANUAL FIX (2026-08-05): api.md types additionalTechs as string, but real wire
// returns an array of employee IDs ([123,456]) — fixed to int[]?. See api.md line 715/867.
```

api.md line references are best-effort (the file drifts); the old-type → wire-type
description is the part that must stay accurate.

## Build & test

```sh
dotnet build                                   # must be 0 errors
dotnet test tests/FieldRoutesApiClient.Tests/  # all tests must pass
```

Tests live in `tests/FieldRoutesApiClient.Tests/` (xunit, fake HTTP handler — no live
API calls).

## Gotchas

- `FieldRoutesApiException(status, text, message)` carries the raw response body in
  `ResponseBody`; never log request bodies — they contain the account authentication
  key/token.
- Search responses use dynamic keys (`idName` / `propertyName` / `propertyNameData`);
  see `FieldRoutesCore.PostSearchAsync`.
- api.md response tables are 3-column (Field/Type/Description) while parameter tables
  are 4-column, so the legacy generator never saw response descriptions. That is one
  reason its type guesses cannot be trusted — always verify against live data.
