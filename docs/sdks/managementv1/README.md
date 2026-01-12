# ManagementV1

## Overview

 

### Available Operations

* [SendVerificationEmail](#sendverificationemail) - SendVerificationEmail

## SendVerificationEmail

SendVerificationEmail

### Example Usage

<!-- UsageSnippet language="unity" operationID="SendVerificationEmail" method="post" path="/management/v1/sendverificationemail" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK();

VerificationEmailRequest req = new VerificationEmailRequest() {
    UserId = "<id>",
};


using(var res = await sdk.ManagementV1.SendVerificationEmailAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [VerificationEmailRequest](../../Models/Shared/VerificationEmailRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[SendVerificationEmailResponse](../../Models/Operations/SendVerificationEmailResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 408, 429                           | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |