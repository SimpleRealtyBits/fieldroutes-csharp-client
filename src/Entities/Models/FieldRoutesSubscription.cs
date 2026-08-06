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
/// <summary>FieldRoutesSubscription record as returned by the FieldRoutes API.</summary>
public sealed class FieldRoutesSubscription
{
    public int? SubscriptionID { get; set; }
    public int? CustomerID { get; set; }
    public int? BillToAccountID { get; set; }
    public int? OfficeID { get; set; }
    public string? DateAdded { get; set; }
    public string? ContractAdded { get; set; }
    public int? Active { get; set; }
    public int? ActiveText { get; set; }
    public decimal? InitialQuote { get; set; }
    public decimal? InitialDiscount { get; set; }
    public decimal? InitialServiceTotal { get; set; }
    public decimal? YifDiscount { get; set; }
    public decimal? RecurringCharge { get; set; }
    public decimal? ContractValue { get; set; }
    public decimal? AnnualRecurringValue { get; set; }
    public int? BillingFrequency { get; set; }
    public int? Frequency { get; set; }
    public int? FollowupService { get; set; }
    public decimal? AgreementLength { get; set; }
    public string? NextService { get; set; }
    public string? LastCompleted { get; set; }
    public int? ServiceID { get; set; }
    public string? ServiceType { get; set; }
    public int? SoldBy { get; set; }
    public int? SoldBy2 { get; set; }
    public int? SoldBy3 { get; set; }
    public int? PreferredTech { get; set; }
    public int? AddedBy { get; set; }
    public int? InitialAppointmentID { get; set; }
    public int? InitialStatus { get; set; }
    public string? InitialStatusText { get; set; }
    public string? DateCancelled { get; set; }
    public string? DateUpdated { get; set; }
    public string? CxlNotes { get; set; }
    public string? SubscriptionLink { get; set; }
    public string? PoNumber { get; set; }
    public int? AppointmentIDs { get; set; }
    // MANUAL FIX (2026-08-05): api.md types completedAppointmentIDs as integer but describes
    // "Every completed appointment attached to this subscription" — real wire is an array of
    // appointment IDs — fixed to int[]?. See api.md line 4852/5005.
    public int[]? CompletedAppointmentIDs { get; set; }
    public object? InitialAppointment { get; set; }
    public object? RecurringTicket { get; set; }
    // MANUAL FIX (2026-08-05): api.md types addOns as string but describes "An array of
    // Add-On objects associated with the INITIAL appointment" — real wire is a JSON array of
    // objects — fixed to List<object>?. See api.md line 4855/5008.
    public List<object>? AddOns { get; set; }
    public int? LeadID { get; set; }
    public string? LeadDateAdded { get; set; }
    public string? LeadUpdated { get; set; }
    public int? LeadAddedBy { get; set; }
    public int? LeadSourceID { get; set; }
    public string? LeadSource { get; set; }
    public int? LeadStatus { get; set; }
    public string? LeadStatusText { get; set; }
    public int? LeadStageID { get; set; }
    public string? LeadStage { get; set; }
    public int? LeadAssignedTo { get; set; }
    public string? LeadDateAssigned { get; set; }
    public decimal? LeadValue { get; set; }
    public string? LeadDateClosed { get; set; }
    public string? LeadLostReason { get; set; }
    public string? LeadLostReasonText { get; set; }
    public int? SourceID { get; set; }
    public string? Source { get; set; }
    public int? AnnualRecurringServices { get; set; }
    public int? UnitIDs { get; set; }
    public int? RegionID { get; set; }
    public string? InitialInvoice { get; set; }
    public string? InitialBillingDate { get; set; }
    public int? RenewalFrequency { get; set; }
    public string? RenewalDate { get; set; }
    public string? CustomDate { get; set; }
    public int? SentriconConnected { get; set; }
    public string? SentriconSiteID { get; set; }
    public string? SeasonalStart { get; set; }
    public string? SeasonalEnd { get; set; }
    public string? NextBillingDate { get; set; }
    public decimal? MaxMonthlyCharge { get; set; }
    public string? ExpirationDate { get; set; }
    public string? LastAppointment { get; set; }
    public string? TemplateType { get; set; }
    public int? ParentID { get; set; }
    public string? Duration { get; set; }
    public int? PreferredDays { get; set; }
    public string? PreferredStart { get; set; }
    public string? PreferredEnd { get; set; }
    public int? CallAhead { get; set; }
}
