# ManagementV1
(*ManagementV1*)

### Available Operations

* [SendVerificationEmail](#sendverificationemail)

## SendVerificationEmail

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

VerificationEmailRequest req = new VerificationEmailRequest() {
    UserId = "<value>",
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

