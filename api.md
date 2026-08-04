# FieldRoutes API Reference

## Table of Contents

- [accessControl](#accesscontrol)
- [additionalContact](#additionalcontact)
- [applicationMethod](#applicationmethod)
- [appliedPayment](#appliedpayment)
- [appointment](#appointment)
- [appointmentCancellationReason](#appointmentcancellationreason)
- [appointmentReminder](#appointmentreminder)
- [appointmentRescheduleReason](#appointmentreschedulereason)
- [cancellationReason](#cancellationreason)
- [changelog](#changelog)
- [chargeback](#chargeback)
- [chemical](#chemical)
- [chemicalUse](#chemicaluse)
- [compassCustomer](#compasscustomer)
- [contract](#contract)
- [customer](#customer)
- [customerFlag](#customerflag)
- [customerSource](#customersource)
- [diagram](#diagram)
- [disbursement](#disbursement)
- [disbursementItem](#disbursementitem)
- [document](#document)
- [door](#door)
- [employee](#employee)
- [employeeLocation](#employeelocation)
- [form](#form)
- [genericFlag](#genericflag)
- [genericFlagAssignment](#genericflagassignment)
- [glAccount](#glaccount)
- [group](#group)
- [insect](#insect)
- [knock](#knock)
- [location](#location)
- [note](#note)
- [office](#office)
- [payment](#payment)
- [paymentProfile](#paymentprofile)
- [product](#product)
- [region](#region)
- [reserviceReason](#reservicereason)
- [review](#review)
- [route](#route)
- [routeTemplate](#routetemplate)
- [servicePlan](#serviceplan)
- [servicePlanRound](#serviceplanround)
- [serviceType](#servicetype)
- [skill](#skill)
- [spot](#spot)
- [subscription](#subscription)
- [task](#task)
- [team](#team)
- [ticket](#ticket)
- [ticketItem](#ticketitem)
- [timeClock](#timeclock)
- [timeClockCategory](#timeclockcategory)
- [unit](#unit)

---

## accessControl

### `/accessControl/[id]`

Get accessControl data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `employeeID` | integer | Employee ID of custom Access Control Profile |
| `accessControlProfileID` | integer | 0: Custom Access Control Profile per user. Otherwise, ID of defined Access Control Profiles |
| `admin` | integer | Administrator |
| `adminMessage` | integer | Admin Messages |
| `editPreferences` | integer | Adjust Preferences |
| `viewOwnRoutes` | integer | View Own Routes |
| `viewOtherRoutes` | integer | View Other's Routes |
| `editOwnRoutes` | integer | Edit Own Routes |
| `editOtherRoutes` | integer | Edit Other's Routes |
| `createRoutes` | integer | Create Routes |
| `deleteRoutes` | integer | Delete Routes |
| `lockUnlockRoutes` | integer | Lock/Unlock Routes |
| `scheduleOnLockedRoutes` | integer | Schedule On Locked Routes |
| `scheduleOwn` | integer | Schedule Appointments |
| `cancelOwn` | integer | Cancel Own Appointments |
| `editOthers` | integer | Edit Other's Appointments |
| `canUnlockAppointments` | integer | Unlock Other's Appointments |
| `intelligentRouting` | integer | Intelligent Routing |
| `editMap` | integer | Assign Map Pages |
| `viewProdValue` | integer | View Production Value |
| `useTechRoutesStructures` | integer | Use Structures/Trend Reporting (Additional Charges Apply) |
| `viewUsers` | integer | View Users |
| `addUsers` | integer | Add Users |
| `editUsers` | integer | Edit Users |
| `viewTechs` | integer | View Techs |
| `addTechs` | integer | Add Techs |
| `editTechs` | integer | Edit Techs |
| `viewSalesmen` | integer | View Sales Reps |
| `addSalesmen` | integer | Add Sales Reps |
| `editSalesmen` | integer | Edit Sales Reps |
| `viewOwnTimeSheet` | integer | View Own Time Sheet |
| `viewOtherTimeSheet` | integer | View Other Time Sheets |
| `editOwnTimeSheet` | integer | Edit Own Time Sheet |
| `editOtherTimeSheet` | integer | Edit Other Time Sheets |
| `overrideTimeClockRestrictions` | integer | Override Time Clock Restrictions |
| `canSpyOnReps` | integer | Rep Spy (SalesRoutes) |
| `editTeams` | integer | Edit Teams |
| `viewEmployeeFinancialSettings` | integer | View Employee Financial Settings |
| `editEmployeeFinancialSettings` | integer | Edit Employee Financial Settings |
| `viewOwnTasks` | integer | View Own Tasks |
| `viewOtherTasks` | integer | View Other Tasks |
| `editOwnTasks` | integer | Edit Own Tasks |
| `editOtherTasks` | integer | Edit Other Tasks |
| `viewAlerts` | integer | View Alerts |
| `viewTransactions` | integer | View Transactions |
| `addCharge` | integer | Add Charges |
| `applyPayment` | integer | Apply Payments |
| `editTransactions` | integer | Edit Transactions |
| `processRefunds` | integer | Refund Payments |
| `deleteInvoice` | integer | Delete Invoices |
| `createCoupon` | integer | Create Coupon |
| `invoiceNegativeItem` | integer | Negative Charges |
| `closedMonthAppointmentCompletion` | integer | Complete appointment when period is locked |
| `createCustomers` | integer | Create Customers |
| `viewOwnCustomers` | integer | View Own Customers |
| `viewOtherCustomers` | integer | View Other Customers |
| `editOwnCustomers` | integer | Edit Own Customers |
| `editOtherCustomers` | integer | Edit Other Customers |
| `toggleCustomerStatus` | integer | Freeze/Unfreeze Customers |
| `editRedNotes` | integer | Edit Red Notes |
| `editCancellationDates` | integer | Edit Cancellation Date/Reason |
| `toggleSubscriptionStatus` | integer | Freeze/Unfreeze Subscriptions |
| `viewOwnSubscriptions` | integer | View Own Subscriptions |
| `viewOtherSubscriptions` | integer | View Other Subscriptions |
| `editOwnSubscriptions` | integer | Edit Own Subscriptions |
| `editOtherSubscriptions` | integer | Edit Other Subscriptions |
| `accessSentricon` | integer | Can Access Sentricon |
| `editOwnSalesRep` | integer | Edit Own Sales Rep |
| `editOtherSalesRep` | integer | Edit Other Sales Rep |
| `viewLeaderBoardsAllOffices` | integer | View Leaderboards of All Offices |
| `createCustomersFromMobile` | integer | Create Customers on Mobile (Additional Charges Apply) |
| `viewOwnLeads` | integer | View Own Leads |
| `viewOtherLeads` | integer | View Other Leads |
| `editOwnLeads` | integer | Edit Own Leads |
| `editOtherLeads` | integer | Edit Other Leads |
| `assignBillingAccount` | integer | Assign Billing Account |
| `viewOwnBilling` | integer | View Own Billing |
| `viewOtherBilling` | integer | View Other Billing |
| `editOwnBilling` | integer | Edit Own Billing |
| `editOtherBilling` | integer | Edit Other Billing |
| `addOwnBilling` | integer | Add Own Billing |
| `addOtherBilling` | integer | Add Other Billing |
| `approveForms` | integer | Approve Forms |
| `viewOwnInvoices` | integer | View Own Invoices |
| `viewOtherInvoices` | integer | View Other Invoices |
| `editTaxable` | integer | Edit Taxable |
| `hideCommercialPricing` | integer | Hide Commercial Price on Mobile |
| `hideResidentialPricing` | integer | Hide Residential Price on Mobile |
| `ignoreMinInitial` | integer | Ignore Min Initial Charge |
| `ignoreMinRecurring` | integer | Ignore Min Recurring Charge |
| `ignoreMinContractValue` | integer | Ignore Min Contract Value |
| `viewSalesmanReports` | integer | View Sales Overview |
| `viewDetailedSalesReports` | integer | View Sales Details |
| `viewOfficeReports` | integer | View Office Reports |
| `viewCustomReports` | integer | View Custom Reports |
| `viewCustomerReport` | integer | View Customer Report |
| `viewDashboard` | integer | View Dashboard |
| `salesroutesBaseballRevenue` | integer | Sales Leaderboard Revenue |
| `serviceNotificationApproval` | integer | Service Notification Approval |
| `viewDisbursementsReport` | integer | View Disbursements Report |
| `activeCustomersWidget` | integer | Active Customers |
| `subscriptionTypesWidget` | integer | Active Subscriptions |
| `cancelReasonsWidget` | integer | Cancellation Reasons |
| `monthlyServicesWidget` | integer | Monthly Services |
| `starRatingWidget` | integer | Technician Ratings |
| `collectionsWidget` | integer | Collections Percentage |
| `completionPercentageWidget` | integer | Completion Percentage |
| `regularStopsPerRouteWidget` | integer | Stops Per Route |
| `aPayCustomersWidget` | integer | Autopay Percentage |
| `accountAgeWidget` | integer | Receivables Aging |
| `paymentBreakdownWidget` | integer | Payment Types |
| `averageRatesWidget` | integer | Average Rates |
| `averageContractValuesWidget` | integer | Average Contract Values |
| `customerAgeWidget` | integer | Average Customer Age |
| `customerSourcesWidget` | integer | Subscription Sources |
| `extraCardsWidget` | integer | Frozen with Account |
| `monthlyBillingWidget` | integer | Recurring Billing |
| `debitBalanceWidget` | integer | Debit Balance |
| `revenueByServiceTypeWidget` | integer | Revenue by Service |
| `revenueByMonthWidget` | integer | Revenue by Month |
| `recurringAnnualRevenueWidget` | integer | Recurring Annual Revenue |
| `accessControlProfileName` | string | Access control profile name (if this is a preset access control profile) |
| `viewAssignmentLayers` | integer | View Assignment Layers |
| `editAnyBoundaryRegion` | integer | Edit Any Boundary Region |
| `editBoundaryRegionInManagedArea` | integer | Edit Boundaries In Managed Area |
| `editAnyAssignmentRegion` | integer | Edit Any Assignment Region |
| `editAssignmentRegionInManagedArea` | integer | Edit Regions In Managed Area |
| `viewReportingLayers` | integer | View Reporting Layers |
| `editOwnReportingRegions` | integer | Edit Own Reporting Regions |
| `editOtherReportingRegions` | integer | Edit Other Reporting Regions |
| `viewDataLayers` | integer | View Data Layers |
| `editOwnDataLayers` | integer | Edit Own Data Layers |
| `editOtherDataLayers` | integer | Edit Other Data Layers |
| `viewDoorKnockSystemLayer` | integer | View Door Knock System Layer |
| `viewCustomerSystemLayer` | integer | View Customer System Layer |
| `viewFeedback` | integer | View Feedback |
| `dateUpdated` | string | Access Control Matrix dateUpdated |

### `/accessControl/get`

Get Bulk data for accessControl. Accepts an array of employeeIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `employeeIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `employeeID` | integer | Employee ID of custom Access Control Profile |
| `accessControlProfileID` | integer | 0: Custom Access Control Profile per user. Otherwise, ID of defined Access Control Profiles |
| `admin` | integer | Administrator |
| `adminMessage` | integer | Admin Messages |
| `editPreferences` | integer | Adjust Preferences |
| `viewOwnRoutes` | integer | View Own Routes |
| `viewOtherRoutes` | integer | View Other's Routes |
| `editOwnRoutes` | integer | Edit Own Routes |
| `editOtherRoutes` | integer | Edit Other's Routes |
| `createRoutes` | integer | Create Routes |
| `deleteRoutes` | integer | Delete Routes |
| `lockUnlockRoutes` | integer | Lock/Unlock Routes |
| `scheduleOnLockedRoutes` | integer | Schedule On Locked Routes |
| `scheduleOwn` | integer | Schedule Appointments |
| `cancelOwn` | integer | Cancel Own Appointments |
| `editOthers` | integer | Edit Other's Appointments |
| `canUnlockAppointments` | integer | Unlock Other's Appointments |
| `intelligentRouting` | integer | Intelligent Routing |
| `editMap` | integer | Assign Map Pages |
| `viewProdValue` | integer | View Production Value |
| `useTechRoutesStructures` | integer | Use Structures/Trend Reporting (Additional Charges Apply) |
| `viewUsers` | integer | View Users |
| `addUsers` | integer | Add Users |
| `editUsers` | integer | Edit Users |
| `viewTechs` | integer | View Techs |
| `addTechs` | integer | Add Techs |
| `editTechs` | integer | Edit Techs |
| `viewSalesmen` | integer | View Sales Reps |
| `addSalesmen` | integer | Add Sales Reps |
| `editSalesmen` | integer | Edit Sales Reps |
| `viewOwnTimeSheet` | integer | View Own Time Sheet |
| `viewOtherTimeSheet` | integer | View Other Time Sheets |
| `editOwnTimeSheet` | integer | Edit Own Time Sheet |
| `editOtherTimeSheet` | integer | Edit Other Time Sheets |
| `overrideTimeClockRestrictions` | integer | Override Time Clock Restrictions |
| `canSpyOnReps` | integer | Rep Spy (SalesRoutes) |
| `editTeams` | integer | Edit Teams |
| `viewEmployeeFinancialSettings` | integer | View Employee Financial Settings |
| `editEmployeeFinancialSettings` | integer | Edit Employee Financial Settings |
| `viewOwnTasks` | integer | View Own Tasks |
| `viewOtherTasks` | integer | View Other Tasks |
| `editOwnTasks` | integer | Edit Own Tasks |
| `editOtherTasks` | integer | Edit Other Tasks |
| `viewAlerts` | integer | View Alerts |
| `viewTransactions` | integer | View Transactions |
| `addCharge` | integer | Add Charges |
| `applyPayment` | integer | Apply Payments |
| `editTransactions` | integer | Edit Transactions |
| `processRefunds` | integer | Refund Payments |
| `deleteInvoice` | integer | Delete Invoices |
| `createCoupon` | integer | Create Coupon |
| `invoiceNegativeItem` | integer | Negative Charges |
| `closedMonthAppointmentCompletion` | integer | Complete appointment when period is locked |
| `createCustomers` | integer | Create Customers |
| `viewOwnCustomers` | integer | View Own Customers |
| `viewOtherCustomers` | integer | View Other Customers |
| `editOwnCustomers` | integer | Edit Own Customers |
| `editOtherCustomers` | integer | Edit Other Customers |
| `toggleCustomerStatus` | integer | Freeze/Unfreeze Customers |
| `editRedNotes` | integer | Edit Red Notes |
| `editCancellationDates` | integer | Edit Cancellation Date/Reason |
| `toggleSubscriptionStatus` | integer | Freeze/Unfreeze Subscriptions |
| `viewOwnSubscriptions` | integer | View Own Subscriptions |
| `viewOtherSubscriptions` | integer | View Other Subscriptions |
| `editOwnSubscriptions` | integer | Edit Own Subscriptions |
| `editOtherSubscriptions` | integer | Edit Other Subscriptions |
| `accessSentricon` | integer | Can Access Sentricon |
| `editOwnSalesRep` | integer | Edit Own Sales Rep |
| `editOtherSalesRep` | integer | Edit Other Sales Rep |
| `viewLeaderBoardsAllOffices` | integer | View Leaderboards of All Offices |
| `createCustomersFromMobile` | integer | Create Customers on Mobile (Additional Charges Apply) |
| `viewOwnLeads` | integer | View Own Leads |
| `viewOtherLeads` | integer | View Other Leads |
| `editOwnLeads` | integer | Edit Own Leads |
| `editOtherLeads` | integer | Edit Other Leads |
| `assignBillingAccount` | integer | Assign Billing Account |
| `viewOwnBilling` | integer | View Own Billing |
| `viewOtherBilling` | integer | View Other Billing |
| `editOwnBilling` | integer | Edit Own Billing |
| `editOtherBilling` | integer | Edit Other Billing |
| `addOwnBilling` | integer | Add Own Billing |
| `addOtherBilling` | integer | Add Other Billing |
| `approveForms` | integer | Approve Forms |
| `viewOwnInvoices` | integer | View Own Invoices |
| `viewOtherInvoices` | integer | View Other Invoices |
| `editTaxable` | integer | Edit Taxable |
| `hideCommercialPricing` | integer | Hide Commercial Price on Mobile |
| `hideResidentialPricing` | integer | Hide Residential Price on Mobile |
| `ignoreMinInitial` | integer | Ignore Min Initial Charge |
| `ignoreMinRecurring` | integer | Ignore Min Recurring Charge |
| `ignoreMinContractValue` | integer | Ignore Min Contract Value |
| `viewSalesmanReports` | integer | View Sales Overview |
| `viewDetailedSalesReports` | integer | View Sales Details |
| `viewOfficeReports` | integer | View Office Reports |
| `viewCustomReports` | integer | View Custom Reports |
| `viewCustomerReport` | integer | View Customer Report |
| `viewDashboard` | integer | View Dashboard |
| `salesroutesBaseballRevenue` | integer | Sales Leaderboard Revenue |
| `serviceNotificationApproval` | integer | Service Notification Approval |
| `viewDisbursementsReport` | integer | View Disbursements Report |
| `activeCustomersWidget` | integer | Active Customers |
| `subscriptionTypesWidget` | integer | Active Subscriptions |
| `cancelReasonsWidget` | integer | Cancellation Reasons |
| `monthlyServicesWidget` | integer | Monthly Services |
| `starRatingWidget` | integer | Technician Ratings |
| `collectionsWidget` | integer | Collections Percentage |
| `completionPercentageWidget` | integer | Completion Percentage |
| `regularStopsPerRouteWidget` | integer | Stops Per Route |
| `aPayCustomersWidget` | integer | Autopay Percentage |
| `accountAgeWidget` | integer | Receivables Aging |
| `paymentBreakdownWidget` | integer | Payment Types |
| `averageRatesWidget` | integer | Average Rates |
| `averageContractValuesWidget` | integer | Average Contract Values |
| `customerAgeWidget` | integer | Average Customer Age |
| `customerSourcesWidget` | integer | Subscription Sources |
| `extraCardsWidget` | integer | Frozen with Account |
| `monthlyBillingWidget` | integer | Recurring Billing |
| `debitBalanceWidget` | integer | Debit Balance |
| `revenueByServiceTypeWidget` | integer | Revenue by Service |
| `revenueByMonthWidget` | integer | Revenue by Month |
| `recurringAnnualRevenueWidget` | integer | Recurring Annual Revenue |
| `accessControlProfileName` | string | Access control profile name (if this is a preset access control profile) |
| `viewAssignmentLayers` | integer | View Assignment Layers |
| `editAnyBoundaryRegion` | integer | Edit Any Boundary Region |
| `editBoundaryRegionInManagedArea` | integer | Edit Boundaries In Managed Area |
| `editAnyAssignmentRegion` | integer | Edit Any Assignment Region |
| `editAssignmentRegionInManagedArea` | integer | Edit Regions In Managed Area |
| `viewReportingLayers` | integer | View Reporting Layers |
| `editOwnReportingRegions` | integer | Edit Own Reporting Regions |
| `editOtherReportingRegions` | integer | Edit Other Reporting Regions |
| `viewDataLayers` | integer | View Data Layers |
| `editOwnDataLayers` | integer | Edit Own Data Layers |
| `editOtherDataLayers` | integer | Edit Other Data Layers |
| `viewDoorKnockSystemLayer` | integer | View Door Knock System Layer |
| `viewCustomerSystemLayer` | integer | View Customer System Layer |
| `viewFeedback` | integer | View Feedback |
| `dateUpdated` | string | Access Control Matrix dateUpdated |

### `/accessControl/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `employeeID` | integer |  | Primary key |
| `employeeIDs` | integer |  | Primary key |
| `accessControlProfileID` | integer |  | 0: Custom Access Control Profile per user. Otherwise, ID of defined Access Control Profiles |
| `admin` | integer |  | Administrator |
| `accessControlProfileIDs` | integer |  | 0: Custom Access Control Profile per user. Otherwise, ID of defined Access Control Profiles |
| `officeID` | integer |  | officeID of the profile |
| `officeIDs` | integer |  | officeID of the profile |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property accessControlIDsNoDataExported will specify the items that are not included in the resolved accessControl array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `accessControlIDs` | array |  |

## additionalContact

### `/additionalContact/[id]`

Get additionalContact data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `additionalContactID` | integer | Primary Key |
| `additionalContactTypeID` | integer | See Admin &gt; Preferences &gt; Customer Preferences &gt; Additional Contact Types |
| `customerID` | integer | Customer ID that the is additional contact belongs to |
| `fname` | string | Contact first name |
| `lname` | string | Contact last name |
| `address` | string |  |
| `city` | string |  |
| `state` | string |  |
| `zip` | string |  |
| `phone` | string |  |
| `phoneExt` | string | Phone1 extension |
| `phone2` | string |  |
| `phone2Ext` | string | phone2 extension |
| `email` | string |  |
| `smsReminders` | integer | Set as 1 if the additionalContact opts in for sms reminders |
| `phoneReminders` | integer | Set as 1 if the additionalContact opts in for phone reminders |
| `emailReminders` | integer | Set as 1 if the additionalContact opts in for email reminders |
| `contactType` | string | e.g. (BILLING, BUSINESS, SERVICE, SERVICE_BILLING, TERMITE) |
| `dateUpdated` | string |  |
| `dateCreated` | string |  |
| `addedBy` | integer |  |
| `editedBy` | integer |  |
| `companyName` | string |  |
| `visibility` | integer |  |
| `businessContactID` | integer |  |
| `termiteReportID` | integer | If this is tied to a WDO termite report this will be non-null |
| `wdoOrderedBy` | integer | If this is a WDO contact order the report this will be set as 1 |
| `wdoPartyOfInterest` | integer | If the WDO contact is a party of interest this will be set as 1 |
| `wdoReportSentTo` | integer |  |
| `wdoEmailOnly` | integer |  |
| `description` | integer | contact type description |

### `/additionalContact/create`

create a customer

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes |  |
| `additionalContactTypeID` | integer | Yes |  |
| `fname` | string |  | First name |
| `lname` | string |  | Last name |
| `address` | string |  | Address string |
| `city` | string |  | City string |
| `state` | string |  | 2 letter state code |
| `zip` | string |  | Zip code |
| `phone` | string |  |  |
| `phone2` | string |  |  |
| `phoneExt` | string |  |  |
| `phone2Ext` | string |  |  |
| `smsReminders` | integer |  |  |
| `phoneReminders` | integer |  |  |
| `emailReminders` | integer |  |  |
| `companyName` | string |  |  |
| `email` | string |  | email |
| `contactType` | string |  | contact type: SERVICE, BILLING, SERVICE_BILLING |
| `businessContactID` | string |  | business contact ID |
| `addedBy` | string |  | User that added this contact |

### `/additionalContact/get`

Get Bulk data for additionalContact. Accepts an array of additionalContactIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `additionalContactIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `additionalContactID` | integer | Primary Key |
| `additionalContactTypeID` | integer | See Admin &gt; Preferences &gt; Customer Preferences &gt; Additional Contact Types |
| `customerID` | integer | Customer ID that the is additional contact belongs to |
| `fname` | string | Contact first name |
| `lname` | string | Contact last name |
| `address` | string |  |
| `city` | string |  |
| `state` | string |  |
| `zip` | string |  |
| `phone` | string |  |
| `phoneExt` | string | Phone1 extension |
| `phone2` | string |  |
| `phone2Ext` | string | phone2 extension |
| `email` | string |  |
| `smsReminders` | integer | Set as 1 if the additionalContact opts in for sms reminders |
| `phoneReminders` | integer | Set as 1 if the additionalContact opts in for phone reminders |
| `emailReminders` | integer | Set as 1 if the additionalContact opts in for email reminders |
| `contactType` | string | e.g. (BILLING, BUSINESS, SERVICE, SERVICE_BILLING, TERMITE) |
| `dateUpdated` | string |  |
| `dateCreated` | string |  |
| `addedBy` | integer |  |
| `editedBy` | integer |  |
| `companyName` | string |  |
| `visibility` | integer |  |
| `businessContactID` | integer |  |
| `termiteReportID` | integer | If this is tied to a WDO termite report this will be non-null |
| `wdoOrderedBy` | integer | If this is a WDO contact order the report this will be set as 1 |
| `wdoPartyOfInterest` | integer | If the WDO contact is a party of interest this will be set as 1 |
| `wdoReportSentTo` | integer |  |
| `wdoEmailOnly` | integer |  |
| `description` | integer | contact type description |

### `/additionalContact/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `additionalContactIDs` | integer |  | Primary Key |
| `additionalContactID` | integer |  | Primary Key |
| `officeIDs` | integer |  | Primary Key |
| `officeID` | integer |  | Primary Key |
| `customerID` | integer |  | Customer ID that the is additional contact belongs to |
| `termiteReportID` | integer |  | If this is tied to a WDO termite report this will be non-null |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property additionalContactIDsNoDataExported will specify the items that are not included in the resolved additionalContact array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `additionalContactIDs` | array |  |

## applicationMethod

### `/applicationMethod/[id]`

Get applicationMethod data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `applicationMethodID` | integer |  |
| `officeID` | integer |  |
| `applicationMethod` | string |  |
| `visible` | integer |  |
| `systemReserved` | integer |  |

### `/applicationMethod/get`

Get Bulk data for applicationMethod. Accepts an array of applciationMethodIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `applciationMethodIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `applicationMethodID` | integer |  |
| `officeID` | integer |  |
| `applicationMethod` | string |  |
| `visible` | integer |  |
| `systemReserved` | integer |  |

### `/applicationMethod/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `methodIDs` | integer |  | Primary key |
| `methodID` | integer |  | Primary key alias |
| `applicationMethodID` | integer |  | Primary key alias |
| `applicationMethodIDs` | integer |  | Primary key alias |
| `officeIDs` | integer |  | OfficeID insect belongs to |
| `visible` | integer |  | visibility of the method |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property applicationMethodIDsNoDataExported will specify the items that are not included in the resolved applicationMethod array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `applicationMethodIDs` | array |  |

## appliedPayment

### `/appliedPayment/[id]`

Get appliedPayment data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `appliedPaymentID` | integer | Applied Payment Unique Identifier |
| `officeID` | integer | Office Unique Identifier |
| `paymentID` | integer | Payment Unique Identifier |
| `ticketID` | integer | Ticket Unique Identifier |
| `customerID` | integer | Customer Unique Identifier |
| `dateApplied` | string | Payment date |
| `appliedBy` | integer | Employee Unique Identifier |
| `appliedAmount` | number | Amount of the payment that was used |
| `taxCollected` | number | Amount of tax that was collected |
| `dateUpdated` | string | Date of last update. Should be the same as dateApplied as these tuples are immutable. |

### `/appliedPayment/get`

Get Bulk data for appliedPayment. Accepts an array of appliedPaymentIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `appliedPaymentIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `appliedPaymentID` | integer | Applied Payment Unique Identifier |
| `officeID` | integer | Office Unique Identifier |
| `paymentID` | integer | Payment Unique Identifier |
| `ticketID` | integer | Ticket Unique Identifier |
| `customerID` | integer | Customer Unique Identifier |
| `dateApplied` | string | Payment date |
| `appliedBy` | integer | Employee Unique Identifier |
| `appliedAmount` | number | Amount of the payment that was used |
| `taxCollected` | number | Amount of tax that was collected |
| `dateUpdated` | string | Date of last update. Should be the same as dateApplied as these tuples are immutable. |

### `/appliedPayment/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `appliedPaymentID` | integer |  | Primary key |
| `appliedPaymentIDs` | integer |  | Primary key alias |
| `officeIDs` | integer |  | Office Unique Identifier |
| `officeID` | integer |  | Office Unique Identifier |
| `paymentIDs` | integer |  | Payment Unique Identifier |
| `paymentID` | integer |  | Payment Unique Identifier |
| `ticketIDs` | integer |  | ticket Unique Identifier |
| `ticketID` | integer |  | ticket Unique Identifier |
| `customerIDs` | integer |  | Customer Unique Identifier |
| `customerID` | integer |  | Customer Unique Identifier |
| `dateApplied` | string |  | Payment application date |
| `dateUpdated` | string |  | Date payment application was last updated. |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property appliedPaymentIDsNoDataExported will specify the items that are not included in the resolved appliedPayment array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `appliedPaymentIDs` | array |  |

## appointment

### `/appointment/[id]`

Get appointment data for single ID -- please provide a specific record ID in the URL structure.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `includeCancellationReason` | integer |  | Send as 1 to retrieve an additional field cancellationReason. |
| `includeTargetPests` | integer |  | Send as 1 to retrieve an additional field targetPests as an array of integers. |
| `includeCustomFields` | integer |  | Send as 1 to retrieve an additional field customFields as an array of Custom Fields names and values. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `appointmentID` | integer | Unique Identifier |
| `officeID` | integer | The ID of the office this appointment belongs to. |
| `customerID` | integer | The ID of the customer this appointment belongs to. |
| `subscriptionID` | integer | The ID of the subscription if this appointment belongs to a subscription. If an appointment is attached to a subscription it inherits its pricing as well as other defaults. It also resets the next due date upon completion. Stand alone services or reservices will be a -1. |
| `subscriptionRegionID` | integer | RegionID of the subscription if this appointment belongs to a one. For stand alone services or reservices it will be -1. |
| `routeID` | integer | The ID of the route that this appointment is assigned to. |
| `spotID` | integer | The ID of the spot that this appointment is assigned to. Null indicates an appointment that is flexible on route. |
| `date` | string | The date this appointment is scheduled for. |
| `start` | string | The beginning of the acceptable time window that the tech may arrive. |
| `end` | string | The end of the acceptable time window that the tech may arrive. |
| `timeWindow` | string | The classification of the time window for the appointment |
| `duration` | integer | The number of minutes this appointment is scheduled for. |
| `type` | integer | The service type ID of this appointment. Reference the endpoint `servicetype` for available options. |
| `dateAdded` | string | The date this appointment was created / added. |
| `employeeID` | integer | The employee ID who created this appointment. |
| `status` | integer | The status code of this appointment. |
| `statusText` | string | Friendly representation of status |
| `callAhead` | integer | The number of minutes the tech should call ahead to the customer before arriving. |
| `isInitial` | integer | Whether or not this is the initial appointment for the associated subscription. 1: yes, 0: no |
| `subscriptionPreferredTech` | integer | The employee ID of the technitian set up as preferred for this service subscription, if this appointment belongs to a one. For stand alone services or reservices it will be -1. |
| `completedBy` | integer | The employee ID who marked this as serviced -- not necessarily which tech completed the service. |
| `servicedBy` | integer | The employee ID of the technician who serviced this appointment |
| `dateCompleted` | string | The date this appointment was marked as serviced (when the action took place and not necessarily the date of the appointment). |
| `signedByCustomer` | string | Returns 1 if the customer gave a signature when the appointment was completed, 0 otherwise. |
| `signedByTech` | string | Returns 1 if the tech gave a signature when the appointment was completed, 0 otherwise. |
| `notes` | string | The notes the technician left for the customer. |
| `officeNotes` | string | The notes the technician left ONLY for the office. |
| `timeIn` | string | The time the technician checked into the appointment (via user defined input). |
| `timeOut` | string | The time the technician checked out of the appointment (via user-defined input). |
| `checkIn` | string | The time the technician checked into the appointment (via check-in button). |
| `checkOut` | string | The time the technician checked out of the appointment (via check-out button). |
| `windSpeed` | integer | Miles Per Hour |
| `windDirection` | string | The direction of the wind -- 8 point compass. |
| `temperature` | integer | Degrees Farenheight. |
| `amountCollected` | number | The amount the tech reported as being collected. |
| `paymentMethod` | integer | The method of payment collected. -1: no payment collected, 0: coupon, 1: cash, 2: check, 3: credit card |
| `servicedInterior` | integer | 1: Serviced Interior, 0: Outside only |
| `ticketID` | integer | The ticket / invoice ID associated with the appointment. |
| `dateCancelled` | string | Cancelation date |
| `additionalTechs` | string | EmployeeIDs of additional techs on the appointment. Comma separated. |
| `appointmentCancellationReason` | string | Appointment cancellation reason, only returned if parameter 'includeCancellationReason' is included with the request. |
| `cancellationReason` | string | Appointment cancellation reason, only returned if parameter 'includeCancellationReason' is included with the request. |
| `rescheduleReasonID` | integer | Appointment reschedule reason ID |
| `reserviceReasonID` | integer | Appointment reservice reason ID |
| `unitIDs` | integer | An array of unit IDs associated with this appointment (for multi unit customers) |
| `targetPests` | integer | Requires parameter 'includeTargetPests' to be sent with the request. The ID of a target insect associated with the appointment, these IDs can be found in preferences via Admin &gt; Preferences &gt; Service Related &gt; Target Issues |
| `appointmentNotes` | string | Notes for the appointment. |
| `doInterior` | integer | 0 - unspecified, 1 - Exterior only, 2 - Interior Needed |
| `dateUpdated` | string | Date the appointment was last changed |
| `cancelledBy` | integer | EmployeeID that cancelled the appointment. |
| `assignedTech` | integer | EmployeeID that was assigned to the appointment. |
| `latIn` | number | latIn recorded at appointment completion |
| `latOut` | number | latOut recorded at appointment completion |
| `longIn` | number | longIn recorded at appointment completion |
| `longOut` | number | longOut recorded at appointment completion |
| `sequence` | integer | When multiple appointments occupy the same spot this determines which of the appointments will be first. |
| `lockedBy` | integer | EmployeeID who locked the appointment, or 0 if it is unlocked |
| `originalAppointmentID` | integer | appointmentID of original appointment that was rescheduled |

### `/appointment/cancel`

Cancel specified appointmentID

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `appointmentID` | integer | Yes | appointmentID to cancel |
| `cancelReason` | string |  | Cancel Reason |
| `cancelledBy` | integer |  | employeeID that cancelled the appointment |

### `/appointment/complete`

Complete specified appointmentID

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `appointmentID` | integer | Yes |  |
| `status` | integer |  | The status of an appointment which can include:0: Pending, 1: Completed, 2: No Show |
| `completionNotes` | string |  |  |
| `officeNotes` | string |  |  |
| `flagNotes` | string |  |  |
| `timeIn` | string |  |  |
| `timeOut` | string |  |  |
| `checkIn` | string |  |  |
| `checkOut` | string |  |  |
| `latIn` | number |  |  |
| `latOut` | number |  |  |
| `longIn` | number |  |  |
| `longOut` | number |  |  |
| `signature` | string |  | base64 encoded signature |
| `techSignature` | string |  | base64 encoded signature |
| `windSpeed` | integer |  |  |
| `windDirection` | string |  | N,NW,NE,etc.. |
| `servicedInterior` | integer |  |  |
| `temperature` | integer |  |  |
| `sprayRigID` | integer |  |  |
| `paymentMethod` | integer |  |  |
| `amountCollected` | number |  |  |
| `checkCollectedNumber` | integer |  |  |
| `chemicals` | array |  |  |
| `employeeID` | integer |  |  |
| `completedBy` | integer |  |  |

### `/appointment/create`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | customerID associated with the appointment |
| `type` | integer | Yes | serviceID to perform |
| `start` | string |  | Start Time Window |
| `end` | string |  | End Time Window |
| `duration` | integer |  | Number of minutes this appointment should last |
| `employeeID` | integer |  | employeeID to whom this appointment belongs |
| `notes` | string |  | Appointment Notes |
| `spotID` |  |  | Specify to fix this appointment to a spot |
| `routeID` | integer |  | Specify to fix this appointment on a route. |
| `callAhead` | integer |  | Number of minutes ahead of the appointment start time to call |
| `assignedTech` | integer |  | employeeID of the technician assigned to this appointment |
| `subscriptionID` | integer |  | Specify the subscriptionID this appointment is associated with |
| `doInterior` | integer |  | 0 - unspecified, 1 - Exterior only, 2 - Interior Needed |
| `targetPests` | string |  | Comma separated list of insectIDs |
| `rejectOccupiedSpots` | integer |  | Send as 1 to receive a failure result when the appointment would create a second appointment in the same spot as another appointment (fixed or floating appointments). |
| `rejectFixedOccupiedSpots` | integer |  | Send as 1 to receive a failure result when the appointment would create a second appointment in the same spot as another fixed-to-spot appointment appointment. |
| `reservation` | string |  | If the spotID sent has been reserved, send a bearer token to schedule to a reserved spot |
| `bypassLockedRoute` | integer |  | Ignore locked route setting and schedule anyways |
| `bypassSchedulePermission` | integer |  | Ignore api can schedule on route and schedule anyways. |
| `servicedBy` | integer |  | employeeID who completed the appointment |
| `completedBy` | integer |  | The employee ID who marked this as serviced -- not necessarily which tech completed the service. |
| `sequence` | integer |  | When multiple appointments occupy the same spot this determines which of the appointments will be first. |

### `/appointment/get`

Get Bulk data for appointment. Accepts an array of appointmentIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `appointmentIDs` | array |  |  |
| `includeCancellationReason` | int |  | Send as 1 to retrieve an additional field cancellationReason. |
| `includeTargetPests` | int |  | Send as 1 to retrieve an additional field targetPests as an array of integers. |
| `includeCustomFields` | int |  | Send as 1 to retrieve an additional field customFields as an array of Custom Fields names and values. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `appointmentID` | integer | Unique Identifier |
| `officeID` | integer | The ID of the office this appointment belongs to. |
| `customerID` | integer | The ID of the customer this appointment belongs to. |
| `subscriptionID` | integer | The ID of the subscription if this appointment belongs to a subscription. If an appointment is attached to a subscription it inherits its pricing as well as other defaults. It also resets the next due date upon completion. Stand alone services or reservices will be a -1. |
| `subscriptionRegionID` | integer | RegionID of the subscription if this appointment belongs to a one. For stand alone services or reservices it will be -1. |
| `routeID` | integer | The ID of the route that this appointment is assigned to. |
| `spotID` | integer | The ID of the spot that this appointment is assigned to. Null indicates an appointment that is flexible on route. |
| `date` | string | The date this appointment is scheduled for. |
| `start` | string | The beginning of the acceptable time window that the tech may arrive. |
| `end` | string | The end of the acceptable time window that the tech may arrive. |
| `timeWindow` | string | The classification of the time window for the appointment |
| `duration` | integer | The number of minutes this appointment is scheduled for. |
| `type` | integer | The service type ID of this appointment. Reference the endpoint `servicetype` for available options. |
| `dateAdded` | string | The date this appointment was created / added. |
| `employeeID` | integer | The employee ID who created this appointment. |
| `status` | integer | The status code of this appointment. |
| `statusText` | string | Friendly representation of status |
| `callAhead` | integer | The number of minutes the tech should call ahead to the customer before arriving. |
| `isInitial` | integer | Whether or not this is the initial appointment for the associated subscription. 1: yes, 0: no |
| `subscriptionPreferredTech` | integer | The employee ID of the technitian set up as preferred for this service subscription, if this appointment belongs to a one. For stand alone services or reservices it will be -1. |
| `completedBy` | integer | The employee ID who marked this as serviced -- not necessarily which tech completed the service. |
| `servicedBy` | integer | The employee ID of the technician who serviced this appointment |
| `dateCompleted` | string | The date this appointment was marked as serviced (when the action took place and not necessarily the date of the appointment). |
| `signedByCustomer` | string | Returns 1 if the customer gave a signature when the appointment was completed, 0 otherwise. |
| `signedByTech` | string | Returns 1 if the tech gave a signature when the appointment was completed, 0 otherwise. |
| `notes` | string | The notes the technician left for the customer. |
| `officeNotes` | string | The notes the technician left ONLY for the office. |
| `timeIn` | string | The time the technician checked into the appointment (via user defined input). |
| `timeOut` | string | The time the technician checked out of the appointment (via user-defined input). |
| `checkIn` | string | The time the technician checked into the appointment (via check-in button). |
| `checkOut` | string | The time the technician checked out of the appointment (via check-out button). |
| `windSpeed` | integer | Miles Per Hour |
| `windDirection` | string | The direction of the wind -- 8 point compass. |
| `temperature` | integer | Degrees Farenheight. |
| `amountCollected` | number | The amount the tech reported as being collected. |
| `paymentMethod` | integer | The method of payment collected. -1: no payment collected, 0: coupon, 1: cash, 2: check, 3: credit card |
| `servicedInterior` | integer | 1: Serviced Interior, 0: Outside only |
| `ticketID` | integer | The ticket / invoice ID associated with the appointment. |
| `dateCancelled` | string | Cancelation date |
| `additionalTechs` | string | EmployeeIDs of additional techs on the appointment. Comma separated. |
| `appointmentCancellationReason` | string | Appointment cancellation reason, only returned if parameter 'includeCancellationReason' is included with the request. |
| `cancellationReason` | string | Appointment cancellation reason, only returned if parameter 'includeCancellationReason' is included with the request. |
| `rescheduleReasonID` | integer | Appointment reschedule reason ID |
| `reserviceReasonID` | integer | Appointment reservice reason ID |
| `unitIDs` | integer | An array of unit IDs associated with this appointment (for multi unit customers) |
| `targetPests` | integer | Requires parameter 'includeTargetPests' to be sent with the request. The ID of a target insect associated with the appointment, these IDs can be found in preferences via Admin &gt; Preferences &gt; Service Related &gt; Target Issues |
| `appointmentNotes` | string | Notes for the appointment. |
| `doInterior` | integer | 0 - unspecified, 1 - Exterior only, 2 - Interior Needed |
| `dateUpdated` | string | Date the appointment was last changed |
| `cancelledBy` | integer | EmployeeID that cancelled the appointment. |
| `assignedTech` | integer | EmployeeID that was assigned to the appointment. |
| `latIn` | number | latIn recorded at appointment completion |
| `latOut` | number | latOut recorded at appointment completion |
| `longIn` | number | longIn recorded at appointment completion |
| `longOut` | number | longOut recorded at appointment completion |
| `sequence` | integer | When multiple appointments occupy the same spot this determines which of the appointments will be first. |
| `lockedBy` | integer | EmployeeID who locked the appointment, or 0 if it is unlocked |
| `originalAppointmentID` | integer | appointmentID of original appointment that was rescheduled |

### `/appointment/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeID` | integer |  |  |
| `officeIDs` | integer |  |  |
| `appointmentIDs` | integer |  | Unique ID |
| `status` | integer |  | The status of an appointment which can include:&lt;ul&gt;&lt;li&gt;0: Pending&lt;/li&gt;&lt;li&gt;1: Completed&lt;/li&gt;&lt;li&gt;2: No Show&lt;/li&gt;&lt;li&gt;-2: Rescheduled&lt;/li&gt;&lt;li&gt;-1: Cancelled&lt;/li&gt;&lt;/ul&gt; |
| `customerIDs` | integer |  | Customer who owns this appointment |
| `subscriptionIDs` | integer |  | Subscription who owns this appointment. Appointments that are attached to subscriptions inherit the subscriptions pricing templates and other defaults as well as update the subscriptions next service dates upon completion. Re-services and stand-alone services are NOT attached to subscriptions. |
| `spotIDs` | integer |  | Spot ID the appointment is assigned to. |
| `routeIDs` | integer |  | Route the appointment is assigned to. |
| `dateAdded` | string |  | Date this appointment was created / scheduled. |
| `dateCompleted` | string |  | Date this appointment was completed / marked serviced (not necessarily the date it was on the schedule). |
| `date` | string |  | Date this appointment is scheduled for. |
| `serviceIDs` | integer |  | Service type ID for this appointment. Reference the endpoint `servicetypes` to see available options |
| `servicedBy` | integer |  | The technician who serviced this appointment |
| `completedBy` | integer |  | The user who marked this appointment as completed NOT necessarily the one who serviced the appointment. |
| `dateAddedStart` | string |  |  |
| `dateAddedEnd` | string |  |  |
| `dateStart` | string |  |  |
| `dateEnd` | string |  |  |
| `dateCancelled` | string |  | Cancelation date |
| `additionalTechs` | integer |  | employeeID of additional tech |
| `salesAnchor` | integer |  | Set as 1 if this is the first appointment connected to a subscription |
| `targetPests` | integer |  | The ID of a target insect associated with the appointment, these IDs can be found in preferences via Admin &gt; Preferences &gt; Service Related &gt; Target Issues |
| `dateUpdated` | string |  | Date the appointment was last changed |
| `salesTeamID` | integer |  | Sales team that sold the appointment. |
| `cancelledBy` | integer |  | EmployeeID that cancelled the appointment. |
| `assignedTech` | integer |  | EmployeeID that was assigned to the appointment. |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property appointmentIDsNoDataExported will specify the items that are not included in the resolved appointment array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `appointmentIDs` | array |  |

### `/appointment/update`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer |  | customerID associated with the appointment |
| `type` | integer |  | serviceID to perform |
| `start` | string |  | Start Time Window |
| `end` | string |  | End Time Window |
| `duration` | integer |  | Number of minutes this appointment should last |
| `employeeID` | integer |  | employeeID to whom this appointment belongs |
| `notes` | string |  | Appointment Notes |
| `spotID` |  |  | Specify to fix this appointment to a spot |
| `routeID` | integer |  | Specify to fix this appointment on a route. |
| `callAhead` | integer |  | Number of minutes ahead of the appointment start time to call |
| `assignedTech` | integer |  | employeeID of the technician assigned to this appointment |
| `subscriptionID` | integer |  | Specify the subscriptionID this appointment is associated with |
| `doInterior` | integer |  | 0 - unspecified, 1 - Exterior only, 2 - Interior Needed |
| `targetPests` | string |  | Comma separated list of insectIDs |
| `rejectOccupiedSpots` | integer |  | Send as 1 to receive a failure result when the appointment would create a second appointment in the same spot as another appointment (fixed or floating appointments). |
| `rejectFixedOccupiedSpots` | integer |  | Send as 1 to receive a failure result when the appointment would create a second appointment in the same spot as another fixed-to-spot appointment appointment. |
| `reservation` | string |  | If the spotID sent has been reserved, send a bearer token to schedule to a reserved spot |
| `bypassLockedRoute` | integer |  | Ignore locked route setting and schedule anyways |
| `bypassSchedulePermission` | integer |  | Ignore api can schedule on route and schedule anyways. |
| `servicedBy` | integer |  | employeeID who completed the appointment |
| `completedBy` | integer |  | The employee ID who marked this as serviced -- not necessarily which tech completed the service. |
| `sequence` | integer |  | When multiple appointments occupy the same spot this determines which of the appointments will be first. |
| `appointmentID` | integer | Yes | Primary key to the appointments table. |
| `timeIn` | string |  | The time the technician checked into the appointment (via user defined input). |
| `timeOut` | string |  | The time the technician checked out of the appointment (via user-defined input). |
| `checkIn` | string |  | The time the technician checked into the appointment (via check-in button). |
| `checkOut` | string |  | The time the technician checked out of the appointment (via check-out button). |
| `status` | integer |  | The status of an appointment which can include:0: Pending, 1: Completed, 2: No Show |
| `cancelledBy` | integer |  | employeeID of employee that cancelled the appointment, if setting to status No Show |

## appointmentCancellationReason

### `/appointmentCancellationReason/[id]`

Get appointmentCancellationReason data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `cancellationReasonID` | integer |  |
| `officeID` | integer |  |
| `visible` | integer | Used by the FieldRoutes application to hide/show reasons from staff |
| `systemReserved` | integer | Used by the FieldRoutes application to specify fixed system actions (this field no longer exists and will always be 0) |
| `reason` | string | Description of the appointment cancellation reason |

### `/appointmentCancellationReason/get`

Get Bulk data for appointmentCancellationReason. Accepts an array of cancellationReasonIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `cancellationReasonIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `cancellationReasonID` | integer |  |
| `officeID` | integer |  |
| `visible` | integer | Used by the FieldRoutes application to hide/show reasons from staff |
| `systemReserved` | integer | Used by the FieldRoutes application to specify fixed system actions (this field no longer exists and will always be 0) |
| `reason` | string | Description of the appointment cancellation reason |

### `/appointmentCancellationReason/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `cancellationReasonIDs` | integer |  |  |
| `cancellationReasonID` | integer |  |  |
| `officeIDs` | integer |  |  |
| `officeID` | integer |  |  |
| `visible` | integer |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property appointmentCancellationReasonIDsNoDataExported will specify the items that are not included in the resolved appointmentCancellationReason array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `appointmentCancellationReasonIDs` | array |  |

## appointmentReminder

### `/appointmentReminder/[id]`

Get appointmentReminder data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `reminderID` | integer | Primary Key |
| `officeID` | integer | Office the reminder belongs to |
| `appointmentID` | integer | appointmentID the reminder pertains to |
| `text` | string | Text of the reminder |
| `dateSent` | string | Time the reminder was sent |
| `emailSent` | string | Time email was sent |
| `voiceSent` | string | Time voice message was sent |
| `status` | integer | -1 = don't send reminder, 0 = not sent, 1 = sent, 9 = confirmed |
| `response` | string | Response text received |
| `responseTime` | string | Time response was received |
| `sendTo` | string | Phone number for SMS |
| `emailAddress` | string | Email address the reminder was sent to |
| `voiceNumber` | string | Phone number for voice |
| `dateUpdated` | string | Date that this appointmentReminder was last updated |

### `/appointmentReminder/create`

create a customer

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `appointmentID` | integer | Yes | appointmentID the reminder pertains to |
| `text` | string | Yes | Text of the reminder |
| `dateSent` | string | Yes | Time the reminder was sent |
| `emailSent` | string | Yes | Time email was sent |
| `voiceSent` | string |  | Time voice message was sent |
| `status` | integer | Yes | -1 = don't send reminder, 0 = not sent(not allowed), 1 = sent, 6 = confirmed by office, 9 = confirmed via SMS |
| `response` | string |  | Response text received |
| `responseTime` | string |  | Time response was received |
| `sendTo` | string |  | Phone number for SMS |
| `emailAddress` | string |  | Email address the reminder was sent to |
| `voiceNumber` | string |  | Phone number for voice |

### `/appointmentReminder/get`

Get Bulk data for appointmentReminder. Accepts an array of reminderIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `reminderIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `reminderID` | integer | Primary Key |
| `officeID` | integer | Office the reminder belongs to |
| `appointmentID` | integer | appointmentID the reminder pertains to |
| `text` | string | Text of the reminder |
| `dateSent` | string | Time the reminder was sent |
| `emailSent` | string | Time email was sent |
| `voiceSent` | string | Time voice message was sent |
| `status` | integer | -1 = don't send reminder, 0 = not sent, 1 = sent, 9 = confirmed |
| `response` | string | Response text received |
| `responseTime` | string | Time response was received |
| `sendTo` | string | Phone number for SMS |
| `emailAddress` | string | Email address the reminder was sent to |
| `voiceNumber` | string | Phone number for voice |
| `dateUpdated` | string | Date that this appointmentReminder was last updated |

### `/appointmentReminder/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `reminderID` | integer |  | Primary Key |
| `reminderIDs` | integer |  | Alias of reminderID |
| `appointmentReminderIDs` | integer |  | Alias of reminderID |
| `officeIDs` | integer |  | Office the reminder belongs to |
| `appointmentID` | integer |  | appointmentID the reminder pertains to |
| `text` | string |  | Text of the reminder |
| `dateSent` | string |  | Time the reminder was sent |
| `emailSent` | string |  | Time email was sent |
| `voiceSent` | string |  | Time voice message was sent |
| `status` | integer |  | -1 = don't send, 0 = not sent, 1 = sent, 9 = confirmed |
| `response` | string |  | Response text received |
| `responseTime` | string |  | Time response was received |
| `sendTo` | string |  | Phone number for SMS |
| `emailAddress` | string |  | Email address the reminder was sent to |
| `voiceNumber` | string |  | Phone number for voice |
| `dateUpdated` | string |  | Date that this appointmentReminder was last updated |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property appointmentReminderIDsNoDataExported will specify the items that are not included in the resolved appointmentReminder array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `appointmentReminderIDs` | array |  |

### `/appointmentReminder/update`

Update appointmentReminder details

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `appointmentID` | integer |  | appointmentID the reminder pertains to |
| `text` | string |  | Text of the reminder |
| `dateSent` | string |  | Time the reminder was sent |
| `emailSent` | string |  | Time email was sent |
| `voiceSent` | string |  | Time voice message was sent |
| `status` | integer |  | -1 = don't send reminder, 0 = not sent(not allowed), 1 = sent, 6 = confirmed by office, 9 = confirmed via SMS |
| `response` | string |  | Response text received |
| `responseTime` | string |  | Time response was received |
| `sendTo` | string |  | Phone number for SMS |
| `emailAddress` | string |  | Email address the reminder was sent to |
| `voiceNumber` | string |  | Phone number for voice |
| `reminderID` | integer | Yes | Primary key to the appointmentReminder table. |

## appointmentRescheduleReason

### `/appointmentRescheduleReason/[id]`

Get appointmentRescheduleReason data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `rescheduleReasonID` | integer |  |
| `officeID` | integer |  |
| `visible` | integer | Used by the FieldRoutes application to hide/show reasons from staff |
| `systemReserved` | integer | Used by the FieldRoutes application to specify fixed system actions (field no longer exists and will always return as 0) |
| `reason` | string | Description of the appointment reschedule reason |

### `/appointmentRescheduleReason/get`

Get Bulk data for appointmentRescheduleReason. Accepts an array of rescheduleReasonIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `rescheduleReasonIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `rescheduleReasonID` | integer |  |
| `officeID` | integer |  |
| `visible` | integer | Used by the FieldRoutes application to hide/show reasons from staff |
| `systemReserved` | integer | Used by the FieldRoutes application to specify fixed system actions (field no longer exists and will always return as 0) |
| `reason` | string | Description of the appointment reschedule reason |

### `/appointmentRescheduleReason/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `rescheduleReasonIDs` | integer |  |  |
| `rescheduleReasonID` | integer |  |  |
| `officeIDs` | integer |  |  |
| `officeID` | integer |  |  |
| `visible` | integer |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property appointmentRescheduleReasonIDsNoDataExported will specify the items that are not included in the resolved appointmentRescheduleReason array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `appointmentRescheduleReasonIDs` | array |  |

## cancellationReason

### `/cancellationReason/[id]`

Get cancellationReason data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `reasonID` | integer |  |
| `officeID` | integer |  |
| `visible` | integer | Used by the FieldRoutes application to hide/show reasons from staff |
| `systemReserved` | integer | Used by the FieldRoutes application to specify fixed system actions (field no longer exists and will will always return 0) |
| `reason` | string | Description of the cancellation reason |

### `/cancellationReason/get`

Get Bulk data for cancellationReason. Accepts an array of reasonIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `reasonIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `reasonID` | integer |  |
| `officeID` | integer |  |
| `visible` | integer | Used by the FieldRoutes application to hide/show reasons from staff |
| `systemReserved` | integer | Used by the FieldRoutes application to specify fixed system actions (field no longer exists and will will always return 0) |
| `reason` | string | Description of the cancellation reason |

### `/cancellationReason/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `reasonIDs` | integer |  |  |
| `reasonID` | integer |  |  |
| `officeIDs` | integer |  |  |
| `officeID` | integer |  |  |
| `visible` | integer |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property cancellationReasonIDsNoDataExported will specify the items that are not included in the resolved cancellationReason array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `cancellationReasonIDs` | array |  |

## changelog

### `/changelog/[id]`

Get changelog data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `changeID` | integer | Unique ID |
| `classID` | integer | Constant number identifying change type. Possible Values: {"Employee":1,"Group":2,"Route":3,"Appointment":4,"Ticket":5,"PaymentProfile":6,"Subscription":7,"Customer":8,"Diagram":9,"InsectsAction":10,"ServiceTypesAction":11,"PreSetNotesAction":13,"SprayRigsAction":12,"AddOnsAction":15,"EquipmentTypesAction":14,"GenericFlagsAction":17,"DivisionsAction":20,"CancellationReasonsAction":18,"FrequencyAction":16,"VoiceMessagesAction":22,"Unit":21,"SalesAidesAction":26,"FormTemplatesAction":28,"RegionsAction":24,"DiagramMarkersAction":37,"LostReasonsAction":40,"BillingLetterTemplatesAction":29,"LocationAction":39,"ChemicalsAction":35,"CustomerSourcesAction":19,"NoteCategoriesAction":41,"SocialNetworkAction":38,"ContractTemplatesAction":27,"OfficeInfoAction":32,"DealsAction":30,"LeadStagesAction":25,"NoteTypesAction":36,"MerchantInfoAction":33,"VendorsAction":80,"AccessControlProfilesAction":23,"Document":42,"PreferencesAction":31,"CustomerCommunicationsAction":34,"ClockCategoriesAction":43,"ObjectionsAction":44,"CompetitorsAction":45,"CommissionRateAction":46,"CreditCardImportAction":47,"PreferencesBodyAction":50,"AdditionalContact":51,"StructureTemplatesAction":58,"ConditionTypesAction":55,"StructuresAction":60,"ConditionsAction":56,"ConditionTemplatesAction":57,"EmailTemplateAction":52,"EmailCategoryAction":53,"ExceptionTypesAction":59,"TimeClockEntriesAction":54,"Payment":61,"Task":62,"TimeClockSettingsAction":63,"VisualRouting":64,"TermiteReportAction":65,"TermiteFindingAction":66,"TermiteRecommendationAction":67,"TermiteAreaAction":68,"TermiteFindingTemplateAction":69,"TermiteRecommendationTemplateAction":70,"RenewalNoticeAction":71,"SubPropertyTypesAction":72,"ElementProfile":73,"BrainProfile":74,"NMIProfile":75,"SpreedlyProfile":76,"RoutesProfile":77,"PayrixProfile":79,"Equipment":78,"SkipReasonsAction":84,"SkillsAction":81,"ServicePlanAction":85,"ServicePlanRoundAction":86,"PropertyEstimationCategoriesAction":87,"PropertyEstimationStatsAction":88,"SalesLeaderboardProfileAction":89,"CustomFieldsAction":92,"AffiliateNetworkBillingOffice":93,"PrepayLetterTemplates":94,"CommissionRateProfilesAssignedEmployees":95} |
| `class` | string | Name of the Class associated with the number. Possible values: Employee, Group, Route, Appointment, Ticket, PaymentProfile, Subscription, Customer, Diagram, InsectsAction, ServiceTypesAction, PreSetNotesAction, SprayRigsAction, AddOnsAction, EquipmentTypesAction, GenericFlagsAction, DivisionsAction, CancellationReasonsAction, FrequencyAction, VoiceMessagesAction, Unit, SalesAidesAction, FormTemplatesAction, RegionsAction, DiagramMarkersAction, LostReasonsAction, BillingLetterTemplatesAction, LocationAction, ChemicalsAction, CustomerSourcesAction, NoteCategoriesAction, SocialNetworkAction, ContractTemplatesAction, OfficeInfoAction, DealsAction, LeadStagesAction, NoteTypesAction, MerchantInfoAction, VendorsAction, AccessControlProfilesAction, Document, PreferencesAction, CustomerCommunicationsAction, ClockCategoriesAction, ObjectionsAction, CompetitorsAction, CommissionRateAction, CreditCardImportAction, PreferencesBodyAction, AdditionalContact, StructureTemplatesAction, ConditionTypesAction, StructuresAction, ConditionsAction, ConditionTemplatesAction, EmailTemplateAction, EmailCategoryAction, ExceptionTypesAction, TimeClockEntriesAction, Payment, Task, TimeClockSettingsAction, VisualRouting, TermiteReportAction, TermiteFindingAction, TermiteRecommendationAction, TermiteAreaAction, TermiteFindingTemplateAction, TermiteRecommendationTemplateAction, RenewalNoticeAction, SubPropertyTypesAction, ElementProfile, BrainProfile, NMIProfile, SpreedlyProfile, RoutesProfile, PayrixProfile, Equipment, SkipReasonsAction, SkillsAction, ServicePlanAction, ServicePlanRoundAction, PropertyEstimationCategoriesAction, PropertyEstimationStatsAction, SalesLeaderboardProfileAction, CustomFieldsAction, AffiliateNetworkBillingOffice, PrepayLetterTemplates, CommissionRateProfilesAssignedEmployees |
| `dateChanged` | string | Date this change was made. |
| `employeeID` | integer | ID of employee who made the change. |
| `notes` | json | JSON encoded object representing the change that was made. |
| `referenceID` | integer | ID of the specified class that was changed |

### `/changelog/get`

Get Bulk data for changelog. Accepts an array of changeIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `changeIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `changeID` | integer | Unique ID |
| `classID` | integer | Constant number identifying change type. Possible Values: {"Employee":1,"Group":2,"Route":3,"Appointment":4,"Ticket":5,"PaymentProfile":6,"Subscription":7,"Customer":8,"Diagram":9,"InsectsAction":10,"ServiceTypesAction":11,"PreSetNotesAction":13,"SprayRigsAction":12,"AddOnsAction":15,"EquipmentTypesAction":14,"GenericFlagsAction":17,"DivisionsAction":20,"CancellationReasonsAction":18,"FrequencyAction":16,"VoiceMessagesAction":22,"Unit":21,"SalesAidesAction":26,"FormTemplatesAction":28,"RegionsAction":24,"DiagramMarkersAction":37,"LostReasonsAction":40,"BillingLetterTemplatesAction":29,"LocationAction":39,"ChemicalsAction":35,"CustomerSourcesAction":19,"NoteCategoriesAction":41,"SocialNetworkAction":38,"ContractTemplatesAction":27,"OfficeInfoAction":32,"DealsAction":30,"LeadStagesAction":25,"NoteTypesAction":36,"MerchantInfoAction":33,"VendorsAction":80,"AccessControlProfilesAction":23,"Document":42,"PreferencesAction":31,"CustomerCommunicationsAction":34,"ClockCategoriesAction":43,"ObjectionsAction":44,"CompetitorsAction":45,"CommissionRateAction":46,"CreditCardImportAction":47,"PreferencesBodyAction":50,"AdditionalContact":51,"StructureTemplatesAction":58,"ConditionTypesAction":55,"StructuresAction":60,"ConditionsAction":56,"ConditionTemplatesAction":57,"EmailTemplateAction":52,"EmailCategoryAction":53,"ExceptionTypesAction":59,"TimeClockEntriesAction":54,"Payment":61,"Task":62,"TimeClockSettingsAction":63,"VisualRouting":64,"TermiteReportAction":65,"TermiteFindingAction":66,"TermiteRecommendationAction":67,"TermiteAreaAction":68,"TermiteFindingTemplateAction":69,"TermiteRecommendationTemplateAction":70,"RenewalNoticeAction":71,"SubPropertyTypesAction":72,"ElementProfile":73,"BrainProfile":74,"NMIProfile":75,"SpreedlyProfile":76,"RoutesProfile":77,"PayrixProfile":79,"Equipment":78,"SkipReasonsAction":84,"SkillsAction":81,"ServicePlanAction":85,"ServicePlanRoundAction":86,"PropertyEstimationCategoriesAction":87,"PropertyEstimationStatsAction":88,"SalesLeaderboardProfileAction":89,"CustomFieldsAction":92,"AffiliateNetworkBillingOffice":93,"PrepayLetterTemplates":94,"CommissionRateProfilesAssignedEmployees":95} |
| `class` | string | Name of the Class associated with the number. Possible values: Employee, Group, Route, Appointment, Ticket, PaymentProfile, Subscription, Customer, Diagram, InsectsAction, ServiceTypesAction, PreSetNotesAction, SprayRigsAction, AddOnsAction, EquipmentTypesAction, GenericFlagsAction, DivisionsAction, CancellationReasonsAction, FrequencyAction, VoiceMessagesAction, Unit, SalesAidesAction, FormTemplatesAction, RegionsAction, DiagramMarkersAction, LostReasonsAction, BillingLetterTemplatesAction, LocationAction, ChemicalsAction, CustomerSourcesAction, NoteCategoriesAction, SocialNetworkAction, ContractTemplatesAction, OfficeInfoAction, DealsAction, LeadStagesAction, NoteTypesAction, MerchantInfoAction, VendorsAction, AccessControlProfilesAction, Document, PreferencesAction, CustomerCommunicationsAction, ClockCategoriesAction, ObjectionsAction, CompetitorsAction, CommissionRateAction, CreditCardImportAction, PreferencesBodyAction, AdditionalContact, StructureTemplatesAction, ConditionTypesAction, StructuresAction, ConditionsAction, ConditionTemplatesAction, EmailTemplateAction, EmailCategoryAction, ExceptionTypesAction, TimeClockEntriesAction, Payment, Task, TimeClockSettingsAction, VisualRouting, TermiteReportAction, TermiteFindingAction, TermiteRecommendationAction, TermiteAreaAction, TermiteFindingTemplateAction, TermiteRecommendationTemplateAction, RenewalNoticeAction, SubPropertyTypesAction, ElementProfile, BrainProfile, NMIProfile, SpreedlyProfile, RoutesProfile, PayrixProfile, Equipment, SkipReasonsAction, SkillsAction, ServicePlanAction, ServicePlanRoundAction, PropertyEstimationCategoriesAction, PropertyEstimationStatsAction, SalesLeaderboardProfileAction, CustomFieldsAction, AffiliateNetworkBillingOffice, PrepayLetterTemplates, CommissionRateProfilesAssignedEmployees |
| `dateChanged` | string | Date this change was made. |
| `employeeID` | integer | ID of employee who made the change. |
| `notes` | json | JSON encoded object representing the change that was made. |
| `referenceID` | integer | ID of the specified class that was changed |

### `/changelog/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  |  |
| `classID` | integer |  |  |
| `referenceID` | integer |  |  |
| `dateChanged` | string |  | The date this log was created |
| `changeIDs` | integer |  | Primary key for changelog |
| `changelogIDs` | integer |  | Primary key for changelog (alias) |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property changelogIDsNoDataExported will specify the items that are not included in the resolved changelog array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `changelogIDs` | array |  |

## chargeback

### `/chargeback/[id]`

Get chargeback data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `gatewayChargebackID` | integer |  |
| `officeID` | integer |  |
| `dateCreated` | string |  |
| `dateUpdated` | string |  |
| `chargebackAmount` | number |  |
| `chargebackReasonCode` | string |  |
| `paymentID` | integer |  |
| `gatewayBillingName` | integer |  |

### `/chargeback/get`

Get Bulk data for chargeback. Accepts an array of gatewayChargebackIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `gatewayChargebackIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `gatewayChargebackID` | integer |  |
| `officeID` | integer |  |
| `dateCreated` | string |  |
| `dateUpdated` | string |  |
| `chargebackAmount` | number |  |
| `chargebackReasonCode` | string |  |
| `paymentID` | integer |  |
| `gatewayBillingName` | integer |  |

### `/chargeback/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `gatewayChargebackIDs` | integer |  | Primary key |
| `gatewayChargebackID` | integer |  | Primary key alias |
| `officeIDs` | integer |  | Office ID chargeback belongs to |
| `dateCreated` | string |  | Date created |
| `dateUpdated` | string |  | Date last updated |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property chargebackIDsNoDataExported will specify the items that are not included in the resolved chargeback array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `chargebackIDs` | array |  |

## chemical

### `/chemical/[id]`

Get chemical data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `chemicalID` | integer |  |
| `name` | string |  |
| `manufacturer` | string |  |
| `label` | string |  |
| `ingredient1` | string |  |
| `ingredient2` | string |  |
| `ingredient3` | string |  |
| `percent1` | number |  |
| `percent2` | number |  |
| `percent3` | number |  |
| `epaNumber` | string |  |
| `image` | string |  |
| `description` | string |  |
| `defaultDilution` | number |  |
| `concentratedUnit` | string |  |
| `dilutedUnit` | string |  |
| `inventoryUnit` | string |  |
| `applicationRate` | string |  |
| `links` | string |  |
| `msdsLink` | string |  |
| `measurementType` | integer |  |
| `visible` | integer |  |
| `defaultApplicationMethod` | integer |  |
| `officeID` | integer |  |
| `isBait` | integer |  |
| `sentriconBaitTypeID` | integer |  |
| `labelLink` | string |  |
| `mixRatioNumerator` | number |  |
| `mixRatioNumeratorUnit` | string |  |
| `mixRatioDenominator` | number |  |
| `mixRatioDenominatorUnit` | string |  |
| `activeIngredientRate` | number |  |
| `type` | integer |  |
| `targetIssues` | integer | default Insect IDs |
| `availableToTermite` | integer |  |
| `pestControlCode` | integer |  |

### `/chemical/get`

Get Bulk data for chemical. Accepts an array of chemicalIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `chemicalIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `chemicalID` | integer |  |
| `name` | string |  |
| `manufacturer` | string |  |
| `label` | string |  |
| `ingredient1` | string |  |
| `ingredient2` | string |  |
| `ingredient3` | string |  |
| `percent1` | number |  |
| `percent2` | number |  |
| `percent3` | number |  |
| `epaNumber` | string |  |
| `image` | string |  |
| `description` | string |  |
| `defaultDilution` | number |  |
| `concentratedUnit` | string |  |
| `dilutedUnit` | string |  |
| `inventoryUnit` | string |  |
| `applicationRate` | string |  |
| `links` | string |  |
| `msdsLink` | string |  |
| `measurementType` | integer |  |
| `visible` | integer |  |
| `defaultApplicationMethod` | integer |  |
| `officeID` | integer |  |
| `isBait` | integer |  |
| `sentriconBaitTypeID` | integer |  |
| `labelLink` | string |  |
| `mixRatioNumerator` | number |  |
| `mixRatioNumeratorUnit` | string |  |
| `mixRatioDenominator` | number |  |
| `mixRatioDenominatorUnit` | string |  |
| `activeIngredientRate` | number |  |
| `type` | integer |  |
| `targetIssues` | integer | default Insect IDs |
| `availableToTermite` | integer |  |
| `pestControlCode` | integer |  |

### `/chemical/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `chemicalIDs` | integer |  | Primary key |
| `officeIDs` | integer |  | Office ID region belongs to |
| `name` | string |  | Name of the chemical |
| `visible` | string |  | Visibility of the chemical |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property chemicalIDsNoDataExported will specify the items that are not included in the resolved chemical array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `chemicalIDs` | array |  |

## chemicalUse

### `/chemicalUse/[id]`

Get chemicalUse data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `chemicalUseID` | integer |  |
| `chemicalID` | integer |  |
| `officeID` | integer |  |
| `appointmentID` | integer |  |
| `customerID` | integer |  |
| `dateCreated` | string |  |
| `createdBy` | string |  |
| `serviceID` | integer |  |
| `dilution` | number |  |
| `dosage` | number |  |
| `amount` | number |  |
| `concentratedAmount` | number |  |
| `concentratedUnit` | string |  |
| `unit` | string |  |
| `targetInsects` | string |  |
| `locationsTreated` | string |  |
| `applicationMethod` | integer |  |
| `squareFoot` | integer |  |
| `structureID` | integer |  |
| `mixRatioNumerator` | number |  |
| `mixRatioNumeratorUnit` | string |  |
| `mixRatioDenominator` | number |  |
| `mixRatioDenominatorUnit` | string |  |
| `activeIngredientRate` | number |  |
| `epaLot` | string |  |
| `pestControlCode` | integer |  |
| `dateUpdated` | string |  |

### `/chemicalUse/get`

Get Bulk data for chemicalUse. Accepts an array of chemicalUseIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `chemicalUseIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `chemicalUseID` | integer |  |
| `chemicalID` | integer |  |
| `officeID` | integer |  |
| `appointmentID` | integer |  |
| `customerID` | integer |  |
| `dateCreated` | string |  |
| `createdBy` | string |  |
| `serviceID` | integer |  |
| `dilution` | number |  |
| `dosage` | number |  |
| `amount` | number |  |
| `concentratedAmount` | number |  |
| `concentratedUnit` | string |  |
| `unit` | string |  |
| `targetInsects` | string |  |
| `locationsTreated` | string |  |
| `applicationMethod` | integer |  |
| `squareFoot` | integer |  |
| `structureID` | integer |  |
| `mixRatioNumerator` | number |  |
| `mixRatioNumeratorUnit` | string |  |
| `mixRatioDenominator` | number |  |
| `mixRatioDenominatorUnit` | string |  |
| `activeIngredientRate` | number |  |
| `epaLot` | string |  |
| `pestControlCode` | integer |  |
| `dateUpdated` | string |  |

### `/chemicalUse/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `chemicalUseIDs` | integer |  | Primary key |
| `chemicalUseID` | integer |  | Primary key alias |
| `officeIDs` | integer |  | Office ID region belongs to |
| `chemicalID` | integer |  | ID of the chemical Used |
| `appointmentID` | integer |  |  |
| `customerID` | integer |  |  |
| `dateCreated` | string |  |  |
| `createdBy` | string |  |  |
| `serviceID` | integer |  |  |
| `dateUpdated` | string |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property chemicalUseIDsNoDataExported will specify the items that are not included in the resolved chemicalUse array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `chemicalUseIDs` | array |  |

## compassCustomer

### `/compassCustomer/[id]`

Get compassCustomer data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `customerID` | integer | Unique Identifier |
| `officeID` | integer | The ID of the office this customer belongs to |
| `name` | string | The name of the customer |
| `dateAdded` | string |  |
| `serviceType` | string | All subscriptions associated with the customer |
| `contractValue` | number | Total contract value for all subscriptions associated with the customer |

### `/compassCustomer/get`

Get Bulk data for compassCustomer. Accepts an array of customerIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `customerID` | integer | Unique Identifier |
| `officeID` | integer | The ID of the office this customer belongs to |
| `name` | string | The name of the customer |
| `dateAdded` | string |  |
| `serviceType` | string | All subscriptions associated with the customer |
| `contractValue` | number | Total contract value for all subscriptions associated with the customer |

### `/compassCustomer/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `1` | c |  |  |
| `2` | d |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property compassCustomerIDsNoDataExported will specify the items that are not included in the resolved compassCustomer array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `compassCustomerIDs` | array |  |

## contract

### `/contract/[id]`

Get contract data for single ID -- please provide a specific record ID in the URL structure.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `includeDocumentLink` | integer |  | Send as 1 to retrieve a link to the document on AWS with a 15 day TTL. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `contractIDs` | integer |  |
| `contractID` | integer |  |
| `customerIDs` | integer |  |
| `subscriptionIDs` | integer |  |
| `dateSigned` | string | The date the contract was signed. |
| `dateAdded` | string | The date the contract was added. |
| `documentState` | integer | State of the document e.g. WIP, COMPLETED |
| `description` | string | description of the contract |
| `dateUpdated` | string | The date the contract was last updated. |

### `/contract/create`

Create the default contract for the subscriptionID or subscriptionLink sent. If sending a signedFile, upload the file as multipart/form-data with parameter name uploadFile

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionID` | integer |  | Foreign key to subscriptions table. |
| `subscriptionLink` | integer |  | Alternative to subscriptionID. This is the "SubscriptionID" sent during an API insert through import/main. |
| `emailCustomer` | integer |  | Set as 1 to also send a link to the customer via email. |
| `dateSigned` | string |  | The date the contract was signed. Required if uploading a signed document. Date formats m/d/y or y-m-d |
| `base64EncodedFile` | string |  | The Base64 encoded signed contract. Pass this if not sending the file. |
| `notifyCustomerOnSignedAgreement` | integer |  | Set to 1 by default, will send out email to customer with contract as well as a first appointment reminder |

### `/contract/delete`

Delete an uploaded contract

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `contractID` | integer |  | Id of the contract to be deleted. |

### `/contract/get`

Get Bulk data for contract. Accepts an array of contractIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `contractIDs` | array |  |  |
| `includeDocumentLink` | int |  | Send as 1 to retrieve a link to the document on AWS with a 15 day TTL. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `contractIDs` | integer |  |
| `contractID` | integer |  |
| `customerIDs` | integer |  |
| `subscriptionIDs` | integer |  |
| `dateSigned` | string | The date the contract was signed. |
| `dateAdded` | string | The date the contract was added. |
| `documentState` | integer | State of the document e.g. WIP, COMPLETED |
| `description` | string | description of the contract |
| `dateUpdated` | string | The date the contract was last updated. |

### `/contract/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  |  |
| `contractIDs` | integer |  |  |
| `customerIDs` | integer |  |  |
| `subscriptionIDs` | integer |  |  |
| `dateSigned` | string |  | The date the contract was signed. |
| `dateAdded` | string |  | The date the contract was added. |
| `dateUpdated` | string |  | The date the contract was last updated. |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property contractIDsNoDataExported will specify the items that are not included in the resolved contract array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `contractIDs` | array |  |

### `/contract/update`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `contractID` | integer | Yes | ID of contract being updated |
| `description` | string |  | Description of contract being updated |

## customer

### `/customer/[id]`

Get customer data for single ID -- please provide a specific record ID in the URL structure.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `includeCancellationReason` | integer |  | Send as 1 to retrieve an array of cancellationNotes associated with each customer. |
| `includeSubscriptions` | integer |  | Send as 1 to retrieve an array of subscriptions associated with each customer. |
| `includeCustomerFlag` | integer |  | Send as 1 to retrieve an array of flags associated with each customer. |
| `includeAdditionalContacts` | integer |  | Send as 1 to retrieve an array of additional contacts associated with each customer. |
| `includePortalLogin` | integer |  | Send as 1 to retrieve additional properties portalLogin (full URL for customer login) and portalLoginExpires (datetime in PST). Portal token guarenteed valid for 3 days or longer. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `customerID` | integer | Unique Identifier |
| `billToAccountID` | integer | Billing Account which this subscription belongs to |
| `officeID` | integer | The ID of the office this customer belongs to. |
| `fname` | string | The first name of the customer |
| `lname` | string | The last name of the customer. |
| `companyName` | string | The company name of the customer. |
| `spouse` | string | Spouse or alternate contact. |
| `commercialAccount` | integer | 0: Not Commercial, 1: Commercial |
| `status` | integer | 0: Inactive Customer, 1: Active Customer |
| `statusText` | string | Friendly status |
| `email` | string | Email Address of customer |
| `phone1` | string | The primary phone number of the customer |
| `ext1` | string | Extension for the primary phone of the customer |
| `phone2` | string | The secondary phone number of the customer |
| `ext2` | string | Extension for the secondary phone of the customer |
| `address` | string | Customer Service Address |
| `city` | string | Customer Service City |
| `state` | string | Customer Service State |
| `zip` | string | Customer Service Zip |
| `billingCompanyName` | string | Billing Company Name |
| `billingFName` | string | Billing First Name |
| `billingLName` | string | Billing Last Name |
| `billingCountryID` | string | Billing CountryID |
| `billingAddress` | string | Billing Address |
| `billingCity` | string | Billing City |
| `billingState` | string | Billing State |
| `billingZip` | string | Billing Zip |
| `billingPhone` | string | Billing Phone |
| `billingEmail` | string | Billing Email |
| `lat` | number | Lattitude |
| `lng` | number | Longitude |
| `squareFeet` | integer | SquareFeet |
| `addedByID` | integer | The user ID who created this customer |
| `dateAdded` | string | The date this customer account was created. |
| `dateCancelled` | string | The date this customer account was cancelled. |
| `dateUpdated` | string | The date this customer was last changed. |
| `sourceID` | integer | The source ID of how the customer was obtained |
| `source` | string | Friendly version of the source |
| `aPay` | string | Whether or not the customer is on auto pay |
| `preferredTechID` | integer | The user ID of the preferred tech |
| `paidInFull` | integer | Whether or not this customer prefers to pay in advance -- flag |
| `subscriptionIDs` | integer | An array of subscription ID's attached to this customer |
| `balance` | number | The total outstanding balance of the customer |
| `balanceAge` | integer | The number of days this customer has owed any invoice. |
| `responsibleBalance` | number | The total outstanding balance of the customer |
| `responsibleBalanceAge` | integer | The number of days this customer has owed any invoice. |
| `customerLink` | string | Customer Link from the that comes from the integration |
| `masterAccount` | string | CustomerID for the master account in the connected property |
| `preferredBillingDate` | integer | Preferred day for Billing |
| `paymentHoldDate` | string | Payment Hold Date |
| `mostRecentCreditCardLastFour` | string | Last 4 digits of most recently used Credit Card |
| `mostRecentCreditCardExpirationDate` | string | Expiration date of most recently used Credit Card |
| `appointmentIDs` | integer | An array of appointmentIDs associated with the customer |
| `ticketIDs` | integer | An array of ticketIDs associated with the customer |
| `paymentIDs` | integer | An array of paymentIDs associated with the customer |
| `subscriptions` | array | An optional array of all subscription objects. Looks for the includeSubscriptions=true parameter |
| `unitIDs` | integer | An array of unitIDs associated with the customer |
| `regionID` | integer | RegionID of the customer |
| `mapCode` | string | Mapcode of the customer |
| `mapPage` | string | Mappage of the customer |
| `specialScheduling` | string | Special Scheduling for the customer |
| `taxRate` | number | Tax rate of the customer |
| `stateTax` | number | State Tax rate of the customer |
| `cityTax` | number | City Tax rate of the customer |
| `countyTax` | number | County Tax rate of the customer |
| `districtTax` | number | District Tax rate of the customer |
| `districtTax1` | number | District 1 Tax rate of the customer |
| `districtTax2` | number | District 2 Tax rate of the customer |
| `districtTax3` | number | District 3 Tax rate of the customer |
| `districtTax4` | number | District 4 Tax rate of the customer |
| `districtTax5` | number | District 5 Tax rate of the customer |
| `customTax` | number | Custom Tax rate of the customer |
| `zipTaxID` | integer | Zip Tax ID of the customer |
| `smsReminders` | integer | Customer SMS reminder preference. |
| `phoneReminders` | integer | Customer phone reminder preference. |
| `emailReminders` | integer | Customer email reminder preference. |
| `customerSource` | string | Customer source. |
| `customerSourceID` | string | Customer sourceID. |
| `maxMonthlyCharge` | number | Max monthly charge for the customer |
| `county` | string | County name |
| `useStructures` | integer | Set as 1 if the customer is marked as a structure customer (a customer can be residential, multi-unit, or structure) |
| `isMultiUnit` | integer | Set as 1 if the customer is marked as a multi-unit customer (a customer can be residential, multi-unit, or structure) |
| `autoPayPaymentProfileID` | integer | ID of the autopay paymentProfile attached to the customer |
| `divisionID` | integer | divisionID of the customer |
| `subPropertyTypeID` | integer | Sub-Property Type ID of the customer |
| `agingDate` | string | Date the balance began. |
| `responsibleAgingDate` | string | Date the responsibleBalance began. |
| `salesmanAPay` | integer | Sales Rep APay customer flag |
| `purpleDragon` | integer | Purple Dragon customer flag |
| `termiteMonitoring` | integer | Switch Over customer flag |
| `pendingCancel` | integer | Pending cancel customer flag |

### `/customer/create`

create a customer

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `billToAccountID` | integer |  |  |
| `fname` | string |  | First name |
| `lname` | string |  | Last name |
| `spouse` | string |  |  |
| `address` | string |  | Address string |
| `city` | string |  | City string |
| `state` | string |  | 2 letter state code |
| `zip` | string |  | Zip code |
| `mapCode` | string |  | Map Code |
| `squareFeet` | integer |  |  |
| `phone1` | string |  |  |
| `phone2` | string |  |  |
| `ext1` | string |  |  |
| `ext2` | string |  |  |
| `aPay` | integer |  | 0 - no APay, 1 - credit card apay, 2 ACH apay |
| `maxMonthlyCharge` | number |  |  |
| `paidInFull` | integer |  |  |
| `preferredPayment` | integer |  |  |
| `status` | integer |  |  |
| `lat` | number |  |  |
| `lng` | number |  |  |
| `employeeID` | integer |  |  |
| `notes` | string |  |  |
| `termiteMonitoring` | integer |  |  |
| `customerLink` | string |  | External ID, usually the primary key for your application |
| `taxRate` | number |  |  |
| `stateTax` | number |  |  |
| `cityTax` | number |  |  |
| `countyTax` | number |  |  |
| `districtTax` | number |  |  |
| `customTax` | number |  |  |
| `customCode` | string |  |  |
| `cityCode` | string |  |  |
| `countyCode` | string |  |  |
| `districtCode` | string |  |  |
| `zipCityCounty` | string |  |  |
| `smsReminders` | integer |  |  |
| `phoneReminders` | integer |  |  |
| `emailReminders` | integer |  |  |
| `preferredTech` | integer |  |  |
| `preferredBillingDate` | string |  |  |
| `countyID` | integer |  |  |
| `county` | string |  |  |
| `countryID` | string |  | 2-letter Country code e.g. US |
| `dateCancelled` | string |  |  |
| `specialScheduling` | string |  |  |
| `regionID` | integer |  |  |
| `salesmanAPay` | integer |  |  |
| `masterAccount` | integer |  | 0 if not part a master account or assigned to one; otherwise ID of the master account for this customer group |
| `billTo` | integer |  |  |
| `commercialAccount` | integer |  |  |
| `companyName` | string |  |  |
| `email` | string |  | email |
| `sourceID` | integer |  | sourceID for the customer (from Admin &gt; Preferences &gt; Customer References &gt; Customer Sources |
| `divisionID` | integer |  |  |
| `subPropertyTypeID` | integer |  |  |
| `billingFName` | string |  | Billing First Name |
| `billingLName` | string |  | Billing Last Name |
| `billingCountryID` | string |  | Billing CountryID |
| `billingAddress` | string |  | Billing Address |
| `billingCity` | string |  | Billing City |
| `billingState` | string |  | Billing State |
| `billingZip` | string |  | Billing Zip |
| `billingPhone` | string |  | Billing Phone |
| `billingEmail` | string |  | Billing Email |
| `billingCompanyName` | string |  | Billing billingCompanyName |
| `billingPhoneExt` | string |  | Billing billingPhoneExt |
| `billingPhone2` | string |  | Billing billingPhone2 |
| `billingPhone2Ext` | string |  | Billing billingPhone2Ext |
| `billingBusinessContactID` | string |  | Billing billingBusinessContactID |
| `purpleDragon` | integer |  | Sets the Purple Dragon customer flag checkbox |

### `/customer/createPaymentProfile`

Create a payment profile using a CreditCardToken and CreditCardTokenID from braintree/element

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | Foreign Key to customers table |
| `CreditCardToken` | string |  | Required for braintree and element. Not required for nmi |
| `CreditCardTokenID` | string |  | Required for braintree and nmi. Not required for element |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Primary Key for paymentProfiles |
| `customerID` | integer | Customer associated with the payment profile |
| `profileID` | string | Credit card token associated with the payment processor |
| `paymentProfileID` | string | Credit card token id associated with the payment processor |
| `createdBy` | integer | EmployeeID who added the payment profile |
| `dateCreated` | string | Date created |
| `billingName` | string | Billing name |
| `billingAddress1` | string | Billing Address |
| `billingCity` | string | Billing city |
| `billingState` | string | Billing state |
| `billingZip` | integer | Billing zip |
| `billingCountryID` | string | Billing country |
| `lastFour` | string | Last four digits of card number |
| `expMonth` | string | Expiration month |
| `expYear` | string | Expiration year |

### `/customer/get`

Get Bulk data for customer. Accepts an array of customerIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerIDs` | array |  |  |
| `includeCancellationReason` | int |  | Send as 1 to retrieve an array of cancellationNotes associated with each customer. |
| `includeSubscriptions` | int |  | Send as 1 to retrieve an array of subscriptions associated with each customer. |
| `includeCustomerFlag` | int |  | Send as 1 to retrieve an array of flags associated with each customer. |
| `includeAdditionalContacts` | int |  | Send as 1 to retrieve an array of additional contacts associated with each customer. |
| `includePortalLogin` | int |  | Send as 1 to retrieve additional properties portalLogin (full URL for customer login) and portalLoginExpires (datetime in PST). Portal token guarenteed valid for 3 days or longer. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `customerID` | integer | Unique Identifier |
| `billToAccountID` | integer | Billing Account which this subscription belongs to |
| `officeID` | integer | The ID of the office this customer belongs to. |
| `fname` | string | The first name of the customer |
| `lname` | string | The last name of the customer. |
| `companyName` | string | The company name of the customer. |
| `spouse` | string | Spouse or alternate contact. |
| `commercialAccount` | integer | 0: Not Commercial, 1: Commercial |
| `status` | integer | 0: Inactive Customer, 1: Active Customer |
| `statusText` | string | Friendly status |
| `email` | string | Email Address of customer |
| `phone1` | string | The primary phone number of the customer |
| `ext1` | string | Extension for the primary phone of the customer |
| `phone2` | string | The secondary phone number of the customer |
| `ext2` | string | Extension for the secondary phone of the customer |
| `address` | string | Customer Service Address |
| `city` | string | Customer Service City |
| `state` | string | Customer Service State |
| `zip` | string | Customer Service Zip |
| `billingCompanyName` | string | Billing Company Name |
| `billingFName` | string | Billing First Name |
| `billingLName` | string | Billing Last Name |
| `billingCountryID` | string | Billing CountryID |
| `billingAddress` | string | Billing Address |
| `billingCity` | string | Billing City |
| `billingState` | string | Billing State |
| `billingZip` | string | Billing Zip |
| `billingPhone` | string | Billing Phone |
| `billingEmail` | string | Billing Email |
| `lat` | number | Lattitude |
| `lng` | number | Longitude |
| `squareFeet` | integer | SquareFeet |
| `addedByID` | integer | The user ID who created this customer |
| `dateAdded` | string | The date this customer account was created. |
| `dateCancelled` | string | The date this customer account was cancelled. |
| `dateUpdated` | string | The date this customer was last changed. |
| `sourceID` | integer | The source ID of how the customer was obtained |
| `source` | string | Friendly version of the source |
| `aPay` | string | Whether or not the customer is on auto pay |
| `preferredTechID` | integer | The user ID of the preferred tech |
| `paidInFull` | integer | Whether or not this customer prefers to pay in advance -- flag |
| `subscriptionIDs` | integer | An array of subscription ID's attached to this customer |
| `balance` | number | The total outstanding balance of the customer |
| `balanceAge` | integer | The number of days this customer has owed any invoice. |
| `responsibleBalance` | number | The total outstanding balance of the customer |
| `responsibleBalanceAge` | integer | The number of days this customer has owed any invoice. |
| `customerLink` | string | Customer Link from the that comes from the integration |
| `masterAccount` | string | CustomerID for the master account in the connected property |
| `preferredBillingDate` | integer | Preferred day for Billing |
| `paymentHoldDate` | string | Payment Hold Date |
| `mostRecentCreditCardLastFour` | string | Last 4 digits of most recently used Credit Card |
| `mostRecentCreditCardExpirationDate` | string | Expiration date of most recently used Credit Card |
| `appointmentIDs` | integer | An array of appointmentIDs associated with the customer |
| `ticketIDs` | integer | An array of ticketIDs associated with the customer |
| `paymentIDs` | integer | An array of paymentIDs associated with the customer |
| `subscriptions` | array | An optional array of all subscription objects. Looks for the includeSubscriptions=true parameter |
| `unitIDs` | integer | An array of unitIDs associated with the customer |
| `regionID` | integer | RegionID of the customer |
| `mapCode` | string | Mapcode of the customer |
| `mapPage` | string | Mappage of the customer |
| `specialScheduling` | string | Special Scheduling for the customer |
| `taxRate` | number | Tax rate of the customer |
| `stateTax` | number | State Tax rate of the customer |
| `cityTax` | number | City Tax rate of the customer |
| `countyTax` | number | County Tax rate of the customer |
| `districtTax` | number | District Tax rate of the customer |
| `districtTax1` | number | District 1 Tax rate of the customer |
| `districtTax2` | number | District 2 Tax rate of the customer |
| `districtTax3` | number | District 3 Tax rate of the customer |
| `districtTax4` | number | District 4 Tax rate of the customer |
| `districtTax5` | number | District 5 Tax rate of the customer |
| `customTax` | number | Custom Tax rate of the customer |
| `zipTaxID` | integer | Zip Tax ID of the customer |
| `smsReminders` | integer | Customer SMS reminder preference. |
| `phoneReminders` | integer | Customer phone reminder preference. |
| `emailReminders` | integer | Customer email reminder preference. |
| `customerSource` | string | Customer source. |
| `customerSourceID` | string | Customer sourceID. |
| `maxMonthlyCharge` | number | Max monthly charge for the customer |
| `county` | string | County name |
| `useStructures` | integer | Set as 1 if the customer is marked as a structure customer (a customer can be residential, multi-unit, or structure) |
| `isMultiUnit` | integer | Set as 1 if the customer is marked as a multi-unit customer (a customer can be residential, multi-unit, or structure) |
| `autoPayPaymentProfileID` | integer | ID of the autopay paymentProfile attached to the customer |
| `divisionID` | integer | divisionID of the customer |
| `subPropertyTypeID` | integer | Sub-Property Type ID of the customer |
| `agingDate` | string | Date the balance began. |
| `responsibleAgingDate` | string | Date the responsibleBalance began. |
| `salesmanAPay` | integer | Sales Rep APay customer flag |
| `purpleDragon` | integer | Purple Dragon customer flag |
| `termiteMonitoring` | integer | Switch Over customer flag |
| `pendingCancel` | integer | Pending cancel customer flag |

### `/customer/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  |  |
| `active` | integer |  | Whether or not this customer is 'Active': 1 or 'Inactive': 0. |
| `customerIDs` | integer |  | Unique Identifier |
| `dateAdded` | string |  | The date this customer was created or added. |
| `dateCancelled` | string |  | The date this customer was cancelled. |
| `dateUpdated` | string |  | Last date this customer record was updated. |
| `aPay` | integer |  | Auto Pay status: 0-Not on Auto Pay, 1-Auto Pay CC, 2-AutoPay ACH |
| `lname` | string |  | Customer's last name |
| `fname` | string |  | Customer's first name |
| `address` | string |  | Customer's address |
| `city` | string |  | Customer's city |
| `state` | string |  | Customer's state |
| `zip` | string |  | Customer's zip code |
| `dateUpdatedStart` | string |  |  |
| `dateUpdatedEnd` | string |  |  |
| `dateAddedStart` | string |  |  |
| `dateAddedEnd` | string |  |  |
| `masterAccount` | integer |  | CustomerID for the master account in the connected property |
| `balanceAge` | integer |  | Balance age in days. Available filters: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN |
| `agingDate` | string |  | Date the balance began. |
| `responsibleBalanceAge` | integer |  | Responsible balance age in days. Available filters: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN |
| `responsibleAgingDate` | string |  | Date the responsibleBalance began. |
| `phone` | integer |  | Match any 10-digit phone number (phone1, phone2, or additionalContact phone). Numbers only. |
| `phone1` | integer |  | Primary 10-digit phone number. Numbers only. |
| `phone2` | integer |  | Secondary 10-digit phone number. Numbers only. |
| `additionalPhone` | integer |  | Additional contact 10-digit phone number. Numbers only. |
| `billingPhone` | integer |  | Billing 10-digit phone number. Numbers only. |
| `companyName` | string |  | Company name of the customer. |
| `customerLink` | string |  | Search by the CustomerID specified on import/main. |
| `regionID` | integer |  | RegionID of the customer |
| `email` | string |  | Customer's email |
| `employeeID` | integer |  | EmployeeID who added the customer |
| `addedByID` | integer |  | EmployeeID who added the customer |
| `autoPayPaymentProfileID` | integer |  | ID of the autopay paymentProfile attached to the customer |
| `balance` | integer |  | Customer balance amount. Available filters: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN |
| `responsibleBalance` | integer |  | Responsible balance amount. Available filters: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property customerIDsNoDataExported will specify the items that are not included in the resolved customer array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `customerIDs` | array |  |

### `/customer/update`

Update customer details

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `billToAccountID` | integer |  |  |
| `fname` | string |  | First name |
| `lname` | string |  | Last name |
| `spouse` | string |  |  |
| `address` | string |  | Address string |
| `city` | string |  | City string |
| `state` | string |  | 2 letter state code |
| `zip` | string |  | Zip code |
| `mapCode` | string |  | Map Code |
| `squareFeet` | integer |  |  |
| `phone1` | string |  |  |
| `phone2` | string |  |  |
| `ext1` | string |  |  |
| `ext2` | string |  |  |
| `aPay` | integer |  | 0 - no APay, 1 - credit card apay, 2 ACH apay |
| `maxMonthlyCharge` | number |  |  |
| `paidInFull` | integer |  |  |
| `preferredPayment` | integer |  |  |
| `status` | integer |  |  |
| `lat` | number |  |  |
| `lng` | number |  |  |
| `employeeID` | integer |  |  |
| `notes` | string |  |  |
| `termiteMonitoring` | integer |  |  |
| `customerLink` | string |  | External ID, usually the primary key for your application |
| `taxRate` | number |  |  |
| `stateTax` | number |  |  |
| `cityTax` | number |  |  |
| `countyTax` | number |  |  |
| `districtTax` | number |  |  |
| `customTax` | number |  |  |
| `customCode` | string |  |  |
| `cityCode` | string |  |  |
| `countyCode` | string |  |  |
| `districtCode` | string |  |  |
| `zipCityCounty` | string |  |  |
| `smsReminders` | integer |  |  |
| `phoneReminders` | integer |  |  |
| `emailReminders` | integer |  |  |
| `preferredTech` | integer |  |  |
| `preferredBillingDate` | string |  |  |
| `countyID` | integer |  |  |
| `county` | string |  |  |
| `countryID` | string |  | 2-letter Country code e.g. US |
| `dateCancelled` | string |  |  |
| `specialScheduling` | string |  |  |
| `regionID` | integer |  |  |
| `salesmanAPay` | integer |  |  |
| `masterAccount` | integer |  | 0 if not part a master account or assigned to one; otherwise ID of the master account for this customer group |
| `billTo` | integer |  |  |
| `commercialAccount` | integer |  |  |
| `companyName` | string |  |  |
| `email` | string |  | email |
| `sourceID` | integer |  | sourceID for the customer (from Admin &gt; Preferences &gt; Customer References &gt; Customer Sources |
| `divisionID` | integer |  |  |
| `subPropertyTypeID` | integer |  |  |
| `billingFName` | string |  | Billing First Name |
| `billingLName` | string |  | Billing Last Name |
| `billingCountryID` | string |  | Billing CountryID |
| `billingAddress` | string |  | Billing Address |
| `billingCity` | string |  | Billing City |
| `billingState` | string |  | Billing State |
| `billingZip` | string |  | Billing Zip |
| `billingPhone` | string |  | Billing Phone |
| `billingEmail` | string |  | Billing Email |
| `billingCompanyName` | string |  | Billing billingCompanyName |
| `billingPhoneExt` | string |  | Billing billingPhoneExt |
| `billingPhone2` | string |  | Billing billingPhone2 |
| `billingPhone2Ext` | string |  | Billing billingPhone2Ext |
| `billingBusinessContactID` | string |  | Billing billingBusinessContactID |
| `purpleDragon` | integer |  | Sets the Purple Dragon customer flag checkbox |
| `customerID` | integer | Yes | Primary key to the customers table. |

### `/customer/updatePaymentProfile`

Update billing information of existing payment profile for a customer

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | Foreign Key to customers table |
| `billingName` | string |  | Billing name associated with payment profile |
| `billingAddress1` | string |  | Billing address associated with payment profile |
| `billingCity` | string |  | Billing city associated with payment profile |
| `billingState` | string |  | Billing state associated with payment profile |
| `billingZip` | integer |  | Billing zip code associated with payment profile |
| `billingCountryID` | string |  | Billing country code associated with payment profile |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Primary Key for paymentProfiles |
| `customerID` | integer | Customer associated with the payment profile |
| `profileID` | string | Credit card token associated with the payment processor |
| `paymentProfileID` | string | Credit card token id associated with the payment processor |
| `createdBy` | integer | EmployeeID who added the payment profile |
| `dateCreated` | string | Date created |
| `billingName` | string | Billing name |
| `billingAddress1` | string | Billing Address |
| `billingCity` | string | Billing city |
| `billingState` | string | Billing state |
| `billingZip` | integer | Billing zip |
| `billingCountryID` | string | Billing country |
| `lastFour` | string | Last four digits of card number |
| `expMonth` | string | Expiration month |
| `expYear` | string | Expiration year |

## customerFlag

### `/customerFlag/[id]`

Get customerFlag data for single ID -- please provide a specific record ID in the URL structure. This function has an addition standard filter for customerFlags that will help squelch unnecessary flags.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `limitCustomerFlags` | string |  | Standard search filter. E.G. "limitCustomerFlags": {"operator":"IN","value":["myFlag","yourflag"} |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `customerID` | integer | CustomerID |
| `flag` | string | Flag Code |
| `flagValue` | string | Flag Value |

### `/customerFlag/get`

Get Bulk data for customerFlag. Accepts an array of customerIDs. Returns a max of 1000 records. This function has an addition standard filter for customerFlags that will help squelch unnecessary flags.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerIDs` | array |  |  |
| `limitCustomerFlags` | string |  | Standard search filter. E.G. "limitCustomerFlags": {"operator":"IN","value":["myFlag","yourflag"} |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `customerID` | integer | CustomerID |
| `flag` | string | Flag Code |
| `flagValue` | string | Flag Value |

### `/customerFlag/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerIDs` | integer |  |  |
| `customerFlags` | string |  | Limit using user-defined generic flags or system flags: paidInFull, switchOver, purpleDragon, pendingCancellation, prefersPaper, collectonsStage |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property customerFlagIDsNoDataExported will specify the items that are not included in the resolved customerFlag array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `customerFlagIDs` | array |  |

### `/customerFlag/update`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | ID of customer the flags are to be set to |
| `paidInFull` | integer |  | Pass 1 to set Paid In Full flag, 0 to unset |
| `termiteMonitoring` | integer |  | Pass 1 to set Switch Over flag, 0 to unset |
| `purpleDragon` | integer |  | Pass 1 to set Purple Dragon flag, 0 to unset |
| `salesmanAPay` | integer |  | Pass 1 to set Sales Rep APay flag, 0 to unset |
| `prefersPaper` | integer |  | Pass 1 to set Prefers Paper flag, 0 to unset |
| `pendingCancel` | integer |  | Pass 1 to set Pending Cancel flag, 0 to unset |
| `pendingCancelReasonID` | integer |  | Cancellation Reason ID, required if setting the Pending Cancel flag |
| `pendingCancelNotes` | string |  | Pending Cancel Notes |

## customerSource

### `/customerSource/[id]`

Get customerSource data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `sourceID` | integer | Primary key |
| `officeID` | integer | Office ID region belongs to |
| `source` | string | Name of the source |
| `salesRoutesDefault` | integer | Set as 1 if this is a default source for the mobile app |
| `visible` | string | Visibility of the source |
| `dealsSource` | integer | set as 1 if source is deals |

### `/customerSource/get`

Get Bulk data for customerSource. Accepts an array of sourceIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `sourceIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `sourceID` | integer | Primary key |
| `officeID` | integer | Office ID region belongs to |
| `source` | string | Name of the source |
| `salesRoutesDefault` | integer | Set as 1 if this is a default source for the mobile app |
| `visible` | string | Visibility of the source |
| `dealsSource` | integer | set as 1 if source is deals |

### `/customerSource/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `sourceID` | integer |  | Primary key |
| `sourceIDs` | integer |  | Primary key alias |
| `customerSourceID` | integer |  | Primary key alias |
| `officeID` | integer |  | Office ID region belongs to |
| `officeIDs` | integer |  | Office ID region belongs to |
| `source` | string |  | Name of the source |
| `salesRoutesDefault` | integer |  | Set as 1 if this is a default source for the mobile app |
| `visible` | string |  | Visibility of the source |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property customerSourceIDsNoDataExported will specify the items that are not included in the resolved customerSource array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `customerSourceIDs` | array |  |

## diagram

### `/diagram/[id]`

Get diagram data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `diagram` | integer |  |
| `customerID` | integer |  |
| `description` | string | Diagram description. |
| `dateCreated` | string | The date the diagram was added. |
| `dateUpdated` | string | The date the diagram was updated. |
| `diagramObject` | array | The diagram object |
| `createdBy` | integer | The employeeID who created the diagram. |
| `diagramType` | string | Type of diagram ['WDO','PROPERTY ESTIMATION']. |
| `measurement` | integer |  |
| `measurementUnit` | string | ['SF','LF','QTY'] |

### `/diagram/get`

Get Bulk data for diagram. Accepts an array of diagramIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `diagramIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `diagram` | integer |  |
| `customerID` | integer |  |
| `description` | string | Diagram description. |
| `dateCreated` | string | The date the diagram was added. |
| `dateUpdated` | string | The date the diagram was updated. |
| `diagramObject` | array | The diagram object |
| `createdBy` | integer | The employeeID who created the diagram. |
| `diagramType` | string | Type of diagram ['WDO','PROPERTY ESTIMATION']. |
| `measurement` | integer |  |
| `measurementUnit` | string | ['SF','LF','QTY'] |

### `/diagram/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `diagramIDs` | integer |  |  |
| `officeIDs` | integer |  |  |
| `officeID` | integer |  |  |
| `customerID` | integer |  |  |
| `dateUpdated` | string |  | The date the diagram was updated. |
| `diagramType` | string |  | Type of diagram ['WDO','PROPERTY ESTIMATION']. |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property diagramIDsNoDataExported will specify the items that are not included in the resolved diagram array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `diagramIDs` | array |  |

### `/diagram/update`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `diagramID` | integer | Yes | ID of diagram being updated |
| `measurement` | integer |  | e.g. linear footage, square footage, or quantity |
| `measurementUnit` | string |  | ['SF','LF','QTY'] |

## disbursement

### `/disbursement/[id]`

Get disbursement data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `gatewayDisbursementID` | integer |  |
| `dateCreated` | string |  |
| `dateUpdated` | string |  |
| `amount` | number |  |

### `/disbursement/get`

Get Bulk data for disbursement. Accepts an array of gatewayDisbursementIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `gatewayDisbursementIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `gatewayDisbursementID` | integer |  |
| `dateCreated` | string |  |
| `dateUpdated` | string |  |
| `amount` | number |  |

### `/disbursement/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `gatewayDisbursementIDs` | integer |  | Primary key |
| `gatewayDisbursementID` | integer |  | Primary key alias |
| `dateCreated` | string |  | Date created |
| `dateUpdated` | string |  | Date last updated |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property disbursementIDsNoDataExported will specify the items that are not included in the resolved disbursement array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `disbursementIDs` | array |  |

## disbursementItem

### `/disbursementItem/[id]`

Get disbursementItem data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `gatewayDisbursementEntryID` | integer |  |
| `gatewayDisbursementID` | integer |  |
| `dateCreated` | string |  |
| `dateUpdated` | string |  |
| `billingFirstName` | string |  |
| `billingLastName` | string |  |
| `amount` | number |  |
| `actualAmount` | number |  |
| `description` | string |  |
| `isFee` | integer |  |
| `gatewayEventID` | integer |  |
| `gatewayEventType` | string |  |
| `gatewayEventFeeType` | string |  |
| `gatewayEventDescription` | string |  |

### `/disbursementItem/get`

Get Bulk data for disbursementItem. Accepts an array of gatewayDisbursementEntryIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `gatewayDisbursementEntryIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `gatewayDisbursementEntryID` | integer |  |
| `gatewayDisbursementID` | integer |  |
| `dateCreated` | string |  |
| `dateUpdated` | string |  |
| `billingFirstName` | string |  |
| `billingLastName` | string |  |
| `amount` | number |  |
| `actualAmount` | number |  |
| `description` | string |  |
| `isFee` | integer |  |
| `gatewayEventID` | integer |  |
| `gatewayEventType` | string |  |
| `gatewayEventFeeType` | string |  |
| `gatewayEventDescription` | string |  |

### `/disbursementItem/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `gatewayDisbursementEntryIDs` | integer |  | Primary key |
| `gatewayDisbursementEntryID` | integer |  | Primary key alias |
| `gatewayDisbursementID` | integer |  | Key to gatewayDisbursements table |
| `dateCreated` | string |  | Date created |
| `dateUpdated` | string |  | Date last updated |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property disbursementItemIDsNoDataExported will specify the items that are not included in the resolved disbursementItem array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `disbursementItemIDs` | array |  |

## document

### `/document/[id]`

Get document data for single ID -- please provide a specific record ID in the URL structure.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `includeDocumentLink` | integer |  | Send as 1 to retrieve a link to the document on AWS with a 15 day TTL. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `uploadID` | integer | Unique Identifier |
| `officeID` | integer |  |
| `customerID` | integer | Customer ID |
| `dateAdded` | string | date this upload was added |
| `addedBy` | integer | Employee ID that added this |
| `description` | string | Description for this upload |
| `showCustomer` | integer | Set to 1 if this upload is visible to the customer |
| `showTech` | integer | Set to 1 if this upload is visible to the technician through the mobile app. |
| `appointmentID` | integer | Appointment ID this upload relates to. |
| `prefix` | integer | origination database prefix |
| `dateUpdated` | string | date document was last updated |

### `/document/create`

Upload file as multipart/form-data with parameter name uploadFile

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | Customer ID this document relates to. |
| `description` | integer | Yes | Description for this document |
| `appointmentID` | integer |  | Appointment ID this document relates to |
| `showCustomer` | bool |  | If set true this document will be accessable to the customer it is attached to. |
| `showTech` | bool |  | If set true this document will be accessable to technicians servicing this customer. |

### `/document/createEncoded`

Allows file upload using a Base64 representation submitted through POST, GET or query string parameters

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | Customer ID this document relates to. |
| `description` | integer | Yes | Description for this document |
| `appointmentID` | integer |  | Appointment ID this document relates to |
| `showCustomer` | bool |  | If set true this document will be accessable to the customer it is attached to. |
| `showTech` | bool |  | If set true this document will be accessable to technicians servicing this customer. |
| `encodedFile` | string | Yes | Base64 representation of a file. |
| `filename` | string | Yes | Name of encoded file |

### `/document/delete`

Delete a customer upload

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | CustomerID to delete from. |
| `uploadID` | integer | Yes | UploadID to delete. |

### `/document/get`

Get Bulk data for document. Accepts an array of uploadIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `uploadIDs` | array |  |  |
| `includeDocumentLink` | int |  | Send as 1 to retrieve a link to the document on AWS with a 15 day TTL. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `uploadID` | integer | Unique Identifier |
| `officeID` | integer |  |
| `customerID` | integer | Customer ID |
| `dateAdded` | string | date this upload was added |
| `addedBy` | integer | Employee ID that added this |
| `description` | string | Description for this upload |
| `showCustomer` | integer | Set to 1 if this upload is visible to the customer |
| `showTech` | integer | Set to 1 if this upload is visible to the technician through the mobile app. |
| `appointmentID` | integer | Appointment ID this upload relates to. |
| `prefix` | integer | origination database prefix |
| `dateUpdated` | string | date document was last updated |

### `/document/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `uploadIDs` | integer |  |  |
| `officeIDs` | integer |  |  |
| `officeID` | integer |  |  |
| `customerIDs` | integer |  | customerID associated with the document |
| `customerID` | integer |  | customerID associated with the document |
| `appointmentIDs` | integer |  | appointmentID associated with the document |
| `appointmentID` | integer |  | appointmentID associated with the document |
| `formTemplateID` | integer |  | formTemplateID for pulling specific form types |
| `dateAdded` | string |  |  |
| `dateUpdated` | string |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property documentIDsNoDataExported will specify the items that are not included in the resolved document array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `documentIDs` | array |  |

### `/document/update`

Update the attributes of a customer upload.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | Customer ID this document relates to. |
| `description` | integer | Yes | Description for this document |
| `appointmentID` | integer |  | Appointment ID this document relates to |
| `showCustomer` | bool |  | If set true this document will be accessable to the customer it is attached to. |
| `showTech` | bool |  | If set true this document will be accessable to technicians servicing this customer. |
| `uploadID` | integer | Yes | ID of upload to update |

## door

### `/door/[id]`

Get door data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `doorID` | integer | doorID |
| `lat` | number | lat |
| `lng` | number | lng |
| `timeCreated` | string | timeCreated |
| `employeeID` | integer | employeeID |
| `name` | string | name |
| `address` | string | address |
| `city` | string | city |
| `state` | string | state |
| `zip` | string | zip |
| `phone` | string | phone |
| `status` | integer | status |
| `notes` | string | notes |
| `email` | string | email |
| `callbackTime` | string | callbackTime |
| `knockCounter` | integer | knockCounter |
| `countryID` | string | countryID |

### `/door/get`

Get Bulk data for door. Accepts an array of doorIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `doorIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `doorID` | integer | doorID |
| `lat` | number | lat |
| `lng` | number | lng |
| `timeCreated` | string | timeCreated |
| `employeeID` | integer | employeeID |
| `name` | string | name |
| `address` | string | address |
| `city` | string | city |
| `state` | string | state |
| `zip` | string | zip |
| `phone` | string | phone |
| `status` | integer | status |
| `notes` | string | notes |
| `email` | string | email |
| `callbackTime` | string | callbackTime |
| `knockCounter` | integer | knockCounter |
| `countryID` | string | countryID |

### `/door/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `doorID` | integer |  | doorID |
| `lat` | number |  | lat |
| `lng` | number |  | lng |
| `employeeID` | integer |  | employeeID |
| `searchDistance` | integer |  | Size in miles of the search grid when using centerLat, centerLng filters. |
| `centerLat` | number |  | Latitude of search radius center. Default distance 50 miles; override with searchDistance parameter. centerLng must also be set to use this filter |
| `centerLng` | number |  | Longitude of search radius center. Default distance 50 miles; override with searchDistance parameter. centerLat must also be set to use this filter |
| `dateCreated` | string |  | alias of timeCreated |
| `timeCreated` | string |  | timeCreated |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property doorIDsNoDataExported will specify the items that are not included in the resolved door array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `doorIDs` | array |  |

## employee

### `/employee/[id]`

Get employee data for single ID -- please provide a specific record ID in the URL structure.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `includeCommissionData` | integer |  | Send as 1 to retrieve additional commission data for the employee. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `employeeID` | integer | Unique Identifier |
| `officeID` | integer | Office ID this employee belongs to |
| `active` | integer | 0: Inactive account, 1: Active account |
| `fname` | string | Employee's first name |
| `lname` | string | Employee's last name |
| `initials` | string | Employee's name initials -- user defined in case of duplicate's |
| `nickname` | string | Employee's nickname |
| `type` | integer | Employee type. 0: Office Staff, 1: Technician, 2: Sales Rep |
| `phone` | string | Phone number |
| `email` | integer | Unique Identifier |
| `username` | string | Employees username |
| `experience` | integer | Years of experience of the rep -- mostly to distinguish rookies from veterans |
| `skillIDs` | integer | IDs of skills associated with the technician |
| `skillDescriptions` | integer | Descriptions of skills associated with the technician |
| `pic` | string | URL of the employee image |
| `linkedEmployeeIDs` | integer | The master account if this employee is linked to other accounts in other offices. For reporting purposes their stats are typically combined. |
| `employeeLink` | string | Employee's Link |
| `licenseNumber` | string | License Number |
| `supervisorID` | integer | EmployeeID of supervisor |
| `roamingRep` | integer | The master employeeID if this employee is linked to other accounts in other offices. Set as 0 if the account cannot roam. |
| `regionalManagerOfficeIDs` | integer | List of officeIDs this employee is a regional manager of |
| `lastLogin` | string | date of last login |
| `teamIDs` | integer | The master employeeID if this employee is linked to other accounts in other offices. Set as 0 if the account cannot roam. |
| `primaryTeam` | integer | The master employeeID if this employee is linked to other accounts in other offices. Set as 0 if the account cannot roam. |
| `accessControlProfileID` | integer | Access Control Profile ID |
| `startAddress` | string | Employee's starting address on routes |
| `startCity` | string | Employee's starting city on routes |
| `startState` | string | Employee's starting state on routes |
| `startZip` | string | Employee's starting zip on routes |
| `startLat` | number | Employee's starting lat on routes |
| `startLng` | number | Employee's starting lng on routes |
| `endAddress` | string | Employee's ending address on routes |
| `endCity` | string | Employee's ending city on routes |
| `endState` | string | Employee's ending state on routes |
| `endZip` | string | Employee's ending zip on routes |
| `endLat` | number | Employee's ending lat on routes |
| `endLng` | number | Employee's ending lng on routes |
| `dateUpdated` | string | Employee dateUpdated |

### `/employee/create`

Create a new employee.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `type` | integer |  | 0: office staff, 1: technician, 2: salesman |
| `fname` | string | Yes | Employee first name. |
| `lname` | string | Yes | Employee last name. |
| `phone` | string |  | Employee phone. |
| `email` | string |  | Employee email. |
| `username` | string |  | Login username, required for a roaming rep. |
| `password` | string |  | Login password, required for a roaming rep. |
| `roamingRep` | integer |  | EmployeeID of the master account. If a non-master account is selected, that account's master rep will be used instead. |
| `roamingMaster` | integer |  | Set as 1 to specify that the user is a roaming master account. This setting will override roamingRep. |
| `regionalManagers` | array |  | Array of officeIDs this employee is a manager of. Replaces existing regionalManager offices. |
| `employeeLink` | string |  | Employee's Link |
| `licenseNumber` | string |  | Employee's License Number |
| `accessControlProfileID` | integer |  | Access Control Profile ID defined in preferences. 0 represents a custom profile. |
| `accessControl` | string |  | Send as form-data array or as a JSON encoded string |
| `active` | integer |  | Send as 0 to set the employee as inactive, send as 1 to set the employee to active. Default state is active. |
| `primaryTeam` | integer |  | Set the primary team for the employee. If the employee is not on this team it will be placed on that team during this operation. |
| `supervisorID` | integer |  | employeeID of the supervisor for this employee. |
| `experience` | integer |  | Integer (max 2 digits) |
| `startAddress` | string |  | Employee's starting address on routes |
| `startCity` | string |  | Employee's starting city on routes |
| `startState` | string |  | Employee's starting state on routes |
| `startZip` | string |  | Employee's starting zip on routes |
| `endAddress` | string |  | Employee's ending address on routes |
| `endCity` | string |  | Employee's ending city on routes |
| `endState` | string |  | Employee's ending state on routes |
| `endZip` | string |  | Employee's ending zip on routes |
| `employeeSkills` | integer |  | Array of skillIDs |
| `pic` | string |  | base64encoded image |

### `/employee/dealias`

Find the employeeIDs associated with this employeeID or link

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `employeeID` | integer |  | Primary key of the employee |
| `employeeLink` | integer |  | External key of the employee |
| `active` | integer |  | active property of the employee 0: inactive 1: active |
| `useBothKeys` | integer |  | Send as 1 to join on both roamingRep and employeeLink relationship |

### `/employee/get`

Get Bulk data for employee. Accepts an array of employeeIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `employeeIDs` | array |  |  |
| `includeCommissionData` | int |  | Send as 1 to retrieve additional commission data for the employee. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `employeeID` | integer | Unique Identifier |
| `officeID` | integer | Office ID this employee belongs to |
| `active` | integer | 0: Inactive account, 1: Active account |
| `fname` | string | Employee's first name |
| `lname` | string | Employee's last name |
| `initials` | string | Employee's name initials -- user defined in case of duplicate's |
| `nickname` | string | Employee's nickname |
| `type` | integer | Employee type. 0: Office Staff, 1: Technician, 2: Sales Rep |
| `phone` | string | Phone number |
| `email` | integer | Unique Identifier |
| `username` | string | Employees username |
| `experience` | integer | Years of experience of the rep -- mostly to distinguish rookies from veterans |
| `skillIDs` | integer | IDs of skills associated with the technician |
| `skillDescriptions` | integer | Descriptions of skills associated with the technician |
| `pic` | string | URL of the employee image |
| `linkedEmployeeIDs` | integer | The master account if this employee is linked to other accounts in other offices. For reporting purposes their stats are typically combined. |
| `employeeLink` | string | Employee's Link |
| `licenseNumber` | string | License Number |
| `supervisorID` | integer | EmployeeID of supervisor |
| `roamingRep` | integer | The master employeeID if this employee is linked to other accounts in other offices. Set as 0 if the account cannot roam. |
| `regionalManagerOfficeIDs` | integer | List of officeIDs this employee is a regional manager of |
| `lastLogin` | string | date of last login |
| `teamIDs` | integer | The master employeeID if this employee is linked to other accounts in other offices. Set as 0 if the account cannot roam. |
| `primaryTeam` | integer | The master employeeID if this employee is linked to other accounts in other offices. Set as 0 if the account cannot roam. |
| `accessControlProfileID` | integer | Access Control Profile ID |
| `startAddress` | string | Employee's starting address on routes |
| `startCity` | string | Employee's starting city on routes |
| `startState` | string | Employee's starting state on routes |
| `startZip` | string | Employee's starting zip on routes |
| `startLat` | number | Employee's starting lat on routes |
| `startLng` | number | Employee's starting lng on routes |
| `endAddress` | string | Employee's ending address on routes |
| `endCity` | string | Employee's ending city on routes |
| `endState` | string | Employee's ending state on routes |
| `endZip` | string | Employee's ending zip on routes |
| `endLat` | number | Employee's ending lat on routes |
| `endLng` | number | Employee's ending lng on routes |
| `dateUpdated` | string | Employee dateUpdated |

### `/employee/reset`

Send a reset password email given an employeeID or username. Password can be set to a specific value through employee/update endpoint

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `employeeID` | integer |  | EmployeeID |
| `username` | string |  | login username |
| `sendEmail` | integer |  | Send recovery email, default behaviour if not send flags are included. |
| `sendSMS` | integer |  | Send recovery sms |

### `/employee/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  |  |
| `active` | integer |  | 'Active': 1 or 'Inactive': 0 |
| `employeeIDs` | integer |  | Unique Identifier |
| `employeeID` | integer |  | Unique Identifier |
| `yearsExperience` | integer |  | How many years this employee has in experience. Typically used for sales reps to distinguish between rookies and seasoned. |
| `lname` | string |  | Employee's last name |
| `fname` | string |  | Employee's first name |
| `type` | integer |  | Employee type. 0: Office Staff, 1: Technician, 2: Sales Rep |
| `employeeLink` | string |  | Employee's Link |
| `roamingRep` | integer |  | EmployeeID of the master account if this account has access to multiple offices. |
| `teamID` | integer |  | teamID of the employee |
| `primaryTeam` | integer |  | primary teamID of the employee |
| `phone` | string |  | phone number |
| `email` | string |  | email |
| `accessControlProfileID` | integer |  | Access Control Profile ID |
| `dateUpdated` | string |  | Date employee was last updated |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property employeeIDsNoDataExported will specify the items that are not included in the resolved employee array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `employeeIDs` | array |  |

### `/employee/update`

Update an employee.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `type` | integer |  | 0: office staff, 1: technician, 2: salesman |
| `fname` | string |  | Employee first name. |
| `lname` | string |  | Employee last name. |
| `phone` | string |  | Employee phone. |
| `email` | string |  | Employee email. |
| `username` | string |  | Login username, required for a roaming rep. |
| `password` | string |  | Login password, required for a roaming rep. |
| `roamingRep` | integer |  | EmployeeID of the master account. If a non-master account is selected, that account's master rep will be used instead. |
| `roamingMaster` | integer |  | Set as 1 to specify that the user is a roaming master account. This setting will override roamingRep. |
| `regionalManagers` | array |  | Array of officeIDs this employee is a manager of. Replaces existing regionalManager offices. |
| `employeeLink` | string |  | Employee's Link |
| `licenseNumber` | string |  | Employee's License Number |
| `accessControlProfileID` | integer |  | Access Control Profile ID defined in preferences. 0 represents a custom profile. |
| `accessControl` | string |  | Send as form-data array or as a JSON encoded string |
| `active` | integer |  | Send as 0 to set the employee as inactive, send as 1 to set the employee to active. Default state is active. |
| `primaryTeam` | integer |  | Set the primary team for the employee. If the employee is not on this team it will be placed on that team during this operation. |
| `supervisorID` | integer |  | employeeID of the supervisor for this employee. |
| `experience` | integer |  | Integer (max 2 digits) |
| `startAddress` | string |  | Employee's starting address on routes |
| `startCity` | string |  | Employee's starting city on routes |
| `startState` | string |  | Employee's starting state on routes |
| `startZip` | string |  | Employee's starting zip on routes |
| `endAddress` | string |  | Employee's ending address on routes |
| `endCity` | string |  | Employee's ending city on routes |
| `endState` | string |  | Employee's ending state on routes |
| `endZip` | string |  | Employee's ending zip on routes |
| `employeeSkills` | integer |  | Array of skillIDs |
| `pic` | string |  | base64encoded image |
| `employeeID` | integer | Yes | Primary key to the employee table. |
| `removeVisualGrouping` | integer |  | Send as 1 to remove visual grouping assignments for the employee. |

## employeeLocation

### `/employeeLocation/[id]`

Get employeeLocation data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `locationID` | integer | Primary key. |
| `employeeID` | integer | EmployeeID the location is assigned to |
| `officeID` | integer |  |
| `time` | integer | time the location check-in took place |
| `latitude` | number | latitude of the check-in |
| `longitude` | number | longitude of the check-in |

### `/employeeLocation/get`

Get Bulk data for employeeLocation. Accepts an array of locationIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `locationIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `locationID` | integer | Primary key. |
| `employeeID` | integer | EmployeeID the location is assigned to |
| `officeID` | integer |  |
| `time` | integer | time the location check-in took place |
| `latitude` | number | latitude of the check-in |
| `longitude` | number | longitude of the check-in |

### `/employeeLocation/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `locationIDs` | integer |  | Primary key. |
| `employeeID` | integer |  | EmployeeID the location is assigned to |
| `officeID` | integer |  |  |
| `time` | integer |  | time the location check-in took place |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property employeeLocationIDsNoDataExported will specify the items that are not included in the resolved employeeLocation array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `employeeLocationIDs` | array |  |

## form

### `/form/[id]`

Get form data for single ID -- please provide a specific record ID in the URL structure.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `includeDocumentLink` | integer |  | Send as 1 to retrieve a link to the document on AWS with a 15 day TTL. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `formID` | integer |  |
| `customerID` | integer |  |
| `dateSigned` | string | The date the form was signed. |
| `dateAdded` | string | The date the form was added. |
| `unitID` | integer | The unitID associated with the form. |
| `employeeID` | integer | The employeeID who created the form. |
| `documentState` | integer | State of the document e.g. WIP, COMPLETED |
| `formTemplateID` | integer | ID of the template this form was created from |
| `formDescription` | string | String description of the template the form was created from. |

### `/form/get`

Get Bulk data for form. Accepts an array of contractIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `contractIDs` | array |  |  |
| `includeDocumentLink` | int |  | Send as 1 to retrieve a link to the document on AWS with a 15 day TTL. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `formID` | integer |  |
| `customerID` | integer |  |
| `dateSigned` | string | The date the form was signed. |
| `dateAdded` | string | The date the form was added. |
| `unitID` | integer | The unitID associated with the form. |
| `employeeID` | integer | The employeeID who created the form. |
| `documentState` | integer | State of the document e.g. WIP, COMPLETED |
| `formTemplateID` | integer | ID of the template this form was created from |
| `formDescription` | string | String description of the template the form was created from. |

### `/form/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `formIDs` | integer |  |  |
| `officeIDs` | integer |  |  |
| `customerID` | integer |  |  |
| `dateSigned` | string |  | The date the form was signed. |
| `dateAdded` | string |  | The date the form was added. |
| `unitID` | integer |  | The unitID associated with the form. |
| `employeeID` | integer |  | The employeeID who created the form. |
| `documentState` | integer |  | State of the document e.g. WIP, COMPLETED |
| `formTemplateID` | integer |  | ID of the template this form was created from |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property formIDsNoDataExported will specify the items that are not included in the resolved form array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `formIDs` | array |  |

## genericFlag

### `/genericFlag/[id]`

Get genericFlag data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `genericFlagID` | integer | Unique Identifier |
| `officeIDs` | integer | Alias for officeID. |
| `officeID` | integer |  |
| `code` | string |  |
| `description` | string |  |
| `status` | integer |  |
| `type` | string |  |
| `dateCreated` | string |  |
| `dateUpdated` | string |  |

### `/genericFlag/get`

Get Bulk data for genericFlag. Accepts an array of genericFlagIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `genericFlagIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `genericFlagID` | integer | Unique Identifier |
| `officeIDs` | integer | Alias for officeID. |
| `officeID` | integer |  |
| `code` | string |  |
| `description` | string |  |
| `status` | integer |  |
| `type` | string |  |
| `dateCreated` | string |  |
| `dateUpdated` | string |  |

### `/genericFlag/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `genericFlagIDs` | integer |  |  |
| `officeIDs` | integer |  |  |
| `code` | string |  |  |
| `description` | string |  |  |
| `status` | integer |  |  |
| `type` | string |  |  |
| `dateCreated` | string |  |  |
| `dateUpdated` | string |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property genericFlagIDsNoDataExported will specify the items that are not included in the resolved genericFlag array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `genericFlagIDs` | array |  |

## genericFlagAssignment

### `/genericFlagAssignment/[id]`

Get genericFlagAssignment data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `genericFlagAssignmentID` | integer | Unique Identifier |
| `genericFlagID` | integer |  |
| `entityID` | integer | CUST, EQAS, SUBS, or APPT ID |
| `type` | string | Type of flag assignment |
| `dateCreated` | string | Date generic flag assignment was created |
| `dateUpdated` | string | Date generic flag assignment was last updated |

### `/genericFlagAssignment/create`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `genericFlagID` | integer | Yes | Foreign key to flag |
| `entityID` | integer | Yes | ID of entity being assigned the flag |
| `type` | string | Yes | Type of flag. |

### `/genericFlagAssignment/delete`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `genericFlagAssignmentID` | integer | Yes |  |

### `/genericFlagAssignment/get`

Get Bulk data for genericFlagAssignment. Accepts an array of genericFlagAssignmentIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `genericFlagAssignmentIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `genericFlagAssignmentID` | integer | Unique Identifier |
| `genericFlagID` | integer |  |
| `entityID` | integer | CUST, EQAS, SUBS, or APPT ID |
| `type` | string | Type of flag assignment |
| `dateCreated` | string | Date generic flag assignment was created |
| `dateUpdated` | string | Date generic flag assignment was last updated |

### `/genericFlagAssignment/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `genericFlagAssignmentIDs` | integer |  |  |
| `genericFlagIDs` | integer |  |  |
| `entityIDs` | integer |  |  |
| `type` | string |  |  |
| `officeIDs` | integer |  |  |
| `officeID` | integer |  |  |
| `dateCreated` | string |  |  |
| `dateUpdated` | string |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property genericFlagAssignmentIDsNoDataExported will specify the items that are not included in the resolved genericFlagAssignment array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `genericFlagAssignmentIDs` | array |  |

### `/genericFlagAssignment/update`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `genericFlagAssignmentID` | integer | Yes | ID of genericFlagAssignment being updated |
| `genericFlagID` | integer | Yes | Foreign key to flag |

## glAccount

### `/glAccount/[id]`

Get glAccount data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `glAccountID` | integer |  |
| `glNumber` | integer |  |
| `officeID` | integer |  |
| `title` | string |  |
| `description` | string |  |
| `visible` | integer |  |

### `/glAccount/get`

Get Bulk data for glAccount. Accepts an array of glAccountIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `glAccountIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `glAccountID` | integer |  |
| `glNumber` | integer |  |
| `officeID` | integer |  |
| `title` | string |  |
| `description` | string |  |
| `visible` | integer |  |

### `/glAccount/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `glAccountIDs` | integer |  |  |
| `glAccountID` | integer |  |  |
| `glNumber` | integer |  |  |
| `officeIDs` | integer |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property glAccountIDsNoDataExported will specify the items that are not included in the resolved glAccount array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `glAccountIDs` | array |  |

## group

### `/group/[id]`

Get group data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `groupID` | integer |  |
| `templateID` | integer |  |
| `dateUpdated` | string |  |

### `/group/create`

create a group

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `date` | string |  | Date to create for |
| `templateID` | integer |  | templateID from office software |
| `title` | string |  | Title string (30 character limit) |

### `/group/get`

Get Bulk data for group. Accepts an array of groupIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `groupIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `groupID` | integer |  |
| `templateID` | integer |  |
| `dateUpdated` | string |  |

### `/group/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `groupIDs` | integer |  | Primary key |
| `groupID` | integer |  | Primary key alias |
| `officeIDs` | integer |  | Office ID region belongs to |
| `date` | string |  | Date the group was last updated |
| `dateUpdated` | string |  | Date the group was last updated |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property groupIDsNoDataExported will specify the items that are not included in the resolved group array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `groupIDs` | array |  |

### `/group/update`

Update group details

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `title` | string |  | Title string (30 character limit) |
| `groupID` | integer | Yes | Primary key to the group table. |

## insect

### `/insect/[id]`

Get insect data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `insectID` | integer |  |
| `officeID` | integer |  |
| `name` | string |  |
| `family` | string |  |
| `threat` | string |  |
| `fact` | string |  |
| `about1` | string |  |
| `about2` | string |  |
| `aboutBlurb` | string |  |
| `funFacts` | string |  |
| `factBlurb` | string |  |
| `image` | string |  |
| `visible` | integer |  |
| `system` | integer |  |

### `/insect/get`

Get Bulk data for insect. Accepts an array of insectIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `insectIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `insectID` | integer |  |
| `officeID` | integer |  |
| `name` | string |  |
| `family` | string |  |
| `threat` | string |  |
| `fact` | string |  |
| `about1` | string |  |
| `about2` | string |  |
| `aboutBlurb` | string |  |
| `funFacts` | string |  |
| `factBlurb` | string |  |
| `image` | string |  |
| `visible` | integer |  |
| `system` | integer |  |

### `/insect/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `insectIDs` | integer |  | Primary key |
| `insectID` | integer |  | Primary key alias |
| `officeIDs` | integer |  | OfficeID insect belongs to |
| `visible` | integer |  | 1 if insect is visible, 0 otherwise |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property insectIDsNoDataExported will specify the items that are not included in the resolved insect array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `insectIDs` | array |  |

## knock

### `/knock/[id]`

Get knock data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `knockID` | integer | Primary Key |
| `type` | integer | 0 - competitor, 1 - objection |
| `doorID` | integer |  |
| `serviceID` | integer |  |
| `employeeID` | integer |  |
| `dateAdded` | string |  |
| `dateUpdated` | string |  |

### `/knock/get`

Get Bulk data for knock. Accepts an array of knockIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `knockIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `knockID` | integer | Primary Key |
| `type` | integer | 0 - competitor, 1 - objection |
| `doorID` | integer |  |
| `serviceID` | integer |  |
| `employeeID` | integer |  |
| `dateAdded` | string |  |
| `dateUpdated` | string |  |

### `/knock/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `knockID` | integer |  | Primary Key |
| `doorID` | integer |  | Door the knock is associated with |
| `dateAdded` | string |  | Date the knock was created |
| `dateUpdated` | string |  | Date the knock was last updated |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property knockIDsNoDataExported will specify the items that are not included in the resolved knock array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `knockIDs` | array |  |

## location

### `/location/[id]`

Get location data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `locationID` | integer |  |
| `officeID` | integer |  |
| `name` | string |  |
| `visible` | integer |  |
| `system` | integer |  |

### `/location/get`

Get Bulk data for location. Accepts an array of locationIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `locationIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `locationID` | integer |  |
| `officeID` | integer |  |
| `name` | string |  |
| `visible` | integer |  |
| `system` | integer |  |

### `/location/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `locationIDs` | integer |  | Primary key |
| `locationID` | integer |  | Primary key alias |
| `officeIDs` | integer |  | OfficeID insect belongs to |
| `visible` | integer |  | visibility of the location |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property locationIDsNoDataExported will specify the items that are not included in the resolved location array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `locationIDs` | array |  |

## note

### `/note/[id]`

Get note data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `noteID` | integer | Unique Identifier |
| `officeIDs` | integer |  |
| `customerID` | integer | Customer ID |
| `customerName` | string | Customer Name |
| `customerSpouse` | string | Spouse Field |
| `companyName` | string | Company Name |
| `employeeID` | integer | Employee ID that created the note |
| `employeeName` | string | Employee name that created the note |
| `date` | string | Date note was created |
| `showCustomer` | integer | Whether or not this shows up on the invoices or customer portal so the customer can see it |
| `showTech` | integer | Whether or not this shows up in the tech app |
| `cancellationReasonID` | integer | If this is part of a cancellation, the ID cancellation reason selected |
| `cancellationReason` | string | If this is part of a cancellation, the description of the cancellation reason selected |
| `typeID` | integer | The ID for the contact type |
| `type` | integer | Description of note type |
| `contactTypeCategories` | integer | Categories associated with the note type |
| `notes` | string | The actual note content |
| `referenceID` | integer | If this is in regards to a subscription cancellation, the subscription ID. Can also be a re-instatement subscription ID, etc... depending on the note type |
| `dateAdded` | string | Date this note was created |
| `dateUpdated` | string | Date the note was last updated. |

### `/note/create`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | Foreign key to customers table. |
| `date` | string | Yes | Date of the note (mutable) |
| `employeeID` | integer |  | Foreign key to employees table. |
| `contactType` | integer | Yes | Foreign key to contactTypes table found via Admin &gt; Preferences &gt; Note Types |
| `notes` | string | Yes | Arbitrary comment string |
| `sendTo` | string |  | System field? |
| `showOnInvoice` | boolean | Yes | 1 to display this note on invoices, 0 to hide |
| `cancellationReason` | integer |  | Foreign key to cancellationReasons table found via Admin &gt; Preferences &gt; Cancellation Reasons |
| `showTech` | boolean |  | Note will be displayed to Tech on the mobile app |
| `showCustomer` | boolean |  | Note will be displayed to the customer in some service notifications |
| `referenceID` | integer |  | Subscription ID this note relates to. |

### `/note/delete`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | Foreign key to customers table. |
| `contactID` | integer | Yes | Foreign key to customerContacts table. |

### `/note/get`

Get Bulk data for note. Accepts an array of noteIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `noteIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `noteID` | integer | Unique Identifier |
| `officeIDs` | integer |  |
| `customerID` | integer | Customer ID |
| `customerName` | string | Customer Name |
| `customerSpouse` | string | Spouse Field |
| `companyName` | string | Company Name |
| `employeeID` | integer | Employee ID that created the note |
| `employeeName` | string | Employee name that created the note |
| `date` | string | Date note was created |
| `showCustomer` | integer | Whether or not this shows up on the invoices or customer portal so the customer can see it |
| `showTech` | integer | Whether or not this shows up in the tech app |
| `cancellationReasonID` | integer | If this is part of a cancellation, the ID cancellation reason selected |
| `cancellationReason` | string | If this is part of a cancellation, the description of the cancellation reason selected |
| `typeID` | integer | The ID for the contact type |
| `type` | integer | Description of note type |
| `contactTypeCategories` | integer | Categories associated with the note type |
| `notes` | string | The actual note content |
| `referenceID` | integer | If this is in regards to a subscription cancellation, the subscription ID. Can also be a re-instatement subscription ID, etc... depending on the note type |
| `dateAdded` | string | Date this note was created |
| `dateUpdated` | string | Date the note was last updated. |

### `/note/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `noteIDs` | integer |  |  |
| `officeIDs` | integer |  |  |
| `customerIDs` | integer |  |  |
| `date` | string |  |  |
| `dateAdded` | string |  |  |
| `typeIDs` | integer |  |  |
| `employeeIDs` | integer |  |  |
| `content` | string |  |  |
| `cancellationReason` | integer |  |  |
| `referenceID` | integer |  |  |
| `dateUpdated` | string |  | Last date this note record was updated. |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property noteIDsNoDataExported will specify the items that are not included in the resolved note array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `noteIDs` | array |  |

### `/note/update`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | Foreign key to customers table. |
| `date` | string | Yes | Date of the note (mutable) |
| `employeeID` | integer |  | Foreign key to employees table. |
| `contactType` | integer | Yes | Foreign key to contactTypes table found via Admin &gt; Preferences &gt; Note Types |
| `notes` | string |  | Arbitrary comment string |
| `sendTo` | string |  | System field? |
| `showOnInvoice` | boolean | Yes | 1 to display this note on invoices, 0 to hide |
| `cancellationReason` | integer |  | Foreign key to cancellationReasons table found via Admin &gt; Preferences &gt; Cancellation Reasons |
| `showTech` | boolean |  | Note will be displayed to Tech on the mobile app |
| `showCustomer` | boolean |  | Note will be displayed to the customer in some service notifications |
| `referenceID` | integer |  | Subscription ID this note relates to. |
| `contactID` | integer | Yes | Primary key to the notes table. |

## office

### `/office/[id]`

Get office data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `officeID` | integer | Primary Key |
| `officeName` | string | Description of the product |
| `companyID` | integer | companyID of the office |
| `licenseNumber` | integer | licenseNumber of the office |
| `contactNumber` | string | phone number of the office |
| `contactEmail` | string | email of the office |
| `website` | string | website of the office |
| `timeZone` | string | time zone of the office |
| `address` | string | physical location of the office |
| `city` | string | city of the office |
| `state` | string | state of the office |
| `zip` | string | zip code of the office |
| `invoiceAddress` | string | invoice address of the office |
| `invoiceCity` | string | invoice city of the office |
| `invoiceState` | string | invoice state of the office |
| `invoiceZip` | string | invoice zip code of the office |
| `cautionStatements` | string | Admin &gt; Preferences &gt; Customer Preferences &gt; Customer Communication &gt; Service Notification Notes / Caution Statements |

### `/office/get`

Get Bulk data for office. Accepts an array of officeIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `officeID` | integer | Primary Key |
| `officeName` | string | Description of the product |
| `companyID` | integer | companyID of the office |
| `licenseNumber` | integer | licenseNumber of the office |
| `contactNumber` | string | phone number of the office |
| `contactEmail` | string | email of the office |
| `website` | string | website of the office |
| `timeZone` | string | time zone of the office |
| `address` | string | physical location of the office |
| `city` | string | city of the office |
| `state` | string | state of the office |
| `zip` | string | zip code of the office |
| `invoiceAddress` | string | invoice address of the office |
| `invoiceCity` | string | invoice city of the office |
| `invoiceState` | string | invoice state of the office |
| `invoiceZip` | string | invoice zip code of the office |
| `cautionStatements` | string | Admin &gt; Preferences &gt; Customer Preferences &gt; Customer Communication &gt; Service Notification Notes / Caution Statements |

### `/office/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeID` | integer |  | Primary Key |
| `companyID` | integer |  | companyID of the office |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property officeIDsNoDataExported will specify the items that are not included in the resolved office array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `officeIDs` | array |  |

## payment

### `/payment/[id]`

Get payment data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `paymentID` | integer | Payment Unique Identifier |
| `officeID` | integer | Office Unique Identifier |
| `customerID` | integer | Customer Unique Identifier |
| `date` | string | Payment date |
| `paymentMethod` | integer | Payment Method 0-Coupon, 1-Cash, 2-Check, 3-Credit Card, 4 ACH, 5-Credit Memo |
| `amount` | number | Payment amount |
| `appliedAmount` | number | Amount of the payment that was used |
| `unassignedAmount` | number | Amount of the payment that was not used yet |
| `status` | integer | Status of the payment (0-Unsuccessful, 1-Successful, 2-Refunded) |
| `invoiceIDs` | integer | Tickets that this payment was applied for |
| `paymentApplications` | string | Array of payment applications associated with the ticket |
| `employeeID` | integer | EmployeeID who recorded the payment |
| `officePayment` | integer | officePayment flag |
| `collectionPayment` | integer | collectionPayment flag |
| `writeOff` | integer | writeOff flag |
| `creditMemo` | integer | 1 if Credit Memo, 0 otherwise |
| `paymentOrigin` | integer | 0 = Office Software, 1 = Customer Portal , 2 = Sales App , 3 = Technician App, 4 = ARM (collections) |
| `originalPaymentID` | integer | Original paymentID (for refunds) |
| `lastFour` | string | Last 4 digits of credit card if applicable |
| `notes` | string | Notes from payment processor |
| `batchOpened` | string | time payment batch was opened |
| `batchClosed` | string | time payment batch was closed |
| `paymentSource` | string | possible values: 'API','Batch Process','Collections','Customer Portal','Manual','Trigger','Import' |
| `dateUpdated` | string | Date of last update |
| `transactionID` | integer | transactionID |

### `/payment/create`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `doCharge` | integer | Yes | 1 - payment will be processed via FieldRoutes. 0 - payment is inserted as a completed payment without charging. |
| `paymentMethod` | integer | Yes | Payment Method 0-Coupon, 1-Cash, 2-Check, 3-Credit Card, 4 ACH |
| `customerID` | integer | Yes | customerID to associate the payment with |
| `amount` | number | Yes | Amount this payment was for |
| `employeeID` | integer |  | Employee to associate with the payment |
| `notes` | integer |  | Description for this payment |
| `ticketID` | integer |  | Limit payment to this ticket |
| `subscriptionID` | integer |  | Limit payment to this subscription |
| `paymentProfileID` | integer |  | Limit use specified paymentProfileID for payment (must be owned by customer) |
| `status` | integer |  | Only applies with doCharge=0. Set as 0 to create a failed payment record, 1 to create a success |

### `/payment/createRefund`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `paymentID` | integer | Yes | paymentID to refund |
| `amount` | number |  | Amount this payment was for |
| `skipProcessing` | integer |  | Send as 1 to create a payment record without processing the refund |

### `/payment/get`

Get Bulk data for payment. Accepts an array of paymentIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `paymentIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `paymentID` | integer | Payment Unique Identifier |
| `officeID` | integer | Office Unique Identifier |
| `customerID` | integer | Customer Unique Identifier |
| `date` | string | Payment date |
| `paymentMethod` | integer | Payment Method 0-Coupon, 1-Cash, 2-Check, 3-Credit Card, 4 ACH, 5-Credit Memo |
| `amount` | number | Payment amount |
| `appliedAmount` | number | Amount of the payment that was used |
| `unassignedAmount` | number | Amount of the payment that was not used yet |
| `status` | integer | Status of the payment (0-Unsuccessful, 1-Successful, 2-Refunded) |
| `invoiceIDs` | integer | Tickets that this payment was applied for |
| `paymentApplications` | string | Array of payment applications associated with the ticket |
| `employeeID` | integer | EmployeeID who recorded the payment |
| `officePayment` | integer | officePayment flag |
| `collectionPayment` | integer | collectionPayment flag |
| `writeOff` | integer | writeOff flag |
| `creditMemo` | integer | 1 if Credit Memo, 0 otherwise |
| `paymentOrigin` | integer | 0 = Office Software, 1 = Customer Portal , 2 = Sales App , 3 = Technician App, 4 = ARM (collections) |
| `originalPaymentID` | integer | Original paymentID (for refunds) |
| `lastFour` | string | Last 4 digits of credit card if applicable |
| `notes` | string | Notes from payment processor |
| `batchOpened` | string | time payment batch was opened |
| `batchClosed` | string | time payment batch was closed |
| `paymentSource` | string | possible values: 'API','Batch Process','Collections','Customer Portal','Manual','Trigger','Import' |
| `dateUpdated` | string | Date of last update |
| `transactionID` | integer | transactionID |

### `/payment/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  | Office Unique Identifier |
| `paymentIDs` | integer |  | Payment Unique Identifier |
| `customerIDs` | integer |  | Customer Unique Identifier |
| `amount` | number |  | Amount of Payment |
| `date` | string |  | Payment date |
| `paymentMethod` | integer |  | Payment Method 0-Coupon, 1-Cash, 2-Check, 3-Credit Card, 4 ACH |
| `status` | integer |  | Status of the payment (0-Unsuccessful, 1-Successful, 2-Refunded) |
| `dateApplied` | string |  | Date the payment was applied |
| `employeeID` | integer |  | employeeID that recorded the payment |
| `originalPaymentID` | integer |  | Original paymentID (for refunds) |
| `dateUpdated` | string |  | Date the payment was last updated |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property paymentIDsNoDataExported will specify the items that are not included in the resolved payment array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `paymentIDs` | array |  |

## paymentProfile

### `/paymentProfile/[id]`

Get paymentProfile data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `paymentProfileID` | integer | Primary key for the paymentProfile |
| `customerID` | integer | customer that the paymentProfile belongs to. |
| `officeID` | integer | OfficeID of the customer that the paymentProfile belongs to. |
| `createdBy` | integer | employeeID who created the paymentProfile |
| `description` | string | Payment profile description |
| `dateCreated` | string | date the payment profile was created |
| `dateUpdated` | string | date the payment profile was last updated |
| `status` | integer | -1 = soft deleted, 0 = empty, 1 = valid, 2 = invalid, 3 = expired, 4 = last transaction failed |
| `statusNotes` | string |  |
| `billingName` | string | Name associated with the CC/Bank account |
| `billingAddress1` | string | Address associated with the CC/Bank account |
| `billingAddress2` | string |  |
| `billingCountryID` | integer | Country associated with the CC/Bank account |
| `billingCity` | string | City associated with the CC/Bank account |
| `billingState` | string | State associated with the CC/Bank account |
| `billingZip` | string | Zip associated with the CC/Bank account |
| `billingPhone` | string | Phone associated with the CC/Bank account |
| `billingEmail` | string | email associated with the CC/Bank account |
| `paymentMethod` | integer | 1=cc, 2 = ach |
| `gateway` | string | ACH or CC gateway E.G. authorize, nmi, brain, element |
| `merchantID` | string | Credit card only |
| `merchantToken` | string | Credit card only |
| `lastFour` | string | Credit card only last four digits of the card |
| `expMonth` | string | Credit card only - Expiration month |
| `expYear` | string | Credit card only - Expiration year |
| `cardType` | string | Credit card only e.g. Visa, Mastercard |
| `bankName` | string | ACH only |
| `accountNumber` | string | ACH only - masked account number |
| `routingNumber` | string | ACH only - routing number |
| `checkType` | integer | ACH only - 0=checking, 1=savings |
| `accountType` | integer | ACH only - 0=personal, 1=business |
| `failedAttempts` | integer |  |
| `sentFailureDate` | string |  |
| `lastAttemptDate` | string |  |
| `paymentHoldDate` | string |  |
| `retryPoints` | integer |  |
| `initialTransactionID` | string |  |
| `lastDeclineType` | string |  |

### `/paymentProfile/create`

Create a payment profile using a CreditCardToken and CreditCardTokenID from braintree/element. This will become the active payment profile for cc/ach.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | Foreign Key to customers table |
| `billingName` | string |  | Billing name associated with payment profile |
| `billingAddress1` | string |  | Billing address associated with payment profile |
| `billingAddress2` | string |  | Billing address associated with payment profile |
| `billingCity` | string |  | Billing city associated with payment profile |
| `billingState` | string |  | Billing state associated with payment profile |
| `billingZip` | integer |  | Billing zip code associated with payment profile |
| `billingCountryID` | string |  | Billing country code associated with payment profile |
| `paymentMethod` | integer | Yes | 1=cc, 2 = ach |
| `gateway` | string |  | ACH or CC gateway E.G. authorize, nmi, brain, element, payrix |
| `bankName` | string |  | ACH only |
| `accountNumber` | string |  | ACH only - check account number |
| `routingNumber` | string |  | ACH only - routing number |
| `checkType` | integer |  | ACH only - 0=checking, 1=savings |
| `accountType` | integer |  | ACH only - 0=personal, 1=business |
| `merchantID` | string |  | Required for braintree and element. Not required for nmi |
| `merchantToken` | string |  | Required for braintree and nmi. Not required for element |
| `autopay` | integer |  | Send as 1 to set the owning customer to autopay using this profile |
| `paymentHoldDate` | string |  | Hold date for the payment profile |

### `/paymentProfile/delete`

Delete a payment profile.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `paymentProfileID` | integer | Yes | Foreign Key to paymentProfile table |

### `/paymentProfile/get`

Get Bulk data for paymentProfile. Accepts an array of paymentProfileIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `paymentProfileIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `paymentProfileID` | integer | Primary key for the paymentProfile |
| `customerID` | integer | customer that the paymentProfile belongs to. |
| `officeID` | integer | OfficeID of the customer that the paymentProfile belongs to. |
| `createdBy` | integer | employeeID who created the paymentProfile |
| `description` | string | Payment profile description |
| `dateCreated` | string | date the payment profile was created |
| `dateUpdated` | string | date the payment profile was last updated |
| `status` | integer | -1 = soft deleted, 0 = empty, 1 = valid, 2 = invalid, 3 = expired, 4 = last transaction failed |
| `statusNotes` | string |  |
| `billingName` | string | Name associated with the CC/Bank account |
| `billingAddress1` | string | Address associated with the CC/Bank account |
| `billingAddress2` | string |  |
| `billingCountryID` | integer | Country associated with the CC/Bank account |
| `billingCity` | string | City associated with the CC/Bank account |
| `billingState` | string | State associated with the CC/Bank account |
| `billingZip` | string | Zip associated with the CC/Bank account |
| `billingPhone` | string | Phone associated with the CC/Bank account |
| `billingEmail` | string | email associated with the CC/Bank account |
| `paymentMethod` | integer | 1=cc, 2 = ach |
| `gateway` | string | ACH or CC gateway E.G. authorize, nmi, brain, element |
| `merchantID` | string | Credit card only |
| `merchantToken` | string | Credit card only |
| `lastFour` | string | Credit card only last four digits of the card |
| `expMonth` | string | Credit card only - Expiration month |
| `expYear` | string | Credit card only - Expiration year |
| `cardType` | string | Credit card only e.g. Visa, Mastercard |
| `bankName` | string | ACH only |
| `accountNumber` | string | ACH only - masked account number |
| `routingNumber` | string | ACH only - routing number |
| `checkType` | integer | ACH only - 0=checking, 1=savings |
| `accountType` | integer | ACH only - 0=personal, 1=business |
| `failedAttempts` | integer |  |
| `sentFailureDate` | string |  |
| `lastAttemptDate` | string |  |
| `paymentHoldDate` | string |  |
| `retryPoints` | integer |  |
| `initialTransactionID` | string |  |
| `lastDeclineType` | string |  |

### `/paymentProfile/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `paymentProfileIDs` | integer |  | Primary key for the paymentProfile |
| `customerIDs` | integer |  | customer that the paymentProfile belongs to. |
| `officeIDs` | integer |  | OfficeID of the customer that the paymentProfile belongs to. |
| `dateCreated` | string |  | date the payment profile was created |
| `dateUpdated` | string |  | date the payment profile was last updated |
| `status` | integer |  | -1 = soft deleted, 0 = empty, 1 = valid, 2 = invalid, 3 = expired, 4 = last transaction failed |
| `billingState` | string |  | State associated with the CC/Bank account |
| `billingZip` | string |  | Zip associated with the CC/Bank account |
| `paymentMethod` | integer |  | 1=cc, 2 = ach |
| `gateway` | string |  | ACH or CC gateway E.G. authorize, nmi, brain, element |
| `cardType` | string |  | Credit card only e.g. Visa, Mastercard |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property paymentProfileIDsNoDataExported will specify the items that are not included in the resolved paymentProfile array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `paymentProfileIDs` | array |  |

### `/paymentProfile/update`

Create a payment profile using a CreditCardToken and CreditCardTokenID from braintree/element. This will become the active payment profile for cc/ach.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `paymentProfileID` | integer | Yes | Foreign Key to paymentProfile table |
| `billingFName` | string |  | Billing name associated with payment profile |
| `billingLName` | string |  | Billing name associated with payment profile |
| `billingAddress1` | string |  | Billing address associated with payment profile |
| `billingAddress2` | string |  | Billing address associated with payment profile |
| `billingCity` | string |  | Billing city associated with payment profile |
| `billingState` | string |  | Billing state associated with payment profile |
| `billingZip` | integer |  | Billing zip code associated with payment profile |
| `billingCountryID` | string |  | Billing country code associated with payment profile |
| `expMonth` | integer |  | 2 digit month |
| `expYear` | integer |  | 2 digit year (e.g. 21 for 2021) |
| `autopay` | integer |  | Send as 1 to set the owning customer to autopay using this profile |
| `paymentHoldDate` | string |  | Hold date for the payment profile |

## product

### `/product/[id]`

Get product data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `productID` | integer | Primary Key |
| `officeID` | integer | OfficeID of the product; -1 is available to all offices. |
| `description` | string | Description of the product |
| `glAccountID` | string | glAccountID of the product |
| `amount` | number | Cost of each product |
| `taxable` | integer | Set as 1 if the product is taxable |
| `code` | string | Product Code (up to 10 characters) |
| `category` | string | Product category |
| `visible` | integer | Whether or not the product is visible in lists when creating a new addon |
| `salesVisible` | integer | Whether or not the product is visible for sales reps on mobile app |
| `recurring` | integer | 0 means it shows up only on the service it was added to, 1 means it shows up on every service |

### `/product/create`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeID` | integer |  | OfficeID of the product; -1 is available to all offices. |
| `description` | string | Yes | Description of the product |
| `amount` | number | Yes | Cost of each product |
| `taxable` | integer | Yes | Set as 1 if the product is taxable |
| `code` | string | Yes | Product Code (up to 25 characters) |
| `category` | string | Yes | Product category |
| `visible` | integer | Yes | Whether or not the product is visible in lists when creating a new addon |
| `salesVisible` | integer | Yes | Whether or not the product is visible for sales reps on mobile app |
| `recurring` | integer | Yes | 0 means it shows up only on the service it was added to, 1 means it shows up on every service |

### `/product/get`

Get Bulk data for product. Accepts an array of productIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `productIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `productID` | integer | Primary Key |
| `officeID` | integer | OfficeID of the product; -1 is available to all offices. |
| `description` | string | Description of the product |
| `glAccountID` | string | glAccountID of the product |
| `amount` | number | Cost of each product |
| `taxable` | integer | Set as 1 if the product is taxable |
| `code` | string | Product Code (up to 10 characters) |
| `category` | string | Product category |
| `visible` | integer | Whether or not the product is visible in lists when creating a new addon |
| `salesVisible` | integer | Whether or not the product is visible for sales reps on mobile app |
| `recurring` | integer | 0 means it shows up only on the service it was added to, 1 means it shows up on every service |

### `/product/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `productID` | integer |  | Primary Key |
| `officeIDs` | integer |  | OfficeID of the product; -1 is available to all offices. |
| `code` | string |  | Product Code (up to 25 characters) |
| `category` | string |  | Product category |
| `visible` | integer |  | Whether or not the product is visible in lists when creating a new addon |
| `salesVisible` | integer |  | Whether or not the product is visible for sales reps on mobile app |
| `description` | string |  | Description of the product |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property productIDsNoDataExported will specify the items that are not included in the resolved product array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `productIDs` | array |  |

### `/product/update`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeID` | integer |  | OfficeID of the product; -1 is available to all offices. |
| `description` | string |  | Description of the product |
| `amount` | number |  | Cost of each product |
| `taxable` | integer |  | Set as 1 if the product is taxable |
| `code` | string |  | Product Code (up to 25 characters) |
| `category` | string |  | Product category |
| `visible` | integer |  | Whether or not the product is visible in lists when creating a new addon |
| `salesVisible` | integer |  | Whether or not the product is visible for sales reps on mobile app |
| `recurring` | integer |  | 0 means it shows up only on the service it was added to, 1 means it shows up on every service |
| `productID` | integer | Yes | Primary key to the notes table. |

## region

### `/region/[id]`

Get region data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `regionIDs` | integer | Primary key |
| `officeIDs` | integer | Office ID region belongs to |
| `description` | string | Description of the region |
| `created` | string | Time the region was created |
| `deleted` | string | Time the region was deleted |
| `points` | string | latitude and longitude bounding points separated by colons |
| `type` | string |  |
| `active` | string | Active status for the region. |

### `/region/get`

Get Bulk data for region. Accepts an array of regionIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `regionIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `regionIDs` | integer | Primary key |
| `officeIDs` | integer | Office ID region belongs to |
| `description` | string | Description of the region |
| `created` | string | Time the region was created |
| `deleted` | string | Time the region was deleted |
| `points` | string | latitude and longitude bounding points separated by colons |
| `type` | string |  |
| `active` | string | Active status for the region. |

### `/region/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `regionIDs` | integer |  | Primary key |
| `officeIDs` | integer |  | Office ID region belongs to |
| `description` | string |  | Description of the region |
| `created` | string |  | Time the region was created |
| `deleted` | string |  | Time the region was deleted |
| `type` | string |  |  |
| `active` | string |  | Active status for the region. |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property regionIDsNoDataExported will specify the items that are not included in the resolved region array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `regionIDs` | array |  |

## reserviceReason

### `/reserviceReason/[id]`

Get reserviceReason data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `reserviceReasonID` | integer |  |
| `officeID` | integer |  |
| `visible` | integer | Used by the FieldRoutes application to hide/show reasons from staff |
| `reason` | string | Description of the appointment reschedule reason |

### `/reserviceReason/get`

Get Bulk data for reserviceReason. Accepts an array of reserviceReasonIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `reserviceReasonIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `reserviceReasonID` | integer |  |
| `officeID` | integer |  |
| `visible` | integer | Used by the FieldRoutes application to hide/show reasons from staff |
| `reason` | string | Description of the appointment reschedule reason |

### `/reserviceReason/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `reserviceReasonIDs` | integer |  |  |
| `reserviceReasonID` | integer |  |  |
| `officeIDs` | integer |  |  |
| `officeID` | integer |  |  |
| `visible` | integer |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property reserviceReasonIDsNoDataExported will specify the items that are not included in the resolved reserviceReason array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `reserviceReasonIDs` | array |  |

## review

### `/review/[id]`

Get review data for single ID -- please provide a specific record ID in the URL structure. This function has an additional non-standard filter "includeCustomers". If true, the Customer object will be included in the results.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `includeCustomers` | integer |  | Set true to include the Customer object in review results.. |
| `pruneSensitiveInfo` | integer |  | Set true to return review text that has been pruned of credit card, phone, and email information. |
| `pruneProfanity` | integer |  | Set true to return review text that has been pruned of common profanity. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `feedbackID` | integer |  |
| `officeIDs` | integer |  |
| `customerID` | integer |  |
| `appointmentID` | integer |  |
| `date` | string |  |
| `starRating` | integer |  |
| `feedback` | string |  |
| `favorable` | integer |  |
| `Customer` | object | The customer object associated with the review (only if 'includeCustomers' parameter is sent) |

### `/review/create`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `appointmentID` | integer | Yes | Foreign key to appointments table |
| `customerID` | integer | Yes | Foreign key to customers table |
| `starRating` | integer | Yes | Integer 1-5 as star rating. |
| `feedback` | string | Yes | Customer Feedback String |
| `time` | string | Yes | Time the feedback was given |

### `/review/delete`

Delete a customerFeedback item.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `feedbackID` | integer | Yes | Primary key of the customerFeedback table |

### `/review/get`

Get Bulk data for review. Accepts an array of feedbackIDs. Returns a max of 1000 records. This function has an additional non-standard filter "includeCustomers". If true, the Customer object will be included in the results.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `feedbackIDs` | array |  |  |
| `includeCustomers` | int |  | Set true to include the Customer object in review results.. |
| `pruneSensitiveInfo` | int |  | Set true to return review text that has been pruned of credit card, phone, and email information. |
| `pruneProfanity` | int |  | Set true to return review text that has been pruned of common profanity. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `feedbackID` | integer |  |
| `officeIDs` | integer |  |
| `customerID` | integer |  |
| `appointmentID` | integer |  |
| `date` | string |  |
| `starRating` | integer |  |
| `feedback` | string |  |
| `favorable` | integer |  |
| `Customer` | object | The customer object associated with the review (only if 'includeCustomers' parameter is sent) |

### `/review/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `feedbackIDs` | integer |  |  |
| `officeIDs` | integer |  |  |
| `customerIDs` | integer |  |  |
| `appointmentIDs` | integer |  |  |
| `date` | string |  |  |
| `starRating` | integer |  |  |
| `favorable` | integer |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property reviewIDsNoDataExported will specify the items that are not included in the resolved review array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `reviewIDs` | array |  |

### `/review/summary`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `zipCodes` | array |  | Zip codes to summarize |
| `cities` | array |  | Cities to summarize |
| `officeIDs` | array |  | Foreign key to offices table. Default: officeID associated with the API key sent. |
| `customerIDs` | array |  | Foreign key to customers table |
| `startTime` | string |  | Left bound for feedback time |
| `endTime` | string |  | Right bound for feedback time |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `stars` | object | Object filled with stars E.G. {1:100, 2:101, 3:200, 4:300, 5:400} |
| `zips` | object | Object filled with zip information E.G. {75252: {num:700, average: 2.5, zip: 75252} } |
| `cities` | object | Object filled with city information E.G. {Dallas: {num:700, average: 2.5, city: "Dallas"} } |
| `average` | number | Average star rating for the given parameters |

### `/review/update`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `appointmentID` | integer |  | Foreign key to appointments table |
| `customerID` | integer |  | Foreign key to customers table |
| `starRating` | integer |  | Integer 1-5 as star rating. |
| `feedback` | string |  | Customer Feedback String |
| `time` | string |  | Time the feedback was given |
| `feedbackID` | integer | Yes | Primary key to the customerFeedback table. |

## route

### `/route/[id]`

Get route data for single ID -- please provide a specific record ID in the URL structure. This function has additional non-standard filters Latitude and Longitude for distance calculation. If these are not specified the office location will be used.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `latitude` | number |  | Latitude for distance calculcations. If not specified, the office longitude will be used |
| `longitude` | number |  | Longitude for distance calculcations. If not specified, the office longitude will be used |
| `maxDistance` | integer |  | Maximum number of miles from the route average to return. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `routeID` | integer | Unique Identifier |
| `title` | integer |  |
| `templateID` | integer |  |
| `dateAdded` | string |  |
| `addedBy` | integer | ID of employee who added this route |
| `officeID` | integer |  |
| `groupID` | integer |  |
| `groupTitle` | integer |  |
| `date` | string | date of this route |
| `dayNotes` | integer |  |
| `dayAlert` | integer |  |
| `dayID` | integer |  |
| `additionalTechs` | string | EmployeeIDs of additional techs on the appointment. Comma separated. |
| `assignedTech` | integer | EmployeeID assigned to route. 0 represents no tech assigned. |
| `apiCanSchedule` | integer | Set as 1 when the API has access to schedule to this route. |
| `scheduleTeams` | string | Array of teams that can schedule to the route. |
| `scheduleTypes` | string | Array of systemTypes that can schedule to the route. {0 office staff, 1 techs, 2 sales, 3 api} |
| `averageLatitude` | number | Average latitude of customers scheduled to this route (or null) |
| `averageLongitude` | number | Average longitude of customers scheduled to this route (or null) |
| `averageDistance` | number | Average distance of customers scheduled to this route to the given latitude and longitude parameters (or the office latitude and longitude if not sent) |
| `dateUpdated` | string | date this route was last updated |
| `distanceScore` | integer | Route distance score (snapshot) |

### `/route/create`

create a route

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `date` | string |  | DayID to create for |
| `templateID` | integer |  | templateID from office software |
| `assignedTech` | integer |  | employeeID |
| `autoCreateGroup` | integer |  | set as 1 if the group should be auto-created with the template title, set as 0 to reject on missing group. Default 1 |
| `groupID` | integer |  | groupID for manually assigning to a group |

### `/route/delete`

Delete a route.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `routeID` | integer | Yes | Foreign Key to routes table |

### `/route/get`

Get Bulk data for route. Accepts an array of routeIDs. Returns a max of 1000 records. This function has additional non-standard filters Latitude and Longitude for distance calculation. If these are not specified the office location will be used.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `routeIDs` | array |  |  |
| `latitude` | number |  | Latitude for distance calculcations. If not specified, the office longitude will be used |
| `longitude` | number |  | Longitude for distance calculcations. If not specified, the office longitude will be used |
| `maxDistance` | int |  | Maximum number of miles from the route average to return. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `routeID` | integer | Unique Identifier |
| `title` | integer |  |
| `templateID` | integer |  |
| `dateAdded` | string |  |
| `addedBy` | integer | ID of employee who added this route |
| `officeID` | integer |  |
| `groupID` | integer |  |
| `groupTitle` | integer |  |
| `date` | string | date of this route |
| `dayNotes` | integer |  |
| `dayAlert` | integer |  |
| `dayID` | integer |  |
| `additionalTechs` | string | EmployeeIDs of additional techs on the appointment. Comma separated. |
| `assignedTech` | integer | EmployeeID assigned to route. 0 represents no tech assigned. |
| `apiCanSchedule` | integer | Set as 1 when the API has access to schedule to this route. |
| `scheduleTeams` | string | Array of teams that can schedule to the route. |
| `scheduleTypes` | string | Array of systemTypes that can schedule to the route. {0 office staff, 1 techs, 2 sales, 3 api} |
| `averageLatitude` | number | Average latitude of customers scheduled to this route (or null) |
| `averageLongitude` | number | Average longitude of customers scheduled to this route (or null) |
| `averageDistance` | number | Average distance of customers scheduled to this route to the given latitude and longitude parameters (or the office latitude and longitude if not sent) |
| `dateUpdated` | string | date this route was last updated |
| `distanceScore` | integer | Route distance score (snapshot) |

### `/route/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array. If the includeData flag is set the additional parameters from getData (latitude, longitude) can be used.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  |  |
| `routeIDs` | integer |  |  |
| `date` | string |  |  |
| `dateStart` | string |  |  |
| `dateEnd` | string |  |  |
| `assignedTech` | integer |  |  |
| `apiCanSchedule` | boolean |  | Send as 1 to retrieve only routes that the API can schedule for. |
| `lastUpdated` | string |  |  |
| `dateUpdated` | string |  |  |
| `employeeTeams` | integer |  | Send with an employeeID to limit routes to those that the employee's team is assigned to via route can schedule settings. |
| `excludeGlobalSalesTeam` | integer |  | send as 1 to ignore routes available to the global sales team |
| `groupTitle` | string |  | Title of the group associated with the route |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property routeIDsNoDataExported will specify the items that are not included in the resolved route array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `routeIDs` | array |  |

### `/route/update`

Update route details

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `date` | string |  | DayID to create for |
| `assignedTech` | integer |  | employeeID |
| `autoCreateGroup` | integer |  | set as 1 if the group should be auto-created with the template title, set as 0 to reject on missing group. Default 1 |
| `groupID` | integer |  | groupID for manually assigning to a group |
| `routeID` | integer | Yes | Primary key to the route table. |

## routeTemplate

### `/routeTemplate/[id]`

Get routeTemplate data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `templateID` | integer |  |
| `officeID` | integer |  |
| `templateName` | string |  |
| `officeDefault` | string |  |
| `visible` | string |  |

### `/routeTemplate/get`

Get Bulk data for routeTemplate. Accepts an array of templateIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `templateIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `templateID` | integer |  |
| `officeID` | integer |  |
| `templateName` | string |  |
| `officeDefault` | string |  |
| `visible` | string |  |

### `/routeTemplate/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `templateIDs` | integer |  | Primary key |
| `templateID` | integer |  | Primary key alias |
| `officeIDs` | integer |  | Office ID route template belongs to |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property routeTemplateIDsNoDataExported will specify the items that are not included in the resolved routeTemplate array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `routeTemplateIDs` | array |  |

## servicePlan

### `/servicePlan/[id]`

Get servicePlan data for single ID -- please provide a specific record ID in the URL structure.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `includeCancellationReason` | integer |  | Send as 1 to retrieve an array of cancellationNotes associated with the subscription. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `subscriptionID` | integer | Unique ID |
| `customerID` | integer | Customer ID which this subscription belongs to |
| `billToAccountID` | integer | Billing Account which this subscription belongs to |
| `officeID` | integer | Office ID which this subscription belongs to |
| `dateAdded` | string | Date this subscription was added / created. Sold date. |
| `contractAdded` | string | Date the last contract was added / created. |
| `active` | integer | 0: frozen, 1: active and being placed in the job pool. |
| `activeText` | integer | Friendly text version of active |
| `initialQuote` | number | The retail quoted price for the initial service on this subscription. |
| `initialDiscount` | number | The discount to be applied to the initial service |
| `initialServiceTotal` | number | The net amount of initialQuote-initialDiscount. DOES NOT INCLUDE add-ons |
| `yifDiscount` | number | The discount provided if paying for a year in advance |
| `recurringCharge` | number | A shortcut for the subtotal of the recurring ticket |
| `contractValue` | number | Calculated as the initial total + the number of recurring services*recurringCharge. There are some tweaks available for different companies / preferences, particularly when dealing with recurring billing. |
| `annualRecurringValue` | number | Calculated as the recurringCharge * the number of services/year. |
| `billingFrequency` | integer | How often this subscription gets their invoice generated -- can be seperate from when their service takes place. 0 / -1 represents getting billed after each service. |
| `frequency` | integer | The frequency that the services get scheduled. -1 represents One-Time, 0 represents 'as needed'. Greater than 0 represents the frequency in days. If it is divisible by 30, it is converted to months -- so 90 would represent 3 months and not necessarily 90 days. |
| `followupService` | integer | How many days after the initial service to schedule the first recurring service. |
| `agreementLength` | number | Agreement Length |
| `nextService` | string | When the next service is due. |
| `lastCompleted` | string | When the last service was completed |
| `serviceID` | integer | The service type ID for the regular recurring services |
| `serviceType` | string | Friendly description of the serviceID |
| `soldBy` | integer | The employee ID who gets credit for this sale. Defaults to the user who added the subscription |
| `soldBy2` | integer | Additional employeeID that gets credit for this sale |
| `soldBy3` | integer | Additional employeeID that gets credit for this sale |
| `preferredTech` | integer | preferred tech ID |
| `addedBy` | integer | The employee ID that added the subscription |
| `initialAppointmentID` | integer | The initial service appointment ID |
| `initialStatus` | integer | A shortcut for the status of the initial appointment |
| `initialStatusText` | string | Friendly text version of the initialStatus |
| `dateCancelled` | string | The date the subscription was cancelled if any. |
| `dateUpdated` | string | The date the subscription was last updated. |
| `cxlNotes` | string | The notes associated with cancelling this appointment. Group_Concat'ed in case of multiple cancellations |
| `subscriptionLink` | string | Subscription Link |
| `poNumber` | string | Subscription poNumber |
| `appointmentIDs` | integer | Every appointment attached to this subscription |
| `completedAppointmentIDs` | integer | Every completed appointment attached to this subscription |
| `initialAppointment` | object | The initial appointment object if includeInitialAppointments = true |
| `recurringTicket` | object | The recurring ticket template associated with this subscription |
| `addOns` | string | An array of Add-On objects associated with the INITIAL appointment. |
| `leadID` | integer | Primary key for lead |
| `leadDateAdded` | string | Time that this lead was created |
| `leadUpdated` | string | Time that this lead was last updated |
| `leadAddedBy` | integer | employeeID that created this lead |
| `leadSourceID` | integer | Lead Source ID |
| `leadSource` | string | Lead Source Description |
| `leadStatus` | integer | Lead Status |
| `leadStatusText` | string | Lead Status Text |
| `leadStageID` | integer | Lead Stage ID |
| `leadStage` | string | Lead Stage Description |
| `leadAssignedTo` | integer | EmployeeID to whom the lead is assigned |
| `leadDateAssigned` | string | Time the lead was assigned |
| `leadValue` | number | Value of the lead |
| `leadDateClosed` | string | Time the lead was closed |
| `leadLostReason` | string | Lead Lost Reason ID |
| `leadLostReasonText` | string | Lead Lost Reason |
| `sourceID` | integer | Subscription Source ID |
| `source` | string | Subscription Source Description |
| `annualRecurringServices` | integer | Services per year without counting initial |
| `unitIDs` | integer | An array of unit IDs available for this subscription (for multi unit customers) - defaults to all unless specific units have been selected |
| `regionID` | integer | RegionID of the subscription |
| `initialInvoice` | string | When the initial invoice should get generated. INITIAL_COMPLETION = when the initial service is completed. SIGNED_AGREEMENT = when the agreement is signed. INITIAL_BILLING_DATE = on a specified billing date. |
| `initialBillingDate` | string | The date to generate initial invoice when initialInvoice = INITIAL_BILLING_DATE |
| `renewalFrequency` | integer | How often a subscription is due for renewal. |
| `renewalDate` | string | Next renewal date |
| `customDate` | string | custom next appointment date |
| `sentriconConnected` | integer | Set as 1 if the subscription is connected to sentricon |
| `sentriconSiteID` | string | Sentricon Site ID or null if not connected to Sentricon |
| `seasonalStart` | string | Date the season starts or 0000-00-00 if it is not a seasonal subscription |
| `seasonalEnd` | string | Date the season ends or 0000-00-00 if it is not a seasonal subscription |
| `nextBillingDate` | string | Next billing date for the subscription |
| `maxMonthlyCharge` | number | Max monthly charge for the subscription |
| `expirationDate` | string | Expiration Date for the subscription. |
| `lastAppointment` | string | Last completed appointment associated with the subscription |
| `templateType` | string | The template type associated with the service type |
| `parentID` | integer | The subscriptionID of the service plan that the service round belongs to |
| `duration` | string | Default duration of services in minutes |
| `preferredDays` | integer | Empty String no preference, 0-Sunday, 1-Monday, 2-Tuesday, 3-Wednesday, 4-Thursday, 5-Friday, 6-Saturday |
| `preferredStart` | string | Preferred appointment start time bound |
| `preferredEnd` | string | Preferred appointment end time bound |
| `callAhead` | integer | int in minutes |
| `nextServicePlanRoundID` | integer | The servicePlanRoundID of the next upcoming service |
| `endBillingDate` | string | Date of last invoice for the service plan |
| `cycleStartDate` | string | Date the first service round for this service plan starts |
| `cycleEndDate` | string | Date the last service round for this service plan ends |
| `cycleAnnualValue` | number | The annual value for the current cycle |

### `/servicePlan/create`

create a service plan

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionLink` | string |  | Subscription Link for import |
| `serviceID` | integer | Yes | The service type ID for the regular recurring services |
| `customerID` | integer | Yes | Customer ID which this subscription belongs to |
| `billToAccountID` | integer |  | Billing Account which this subscription belongs to |
| `active` | integer |  | 0: frozen, 1: active and being placed in the job pool. |
| `billingFrequency` | integer |  | Frequency that an invoice is generated for this service. -1/0 |
| `frequency` | integer |  | The frequency that the services get scheduled. -1 represents One-Time, 0 represents 'as needed'. Greater than 0 represents the frequency in days. If it is divisible by 30, it is converted to months -- so 90 would represent 3 months and not necessarily 90 days. |
| `seasonalStart` | string |  | Seasonal Start |
| `seasonalEnd` | string |  | Seasonal End |
| `followupDelay` | integer |  | How many days after the initial service to schedule the first recurring service. Set as -1 to use frequency |
| `agreementLength` | integer |  | Agreement Length |
| `preferredTech` | integer |  | The employee ID of the preferred tech - 0 for no preference |
| `preferredDays` | integer |  | Preferred appointment day (0-SUN, 1-MON, 2-TUE, 3-WED, 4-THU, 5-FRI, 6-SAT) |
| `preferredStart` | string |  | Preferred appointment start time window in local time e.g. 00:00:00 |
| `preferredEnd` | string |  | Preferred appointment end time window in local time e.g. 14:30:00 |
| `sourceID` | integer |  | Subscription Source ID |
| `regionID` | integer |  | RegionID of the subscription |
| `renewalFrequency` | integer |  | How often a subscription is due for renewal. |
| `renewalDate` | string |  | Next renewal date |
| `customDate` | string |  | Custom next appointment date for the subscription. |
| `customScheduleID` | integer |  | ID of a pre-defined custom-schedule for services. frequency will be set to -3. |
| `nextBillingDate` | string |  | Next billing date for the subscription |
| `duration` | integer |  | The default duration in minutes for the appointment. Set to -1 to inherit from the service type. |
| `leadValue` | number |  | Value of the lead |
| `expirationDate` | integer |  | Expiration date of the subscription |
| `addedBy` | integer |  | The employee ID that added the subscription |
| `dateCancelled` | string |  | Date the subscription was cancelled |
| `billingTermsDays` | integer |  | Net Billing Days |
| `poNumber` | string |  | subscription poNumber |
| `callAhead` | integer |  | int in minutes |
| `soldBy` | integer |  | The employee ID who gets credit for this sale. Defaults to the user who added the subscription |
| `soldBy2` | integer |  | Additional employeeID that gets credit for this sale |
| `soldBy3` | integer |  | Additional employeeID that gets credit for this sale |
| `convertToLead` | integer |  | Automatically convert the subscription to a lead following the request |
| `serviceCharge` | integer |  | Amount that will be charged each service. To edit this after create use ticket/update with the subscriptionID and templateType=R |
| `addons` | object |  | Array of ticket addon objects, see ticket/createAddon for parameters. To edit this after create use ticket/update with the subscriptionID and templateType=R |
| `initialCharge` | integer |  | Amount that will be charged on the initial service. To edit this after create use ticket/update with the subscriptionID and templateType=I |
| `initialAddons` | object |  | Array of ticket addon objects, see ticket/createAddon for parameters. To edit this after create use ticket/update with the subscriptionID and templateType=I |
| `initialInvoice` | string |  | When the initial invoice should get generated. INITIAL_COMPLETION = when the initial service is completed. SIGNED_AGREEMENT = when the agreement is signed. INITIAL_BILLING_DATE = on a specified billing date. |
| `nextServicePlanRoundID` | integer |  | The servicePlanRoundID of the next upcoming service |
| `endBillingDate` | string |  | Date of last invoice for the service plan |

### `/servicePlan/get`

Get Bulk data for servicePlan. Accepts an array of subscriptionIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionIDs` | array |  |  |
| `includeCancellationReason` | int |  | Send as 1 to retrieve an array of cancellationNotes associated with the subscription. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `subscriptionID` | integer | Unique ID |
| `customerID` | integer | Customer ID which this subscription belongs to |
| `billToAccountID` | integer | Billing Account which this subscription belongs to |
| `officeID` | integer | Office ID which this subscription belongs to |
| `dateAdded` | string | Date this subscription was added / created. Sold date. |
| `contractAdded` | string | Date the last contract was added / created. |
| `active` | integer | 0: frozen, 1: active and being placed in the job pool. |
| `activeText` | integer | Friendly text version of active |
| `initialQuote` | number | The retail quoted price for the initial service on this subscription. |
| `initialDiscount` | number | The discount to be applied to the initial service |
| `initialServiceTotal` | number | The net amount of initialQuote-initialDiscount. DOES NOT INCLUDE add-ons |
| `yifDiscount` | number | The discount provided if paying for a year in advance |
| `recurringCharge` | number | A shortcut for the subtotal of the recurring ticket |
| `contractValue` | number | Calculated as the initial total + the number of recurring services*recurringCharge. There are some tweaks available for different companies / preferences, particularly when dealing with recurring billing. |
| `annualRecurringValue` | number | Calculated as the recurringCharge * the number of services/year. |
| `billingFrequency` | integer | How often this subscription gets their invoice generated -- can be seperate from when their service takes place. 0 / -1 represents getting billed after each service. |
| `frequency` | integer | The frequency that the services get scheduled. -1 represents One-Time, 0 represents 'as needed'. Greater than 0 represents the frequency in days. If it is divisible by 30, it is converted to months -- so 90 would represent 3 months and not necessarily 90 days. |
| `followupService` | integer | How many days after the initial service to schedule the first recurring service. |
| `agreementLength` | number | Agreement Length |
| `nextService` | string | When the next service is due. |
| `lastCompleted` | string | When the last service was completed |
| `serviceID` | integer | The service type ID for the regular recurring services |
| `serviceType` | string | Friendly description of the serviceID |
| `soldBy` | integer | The employee ID who gets credit for this sale. Defaults to the user who added the subscription |
| `soldBy2` | integer | Additional employeeID that gets credit for this sale |
| `soldBy3` | integer | Additional employeeID that gets credit for this sale |
| `preferredTech` | integer | preferred tech ID |
| `addedBy` | integer | The employee ID that added the subscription |
| `initialAppointmentID` | integer | The initial service appointment ID |
| `initialStatus` | integer | A shortcut for the status of the initial appointment |
| `initialStatusText` | string | Friendly text version of the initialStatus |
| `dateCancelled` | string | The date the subscription was cancelled if any. |
| `dateUpdated` | string | The date the subscription was last updated. |
| `cxlNotes` | string | The notes associated with cancelling this appointment. Group_Concat'ed in case of multiple cancellations |
| `subscriptionLink` | string | Subscription Link |
| `poNumber` | string | Subscription poNumber |
| `appointmentIDs` | integer | Every appointment attached to this subscription |
| `completedAppointmentIDs` | integer | Every completed appointment attached to this subscription |
| `initialAppointment` | object | The initial appointment object if includeInitialAppointments = true |
| `recurringTicket` | object | The recurring ticket template associated with this subscription |
| `addOns` | string | An array of Add-On objects associated with the INITIAL appointment. |
| `leadID` | integer | Primary key for lead |
| `leadDateAdded` | string | Time that this lead was created |
| `leadUpdated` | string | Time that this lead was last updated |
| `leadAddedBy` | integer | employeeID that created this lead |
| `leadSourceID` | integer | Lead Source ID |
| `leadSource` | string | Lead Source Description |
| `leadStatus` | integer | Lead Status |
| `leadStatusText` | string | Lead Status Text |
| `leadStageID` | integer | Lead Stage ID |
| `leadStage` | string | Lead Stage Description |
| `leadAssignedTo` | integer | EmployeeID to whom the lead is assigned |
| `leadDateAssigned` | string | Time the lead was assigned |
| `leadValue` | number | Value of the lead |
| `leadDateClosed` | string | Time the lead was closed |
| `leadLostReason` | string | Lead Lost Reason ID |
| `leadLostReasonText` | string | Lead Lost Reason |
| `sourceID` | integer | Subscription Source ID |
| `source` | string | Subscription Source Description |
| `annualRecurringServices` | integer | Services per year without counting initial |
| `unitIDs` | integer | An array of unit IDs available for this subscription (for multi unit customers) - defaults to all unless specific units have been selected |
| `regionID` | integer | RegionID of the subscription |
| `initialInvoice` | string | When the initial invoice should get generated. INITIAL_COMPLETION = when the initial service is completed. SIGNED_AGREEMENT = when the agreement is signed. INITIAL_BILLING_DATE = on a specified billing date. |
| `initialBillingDate` | string | The date to generate initial invoice when initialInvoice = INITIAL_BILLING_DATE |
| `renewalFrequency` | integer | How often a subscription is due for renewal. |
| `renewalDate` | string | Next renewal date |
| `customDate` | string | custom next appointment date |
| `sentriconConnected` | integer | Set as 1 if the subscription is connected to sentricon |
| `sentriconSiteID` | string | Sentricon Site ID or null if not connected to Sentricon |
| `seasonalStart` | string | Date the season starts or 0000-00-00 if it is not a seasonal subscription |
| `seasonalEnd` | string | Date the season ends or 0000-00-00 if it is not a seasonal subscription |
| `nextBillingDate` | string | Next billing date for the subscription |
| `maxMonthlyCharge` | number | Max monthly charge for the subscription |
| `expirationDate` | string | Expiration Date for the subscription. |
| `lastAppointment` | string | Last completed appointment associated with the subscription |
| `templateType` | string | The template type associated with the service type |
| `parentID` | integer | The subscriptionID of the service plan that the service round belongs to |
| `duration` | string | Default duration of services in minutes |
| `preferredDays` | integer | Empty String no preference, 0-Sunday, 1-Monday, 2-Tuesday, 3-Wednesday, 4-Thursday, 5-Friday, 6-Saturday |
| `preferredStart` | string | Preferred appointment start time bound |
| `preferredEnd` | string | Preferred appointment end time bound |
| `callAhead` | integer | int in minutes |
| `nextServicePlanRoundID` | integer | The servicePlanRoundID of the next upcoming service |
| `endBillingDate` | string | Date of last invoice for the service plan |
| `cycleStartDate` | string | Date the first service round for this service plan starts |
| `cycleEndDate` | string | Date the last service round for this service plan ends |
| `cycleAnnualValue` | number | The annual value for the current cycle |

### `/servicePlan/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  |  |
| `active` | integer |  | Default: (0,1). 0: Frozen and no longer being placed in the job pool, 1: Active, -3: Lead |
| `customerIDs` | integer |  | Customer who owns this subcscription |
| `subscriptionIDs` | integer |  | Unique Identifier for this Subscription |
| `soldBy` | integer |  | The user who is being credited for this sale. Used in stats and commissions reporting |
| `preferredTech` | integer |  | The employee ID of the preferred tech |
| `dateAdded` | string |  | Date this subscription was created / added / sold |
| `dateCancelled` | string |  | Date this subscription was cancelled |
| `dateUpdated` | string |  | Last date that something was changed on this subscription. |
| `serviceType` | integer |  | The recurring service type to be scheduled for this subscription |
| `serviceID` | integer |  | The recurring service type to be scheduled for this subscription |
| `frequency` | integer |  | The service frequency of this subscription. &gt;0: The number of days, if it is divisible by 30 it is the number of months, -3: Custom Schedule |
| `dueDate` | string |  | When this subscription is due for their next service |
| `lastCompleted` | string |  | When the last service was completed |
| `dateUpdatedStart` | string |  |  |
| `dateUpdatedEnd` | string |  |  |
| `dateAddedStart` | string |  |  |
| `dateAddedEnd` | string |  |  |
| `contractIDs` | integer |  | The contract ID signed for the subscription |
| `leadDateClosed` | string |  | The date the lead was closed |
| `leadDateAssigned` | string |  | The date the lead was assigned |
| `leadStageID` | integer |  | The stageID of the lead |
| `leadAssignedTo` | integer |  | The employeeID the lead was assigned to |
| `leadAddedBy` | integer |  | The employeeID who added the lead |
| `leadDateAdded` | string |  | The date the lead was added |
| `leadUpdated` | string |  | The date the lead was last updated |
| `leadSourceID` | integer |  | The sourceID of the lead |
| `sourceID` | integer |  | The sourceID of the subscription |
| `nextService` | string |  | The date that the next service is due |
| `regionID` | integer |  | RegionID of the subscription |
| `lastRegularServiceDate` | string |  | Date for last service of subscription type |
| `lastRegularServiceStatus` | integer |  | Last regular service status |
| `sentriconConnected` | integer |  | Set as 1 if the subscription is connected to sentricon |
| `sentriconSiteID` | string |  | Sentricon Site ID or null if not connected to Sentricon |
| `nextBillingDate` | string |  | Next billing date for the subscription |
| `parentID` | integer |  |  |
| `templateType` | string |  | The template type associated with the service type |
| `lastAppointment` | string |  | Last appointment of the subscription |
| `cycleStartDate` | string |  | Date the first service round for this service plan starts |
| `cycleEndDate` | string |  | Date the last service round for this service plan ends |
| `cycleAnnualValue` | number |  | The annual value for the current cycle |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property servicePlanIDsNoDataExported will specify the items that are not included in the resolved servicePlan array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `servicePlanIDs` | array |  |

### `/servicePlan/update`

Update service plan subscription details

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionLink` | string |  | Subscription Link for import |
| `serviceID` | integer |  | The service type ID for the regular recurring services |
| `customerID` | integer |  | Customer ID which this subscription belongs to |
| `billToAccountID` | integer |  | Billing Account which this subscription belongs to |
| `active` | integer |  | 0: frozen, 1: active and being placed in the job pool. |
| `billingFrequency` | integer |  | Frequency that an invoice is generated for this service. -1/0 |
| `frequency` | integer |  | The frequency that the services get scheduled. -1 represents One-Time, 0 represents 'as needed'. Greater than 0 represents the frequency in days. If it is divisible by 30, it is converted to months -- so 90 would represent 3 months and not necessarily 90 days. |
| `seasonalStart` | string |  | Seasonal Start |
| `seasonalEnd` | string |  | Seasonal End |
| `followupDelay` | integer |  | How many days after the initial service to schedule the first recurring service. Set as -1 to use frequency |
| `agreementLength` | integer |  | Agreement Length |
| `preferredTech` | integer |  | The employee ID of the preferred tech - 0 for no preference |
| `preferredDays` | integer |  | Preferred appointment day (0-SUN, 1-MON, 2-TUE, 3-WED, 4-THU, 5-FRI, 6-SAT) |
| `preferredStart` | string |  | Preferred appointment start time window in local time e.g. 00:00:00 |
| `preferredEnd` | string |  | Preferred appointment end time window in local time e.g. 14:30:00 |
| `sourceID` | integer |  | Subscription Source ID |
| `regionID` | integer |  | RegionID of the subscription |
| `renewalFrequency` | integer |  | How often a subscription is due for renewal. |
| `renewalDate` | string |  | Next renewal date |
| `customDate` | string |  | Custom next appointment date for the subscription. |
| `customScheduleID` | integer |  | ID of a pre-defined custom-schedule for services. frequency will be set to -3. |
| `nextBillingDate` | string |  | Next billing date for the subscription |
| `duration` | integer |  | The default duration in minutes for the appointment. Set to -1 to inherit from the service type. |
| `leadValue` | number |  | Value of the lead |
| `expirationDate` | integer |  | Expiration date of the subscription |
| `addedBy` | integer |  | The employee ID that added the subscription |
| `dateCancelled` | string |  | Date the subscription was cancelled |
| `billingTermsDays` | integer |  | Net Billing Days |
| `poNumber` | string |  | subscription poNumber |
| `callAhead` | integer |  | int in minutes |
| `soldBy` | integer |  | The employee ID who gets credit for this sale. Defaults to the user who added the subscription |
| `soldBy2` | integer |  | Additional employeeID that gets credit for this sale |
| `soldBy3` | integer |  | Additional employeeID that gets credit for this sale |
| `convertToLead` | integer |  | Automatically convert the subscription to a lead following the request |
| `initialInvoice` | string |  | When the initial invoice should get generated. INITIAL_COMPLETION = when the initial service is completed. SIGNED_AGREEMENT = when the agreement is signed. INITIAL_BILLING_DATE = on a specified billing date. |
| `subscriptionID` | integer | Yes | Primary key to the tickets table. |

### `/servicePlan/updateLeadStage`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionID` | integer | Yes | Foreign key to subscriptions table. |
| `subscriptionLink` | integer |  | Alternative to subscriptionID. This is the "SubscriptionID" sent during an API insert through import/main. |
| `stageID` | integer |  | Lead stage ID. |
| `status` | integer |  | 0 - Convert To Lead, 1 - Convert to subscription (lead won) |
| `lostReason` | integer |  | Lead Lost Reason |

## servicePlanRound

### `/servicePlanRound/[id]`

Get servicePlanRound data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `subscriptionID` | integer | Unique ID |
| `customerID` | integer | Customer ID which this subscription belongs to |
| `billToAccountID` | integer | Billing Account which this subscription belongs to |
| `officeID` | integer | Office ID which this subscription belongs to |
| `dateAdded` | string | Date this subscription was added / created. Sold date. |
| `contractAdded` | string | Date the last contract was added / created. |
| `active` | integer | 0: frozen, 1: active and being placed in the job pool. |
| `activeText` | integer | Friendly text version of active |
| `initialQuote` | number | The retail quoted price for the initial service on this subscription. |
| `initialDiscount` | number | The discount to be applied to the initial service |
| `initialServiceTotal` | number | The net amount of initialQuote-initialDiscount. DOES NOT INCLUDE add-ons |
| `yifDiscount` | number | The discount provided if paying for a year in advance |
| `recurringCharge` | number | A shortcut for the subtotal of the recurring ticket |
| `contractValue` | number | Calculated as the initial total + the number of recurring services*recurringCharge. There are some tweaks available for different companies / preferences, particularly when dealing with recurring billing. |
| `annualRecurringValue` | number | Calculated as the recurringCharge * the number of services/year. |
| `billingFrequency` | integer | How often this subscription gets their invoice generated -- can be seperate from when their service takes place. 0 / -1 represents getting billed after each service. |
| `frequency` | integer | The frequency that the services get scheduled. -1 represents One-Time, 0 represents 'as needed'. Greater than 0 represents the frequency in days. If it is divisible by 30, it is converted to months -- so 90 would represent 3 months and not necessarily 90 days. |
| `followupService` | integer | How many days after the initial service to schedule the first recurring service. |
| `agreementLength` | number | Agreement Length |
| `nextService` | string | When the next service is due. |
| `lastCompleted` | string | When the last service was completed |
| `serviceID` | integer | The service type ID for the regular recurring services |
| `serviceType` | string | Friendly description of the serviceID |
| `soldBy` | integer | The employee ID who gets credit for this sale. Defaults to the user who added the subscription |
| `soldBy2` | integer | Additional employeeID that gets credit for this sale |
| `soldBy3` | integer | Additional employeeID that gets credit for this sale |
| `preferredTech` | integer | preferred tech ID |
| `addedBy` | integer | The employee ID that added the subscription |
| `initialAppointmentID` | integer | The initial service appointment ID |
| `initialStatus` | integer | A shortcut for the status of the initial appointment |
| `initialStatusText` | string | Friendly text version of the initialStatus |
| `dateCancelled` | string | The date the subscription was cancelled if any. |
| `dateUpdated` | string | The date the subscription was last updated. |
| `cxlNotes` | string | The notes associated with cancelling this appointment. Group_Concat'ed in case of multiple cancellations |
| `subscriptionLink` | string | Subscription Link |
| `poNumber` | string | Subscription poNumber |
| `appointmentIDs` | integer | Every appointment attached to this subscription |
| `completedAppointmentIDs` | integer | Every completed appointment attached to this subscription |
| `initialAppointment` | object | The initial appointment object if includeInitialAppointments = true |
| `recurringTicket` | object | The recurring ticket template associated with this subscription |
| `addOns` | string | An array of Add-On objects associated with the INITIAL appointment. |
| `leadID` | integer | Primary key for lead |
| `leadDateAdded` | string | Time that this lead was created |
| `leadUpdated` | string | Time that this lead was last updated |
| `leadAddedBy` | integer | employeeID that created this lead |
| `leadSourceID` | integer | Lead Source ID |
| `leadSource` | string | Lead Source Description |
| `leadStatus` | integer | Lead Status |
| `leadStatusText` | string | Lead Status Text |
| `leadStageID` | integer | Lead Stage ID |
| `leadStage` | string | Lead Stage Description |
| `leadAssignedTo` | integer | EmployeeID to whom the lead is assigned |
| `leadDateAssigned` | string | Time the lead was assigned |
| `leadValue` | number | Value of the lead |
| `leadDateClosed` | string | Time the lead was closed |
| `leadLostReason` | string | Lead Lost Reason ID |
| `leadLostReasonText` | string | Lead Lost Reason |
| `sourceID` | integer | Subscription Source ID |
| `source` | string | Subscription Source Description |
| `annualRecurringServices` | integer | Services per year without counting initial |
| `unitIDs` | integer | An array of unit IDs available for this subscription (for multi unit customers) - defaults to all unless specific units have been selected |
| `regionID` | integer | RegionID of the subscription |
| `initialInvoice` | string | When the initial invoice should get generated. INITIAL_COMPLETION = when the initial service is completed. SIGNED_AGREEMENT = when the agreement is signed. INITIAL_BILLING_DATE = on a specified billing date. |
| `initialBillingDate` | string | The date to generate initial invoice when initialInvoice = INITIAL_BILLING_DATE |
| `renewalFrequency` | integer | How often a subscription is due for renewal. |
| `renewalDate` | string | Next renewal date |
| `customDate` | string | custom next appointment date |
| `sentriconConnected` | integer | Set as 1 if the subscription is connected to sentricon |
| `sentriconSiteID` | string | Sentricon Site ID or null if not connected to Sentricon |
| `seasonalStart` | string | Date the season starts or 0000-00-00 if it is not a seasonal subscription |
| `seasonalEnd` | string | Date the season ends or 0000-00-00 if it is not a seasonal subscription |
| `nextBillingDate` | string | Next billing date for the subscription |
| `maxMonthlyCharge` | number | Max monthly charge for the subscription |
| `expirationDate` | string | Expiration Date for the subscription. |
| `lastAppointment` | string | Last completed appointment associated with the subscription |
| `templateType` | string | The template type associated with the service type |
| `parentID` | integer | The subscriptionID of the service plan that the service round belongs to |
| `duration` | string | Default duration of services in minutes |
| `preferredDays` | integer | Empty String no preference, 0-Sunday, 1-Monday, 2-Tuesday, 3-Wednesday, 4-Thursday, 5-Friday, 6-Saturday |
| `preferredStart` | string | Preferred appointment start time bound |
| `preferredEnd` | string | Preferred appointment end time bound |
| `callAhead` | integer | int in minutes |
| `nextServicePlanRoundID` | integer | The servicePlanRoundID for this service round |
| `servicePlanID` | integer | The serviceID of the service plan that this round belongs to |
| `startDate` | string | Start date for this service round |
| `endDate` | string | End date for this service round |
| `prerequisiteServicePlanRoundID` | integer | The servicePlanRoundID of the prior round that this round is dependent on |
| `daysAfterPrerequisite` | integer | Days to wait after the prior service round completed before starting this service round |
| `maxDelay` | integer | Maximum number of days to wait before starting this service round |
| `skipped` | string | The skip/omit status for the round |
| `skipReasonID` | integer | The skip reason for MANUAL_SKIPPED rounds, defined in skipReasons table |
| `dateSkipped` | string | The date that the skip status was changed |

### `/servicePlanRound/get`

Get Bulk data for servicePlanRound. Accepts an array of subscriptionIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `subscriptionID` | integer | Unique ID |
| `customerID` | integer | Customer ID which this subscription belongs to |
| `billToAccountID` | integer | Billing Account which this subscription belongs to |
| `officeID` | integer | Office ID which this subscription belongs to |
| `dateAdded` | string | Date this subscription was added / created. Sold date. |
| `contractAdded` | string | Date the last contract was added / created. |
| `active` | integer | 0: frozen, 1: active and being placed in the job pool. |
| `activeText` | integer | Friendly text version of active |
| `initialQuote` | number | The retail quoted price for the initial service on this subscription. |
| `initialDiscount` | number | The discount to be applied to the initial service |
| `initialServiceTotal` | number | The net amount of initialQuote-initialDiscount. DOES NOT INCLUDE add-ons |
| `yifDiscount` | number | The discount provided if paying for a year in advance |
| `recurringCharge` | number | A shortcut for the subtotal of the recurring ticket |
| `contractValue` | number | Calculated as the initial total + the number of recurring services*recurringCharge. There are some tweaks available for different companies / preferences, particularly when dealing with recurring billing. |
| `annualRecurringValue` | number | Calculated as the recurringCharge * the number of services/year. |
| `billingFrequency` | integer | How often this subscription gets their invoice generated -- can be seperate from when their service takes place. 0 / -1 represents getting billed after each service. |
| `frequency` | integer | The frequency that the services get scheduled. -1 represents One-Time, 0 represents 'as needed'. Greater than 0 represents the frequency in days. If it is divisible by 30, it is converted to months -- so 90 would represent 3 months and not necessarily 90 days. |
| `followupService` | integer | How many days after the initial service to schedule the first recurring service. |
| `agreementLength` | number | Agreement Length |
| `nextService` | string | When the next service is due. |
| `lastCompleted` | string | When the last service was completed |
| `serviceID` | integer | The service type ID for the regular recurring services |
| `serviceType` | string | Friendly description of the serviceID |
| `soldBy` | integer | The employee ID who gets credit for this sale. Defaults to the user who added the subscription |
| `soldBy2` | integer | Additional employeeID that gets credit for this sale |
| `soldBy3` | integer | Additional employeeID that gets credit for this sale |
| `preferredTech` | integer | preferred tech ID |
| `addedBy` | integer | The employee ID that added the subscription |
| `initialAppointmentID` | integer | The initial service appointment ID |
| `initialStatus` | integer | A shortcut for the status of the initial appointment |
| `initialStatusText` | string | Friendly text version of the initialStatus |
| `dateCancelled` | string | The date the subscription was cancelled if any. |
| `dateUpdated` | string | The date the subscription was last updated. |
| `cxlNotes` | string | The notes associated with cancelling this appointment. Group_Concat'ed in case of multiple cancellations |
| `subscriptionLink` | string | Subscription Link |
| `poNumber` | string | Subscription poNumber |
| `appointmentIDs` | integer | Every appointment attached to this subscription |
| `completedAppointmentIDs` | integer | Every completed appointment attached to this subscription |
| `initialAppointment` | object | The initial appointment object if includeInitialAppointments = true |
| `recurringTicket` | object | The recurring ticket template associated with this subscription |
| `addOns` | string | An array of Add-On objects associated with the INITIAL appointment. |
| `leadID` | integer | Primary key for lead |
| `leadDateAdded` | string | Time that this lead was created |
| `leadUpdated` | string | Time that this lead was last updated |
| `leadAddedBy` | integer | employeeID that created this lead |
| `leadSourceID` | integer | Lead Source ID |
| `leadSource` | string | Lead Source Description |
| `leadStatus` | integer | Lead Status |
| `leadStatusText` | string | Lead Status Text |
| `leadStageID` | integer | Lead Stage ID |
| `leadStage` | string | Lead Stage Description |
| `leadAssignedTo` | integer | EmployeeID to whom the lead is assigned |
| `leadDateAssigned` | string | Time the lead was assigned |
| `leadValue` | number | Value of the lead |
| `leadDateClosed` | string | Time the lead was closed |
| `leadLostReason` | string | Lead Lost Reason ID |
| `leadLostReasonText` | string | Lead Lost Reason |
| `sourceID` | integer | Subscription Source ID |
| `source` | string | Subscription Source Description |
| `annualRecurringServices` | integer | Services per year without counting initial |
| `unitIDs` | integer | An array of unit IDs available for this subscription (for multi unit customers) - defaults to all unless specific units have been selected |
| `regionID` | integer | RegionID of the subscription |
| `initialInvoice` | string | When the initial invoice should get generated. INITIAL_COMPLETION = when the initial service is completed. SIGNED_AGREEMENT = when the agreement is signed. INITIAL_BILLING_DATE = on a specified billing date. |
| `initialBillingDate` | string | The date to generate initial invoice when initialInvoice = INITIAL_BILLING_DATE |
| `renewalFrequency` | integer | How often a subscription is due for renewal. |
| `renewalDate` | string | Next renewal date |
| `customDate` | string | custom next appointment date |
| `sentriconConnected` | integer | Set as 1 if the subscription is connected to sentricon |
| `sentriconSiteID` | string | Sentricon Site ID or null if not connected to Sentricon |
| `seasonalStart` | string | Date the season starts or 0000-00-00 if it is not a seasonal subscription |
| `seasonalEnd` | string | Date the season ends or 0000-00-00 if it is not a seasonal subscription |
| `nextBillingDate` | string | Next billing date for the subscription |
| `maxMonthlyCharge` | number | Max monthly charge for the subscription |
| `expirationDate` | string | Expiration Date for the subscription. |
| `lastAppointment` | string | Last completed appointment associated with the subscription |
| `templateType` | string | The template type associated with the service type |
| `parentID` | integer | The subscriptionID of the service plan that the service round belongs to |
| `duration` | string | Default duration of services in minutes |
| `preferredDays` | integer | Empty String no preference, 0-Sunday, 1-Monday, 2-Tuesday, 3-Wednesday, 4-Thursday, 5-Friday, 6-Saturday |
| `preferredStart` | string | Preferred appointment start time bound |
| `preferredEnd` | string | Preferred appointment end time bound |
| `callAhead` | integer | int in minutes |
| `nextServicePlanRoundID` | integer | The servicePlanRoundID for this service round |
| `servicePlanID` | integer | The serviceID of the service plan that this round belongs to |
| `startDate` | string | Start date for this service round |
| `endDate` | string | End date for this service round |
| `prerequisiteServicePlanRoundID` | integer | The servicePlanRoundID of the prior round that this round is dependent on |
| `daysAfterPrerequisite` | integer | Days to wait after the prior service round completed before starting this service round |
| `maxDelay` | integer | Maximum number of days to wait before starting this service round |
| `skipped` | string | The skip/omit status for the round |
| `skipReasonID` | integer | The skip reason for MANUAL_SKIPPED rounds, defined in skipReasons table |
| `dateSkipped` | string | The date that the skip status was changed |

### `/servicePlanRound/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  |  |
| `active` | integer |  | Default: (0,1). 0: Frozen and no longer being placed in the job pool, 1: Active, -3: Lead |
| `customerIDs` | integer |  | Customer who owns this subcscription |
| `subscriptionIDs` | integer |  | Unique Identifier for this Subscription |
| `soldBy` | integer |  | The user who is being credited for this sale. Used in stats and commissions reporting |
| `preferredTech` | integer |  | The employee ID of the preferred tech |
| `dateAdded` | string |  | Date this subscription was created / added / sold |
| `dateCancelled` | string |  | Date this subscription was cancelled |
| `dateUpdated` | string |  | Last date that something was changed on this subscription. |
| `serviceType` | integer |  | The recurring service type to be scheduled for this subscription |
| `serviceID` | integer |  | The recurring service type to be scheduled for this subscription |
| `frequency` | integer |  | The service frequency of this subscription. &gt;0: The number of days, if it is divisible by 30 it is the number of months, -3: Custom Schedule |
| `dueDate` | string |  | When this subscription is due for their next service |
| `lastCompleted` | string |  | When the last service was completed |
| `dateUpdatedStart` | string |  |  |
| `dateUpdatedEnd` | string |  |  |
| `dateAddedStart` | string |  |  |
| `dateAddedEnd` | string |  |  |
| `contractIDs` | integer |  | The contract ID signed for the subscription |
| `leadDateClosed` | string |  | The date the lead was closed |
| `leadDateAssigned` | string |  | The date the lead was assigned |
| `leadStageID` | integer |  | The stageID of the lead |
| `leadAssignedTo` | integer |  | The employeeID the lead was assigned to |
| `leadAddedBy` | integer |  | The employeeID who added the lead |
| `leadDateAdded` | string |  | The date the lead was added |
| `leadUpdated` | string |  | The date the lead was last updated |
| `leadSourceID` | integer |  | The sourceID of the lead |
| `sourceID` | integer |  | The sourceID of the subscription |
| `nextService` | string |  | The date that the next service is due |
| `regionID` | integer |  | RegionID of the subscription |
| `lastRegularServiceDate` | string |  | Date for last service of subscription type |
| `lastRegularServiceStatus` | integer |  | Last regular service status |
| `sentriconConnected` | integer |  | Set as 1 if the subscription is connected to sentricon |
| `sentriconSiteID` | string |  | Sentricon Site ID or null if not connected to Sentricon |
| `nextBillingDate` | string |  | Next billing date for the subscription |
| `parentID` | integer |  |  |
| `templateType` | string |  | The template type associated with the service type |
| `lastAppointment` | string |  | Last appointment of the subscription |
| `description` | string |  | Service plan round description/abbreviation |
| `startDate` | string |  | Date this service round can start being serviced |
| `endDate` | string |  | Last date that this service round can be serviced |
| `skipped` | string |  | The skip/omit status for the round |
| `dateSkipped` | string |  | The date this round was skipped or omitted |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property servicePlanRoundIDsNoDataExported will specify the items that are not included in the resolved servicePlanRound array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `servicePlanRoundIDs` | array |  |

### `/servicePlanRound/update`

update a service plan round

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionID` | integer | Yes | Primary key to the subscriptions table. |
| `description` | string |  | Service plan round description/abbreviation |
| `startDate` | string |  | Start date for this service round |
| `endDate` | string |  | End date for this service round |
| `daysAfterPrerequisite` | integer |  | Days to wait after the prior service round completed before starting this service round |
| `maxDelay` | integer |  | Maximum number of days to wait before starting this service round |
| `skipped` | string |  | The skip/omit status for the round |
| `skipReasonID` | integer |  | The skip reason for MANUAL_SKIPPED rounds, defined in skipReasons table |
| `skippedNotes` | string |  | The skip notes for MANUAL_SKIPPED rounds |

## serviceType

### `/serviceType/[id]`

Get serviceType data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `typeID` | integer | Unique Identifier |
| `officeID` | integer | Office ID this service type belongs to, it will be -1 if it is a Global service type |
| `description` | string | Service type description |
| `frequency` | integer | Service Type Frequecy. (-1 when it is As need, 0 when it is One Time, -3 when it is Custom Schedule) |
| `defaultCharge` | number | Service type default charge |
| `category` | string | Service type category |
| `reservice` | integer | Service is a reservice type |
| `defaultLength` | integer | Default appointment duration in minutes |
| `defaultInitialCharge` | number | Service defaultInitialCharge. If this is not set, the office default initial quote is sent instead. |
| `initialID` | integer | Initial service type, or 0 if one is not set. |
| `minimumRecurringCharge` | number | Minimum recurring charge for subscriptions. |
| `minimumInitialCharge` | number | Minimum initial charge for subscriptions. |
| `regularService` | integer | Set as 1 if the service type is marked as a regular service. |
| `initial` | integer | Set as 1 if the service type is marked as an initial service. |
| `seasonStart` | string | Season Start Date for this service |
| `seasonEnd` | string | Season End Date for this service |
| `glAccountID` | integer | glAccountID of the service |
| `sentricon` | integer | Sentricon service type (reports to Sentricon Web Services when completed) |
| `visible` | integer | 1 if visible, 0 if hidden. |

### `/serviceType/get`

Get Bulk data for serviceType. Accepts an array of typeIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `typeIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `typeID` | integer | Unique Identifier |
| `officeID` | integer | Office ID this service type belongs to, it will be -1 if it is a Global service type |
| `description` | string | Service type description |
| `frequency` | integer | Service Type Frequecy. (-1 when it is As need, 0 when it is One Time, -3 when it is Custom Schedule) |
| `defaultCharge` | number | Service type default charge |
| `category` | string | Service type category |
| `reservice` | integer | Service is a reservice type |
| `defaultLength` | integer | Default appointment duration in minutes |
| `defaultInitialCharge` | number | Service defaultInitialCharge. If this is not set, the office default initial quote is sent instead. |
| `initialID` | integer | Initial service type, or 0 if one is not set. |
| `minimumRecurringCharge` | number | Minimum recurring charge for subscriptions. |
| `minimumInitialCharge` | number | Minimum initial charge for subscriptions. |
| `regularService` | integer | Set as 1 if the service type is marked as a regular service. |
| `initial` | integer | Set as 1 if the service type is marked as an initial service. |
| `seasonStart` | string | Season Start Date for this service |
| `seasonEnd` | string | Season End Date for this service |
| `glAccountID` | integer | glAccountID of the service |
| `sentricon` | integer | Sentricon service type (reports to Sentricon Web Services when completed) |
| `visible` | integer | 1 if visible, 0 if hidden. |

### `/serviceType/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  | Office Unique Identifier |
| `typeIDs` | integer |  | Service Type Unique Identifier |
| `description` | string |  | Description of the Service Type |
| `category` | string |  | Category of the Service Type |
| `reservice` | integer |  | Service is a reservice type |
| `sentricon` | integer |  | Service is a sentricon service type |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property serviceTypeIDsNoDataExported will specify the items that are not included in the resolved serviceType array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `serviceTypeIDs` | array |  |

## skill

### `/skill/[id]`

Get skill data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `skillID` | integer |  |
| `name` | string |  |
| `officeID` | integer |  |
| `visible` | integer |  |
| `serviceIDs` | integer | IDs of serviceTypes associated with the skill |
| `productIDs` | integer | IDs of addOns associated with the skill |

### `/skill/create`

create a skill

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `name` | string | Yes | Name of skill |
| `officeID` | integer | Yes | officeID this skill is specific to, or -1 to be available to all offices |
| `visible` | integer | Yes | Skill visibility: 1 = visible, 0 = hidden |
| `serviceIDs` | string |  | Array of serviceType IDs the skill should be for |
| `productIDs` | string |  | Array of productIDs the skill should be for |

### `/skill/get`

Get Bulk data for skill. Accepts an array of skillIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `skillIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `skillID` | integer |  |
| `name` | string |  |
| `officeID` | integer |  |
| `visible` | integer |  |
| `serviceIDs` | integer | IDs of serviceTypes associated with the skill |
| `productIDs` | integer | IDs of addOns associated with the skill |

### `/skill/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `skillIDs` | integer |  | Primary key |
| `skillID` | integer |  | Primary key alias |
| `officeIDs` | integer |  | Office ID skill belongs to |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property skillIDsNoDataExported will specify the items that are not included in the resolved skill array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `skillIDs` | array |  |

### `/skill/update`

Update skill details

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `name` | string |  | Name of skill |
| `officeID` | integer |  | officeID this skill is specific to, or -1 to be available to all offices |
| `visible` | integer |  | Skill visibility: 1 = visible, 0 = hidden |
| `serviceIDs` | string |  | Array of serviceType IDs the skill should be for |
| `productIDs` | string |  | Array of productIDs the skill should be for |
| `skillID` | integer | Yes | Primary key to the skills table. |

## spot

### `/spot/[id]`

Get spot data for single ID -- please provide a specific record ID in the URL structure. This function has additional non-standard filters Latitude and Longitude for distance calculation. If these are not specified the office location will be used.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `latitude` | number |  | Latitude for distance calculcations. If not specified, the office longitude will be used |
| `longitude` | number |  | Longitude for distance calculcations. If not specified, the office longitude will be used |
| `maxDistance` | integer |  | Maximum number of miles from the previous spot to return. |
| `ignoreInitialDriveTime` | integer |  | If sent as 1 the start and end of the route will be ignored for distanceToClosest and maxDistance once the route has an appointment on it. This strategy can be beneficial technicians are driving a long distance to their first appointment, then servicing locally from there. |
| `open` | integer |  | Set as 1 to return only open routes from the GET |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `spotID` | integer |  |
| `routeID` | integer |  |
| `date` | string |  |
| `start` | string |  |
| `end` | string |  |
| `spotCapacity` | integer |  |
| `description` | string |  |
| `currentAppointment` | integer |  |
| `currentAppointmentDuration` | integer |  |
| `blockReason` | string |  |
| `distanceToPrevious` | number |  |
| `previousLat` | number |  |
| `previousLng` | number |  |
| `prevCustomer` | integer | ID of the customer occupying the next appointment |
| `prevSpotID` | integer | ID of the last occupied spot |
| `prevAppointmentID` | integer | ID of the last appointment |
| `distanceToNext` | number |  |
| `nextLat` | number |  |
| `nextLng` | number |  |
| `nextCustomer` | integer | ID of the customer occupying the next filled appointment |
| `nextSpotID` | integer | ID of the next occupied spot |
| `nextAppointmentID` | integer | ID of the next appointment |
| `apiCanSchedule` | integer | 1 when the API can schedule to this spot |
| `assignedTech` | integer | EmployeeID assigned to the route. |
| `reserved` | integer | True if the appointment has been reserved by an API user. |
| `reservationEnd` | string | The time that the reservation on this spot will expire. |

### `/spot/block`

Block spots

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `spotID` | integer |  | Foreign key to spots table |
| `spotIDs` | array |  | Array of additional spotIDs to block |
| `description` | array |  | Block description default: Break |

### `/spot/get`

Get Bulk data for spot. Accepts an array of spotIDs. Returns a max of 1000 records. This function has additional non-standard filters Latitude and Longitude for distance calculation. If these are not specified the office location will be used.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `spotIDs` | array |  |  |
| `latitude` | number |  | Latitude for distance calculcations. If not specified, the office longitude will be used |
| `longitude` | number |  | Longitude for distance calculcations. If not specified, the office longitude will be used |
| `maxDistance` | int |  | Maximum number of miles from the previous spot to return. |
| `ignoreInitialDriveTime` | int |  | If sent as 1 the start and end of the route will be ignored for distanceToClosest and maxDistance once the route has an appointment on it. This strategy can be beneficial technicians are driving a long distance to their first appointment, then servicing locally from there. |
| `open` | int |  | Set as 1 to return only open routes from the GET |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `spotID` | integer |  |
| `routeID` | integer |  |
| `date` | string |  |
| `start` | string |  |
| `end` | string |  |
| `spotCapacity` | integer |  |
| `description` | string |  |
| `currentAppointment` | integer |  |
| `currentAppointmentDuration` | integer |  |
| `blockReason` | string |  |
| `distanceToPrevious` | number |  |
| `previousLat` | number |  |
| `previousLng` | number |  |
| `prevCustomer` | integer | ID of the customer occupying the next appointment |
| `prevSpotID` | integer | ID of the last occupied spot |
| `prevAppointmentID` | integer | ID of the last appointment |
| `distanceToNext` | number |  |
| `nextLat` | number |  |
| `nextLng` | number |  |
| `nextCustomer` | integer | ID of the customer occupying the next filled appointment |
| `nextSpotID` | integer | ID of the next occupied spot |
| `nextAppointmentID` | integer | ID of the next appointment |
| `apiCanSchedule` | integer | 1 when the API can schedule to this spot |
| `assignedTech` | integer | EmployeeID assigned to the route. |
| `reserved` | integer | True if the appointment has been reserved by an API user. |
| `reservationEnd` | string | The time that the reservation on this spot will expire. |

### `/spot/release`

Release reservations on a spot

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `spotID` | integer |  | Foreign key to spots table |

### `/spot/reserve`

Reserve a spot until a particular time

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `spotID` | integer |  | Foreign key to spots table |
| `spotOptions` | array |  | Array of spotIDs. If sent, the first available spotID in this set will be reserved |
| `duration` | integer | Yes | duration of the lock in minutes |

### `/spot/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array. If the includeData flag is set the additional parameters from getData (latitude, longitude, and maxDistance) can be used.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  |  |
| `spotIDs` | integer |  | Primary key for spots. |
| `date` | string |  |  |
| `apiCanSchedule` | boolean |  | Send as 1 to retrieve only routes that the API can schedule for. |
| `assignedTech` | integer |  |  |
| `routeID` | integer |  | Primary key for routes. |
| `routeIDs` | integer |  | Primary key for routes. |
| `reserved` | integer |  | Primary key for routes. |
| `dateUpdated` | string |  | Date of last update. |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property spotIDsNoDataExported will specify the items that are not included in the resolved spot array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `spotIDs` | array |  |

### `/spot/unblock`

unblock spots

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `spotID` | integer |  | Foreign key to spots table |
| `spotIDs` | array |  | Array of additional spotIDs to unblock |

## subscription

### `/subscription/[id]`

Get subscription data for single ID -- please provide a specific record ID in the URL structure.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `includeCancellationReason` | integer |  | Send as 1 to retrieve an array of cancellationNotes associated with the subscription. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `subscriptionID` | integer | Unique ID |
| `customerID` | integer | Customer ID which this subscription belongs to |
| `billToAccountID` | integer | Billing Account which this subscription belongs to |
| `officeID` | integer | Office ID which this subscription belongs to |
| `dateAdded` | string | Date this subscription was added / created. Sold date. |
| `contractAdded` | string | Date the last contract was added / created. |
| `active` | integer | 0: frozen, 1: active and being placed in the job pool. |
| `activeText` | integer | Friendly text version of active |
| `initialQuote` | number | The retail quoted price for the initial service on this subscription. |
| `initialDiscount` | number | The discount to be applied to the initial service |
| `initialServiceTotal` | number | The net amount of initialQuote-initialDiscount. DOES NOT INCLUDE add-ons |
| `yifDiscount` | number | The discount provided if paying for a year in advance |
| `recurringCharge` | number | A shortcut for the subtotal of the recurring ticket |
| `contractValue` | number | Calculated as the initial total + the number of recurring services*recurringCharge. There are some tweaks available for different companies / preferences, particularly when dealing with recurring billing. |
| `annualRecurringValue` | number | Calculated as the recurringCharge * the number of services/year. |
| `billingFrequency` | integer | How often this subscription gets their invoice generated -- can be seperate from when their service takes place. 0 / -1 represents getting billed after each service. |
| `frequency` | integer | The frequency that the services get scheduled. -1 represents One-Time, 0 represents 'as needed'. Greater than 0 represents the frequency in days. If it is divisible by 30, it is converted to months -- so 90 would represent 3 months and not necessarily 90 days. |
| `followupService` | integer | How many days after the initial service to schedule the first recurring service. |
| `agreementLength` | number | Agreement Length |
| `nextService` | string | When the next service is due. |
| `lastCompleted` | string | When the last service was completed |
| `serviceID` | integer | The service type ID for the regular recurring services |
| `serviceType` | string | Friendly description of the serviceID |
| `soldBy` | integer | The employee ID who gets credit for this sale. Defaults to the user who added the subscription |
| `soldBy2` | integer | Additional employeeID that gets credit for this sale |
| `soldBy3` | integer | Additional employeeID that gets credit for this sale |
| `preferredTech` | integer | preferred tech ID |
| `addedBy` | integer | The employee ID that added the subscription |
| `initialAppointmentID` | integer | The initial service appointment ID |
| `initialStatus` | integer | A shortcut for the status of the initial appointment |
| `initialStatusText` | string | Friendly text version of the initialStatus |
| `dateCancelled` | string | The date the subscription was cancelled if any. |
| `dateUpdated` | string | The date the subscription was last updated. |
| `cxlNotes` | string | The notes associated with cancelling this appointment. Group_Concat'ed in case of multiple cancellations |
| `subscriptionLink` | string | Subscription Link |
| `poNumber` | string | Subscription poNumber |
| `appointmentIDs` | integer | Every appointment attached to this subscription |
| `completedAppointmentIDs` | integer | Every completed appointment attached to this subscription |
| `initialAppointment` | object | The initial appointment object if includeInitialAppointments = true |
| `recurringTicket` | object | The recurring ticket template associated with this subscription |
| `addOns` | string | An array of Add-On objects associated with the INITIAL appointment. |
| `leadID` | integer | Primary key for lead |
| `leadDateAdded` | string | Time that this lead was created |
| `leadUpdated` | string | Time that this lead was last updated |
| `leadAddedBy` | integer | employeeID that created this lead |
| `leadSourceID` | integer | Lead Source ID |
| `leadSource` | string | Lead Source Description |
| `leadStatus` | integer | Lead Status |
| `leadStatusText` | string | Lead Status Text |
| `leadStageID` | integer | Lead Stage ID |
| `leadStage` | string | Lead Stage Description |
| `leadAssignedTo` | integer | EmployeeID to whom the lead is assigned |
| `leadDateAssigned` | string | Time the lead was assigned |
| `leadValue` | number | Value of the lead |
| `leadDateClosed` | string | Time the lead was closed |
| `leadLostReason` | string | Lead Lost Reason ID |
| `leadLostReasonText` | string | Lead Lost Reason |
| `sourceID` | integer | Subscription Source ID |
| `source` | string | Subscription Source Description |
| `annualRecurringServices` | integer | Services per year without counting initial |
| `unitIDs` | integer | An array of unit IDs available for this subscription (for multi unit customers) - defaults to all unless specific units have been selected |
| `regionID` | integer | RegionID of the subscription |
| `initialInvoice` | string | When the initial invoice should get generated. INITIAL_COMPLETION = when the initial service is completed. SIGNED_AGREEMENT = when the agreement is signed. INITIAL_BILLING_DATE = on a specified billing date. |
| `initialBillingDate` | string | The date to generate initial invoice when initialInvoice = INITIAL_BILLING_DATE |
| `renewalFrequency` | integer | How often a subscription is due for renewal. |
| `renewalDate` | string | Next renewal date |
| `customDate` | string | custom next appointment date |
| `sentriconConnected` | integer | Set as 1 if the subscription is connected to sentricon |
| `sentriconSiteID` | string | Sentricon Site ID or null if not connected to Sentricon |
| `seasonalStart` | string | Date the season starts or 0000-00-00 if it is not a seasonal subscription |
| `seasonalEnd` | string | Date the season ends or 0000-00-00 if it is not a seasonal subscription |
| `nextBillingDate` | string | Next billing date for the subscription |
| `maxMonthlyCharge` | number | Max monthly charge for the subscription |
| `expirationDate` | string | Expiration Date for the subscription. |
| `lastAppointment` | string | Last completed appointment associated with the subscription |
| `templateType` | string | The template type associated with the service type |
| `parentID` | integer | The subscriptionID of the service plan that the service round belongs to |
| `duration` | string | Default duration of services in minutes |
| `preferredDays` | integer | Empty String no preference, 0-Sunday, 1-Monday, 2-Tuesday, 3-Wednesday, 4-Thursday, 5-Friday, 6-Saturday |
| `preferredStart` | string | Preferred appointment start time bound |
| `preferredEnd` | string | Preferred appointment end time bound |
| `callAhead` | integer | int in minutes |

### `/subscription/create`

create a subscription

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionLink` | string |  | Subscription Link for import |
| `serviceID` | integer | Yes | The service type ID for the regular recurring services |
| `customerID` | integer | Yes | Customer ID which this subscription belongs to |
| `billToAccountID` | integer |  | Billing Account which this subscription belongs to |
| `active` | integer |  | 0: frozen, 1: active and being placed in the job pool. |
| `billingFrequency` | integer |  | Frequency that an invoice is generated for this service. -1/0 |
| `frequency` | integer |  | The frequency that the services get scheduled. -1 represents One-Time, 0 represents 'as needed'. Greater than 0 represents the frequency in days. If it is divisible by 30, it is converted to months -- so 90 would represent 3 months and not necessarily 90 days. |
| `seasonalStart` | string |  | Seasonal Start |
| `seasonalEnd` | string |  | Seasonal End |
| `followupDelay` | integer |  | How many days after the initial service to schedule the first recurring service. Set as -1 to use frequency |
| `agreementLength` | integer |  | Agreement Length |
| `preferredTech` | integer |  | The employee ID of the preferred tech - 0 for no preference |
| `preferredDays` | integer |  | Preferred appointment day (0-SUN, 1-MON, 2-TUE, 3-WED, 4-THU, 5-FRI, 6-SAT) |
| `preferredStart` | string |  | Preferred appointment start time window in local time e.g. 00:00:00 |
| `preferredEnd` | string |  | Preferred appointment end time window in local time e.g. 14:30:00 |
| `sourceID` | integer |  | Subscription Source ID |
| `regionID` | integer |  | RegionID of the subscription |
| `renewalFrequency` | integer |  | How often a subscription is due for renewal. |
| `renewalDate` | string |  | Next renewal date |
| `customDate` | string |  | Custom next appointment date for the subscription. |
| `customScheduleID` | integer |  | ID of a pre-defined custom-schedule for services. frequency will be set to -3. |
| `nextBillingDate` | string |  | Next billing date for the subscription |
| `duration` | integer |  | The default duration in minutes for the appointment. Set to -1 to inherit from the service type. |
| `leadValue` | number |  | Value of the lead |
| `expirationDate` | integer |  | Expiration date of the subscription |
| `addedBy` | integer |  | The employee ID that added the subscription |
| `dateCancelled` | string |  | Date the subscription was cancelled |
| `billingTermsDays` | integer |  | Net Billing Days |
| `poNumber` | string |  | subscription poNumber |
| `callAhead` | integer |  | int in minutes |
| `soldBy` | integer |  | The employee ID who gets credit for this sale. Defaults to the user who added the subscription |
| `soldBy2` | integer |  | Additional employeeID that gets credit for this sale |
| `soldBy3` | integer |  | Additional employeeID that gets credit for this sale |
| `convertToLead` | integer |  | Automatically convert the subscription to a lead following the request |
| `serviceCharge` | integer |  | Amount that will be charged each service. To edit this after create use ticket/update with the subscriptionID and templateType=R |
| `addons` | object |  | Array of ticket addon objects, see ticket/createAddon for parameters. To edit this after create use ticket/update with the subscriptionID and templateType=R |
| `initialCharge` | integer |  | Amount that will be charged on the initial service. To edit this after create use ticket/update with the subscriptionID and templateType=I |
| `initialAddons` | object |  | Array of ticket addon objects, see ticket/createAddon for parameters. To edit this after create use ticket/update with the subscriptionID and templateType=I |
| `initialInvoice` | string |  | When the initial invoice should get generated. INITIAL_COMPLETION = when the initial service is completed. SIGNED_AGREEMENT = when the agreement is signed. INITIAL_BILLING_DATE = on a specified billing date. |

### `/subscription/createInitialAddOn`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionID` | integer | Yes | Foreign key to subscriptions table. |
| `productID` | integer | Yes | Foreign key to products table. |
| `serviceID` | integer |  | Foreign key to serviceTypes table. |
| `amount` | number | Yes | Amount to charge for this addon. |
| `quantity` | integer |  | The number of items. Defaults to 1. |
| `taxable` | integer |  | 1- tax 0 - no tax; Defaults to the value specified for serviceTaxable on initial ticket. |
| `creditTo` | integer |  | The employee who will receive credit for selling the add-on for commissions. Defaults to creditTo on Service Subscription. |
| `description` | string |  | Customer facing text for item. |

### `/subscription/delete`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionID` | integer | Yes | Primary key to subscriptions table. |

### `/subscription/deleteInitialAddOn`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionID` | integer | Yes | Foreign key to subscriptions table. |
| `addOnID` | integer | Yes | Foreign key to initialAddons table. |

### `/subscription/get`

Get Bulk data for subscription. Accepts an array of subscriptionIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionIDs` | array |  |  |
| `includeCancellationReason` | int |  | Send as 1 to retrieve an array of cancellationNotes associated with the subscription. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `subscriptionID` | integer | Unique ID |
| `customerID` | integer | Customer ID which this subscription belongs to |
| `billToAccountID` | integer | Billing Account which this subscription belongs to |
| `officeID` | integer | Office ID which this subscription belongs to |
| `dateAdded` | string | Date this subscription was added / created. Sold date. |
| `contractAdded` | string | Date the last contract was added / created. |
| `active` | integer | 0: frozen, 1: active and being placed in the job pool. |
| `activeText` | integer | Friendly text version of active |
| `initialQuote` | number | The retail quoted price for the initial service on this subscription. |
| `initialDiscount` | number | The discount to be applied to the initial service |
| `initialServiceTotal` | number | The net amount of initialQuote-initialDiscount. DOES NOT INCLUDE add-ons |
| `yifDiscount` | number | The discount provided if paying for a year in advance |
| `recurringCharge` | number | A shortcut for the subtotal of the recurring ticket |
| `contractValue` | number | Calculated as the initial total + the number of recurring services*recurringCharge. There are some tweaks available for different companies / preferences, particularly when dealing with recurring billing. |
| `annualRecurringValue` | number | Calculated as the recurringCharge * the number of services/year. |
| `billingFrequency` | integer | How often this subscription gets their invoice generated -- can be seperate from when their service takes place. 0 / -1 represents getting billed after each service. |
| `frequency` | integer | The frequency that the services get scheduled. -1 represents One-Time, 0 represents 'as needed'. Greater than 0 represents the frequency in days. If it is divisible by 30, it is converted to months -- so 90 would represent 3 months and not necessarily 90 days. |
| `followupService` | integer | How many days after the initial service to schedule the first recurring service. |
| `agreementLength` | number | Agreement Length |
| `nextService` | string | When the next service is due. |
| `lastCompleted` | string | When the last service was completed |
| `serviceID` | integer | The service type ID for the regular recurring services |
| `serviceType` | string | Friendly description of the serviceID |
| `soldBy` | integer | The employee ID who gets credit for this sale. Defaults to the user who added the subscription |
| `soldBy2` | integer | Additional employeeID that gets credit for this sale |
| `soldBy3` | integer | Additional employeeID that gets credit for this sale |
| `preferredTech` | integer | preferred tech ID |
| `addedBy` | integer | The employee ID that added the subscription |
| `initialAppointmentID` | integer | The initial service appointment ID |
| `initialStatus` | integer | A shortcut for the status of the initial appointment |
| `initialStatusText` | string | Friendly text version of the initialStatus |
| `dateCancelled` | string | The date the subscription was cancelled if any. |
| `dateUpdated` | string | The date the subscription was last updated. |
| `cxlNotes` | string | The notes associated with cancelling this appointment. Group_Concat'ed in case of multiple cancellations |
| `subscriptionLink` | string | Subscription Link |
| `poNumber` | string | Subscription poNumber |
| `appointmentIDs` | integer | Every appointment attached to this subscription |
| `completedAppointmentIDs` | integer | Every completed appointment attached to this subscription |
| `initialAppointment` | object | The initial appointment object if includeInitialAppointments = true |
| `recurringTicket` | object | The recurring ticket template associated with this subscription |
| `addOns` | string | An array of Add-On objects associated with the INITIAL appointment. |
| `leadID` | integer | Primary key for lead |
| `leadDateAdded` | string | Time that this lead was created |
| `leadUpdated` | string | Time that this lead was last updated |
| `leadAddedBy` | integer | employeeID that created this lead |
| `leadSourceID` | integer | Lead Source ID |
| `leadSource` | string | Lead Source Description |
| `leadStatus` | integer | Lead Status |
| `leadStatusText` | string | Lead Status Text |
| `leadStageID` | integer | Lead Stage ID |
| `leadStage` | string | Lead Stage Description |
| `leadAssignedTo` | integer | EmployeeID to whom the lead is assigned |
| `leadDateAssigned` | string | Time the lead was assigned |
| `leadValue` | number | Value of the lead |
| `leadDateClosed` | string | Time the lead was closed |
| `leadLostReason` | string | Lead Lost Reason ID |
| `leadLostReasonText` | string | Lead Lost Reason |
| `sourceID` | integer | Subscription Source ID |
| `source` | string | Subscription Source Description |
| `annualRecurringServices` | integer | Services per year without counting initial |
| `unitIDs` | integer | An array of unit IDs available for this subscription (for multi unit customers) - defaults to all unless specific units have been selected |
| `regionID` | integer | RegionID of the subscription |
| `initialInvoice` | string | When the initial invoice should get generated. INITIAL_COMPLETION = when the initial service is completed. SIGNED_AGREEMENT = when the agreement is signed. INITIAL_BILLING_DATE = on a specified billing date. |
| `initialBillingDate` | string | The date to generate initial invoice when initialInvoice = INITIAL_BILLING_DATE |
| `renewalFrequency` | integer | How often a subscription is due for renewal. |
| `renewalDate` | string | Next renewal date |
| `customDate` | string | custom next appointment date |
| `sentriconConnected` | integer | Set as 1 if the subscription is connected to sentricon |
| `sentriconSiteID` | string | Sentricon Site ID or null if not connected to Sentricon |
| `seasonalStart` | string | Date the season starts or 0000-00-00 if it is not a seasonal subscription |
| `seasonalEnd` | string | Date the season ends or 0000-00-00 if it is not a seasonal subscription |
| `nextBillingDate` | string | Next billing date for the subscription |
| `maxMonthlyCharge` | number | Max monthly charge for the subscription |
| `expirationDate` | string | Expiration Date for the subscription. |
| `lastAppointment` | string | Last completed appointment associated with the subscription |
| `templateType` | string | The template type associated with the service type |
| `parentID` | integer | The subscriptionID of the service plan that the service round belongs to |
| `duration` | string | Default duration of services in minutes |
| `preferredDays` | integer | Empty String no preference, 0-Sunday, 1-Monday, 2-Tuesday, 3-Wednesday, 4-Thursday, 5-Friday, 6-Saturday |
| `preferredStart` | string | Preferred appointment start time bound |
| `preferredEnd` | string | Preferred appointment end time bound |
| `callAhead` | integer | int in minutes |

### `/subscription/getInitialAddOns`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionID` | integer | Yes | Foreign key to subscriptions table. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `addOnID` | integer | Primary Key ticketItems.itemID |
| `subscriptionID` | integer | Foreign key to subscriptions table. |
| `productID` | integer | Foreign key to products table. |
| `amount` | number | Amount to charge for this addon. |
| `description` | string | Friendly description of the product. |
| `quantity` | integer | The number of items. |
| `taxable` | integer | 1- tax 0 - no tax |
| `creditTo` | integer | Employee who sold the add-on |

### `/subscription/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  |  |
| `active` | integer |  | Default: (0,1). 0: Frozen and no longer being placed in the job pool, 1: Active, -3: Lead |
| `customerIDs` | integer |  | Customer who owns this subcscription |
| `subscriptionIDs` | integer |  | Unique Identifier for this Subscription |
| `soldBy` | integer |  | The user who is being credited for this sale. Used in stats and commissions reporting |
| `preferredTech` | integer |  | The employee ID of the preferred tech |
| `dateAdded` | string |  | Date this subscription was created / added / sold |
| `dateCancelled` | string |  | Date this subscription was cancelled |
| `dateUpdated` | string |  | Last date that something was changed on this subscription. |
| `serviceType` | integer |  | The recurring service type to be scheduled for this subscription |
| `serviceID` | integer |  | The recurring service type to be scheduled for this subscription |
| `frequency` | integer |  | The service frequency of this subscription. &gt;0: The number of days, if it is divisible by 30 it is the number of months, -3: Custom Schedule |
| `dueDate` | string |  | When this subscription is due for their next service |
| `lastCompleted` | string |  | When the last service was completed |
| `dateUpdatedStart` | string |  |  |
| `dateUpdatedEnd` | string |  |  |
| `dateAddedStart` | string |  |  |
| `dateAddedEnd` | string |  |  |
| `contractIDs` | integer |  | The contract ID signed for the subscription |
| `leadDateClosed` | string |  | The date the lead was closed |
| `leadDateAssigned` | string |  | The date the lead was assigned |
| `leadStageID` | integer |  | The stageID of the lead |
| `leadAssignedTo` | integer |  | The employeeID the lead was assigned to |
| `leadAddedBy` | integer |  | The employeeID who added the lead |
| `leadDateAdded` | string |  | The date the lead was added |
| `leadUpdated` | string |  | The date the lead was last updated |
| `leadSourceID` | integer |  | The sourceID of the lead |
| `sourceID` | integer |  | The sourceID of the subscription |
| `nextService` | string |  | The date that the next service is due |
| `regionID` | integer |  | RegionID of the subscription |
| `lastRegularServiceDate` | string |  | Date for last service of subscription type |
| `lastRegularServiceStatus` | integer |  | Last regular service status |
| `sentriconConnected` | integer |  | Set as 1 if the subscription is connected to sentricon |
| `sentriconSiteID` | string |  | Sentricon Site ID or null if not connected to Sentricon |
| `nextBillingDate` | string |  | Next billing date for the subscription |
| `parentID` | integer |  |  |
| `templateType` | string |  | The template type associated with the service type |
| `lastAppointment` | string |  | Last appointment of the subscription |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property subscriptionIDsNoDataExported will specify the items that are not included in the resolved subscription array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `subscriptionIDs` | array |  |

### `/subscription/setInitialAddOns`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionID` | integer | Yes | Foreign key to subscriptions table. |
| `addons` | array |  | Addon Entity - see createInitialAddOn params |

### `/subscription/update`

Update subscription details

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionLink` | string |  | Subscription Link for import |
| `serviceID` | integer |  | The service type ID for the regular recurring services |
| `customerID` | integer |  | Customer ID which this subscription belongs to |
| `billToAccountID` | integer |  | Billing Account which this subscription belongs to |
| `active` | integer |  | 0: frozen, 1: active and being placed in the job pool. |
| `billingFrequency` | integer |  | Frequency that an invoice is generated for this service. -1/0 |
| `frequency` | integer |  | The frequency that the services get scheduled. -1 represents One-Time, 0 represents 'as needed'. Greater than 0 represents the frequency in days. If it is divisible by 30, it is converted to months -- so 90 would represent 3 months and not necessarily 90 days. |
| `seasonalStart` | string |  | Seasonal Start |
| `seasonalEnd` | string |  | Seasonal End |
| `followupDelay` | integer |  | How many days after the initial service to schedule the first recurring service. Set as -1 to use frequency |
| `agreementLength` | integer |  | Agreement Length |
| `preferredTech` | integer |  | The employee ID of the preferred tech - 0 for no preference |
| `preferredDays` | integer |  | Preferred appointment day (0-SUN, 1-MON, 2-TUE, 3-WED, 4-THU, 5-FRI, 6-SAT) |
| `preferredStart` | string |  | Preferred appointment start time window in local time e.g. 00:00:00 |
| `preferredEnd` | string |  | Preferred appointment end time window in local time e.g. 14:30:00 |
| `sourceID` | integer |  | Subscription Source ID |
| `regionID` | integer |  | RegionID of the subscription |
| `renewalFrequency` | integer |  | How often a subscription is due for renewal. |
| `renewalDate` | string |  | Next renewal date |
| `customDate` | string |  | Custom next appointment date for the subscription. |
| `customScheduleID` | integer |  | ID of a pre-defined custom-schedule for services. frequency will be set to -3. |
| `nextBillingDate` | string |  | Next billing date for the subscription |
| `duration` | integer |  | The default duration in minutes for the appointment. Set to -1 to inherit from the service type. |
| `leadValue` | number |  | Value of the lead |
| `expirationDate` | integer |  | Expiration date of the subscription |
| `addedBy` | integer |  | The employee ID that added the subscription |
| `dateCancelled` | string |  | Date the subscription was cancelled |
| `billingTermsDays` | integer |  | Net Billing Days |
| `poNumber` | string |  | subscription poNumber |
| `callAhead` | integer |  | int in minutes |
| `soldBy` | integer |  | The employee ID who gets credit for this sale. Defaults to the user who added the subscription |
| `soldBy2` | integer |  | Additional employeeID that gets credit for this sale |
| `soldBy3` | integer |  | Additional employeeID that gets credit for this sale |
| `convertToLead` | integer |  | Automatically convert the subscription to a lead following the request |
| `initialInvoice` | string |  | When the initial invoice should get generated. INITIAL_COMPLETION = when the initial service is completed. SIGNED_AGREEMENT = when the agreement is signed. INITIAL_BILLING_DATE = on a specified billing date. |
| `subscriptionID` | integer | Yes | Primary key to the tickets table. |

### `/subscription/updateInitialAddOn`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionID` | integer | Yes | Foreign key to subscriptions table. |
| `productID` | integer | Yes | Foreign key to products table. |
| `serviceID` | integer |  | Foreign key to serviceTypes table. |
| `amount` | number | Yes | Amount to charge for this addon. |
| `quantity` | integer |  | The number of items. Defaults to 1. |
| `taxable` | integer |  | 1- tax 0 - no tax; Defaults to the value specified for serviceTaxable on initial ticket. |
| `creditTo` | integer |  | The employee who will receive credit for selling the add-on for commissions. Defaults to creditTo on Service Subscription. |
| `description` | string |  | Customer facing text for item. |
| `addOnID` | integer | Yes | Foreign key to ticketItems table. Retrieve via getInitialAddons(subscriptionID). |

### `/subscription/updateLeadStage`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `subscriptionID` | integer | Yes | Foreign key to subscriptions table. |
| `subscriptionLink` | integer |  | Alternative to subscriptionID. This is the "SubscriptionID" sent during an API insert through import/main. |
| `stageID` | integer |  | Lead stage ID. |
| `status` | integer |  | 0 - Convert To Lead, 1 - Convert to subscription (lead won) |
| `lostReason` | integer |  | Lead Lost Reason |

## task

### `/task/[id]`

Get task data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `taskIDs` | integer | Primary key. |
| `officeID` | integer | officeID of the task |
| `customerID` | integer | customerID the task is related to |
| `addedBy` | integer | EmployeeID who created the task |
| `assignedTo` | integer | EmployeeID the task is assigned to |
| `completedBy` | integer | EmployeeID who completed the task |
| `type` | integer | Type of task: 0 - Alert, 1 - Task |
| `dueDate` | string | Time the task or alert is due. |
| `dateAdded` | string | Time the task or alert was added. |
| `dateCompleted` | string | Time the task was completed |
| `category` | integer | Category ID of the task. |
| `categoryDescription` | integer | Category text of the task. |
| `task` | string | Text description of the task. |
| `completionNotes` | string | Completion notes for the task. |
| `referenceID` | integer | ReferenceID for the task. (e.g. subscriptionID that it relates to) |
| `phone` | string | Phone number associated with the task |
| `dateUpdated` | string | Time the task was last updated. |
| `status` | string | Status of the task. (0-Pending, 1-Completed, 2-In Use, 3-Urgent) |

### `/task/create`

Create a new task or alert.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `type` | integer | Yes | 0: task, 1: alert |
| `customerID` | integer | Yes | CustomerID the task pertains to |
| `referenceID` | integer |  | SubscriptionID the task pertains to |
| `phone` | string |  | Phone number for the task |
| `category` | integer |  | categoryID of the task values: Appt Status (15), Billing (1), Customer Care (10), Customer Status (13), Feedback (7), Follow Up (5), Office (6), Reminder Reply (9), Sales (11), Scheduling (2), Service (4), SMS Reply (12), Subscription Status (14), Tech Flag (8), Voice Mail (3) |
| `addedBy` | integer |  | EmployeeID who added the task or alert |
| `assignedTo` | integer |  | EmployeeID the task is assigned to |
| `dueDate` | string |  | Date the task is due |
| `task` | string |  | Text description of the task |
| `status` | integer |  | 0: Pending, 1: Completed, 2: In Use, 3: Urgent, -1: Deleted |
| `dateCompleted` | string |  |  |
| `completedBy` | integer |  |  |
| `completionNotes` | integer |  |  |

### `/task/get`

Get Bulk data for task. Accepts an array of taskIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `taskIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `taskIDs` | integer | Primary key. |
| `officeID` | integer | officeID of the task |
| `customerID` | integer | customerID the task is related to |
| `addedBy` | integer | EmployeeID who created the task |
| `assignedTo` | integer | EmployeeID the task is assigned to |
| `completedBy` | integer | EmployeeID who completed the task |
| `type` | integer | Type of task: 0 - Alert, 1 - Task |
| `dueDate` | string | Time the task or alert is due. |
| `dateAdded` | string | Time the task or alert was added. |
| `dateCompleted` | string | Time the task was completed |
| `category` | integer | Category ID of the task. |
| `categoryDescription` | integer | Category text of the task. |
| `task` | string | Text description of the task. |
| `completionNotes` | string | Completion notes for the task. |
| `referenceID` | integer | ReferenceID for the task. (e.g. subscriptionID that it relates to) |
| `phone` | string | Phone number associated with the task |
| `dateUpdated` | string | Time the task was last updated. |
| `status` | string | Status of the task. (0-Pending, 1-Completed, 2-In Use, 3-Urgent) |

### `/task/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `taskIDs` | integer |  | Primary key. |
| `officeID` | integer |  |  |
| `officeIDs` | integer |  |  |
| `customerID` | integer |  | CustomerID the task relates to. |
| `addedBy` | integer |  | EmployeeID who created the task |
| `assignedTo` | integer |  | EmployeeID the task is assigned to |
| `completedBy` | integer |  | EmployeeID who completed the task |
| `type` | integer |  | Type of task: 0 - Task, 1 - Alert |
| `dueDate` | string |  | Time the task or alert is due. |
| `dateAdded` | string |  | Time the task or alert was added. |
| `category` | integer |  | Category ID of the task |
| `referenceID` | integer |  | ReferenceID for the task. (e.g. subscriptionID that it relates to) |
| `phone` | string |  | Phone number associated with the task |
| `dateUpdated` | string |  | Time the task was last updated. |
| `status` | integer |  | Status of the task. (0-Pending, 1-Completed, 2-In Use, 3-Urgent) |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property taskIDsNoDataExported will specify the items that are not included in the resolved task array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `taskIDs` | array |  |

### `/task/update`

Update a task.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `type` | integer |  | 0: task, 1: alert |
| `customerID` | integer |  | CustomerID the task pertains to |
| `referenceID` | integer |  | SubscriptionID the task pertains to |
| `phone` | string |  | Phone number for the task |
| `category` | integer |  | categoryID of the task values: Appt Status (15), Billing (1), Customer Care (10), Customer Status (13), Feedback (7), Follow Up (5), Office (6), Reminder Reply (9), Sales (11), Scheduling (2), Service (4), SMS Reply (12), Subscription Status (14), Tech Flag (8), Voice Mail (3) |
| `addedBy` | integer |  | EmployeeID who added the task or alert |
| `assignedTo` | integer |  | EmployeeID the task is assigned to |
| `dueDate` | string |  | Date the task is due |
| `task` | string |  | Text description of the task |
| `status` | integer |  | 0: Pending, 1: Completed, 2: In Use, 3: Urgent, -1: Deleted |
| `dateCompleted` | string |  |  |
| `completedBy` | integer |  |  |
| `completionNotes` | integer |  |  |
| `taskID` | integer | Yes | Primary key to the task table. |

## team

### `/team/[id]`

Get team data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `teamID` | integer | Unique Identifier |
| `officeID` | integer | Office ID this team belongs to |
| `name` | string | Team name |
| `teamLeader` | integer | Team Leader ID |
| `employeeIDs` | integer | Employee IDs of team members |

### `/team/get`

Get Bulk data for team. Accepts an array of teamIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `teamIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `teamID` | integer | Unique Identifier |
| `officeID` | integer | Office ID this team belongs to |
| `name` | string | Team name |
| `teamLeader` | integer | Team Leader ID |
| `employeeIDs` | integer | Employee IDs of team members |

### `/team/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `teamID` | integer |  | Unique Identifier |
| `officeIDs` | integer |  |  |
| `name` | string |  | Team Name |
| `type` | integer |  | Team type. 0: Office Team, 2: Sales Team |
| `teamLeader` | integer |  | Employee ID of the team leader |
| `employeeIDs` | integer |  | Employee IDs of team members |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property teamIDsNoDataExported will specify the items that are not included in the resolved team array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `teamIDs` | array |  |

## ticket

### `/ticket/[id]`

Get ticket data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `ticketID` | integer | Unique ID |
| `customerID` | integer | Customer ID which this subscription belongs to |
| `billToAccountID` | integer | Billing Account which this subscription belongs to |
| `officeID` | integer | Office ID which this subscription belongs to |
| `dateCreated` | string | Date this ticket was added / created. |
| `invoiceDate` | string | Invoice date |
| `dateUpdated` | string | The date the ticket was updated |
| `active` | integer | 0: pending, 1: active and counts towards customer's outstanding balance, -1: a ticket template. |
| `subTotal` | number | Subtotal = serviceCharge + sum of line items |
| `taxAmount` | number | Total calculated tax |
| `total` | number | Subtotal + total |
| `serviceCharge` | number | Base charge for this ticket. |
| `serviceTaxable` | integer | Whether or not the base service charge for this ticket is taxable (1) or not (0) |
| `productionValue` | number | Value for reporting / commission purposes. -1: Same as subTotal, &gt;= 0: different from subtotal |
| `taxRate` | number | The tax rate associated with this ticket. |
| `appointmentID` | integer | If this ticket is attached to an appointment it will show here |
| `balance` | number | Any unpaid balance left on this ticket |
| `subscriptionID` | integer | ONLY CONTAINS A VALUE WHEN THIS IS A TEMPLATE for a particular subscription. These should never be active |
| `autoGenerated` | integer | The subscription ID that generated this ticket when it was part of recurring billing, from a renewal or for the initial service if the initial invoice does not get generated at the time of service completion. |
| `autoGeneratedType` | string | Indicates if the invoice was create as part of the recurring billing schedule, for a subscription renewal or is the initial invoice when the initial invoice is not created at the time of service completion. INITIAL = initial invoice, RECURRING = recurring billing invoice, RENEWAL = renewal invoice. |
| `renewalID` | integer | The subscription ID that generated this ticket when it was part of a renewal |
| `serviceID` | integer | Ticket service type |
| `items` | string | An array of line items associated with this ticket |
| `invoiceNumber` | string | The displayed Invoice # |
| `templateType` | string | The ticket template type. I: initial ticket template, R: recurring ticket template, NA: not a ticket template. |
| `glNumber` | string | glNumber of the ticket |
| `createdBy` | string | employeeID who created the Ticket |

### `/ticket/create`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer | Yes | Foreign key to customers table. |
| `subscriptionID` | integer | Yes | Foreign key to subscription table. |
| `serviceID` | integer | Yes | Foreign key to serviceTypes table. |
| `serviceTaxable` | integer |  | 1- tax 0 - no tax; Defaults to the value specified for given serviceID. |
| `date` | string | Yes | Date this invoice should be applied |
| `billToAccountID` | integer |  | Foreign key to customers table. |
| `serviceCharge` | number | Yes | Value in USD. |
| `additionalNotes` | string |  | Add notes about the invoice. |
| `status` | string |  | 0 = not active, 1 = active, -1 = ticket template, -3 = lead |
| `templateType` | string |  | R = recurring, I = initial, NA = not applicable/not a template |
| `productionValue` | number |  | Production value for this ticket. |
| `addons` | array |  | Array of ticket addon objects, see ticket/createAddon. Send as empty array or false to unset. |

### `/ticket/createAddOn`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `ticketID` | integer | Yes | Foreign key to tickets table. Retrieve via getAddons(subscriptionID). |
| `description` | string |  | Customer Facing text for item. |
| `quantity` | integer |  | Number of products or services to add. |
| `amount` | number | Yes | Charge Amount for item. |
| `productID` | integer |  | Foreign key to products table. |
| `serviceID` | integer |  | Foreign key to services Table. |
| `taxable` | integer | Yes | 0 for untaxable, 1 for taxable. Items with negative amounts cannot be taxable. |
| `creditTo` | integer |  | Foreign key to employees table. |
| `unitID` | integer |  | Foreign key to unit table (if applicable for unit specific addons on multi-unit customers) |

### `/ticket/delete`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `ticketID` | integer | Yes | Primary key to tickets table. |

### `/ticket/deleteAddOn`

Delete a ticketItem from the given ticketID.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `ticketID` | integer | Yes | Foreign key to subscriptions table. |
| `itemID` | integer | Yes | Foreign key to ticketItems table. Retrieve via getAddons(subscriptionID). |

### `/ticket/get`

Get Bulk data for ticket. Accepts an array of ticketIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `ticketIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `ticketID` | integer | Unique ID |
| `customerID` | integer | Customer ID which this subscription belongs to |
| `billToAccountID` | integer | Billing Account which this subscription belongs to |
| `officeID` | integer | Office ID which this subscription belongs to |
| `dateCreated` | string | Date this ticket was added / created. |
| `invoiceDate` | string | Invoice date |
| `dateUpdated` | string | The date the ticket was updated |
| `active` | integer | 0: pending, 1: active and counts towards customer's outstanding balance, -1: a ticket template. |
| `subTotal` | number | Subtotal = serviceCharge + sum of line items |
| `taxAmount` | number | Total calculated tax |
| `total` | number | Subtotal + total |
| `serviceCharge` | number | Base charge for this ticket. |
| `serviceTaxable` | integer | Whether or not the base service charge for this ticket is taxable (1) or not (0) |
| `productionValue` | number | Value for reporting / commission purposes. -1: Same as subTotal, &gt;= 0: different from subtotal |
| `taxRate` | number | The tax rate associated with this ticket. |
| `appointmentID` | integer | If this ticket is attached to an appointment it will show here |
| `balance` | number | Any unpaid balance left on this ticket |
| `subscriptionID` | integer | ONLY CONTAINS A VALUE WHEN THIS IS A TEMPLATE for a particular subscription. These should never be active |
| `autoGenerated` | integer | The subscription ID that generated this ticket when it was part of recurring billing, from a renewal or for the initial service if the initial invoice does not get generated at the time of service completion. |
| `autoGeneratedType` | string | Indicates if the invoice was create as part of the recurring billing schedule, for a subscription renewal or is the initial invoice when the initial invoice is not created at the time of service completion. INITIAL = initial invoice, RECURRING = recurring billing invoice, RENEWAL = renewal invoice. |
| `renewalID` | integer | The subscription ID that generated this ticket when it was part of a renewal |
| `serviceID` | integer | Ticket service type |
| `items` | string | An array of line items associated with this ticket |
| `invoiceNumber` | string | The displayed Invoice # |
| `templateType` | string | The ticket template type. I: initial ticket template, R: recurring ticket template, NA: not a ticket template. |
| `glNumber` | string | glNumber of the ticket |
| `createdBy` | string | employeeID who created the Ticket |

### `/ticket/getAddOns`

Get Addons for a ticket.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `ticketID` | integer | Yes | Foreign key to tickets table. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `itemID` | integer | Primary key for ticketItems |
| `ticketID` | integer | Foreign key to tickets table. Retrieve via getAddons(subscriptionID). |
| `description` | string | Customer Facing text for item. |
| `quantity` | integer | Number of products or services to add. |
| `amount` | number | Charge Amount for item. |
| `productID` | integer | Foreign key to products table. |
| `serviceID` | integer | Foreign key to services Table. |
| `taxable` | integer | 0 for untaxable, 1 for taxable. Items with negative amounts cannot be taxable. |
| `creditTo` | integer | Foreign key to employees table. |
| `unitID` | integer | Foreign key to unit table (if applicable for unit specific addons on multi-unit customers) |

### `/ticket/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `officeIDs` | integer |  |  |
| `ticketIDs` | integer |  |  |
| `status` | integer |  | Whether this ticket/invoice is active: 1 or inactive: 0. Inactive tickets are not added to the customer's balance or A/R aging |
| `customerIDs` | integer |  | The customer who owns this ticket |
| `recurringTemplateSubscriptionIDs` | integer |  | When a ticket has a recurring template subscription ID it represents a recurring ticket template |
| `dateCreated` | string |  | The date this ticket was created |
| `invoiceDate` | string |  | Invoice date |
| `dateUpdated` | string |  | The date the ticket was updated |
| `balance` | number |  | Any unpaid balance left on this ticket |
| `subTotal` | number |  | Amount of ticket before tax |
| `total` | number |  | Total of invoice including any applicable taxes |
| `taxAmount` | number |  | Amount of tax |
| `appointmentIDs` | integer |  | The appointment this ticket was generated for. Tickets may not always be attached to an appointment. For example in cases of recurring billing or stand alone invoices for administrative fees. |
| `subscriptionIDs` | integer |  | The subscription this ticket was generated for. This is only used for the ticket template which define the price of the subscription setup. |
| `templateType` | string |  | The ticket template type. I: initial ticket template, R: recurring ticket template, NA: not a ticket template. |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property ticketIDsNoDataExported will specify the items that are not included in the resolved ticket array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `ticketIDs` | array |  |

### `/ticket/setAddOns`

Delete all existing addons and set the addons for the specified ticket to the received array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `ticketID` | integer | Yes | Foreign key to subscriptions table. |
| `addons` | array |  | Addon Entity - see createAddOn params |

### `/ticket/update`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `customerID` | integer |  | Foreign key to customers table. |
| `subscriptionID` | integer |  | Foreign key to subscription table. |
| `serviceID` | integer |  | Foreign key to serviceTypes table. |
| `serviceTaxable` | integer |  | 1- tax 0 - no tax; Defaults to the value specified for given serviceID. |
| `date` | string |  | Date this invoice should be applied |
| `billToAccountID` | integer |  | Foreign key to customers table. |
| `serviceCharge` | number |  | Value in USD. |
| `additionalNotes` | string |  | Add notes about the invoice. |
| `status` | string |  | 0 = not active, 1 = active, -1 = ticket template, -3 = lead |
| `templateType` | string |  | R = recurring, I = initial, NA = not applicable/not a template |
| `productionValue` | number |  | Production value for this ticket. |
| `addons` | array |  | If addons are sent with ticket/update a `setAddons` operation will be used. Old addons will be removed and new addons will be created to match the array sent. |
| `ticketID` | integer | Yes | Primary key to the tickets table. |

### `/ticket/updateAddOn`

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `ticketID` | integer | Yes | Foreign key to tickets table. Retrieve via getAddons(subscriptionID). |
| `description` | string |  | Customer Facing text for item. |
| `quantity` | integer |  | Number of products or services to add. |
| `amount` | number |  | Charge Amount for item. |
| `productID` | integer |  | Foreign key to products table. |
| `serviceID` | integer |  | Foreign key to services Table. |
| `taxable` | integer |  | 0 for untaxable, 1 for taxable. Items with negative amounts cannot be taxable. |
| `creditTo` | integer |  | Foreign key to employees table. |
| `unitID` | integer |  | Foreign key to unit table (if applicable for unit specific addons on multi-unit customers) |
| `itemID` | integer | Yes | Primary key to the ticketItems table. |

## ticketItem

### `/ticketItem/[id]`

Get ticketItem data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `itemID` | integer | Unique ID |
| `ticketID` | integer | ticket ID |
| `officeID` | integer | office ID |
| `description` | string | description |
| `quantity` | integer | quantity |
| `amount` | number | amount |
| `productID` | integer | productID |
| `serviceID` | integer | serviceID |
| `taxable` | integer | taxable |
| `creditTo` | integer | creditTo |
| `unitID` | integer | unitID |
| `glNumber` | string | glNumber |
| `measurementSF` | integer | measurementSF |
| `measurementLF` | integer | measurementLF |
| `prepaymentAmount` | integer | prepaymentAmount |
| `category` | string | product category |
| `code` | string | product code |
| `dateCreated` | string | Date this ticketItem was added / created. |
| `dateUpdated` | string | The date the ticketItem was updated |

### `/ticketItem/get`

Get Bulk data for ticketItem. Accepts an array of itemIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `itemIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `itemID` | integer | Unique ID |
| `ticketID` | integer | ticket ID |
| `officeID` | integer | office ID |
| `description` | string | description |
| `quantity` | integer | quantity |
| `amount` | number | amount |
| `productID` | integer | productID |
| `serviceID` | integer | serviceID |
| `taxable` | integer | taxable |
| `creditTo` | integer | creditTo |
| `unitID` | integer | unitID |
| `glNumber` | string | glNumber |
| `measurementSF` | integer | measurementSF |
| `measurementLF` | integer | measurementLF |
| `prepaymentAmount` | integer | prepaymentAmount |
| `category` | string | product category |
| `code` | string | product code |
| `dateCreated` | string | Date this ticketItem was added / created. |
| `dateUpdated` | string | The date the ticketItem was updated |

### `/ticketItem/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `itemIDs` | integer |  |  |
| `officeIDs` | integer |  |  |
| `officeID` | integer |  |  |
| `ticketID` | integer |  |  |
| `ticketIDs` | integer |  |  |
| `productID` | integer |  |  |
| `serviceID` | integer |  |  |
| `glNumber` | integer |  |  |
| `creditTo` | integer |  |  |
| `dateUpdated` | string |  |  |
| `dateCreated` | string |  |  |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property ticketItemIDsNoDataExported will specify the items that are not included in the resolved ticketItem array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `ticketItemIDs` | array |  |

## timeClock

### `/timeClock/[id]`

Get timeClock data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `entryID` | integer | Unique ID |
| `employeeID` | integer | EmployeeID time clock entry applied to |
| `officeID` | integer | officeID the time clock entry was made on |
| `timeIn` | string | Clock-in time in server time (PST) |
| `timeOut` | string | Clock-Out time in server time (PST) |
| `clockCategoryID` | integer | Clock category ID that was used for this entry |
| `paid` | integer | 0 - time clock category is specified as unpaid, 1 - time clock category is specified as paid. If time clock category is specified as 0 or does not exist it is considered a paid entry. |

### `/timeClock/get`

Get Bulk data for timeClock. Accepts an array of entryIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `entryIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `entryID` | integer | Unique ID |
| `employeeID` | integer | EmployeeID time clock entry applied to |
| `officeID` | integer | officeID the time clock entry was made on |
| `timeIn` | string | Clock-in time in server time (PST) |
| `timeOut` | string | Clock-Out time in server time (PST) |
| `clockCategoryID` | integer | Clock category ID that was used for this entry |
| `paid` | integer | 0 - time clock category is specified as unpaid, 1 - time clock category is specified as paid. If time clock category is specified as 0 or does not exist it is considered a paid entry. |

### `/timeClock/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `entryIDs` | integer |  | Primary key. |
| `timeClockIDs` | integer |  | Primary key (alias) |
| `officeIDs` | integer |  |  |
| `employeeIDs` | integer |  | EmployeeID who the time clock entry applies to. |
| `timeIn` | string |  | Clock-in time |
| `timeOut` | string |  | Clock-out time |
| `paid` | integer |  | 0 for unpaid categories, 1 for paid categories. Clock entries with no category association are considered paid. |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property timeClockIDsNoDataExported will specify the items that are not included in the resolved timeClock array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `timeClockIDs` | array |  |

## timeClockCategory

### `/timeClockCategory/[id]`

Get timeClockCategory data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `clockCategoryID` | integer | Primary key. |
| `officeID` | integer |  |
| `visible` | integer | Visible to staff |
| `allowOnClockIn` | integer | time clock category is allowed on initial clock in. |
| `systemReserved` | integer | 1 = system reserved category (cannot be deleted or changed) |
| `paid` | integer | 0 for unpaid categories, 1 for paid categories. Clock entries with no category association are considered paid. |
| `dateUpdated` | string | Date this category was last changed |
| `description` | integer | Description associated with the clock category |

### `/timeClockCategory/get`

Get Bulk data for timeClockCategory. Accepts an array of clockCategoryIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `clockCategoryIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `clockCategoryID` | integer | Primary key. |
| `officeID` | integer |  |
| `visible` | integer | Visible to staff |
| `allowOnClockIn` | integer | time clock category is allowed on initial clock in. |
| `systemReserved` | integer | 1 = system reserved category (cannot be deleted or changed) |
| `paid` | integer | 0 for unpaid categories, 1 for paid categories. Clock entries with no category association are considered paid. |
| `dateUpdated` | string | Date this category was last changed |
| `description` | integer | Description associated with the clock category |

### `/timeClockCategory/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `clockCategoryIDs` | integer |  | Primary key. |
| `timeClockCategoryIDs` | integer |  | Primary key (alias) |
| `officeIDs` | integer |  |  |
| `visible` | integer |  | Visible to staff |
| `allowOnClockIn` | integer |  | time clock category is allowed on initial clock in. |
| `systemReserved` | integer |  | 1 = system reserved category (cannot be deleted or changed) |
| `paid` | integer |  | 0 for unpaid categories, 1 for paid categories. Clock entries with no category association are considered paid. |
| `dateUpdated` | string |  | Date this category was last changed |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property timeClockCategoryIDsNoDataExported will specify the items that are not included in the resolved timeClockCategory array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `timeClockCategoryIDs` | array |  |

## unit

### `/unit/[id]`

Get unit data for single ID -- please provide a specific record ID in the URL structure.

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `unitID` | integer | Unique ID |
| `unitName` | string | Unit name (building + - + description) |
| `building` | string | Unit building |
| `description` | string | Unit description |
| `customerID` | integer | customerID the unit belongs to. |

### `/unit/get`

Get Bulk data for unit. Accepts an array of unitIDs. Returns a max of 1000 records.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `unitIDs` | array |  |  |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `unitID` | integer | Unique ID |
| `unitName` | string | Unit name (building + - + description) |
| `building` | string | Unit building |
| `description` | string | Unit description |
| `customerID` | integer | customerID the unit belongs to. |

### `/unit/search`

Provide a set of parameters which will return a list of ids. There is no limit to the number of IDs this will return. You can then supply these ids to the `get` endpoint in order to retrieve bulk data. Every parameter available supports a simple value OR a powerful query object that gives you access to all basic comparators. Example: dateAdded={"operator":"&gt;","value":"2016-01-01"} Example: dateAdded={"operator\":\"BETWEEN\",\"value\":[\"2016-05-12\",\"2016-05-13\"]} Available operators: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS. Each of the search endpoints allows for an optional parameter 'includeData'. When sent, the API will additionally send the resolved objects for the first 1000 IDs. Keep in mind when using 'includeData' that if there are more than 1000 items an additional property '{entity}IDsNoDataExported' will specify the items that are not included in the resolved data array.

**Parameters**

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `unitIDs` | integer |  | Primary key. |
| `officeIDs` | integer |  |  |
| `customerIDs` | integer |  | Customer who owns this unit |
| `includeData` | integer |  | {0,1} Sends the resolved objects for the first 1000 IDs. If there are more than 1000 items an additional property unitIDsNoDataExported will specify the items that are not included in the resolved unit array. |

**Response**

| Field | Type | Description |
|-------|------|-------------|
| `unitIDs` | array |  |
