# OrgTokensV1
(*OrgTokensV1*)

### Available Operations

* [CreateOrgToken](#createorgtoken) - Create a new organization token.
* [GetOrgTokens](#getorgtokens) - List all organization tokens for a given org.
* [RevokeOrgToken](#revokeorgtoken) - Revoke an organization token.

## CreateOrgToken

Create a new organization token.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

CreateOrgTokenRequest req = new CreateOrgTokenRequest() {
    CreateOrgToken = new CreateOrgToken() {
        Name = "ci-token",
    },
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
};

using(var res = await sdk.OrgTokensV1.CreateOrgTokenAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreateOrgTokenRequest](../../Models/Operations/CreateOrgTokenRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[CreateOrgTokenResponse](../../Models/Operations/CreateOrgTokenResponse.md)**


## GetOrgTokens

List all organization tokens for a given org.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

GetOrgTokensRequest req = new GetOrgTokensRequest() {
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
};

using(var res = await sdk.OrgTokensV1.GetOrgTokensAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetOrgTokensRequest](../../Models/Operations/GetOrgTokensRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[GetOrgTokensResponse](../../Models/Operations/GetOrgTokensResponse.md)**


## RevokeOrgToken

Revoke an organization token.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

RevokeOrgTokenRequest req = new RevokeOrgTokenRequest() {
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    OrgTokenId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
};

using(var res = await sdk.OrgTokensV1.RevokeOrgTokenAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [RevokeOrgTokenRequest](../../Models/Operations/RevokeOrgTokenRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[RevokeOrgTokenResponse](../../Models/Operations/RevokeOrgTokenResponse.md)**

