# LobbiesV1
(*LobbiesV1*)

## Overview

### Available Operations

* [~~CreatePrivateLobbyDeprecated~~](#createprivatelobbydeprecated) - CreatePrivateLobbyDeprecated :warning: **Deprecated**
* [~~CreatePublicLobbyDeprecated~~](#createpubliclobbydeprecated) - CreatePublicLobbyDeprecated :warning: **Deprecated**
* [~~ListActivePublicLobbiesDeprecatedV1~~](#listactivepubliclobbiesdeprecatedv1) - ListActivePublicLobbiesDeprecatedV1 :warning: **Deprecated**

## ~~CreatePrivateLobbyDeprecated~~

CreatePrivateLobbyDeprecated

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

CreatePrivateLobbyDeprecatedRequest req = new CreatePrivateLobbyDeprecatedRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.LobbiesV1.CreatePrivateLobbyDeprecatedAsync(
    security: new CreatePrivateLobbyDeprecatedSecurity() {
        PlayerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                                                              | Type                                                                                                                                   | Required                                                                                                                               | Description                                                                                                                            |
| -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                              | [CreatePrivateLobbyDeprecatedRequest](../../Models/Operations/CreatePrivateLobbyDeprecatedRequest.md)                                  | :heavy_check_mark:                                                                                                                     | The request object to use for the request.                                                                                             |
| `security`                                                                                                                             | [HathoraCloud.Models.Operations.CreatePrivateLobbyDeprecatedSecurity](../../models/operations/CreatePrivateLobbyDeprecatedSecurity.md) | :heavy_check_mark:                                                                                                                     | The security requirements to use for the request.                                                                                      |

### Response

**[CreatePrivateLobbyDeprecatedResponse](../../Models/Operations/CreatePrivateLobbyDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 402, 404, 422, 429            | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~CreatePublicLobbyDeprecated~~

CreatePublicLobbyDeprecated

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

CreatePublicLobbyDeprecatedRequest req = new CreatePublicLobbyDeprecatedRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.LobbiesV1.CreatePublicLobbyDeprecatedAsync(
    security: new CreatePublicLobbyDeprecatedSecurity() {
        PlayerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                                                            | Type                                                                                                                                 | Required                                                                                                                             | Description                                                                                                                          |
| ------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                            | [CreatePublicLobbyDeprecatedRequest](../../Models/Operations/CreatePublicLobbyDeprecatedRequest.md)                                  | :heavy_check_mark:                                                                                                                   | The request object to use for the request.                                                                                           |
| `security`                                                                                                                           | [HathoraCloud.Models.Operations.CreatePublicLobbyDeprecatedSecurity](../../models/operations/CreatePublicLobbyDeprecatedSecurity.md) | :heavy_check_mark:                                                                                                                   | The security requirements to use for the request.                                                                                    |

### Response

**[CreatePublicLobbyDeprecatedResponse](../../Models/Operations/CreatePublicLobbyDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 402, 404, 422, 429            | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~ListActivePublicLobbiesDeprecatedV1~~

ListActivePublicLobbiesDeprecatedV1

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

ListActivePublicLobbiesDeprecatedV1Request req = new ListActivePublicLobbiesDeprecatedV1Request() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.LobbiesV1.ListActivePublicLobbiesDeprecatedV1Async(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListActivePublicLobbiesDeprecatedV1Request](../../Models/Operations/ListActivePublicLobbiesDeprecatedV1Request.md) | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |

### Response

**[ListActivePublicLobbiesDeprecatedV1Response](../../Models/Operations/ListActivePublicLobbiesDeprecatedV1Response.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 404, 422, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |