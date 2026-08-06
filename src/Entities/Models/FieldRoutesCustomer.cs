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
/// <summary>FieldRoutesCustomer record as returned by the FieldRoutes API.</summary>
public sealed class FieldRoutesCustomer
{
    public int? CustomerID { get; set; }
    public int? BillToAccountID { get; set; }
    public int? OfficeID { get; set; }
    public string? Fname { get; set; }
    public string? Lname { get; set; }
    public string? CompanyName { get; set; }
    public string? Spouse { get; set; }
    public int? CommercialAccount { get; set; }
    public int? Status { get; set; }
    public string? StatusText { get; set; }
    public string? Email { get; set; }
    public string? Phone1 { get; set; }
    public string? Ext1 { get; set; }
    public string? Phone2 { get; set; }
    public string? Ext2 { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
    public string? BillingCompanyName { get; set; }
    public string? BillingFName { get; set; }
    public string? BillingLName { get; set; }
    public string? BillingCountryID { get; set; }
    public string? BillingAddress { get; set; }
    public string? BillingCity { get; set; }
    public string? BillingState { get; set; }
    public string? BillingZip { get; set; }
    public string? BillingPhone { get; set; }
    public string? BillingEmail { get; set; }
    public decimal? Lat { get; set; }
    public decimal? Lng { get; set; }
    public int? SquareFeet { get; set; }
    public int? AddedByID { get; set; }
    public string? DateAdded { get; set; }
    public string? DateCancelled { get; set; }
    public string? DateUpdated { get; set; }
    public int? SourceID { get; set; }
    public string? Source { get; set; }
    public string? APay { get; set; }
    public int? PreferredTechID { get; set; }
    public int? PaidInFull { get; set; }
    // MANUAL FIX (2026-08-05): api.md types subscriptionIDs as integer but describes
    // "An array of subscription ID's attached to this customer" — real wire is a JSON array
    // of IDs — fixed to int[]?. See api.md line 1837/2060.
    public int[]? SubscriptionIDs { get; set; }
    public decimal? Balance { get; set; }
    public int? BalanceAge { get; set; }
    public decimal? ResponsibleBalance { get; set; }
    public int? ResponsibleBalanceAge { get; set; }
    public string? CustomerLink { get; set; }
    public string? MasterAccount { get; set; }
    public int? PreferredBillingDate { get; set; }
    public string? PaymentHoldDate { get; set; }
    public string? MostRecentCreditCardLastFour { get; set; }
    public string? MostRecentCreditCardExpirationDate { get; set; }
    // MANUAL FIX (2026-08-05): api.md types appointmentIDs as integer but describes
    // "An array of appointmentIDs associated with the customer" — real wire is a JSON array
    // of IDs — fixed to int[]?. See api.md line 1848/2071.
    public int[]? AppointmentIDs { get; set; }
    // MANUAL FIX (2026-08-05): api.md types ticketIDs as integer but describes
    // "An array of ticketIDs associated with the customer" — real wire is a JSON array of
    // IDs — fixed to int[]?. See api.md line 1849/2072.
    public int[]? TicketIDs { get; set; }
    // MANUAL FIX (2026-08-05): api.md types paymentIDs as integer but describes
    // "An array of paymentIDs associated with the customer" — real wire is a JSON array of
    // IDs — fixed to int[]?. See api.md line 1850/2073.
    public int[]? PaymentIDs { get; set; }
    public List<object>? Subscriptions { get; set; }
    // MANUAL FIX (2026-08-05): api.md types unitIDs as integer but describes "An array of
    // unitIDs associated with the customer" — real wire is a JSON array of IDs — fixed to
    // int[]?. See api.md line 1852/2075.
    public int[]? UnitIDs { get; set; }
    public int? RegionID { get; set; }
    public string? MapCode { get; set; }
    public string? MapPage { get; set; }
    public string? SpecialScheduling { get; set; }
    public decimal? TaxRate { get; set; }
    public decimal? StateTax { get; set; }
    public decimal? CityTax { get; set; }
    public decimal? CountyTax { get; set; }
    public decimal? DistrictTax { get; set; }
    public decimal? DistrictTax1 { get; set; }
    public decimal? DistrictTax2 { get; set; }
    public decimal? DistrictTax3 { get; set; }
    public decimal? DistrictTax4 { get; set; }
    public decimal? DistrictTax5 { get; set; }
    public decimal? CustomTax { get; set; }
    public int? ZipTaxID { get; set; }
    public int? SmsReminders { get; set; }
    public int? PhoneReminders { get; set; }
    public int? EmailReminders { get; set; }
    public string? CustomerSource { get; set; }
    public string? CustomerSourceID { get; set; }
    public decimal? MaxMonthlyCharge { get; set; }
    public string? County { get; set; }
    public int? UseStructures { get; set; }
    public int? IsMultiUnit { get; set; }
    public int? AutoPayPaymentProfileID { get; set; }
    public int? DivisionID { get; set; }
    public int? SubPropertyTypeID { get; set; }
    public string? AgingDate { get; set; }
    public string? ResponsibleAgingDate { get; set; }
    public int? SalesmanAPay { get; set; }
    public int? PurpleDragon { get; set; }
    public int? TermiteMonitoring { get; set; }
    public int? PendingCancel { get; set; }
}
