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
/// <summary>FieldRoutesEmployee record as returned by the FieldRoutes API.</summary>
public sealed class FieldRoutesEmployee
{
    public int? EmployeeID { get; set; }
    public int? OfficeID { get; set; }
    public int? Active { get; set; }
    public string? Fname { get; set; }
    public string? Lname { get; set; }
    public string? Initials { get; set; }
    public string? Nickname { get; set; }
    public int? Type { get; set; }
    public string? Phone { get; set; }
    // MANUAL FIX (2026-08-05): api.md employee response types email as integer ("Unique
    // Identifier" — doc error), but real wire returns the employee's email address string;
    // the employee/create endpoint documents email as string ("Employee email") — fixed to
    // string?. See api.md line 2869 (response), 2911 (create).
    public string? Email { get; set; }
    public string? Username { get; set; }
    public int? Experience { get; set; }
    // MANUAL FIX (2026-08-05): api.md types skillIDs as integer but describes "IDs of skills
    // associated with the technician" — real wire is an array of skill IDs — fixed to int[]?.
    // See api.md line 2872/2976.
    public int[]? SkillIDs { get; set; }
    // MANUAL FIX (2026-08-05): api.md types skillDescriptions as integer but describes
    // "Descriptions of skills associated with the technician" — real wire is an array of
    // strings — fixed to string[]?. See api.md line 2873/2977.
    public string[]? SkillDescriptions { get; set; }
    public string? Pic { get; set; }
    // MANUAL FIX (2026-08-05): api.md types linkedEmployeeIDs as integer, but real wire
    // returns an array of employee IDs — fixed to int[]? (TolerantInt32ArrayConverter
    // accepts array / single number / comma-separated string / null). See api.md line 2875/2979.
    public int[]? LinkedEmployeeIDs { get; set; }
    public string? EmployeeLink { get; set; }
    public string? LicenseNumber { get; set; }
    public int? SupervisorID { get; set; }
    public int? RoamingRep { get; set; }
    // MANUAL FIX (2026-08-05): api.md types regionalManagerOfficeIDs as integer but describes
    // "List of officeIDs this employee is a regional manager of" — real wire is an array of
    // office IDs — fixed to int[]?. See api.md line 2880/2984.
    public int[]? RegionalManagerOfficeIDs { get; set; }
    public string? LastLogin { get; set; }
    // MANUAL FIX (2026-08-05): api.md types teamIDs as integer, but real wire returns an
    // array of team IDs — live employee/get threw "Unexpected token StartArray for Int32?.
    // Path: $[0].teamIDs" — fixed to int[]? (TolerantInt32ArrayConverter accepts array /
    // single number / comma-separated string / null). See api.md line 2882/2986.
    public int[]? TeamIDs { get; set; }
    public int? PrimaryTeam { get; set; }
    public int? AccessControlProfileID { get; set; }
    public string? StartAddress { get; set; }
    public string? StartCity { get; set; }
    public string? StartState { get; set; }
    public string? StartZip { get; set; }
    public decimal? StartLat { get; set; }
    public decimal? StartLng { get; set; }
    public string? EndAddress { get; set; }
    public string? EndCity { get; set; }
    public string? EndState { get; set; }
    public string? EndZip { get; set; }
    public decimal? EndLat { get; set; }
    public decimal? EndLng { get; set; }
    public string? DateUpdated { get; set; }
}
