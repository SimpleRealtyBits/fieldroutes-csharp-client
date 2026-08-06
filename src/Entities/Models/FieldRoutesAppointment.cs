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
/// <summary>FieldRoutesAppointment record as returned by the FieldRoutes API.</summary>
public sealed class FieldRoutesAppointment
{
    public int? AppointmentID { get; set; }
    public int? OfficeID { get; set; }
    public int? CustomerID { get; set; }
    public int? SubscriptionID { get; set; }
    public int? SubscriptionRegionID { get; set; }
    public int? RouteID { get; set; }
    public int? SpotID { get; set; }
    public string? Date { get; set; }
    public string? Start { get; set; }
    public string? End { get; set; }
    public string? TimeWindow { get; set; }
    public int? Duration { get; set; }
    public int? Type { get; set; }
    public string? DateAdded { get; set; }
    public int? EmployeeID { get; set; }
    public int? Status { get; set; }
    public string? StatusText { get; set; }
    public int? CallAhead { get; set; }
    public int? IsInitial { get; set; }
    public int? SubscriptionPreferredTech { get; set; }
    public int? CompletedBy { get; set; }
    public int? ServicedBy { get; set; }
    public string? DateCompleted { get; set; }
    public string? SignedByCustomer { get; set; }
    public string? SignedByTech { get; set; }
    public string? Notes { get; set; }
    public string? OfficeNotes { get; set; }
    public string? TimeIn { get; set; }
    public string? TimeOut { get; set; }
    public string? CheckIn { get; set; }
    public string? CheckOut { get; set; }
    public int? WindSpeed { get; set; }
    public string? WindDirection { get; set; }
    public int? Temperature { get; set; }
    public decimal? AmountCollected { get; set; }
    public int? PaymentMethod { get; set; }
    public int? ServicedInterior { get; set; }
    public int? TicketID { get; set; }
    public string? DateCancelled { get; set; }
    // MANUAL FIX (2026-08-05): api.md types additionalTechs as string ("Comma separated"),
    // but real wire returns an array of employee IDs ([123,456]) — fixed to int[]?
    // (TolerantInt32ArrayConverter also accepts the comma-separated form). See api.md line 715/867.
    public int[]? AdditionalTechs { get; set; }
    public string? AppointmentCancellationReason { get; set; }
    public string? CancellationReason { get; set; }
    public int? RescheduleReasonID { get; set; }
    public int? ReserviceReasonID { get; set; }
    // MANUAL FIX (2026-08-05): api.md types unitIDs as integer but describes "An array of
    // unit IDs associated with this appointment (for multi unit customers)" — real wire is a
    // JSON array of IDs — fixed to int[]?. See api.md line 720/872.
    public int[]? UnitIDs { get; set; }
    // MANUAL FIX (2026-08-05): NOT CHANGED — api.md is contradictory for targetPests: the
    // includeTargetPests param note says the additional field is "an array of integers"
    // (line 669/821) while the response table types it as integer (line 721/873). Left as
    // int? pending verification against a live response sent with includeTargetPests=1.
    public int? TargetPests { get; set; }
    public string? AppointmentNotes { get; set; }
    public int? DoInterior { get; set; }
    public string? DateUpdated { get; set; }
    public int? CancelledBy { get; set; }
    public int? AssignedTech { get; set; }
    public decimal? LatIn { get; set; }
    public decimal? LatOut { get; set; }
    public decimal? LongIn { get; set; }
    public decimal? LongOut { get; set; }
    public int? Sequence { get; set; }
    public int? LockedBy { get; set; }
    public int? OriginalAppointmentID { get; set; }
}
