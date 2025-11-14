# BillingV1
(*BillingV1*)

## Overview

 

### Available Operations

* [~~GetBalance~~](#getbalance) - GetBalance :warning: **Deprecated**
* [GetInvoices](#getinvoices) - GetInvoices
* [GetPaymentMethod](#getpaymentmethod) - GetPaymentMethod
* [GetUpcomingInvoiceItems](#getupcominginvoiceitems) - GetUpcomingInvoiceItems
* [GetUpcomingInvoiceTotal](#getupcominginvoicetotal) - GetUpcomingInvoiceTotal
* [InitStripeCustomerPortalUrl](#initstripecustomerportalurl) - InitStripeCustomerPortalUrl

## ~~GetBalance~~

GetBalance

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetBalance" method="get" path="/billing/v1/balance" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetBalanceRequest req = new GetBalanceRequest() {};


using(var res = await sdk.BillingV1.GetBalanceAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetBalanceRequest](../../Models/Operations/GetBalanceRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetBalanceResponse](../../Models/Operations/GetBalanceResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetInvoices

GetInvoices

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetInvoices" method="get" path="/billing/v1/invoices" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetInvoicesRequest req = new GetInvoicesRequest() {};


using(var res = await sdk.BillingV1.GetInvoicesAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetInvoicesRequest](../../Models/Operations/GetInvoicesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[GetInvoicesResponse](../../Models/Operations/GetInvoicesResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetPaymentMethod

GetPaymentMethod

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetPaymentMethod" method="get" path="/billing/v1/paymentmethod" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetPaymentMethodRequest req = new GetPaymentMethodRequest() {};


using(var res = await sdk.BillingV1.GetPaymentMethodAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetPaymentMethodRequest](../../Models/Operations/GetPaymentMethodRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[GetPaymentMethodResponse](../../Models/Operations/GetPaymentMethodResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetUpcomingInvoiceItems

GetUpcomingInvoiceItems

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetUpcomingInvoiceItems" method="get" path="/billing/v1/upcoming/items" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetUpcomingInvoiceItemsRequest req = new GetUpcomingInvoiceItemsRequest() {};


using(var res = await sdk.BillingV1.GetUpcomingInvoiceItemsAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetUpcomingInvoiceItemsRequest](../../Models/Operations/GetUpcomingInvoiceItemsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[GetUpcomingInvoiceItemsResponse](../../Models/Operations/GetUpcomingInvoiceItemsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetUpcomingInvoiceTotal

GetUpcomingInvoiceTotal

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetUpcomingInvoiceTotal" method="get" path="/billing/v1/upcoming/total" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetUpcomingInvoiceTotalRequest req = new GetUpcomingInvoiceTotalRequest() {};


using(var res = await sdk.BillingV1.GetUpcomingInvoiceTotalAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetUpcomingInvoiceTotalRequest](../../Models/Operations/GetUpcomingInvoiceTotalRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[GetUpcomingInvoiceTotalResponse](../../Models/Operations/GetUpcomingInvoiceTotalResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## InitStripeCustomerPortalUrl

InitStripeCustomerPortalUrl

### Example Usage

<!-- UsageSnippet language="unity" operationID="InitStripeCustomerPortalUrl" method="post" path="/billing/v1/customerportalurl" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

InitStripeCustomerPortalUrlRequest req = new InitStripeCustomerPortalUrlRequest() {
    CustomerPortalUrl = new CustomerPortalUrl() {
        ReturnUrl = "https://sunny-majority.com/",
    },
};


using(var res = await sdk.BillingV1.InitStripeCustomerPortalUrlAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [InitStripeCustomerPortalUrlRequest](../../Models/Operations/InitStripeCustomerPortalUrlRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[InitStripeCustomerPortalUrlResponse](../../Models/Operations/InitStripeCustomerPortalUrlResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |