# BillingV1
(*BillingV1*)

### Available Operations

* [GetBalance](#getbalance)
* [GetInvoices](#getinvoices)
* [GetPaymentMethod](#getpaymentmethod)
* [InitStripeCustomerPortalUrl](#initstripecustomerportalurl)

## GetBalance

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

using(var res = await sdk.BillingV1.GetBalanceAsync())
{
    // handle response
}
```


### Response

**[GetBalanceResponse](../../Models/Operations/GetBalanceResponse.md)**


## GetInvoices

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

using(var res = await sdk.BillingV1.GetInvoicesAsync())
{
    // handle response
}
```


### Response

**[GetInvoicesResponse](../../Models/Operations/GetInvoicesResponse.md)**


## GetPaymentMethod

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

using(var res = await sdk.BillingV1.GetPaymentMethodAsync())
{
    // handle response
}
```


### Response

**[GetPaymentMethodResponse](../../Models/Operations/GetPaymentMethodResponse.md)**


## InitStripeCustomerPortalUrl

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

CustomerPortalUrl req = new CustomerPortalUrl() {
    ReturnUrl = "<value>",
};

using(var res = await sdk.BillingV1.InitStripeCustomerPortalUrlAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [CustomerPortalUrl](../../Models/Shared/CustomerPortalUrl.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |


### Response

**[InitStripeCustomerPortalUrlResponse](../../Models/Operations/InitStripeCustomerPortalUrlResponse.md)**

