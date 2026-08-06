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
/// <summary>FieldRoutesPayment record as returned by the FieldRoutes API.</summary>
public sealed class FieldRoutesPayment
{
    public int? PaymentID { get; set; }
    public int? OfficeID { get; set; }
    public int? CustomerID { get; set; }
    public string? Date { get; set; }
    public int? PaymentMethod { get; set; }
    public decimal? Amount { get; set; }
    public decimal? AppliedAmount { get; set; }
    public decimal? UnassignedAmount { get; set; }
    public int? Status { get; set; }
    // MANUAL FIX (2026-08-05): api.md types invoiceIDs as integer but describes
    // "Tickets that this payment was applied for" — real wire is an array of invoice IDs —
    // fixed to int[]?. See api.md line 3938/4005.
    public int[]? InvoiceIDs { get; set; }
    // MANUAL FIX (2026-08-05): api.md types paymentApplications as string but describes
    // "Array of payment applications associated with the ticket" — real wire is a JSON array
    // of objects — fixed to List<object>?. See api.md line 3939/4006.
    public List<object>? PaymentApplications { get; set; }
    public int? EmployeeID { get; set; }
    public int? OfficePayment { get; set; }
    public int? CollectionPayment { get; set; }
    public int? WriteOff { get; set; }
    public int? CreditMemo { get; set; }
    public int? PaymentOrigin { get; set; }
    public int? OriginalPaymentID { get; set; }
    public string? LastFour { get; set; }
    public string? Notes { get; set; }
    public string? BatchOpened { get; set; }
    public string? BatchClosed { get; set; }
    public string? PaymentSource { get; set; }
    public string? DateUpdated { get; set; }
    public int? TransactionID { get; set; }
}
