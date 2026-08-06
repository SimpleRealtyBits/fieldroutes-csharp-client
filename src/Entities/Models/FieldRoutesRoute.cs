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
/// <summary>FieldRoutesRoute record as returned by the FieldRoutes API.</summary>
public sealed class FieldRoutesRoute
{
    public int? RouteID { get; set; }
    // MANUAL FIX (2026-08-05): api.md types route.title as integer, but real wire
    // returns the route's title text as a string — fixed to string?. See api.md line 4616/4680.
    public string? Title { get; set; }
    public int? TemplateID { get; set; }
    public string? DateAdded { get; set; }
    public int? AddedBy { get; set; }
    public int? OfficeID { get; set; }
    public int? GroupID { get; set; }
    // MANUAL FIX (2026-08-05): api.md route response types groupTitle as integer, but real
    // wire returns a string; the route/search table itself documents it as string ("Title of
    // the group associated with the route") — fixed to string?. See api.md line 4622/4686 (response), 4721 (search).
    public string? GroupTitle { get; set; }
    public string? Date { get; set; }
    // MANUAL FIX (2026-08-05): api.md types dayNotes as integer, but real wire returns
    // free-text day notes as a string — fixed to string?. See api.md line 4624/4688.
    public string? DayNotes { get; set; }
    public int? DayAlert { get; set; }
    public int? DayID { get; set; }
    // MANUAL FIX (2026-08-05): api.md types additionalTechs as string ("Comma separated"),
    // but real wire returns an array of employee IDs ([123,456]) — fixed to int[]?
    // (TolerantInt32ArrayConverter also accepts the comma-separated form). See api.md line 4627/4691.
    public int[]? AdditionalTechs { get; set; }
    public int? AssignedTech { get; set; }
    public int? ApiCanSchedule { get; set; }
    // MANUAL FIX (2026-08-05): api.md types scheduleTeams as string but describes it as
    // "Array of teams that can schedule to the route" — real wire is an array of team IDs —
    // fixed to int[]?. See api.md line 4630/4694.
    public int[]? ScheduleTeams { get; set; }
    // MANUAL FIX (2026-08-05): api.md types scheduleTypes as string but describes it as
    // "Array of systemTypes that can schedule to the route. {0 office staff, 1 techs, 2 sales, 3 api}"
    // — real wire is an array of ints — fixed to int[]?. See api.md line 4631/4695.
    public int[]? ScheduleTypes { get; set; }
    public decimal? AverageLatitude { get; set; }
    public decimal? AverageLongitude { get; set; }
    public decimal? AverageDistance { get; set; }
    public string? DateUpdated { get; set; }
    public int? DistanceScore { get; set; }
}
