# BuildsV1
(*BuildsV1*)

## Overview

### Available Operations

* [~~CreateBuildDeprecated~~](#createbuilddeprecated) - CreateBuildDeprecated :warning: **Deprecated**
* [~~DeleteBuildDeprecated~~](#deletebuilddeprecated) - DeleteBuildDeprecated :warning: **Deprecated**
* [~~GetBuildInfoDeprecated~~](#getbuildinfodeprecated) - GetBuildInfoDeprecated :warning: **Deprecated**
* [~~GetBuildsDeprecated~~](#getbuildsdeprecated) - GetBuildsDeprecated :warning: **Deprecated**
* [~~RunBuildDeprecated~~](#runbuilddeprecated) - RunBuildDeprecated :warning: **Deprecated**

## ~~CreateBuildDeprecated~~

Creates a new [build](https://hathora.dev/docs/concepts/hathora-entities#build). Responds with a `buildId` that you must pass to [`RunBuild()`](https://hathora.dev/api#tag/BuildV1/operation/RunBuild) to build the game server artifact. You can optionally pass in a `buildTag` to associate an external version with a build.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

CreateBuildDeprecatedRequest req = new CreateBuildDeprecatedRequest() {
    CreateBuildParams = new CreateBuildParams() {
        BuildTag = "0.1.14-14c793",
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.BuildsV1.CreateBuildDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [CreateBuildDeprecatedRequest](../../Models/Operations/CreateBuildDeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[CreateBuildDeprecatedResponse](../../Models/Operations/CreateBuildDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~DeleteBuildDeprecated~~

Delete a [build](https://hathora.dev/docs/concepts/hathora-entities#build). All associated metadata is deleted.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

DeleteBuildDeprecatedRequest req = new DeleteBuildDeprecatedRequest() {
    BuildId = 1,
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.BuildsV1.DeleteBuildDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [DeleteBuildDeprecatedRequest](../../Models/Operations/DeleteBuildDeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[DeleteBuildDeprecatedResponse](../../Models/Operations/DeleteBuildDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~GetBuildInfoDeprecated~~

Get details for a [build](https://hathora.dev/docs/concepts/hathora-entities#build).

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

GetBuildInfoDeprecatedRequest req = new GetBuildInfoDeprecatedRequest() {
    BuildId = 1,
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.BuildsV1.GetBuildInfoDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetBuildInfoDeprecatedRequest](../../Models/Operations/GetBuildInfoDeprecatedRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[GetBuildInfoDeprecatedResponse](../../Models/Operations/GetBuildInfoDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~GetBuildsDeprecated~~

Returns an array of [builds](https://hathora.dev/docs/concepts/hathora-entities#build) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

GetBuildsDeprecatedRequest req = new GetBuildsDeprecatedRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.BuildsV1.GetBuildsDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetBuildsDeprecatedRequest](../../Models/Operations/GetBuildsDeprecatedRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetBuildsDeprecatedResponse](../../Models/Operations/GetBuildsDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~RunBuildDeprecated~~

Builds a game server artifact from a tarball you provide. Pass in the `buildId` generated from [`CreateBuild()`](https://hathora.dev/api#tag/BuildV1/operation/CreateBuild).

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

RunBuildDeprecatedRequest req = new RunBuildDeprecatedRequest() {
    RequestBody = new RunBuildDeprecatedRequestBody() {
        File = new File() {
            Content = System.Text.Encoding.UTF8.GetBytes("0x9C4e3B3eB2"),
            FileName = "example.file",
        },
    },
    BuildId = 1,
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.BuildsV1.RunBuildDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [RunBuildDeprecatedRequest](../../Models/Operations/RunBuildDeprecatedRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[RunBuildDeprecatedResponse](../../Models/Operations/RunBuildDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 404, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |