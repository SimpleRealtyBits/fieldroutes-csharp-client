// Originally generated from api.md by tools/generate.py (now DEPRECATED).
// This file is MANUALLY MAINTAINED — never regenerate. See AGENTS.md.
#nullable enable
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using FieldRoutesApiClient.Core;

namespace FieldRoutesApiClient.Entities;
/// <summary>FieldRoutesSpot record as returned by the FieldRoutes API.</summary>
public sealed class FieldRoutesSpot
{
    public int? SpotID { get; set; }
    public int? RouteID { get; set; }
    public string? Date { get; set; }
    public string? Start { get; set; }
    public string? End { get; set; }
    public int? SpotCapacity { get; set; }
    public string? Description { get; set; }
    public int? CurrentAppointment { get; set; }
    public int? CurrentAppointmentDuration { get; set; }
    public string? BlockReason { get; set; }
    public decimal? DistanceToPrevious { get; set; }
    public decimal? PreviousLat { get; set; }
    public decimal? PreviousLng { get; set; }
    public int? PrevCustomer { get; set; }
    public int? PrevSpotID { get; set; }
    public int? PrevAppointmentID { get; set; }
    public decimal? DistanceToNext { get; set; }
    public decimal? NextLat { get; set; }
    public decimal? NextLng { get; set; }
    public int? NextCustomer { get; set; }
    public int? NextSpotID { get; set; }
    public int? NextAppointmentID { get; set; }
    public int? ApiCanSchedule { get; set; }
    public int? AssignedTech { get; set; }
    // MANUAL FIX (2026-08-05): api.md spot response table has no `open` field — the only
    // mention is a spot/get `open=1` PARAM documented as "return only open ROUTES" (semantically
    // different). But aruza's production schedule board read per-spot `Open` (0/1) directly from
    // real spot/get responses on the same tenant — added for blocked-slot rendering
    // (IsBlocked = Open == 0 && CurrentAppointment <= 0). int? matches sibling flags
    // (ApiCanSchedule, Reserved); TolerantNullableInt32Converter yields null if a response omits
    // it — consumers should treat null as not-open.
    public int? Open { get; set; }
    public int? Reserved { get; set; }
    public string? ReservationEnd { get; set; }
}
