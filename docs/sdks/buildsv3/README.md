# BuildsV3
(*BuildsV3*)

## Overview

Operations that allow you create and manage your [builds](https://hathora.dev/docs/concepts/hathora-entities#build).

### Available Operations

* [CreateBuild](#createbuild) - CreateBuild
* [CreateBuildRegistry](#createbuildregistry) - CreateBuildRegistry
* [DeleteBuild](#deletebuild) - DeleteBuild
* [GetBuild](#getbuild) - GetBuild
* [GetBuilds](#getbuilds) - GetBuilds
* [RunBuild](#runbuild) - RunBuild
* [RunBuildRegistry](#runbuildregistry) - RunBuildRegistry

## CreateBuild

Creates a new [build](https://hathora.dev/docs/concepts/hathora-entities#build) with optional `multipartUploadUrls` that can be used to upload larger builds in parts before calling `runBuild`. Responds with a `buildId` that you must pass to [`RunBuild()`](https://hathora.dev/api#tag/BuildV1/operation/RunBuild) to build the game server artifact. You can optionally pass in a `buildTag` to associate an external version with a build.

### Example Usage

<!-- UsageSnippet language="unity" operationID="CreateBuild" method="post" path="/builds/v3/builds" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

CreateBuildRequest req = new CreateBuildRequest() {
    CreateMultipartBuildParams = new CreateMultipartBuildParams() {
        BuildId = "bld-6d4c6a71-2d75-4b42-94e1-f312f57f33c5",
        BuildSizeInBytes = 2645.24D,
        BuildTag = "0.1.14-14c793",
    },
};


using(var res = await sdk.BuildsV3.CreateBuildAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [CreateBuildRequest](../../Models/Operations/CreateBuildRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[CreateBuildResponse](../../Models/Operations/CreateBuildResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 404, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## CreateBuildRegistry

Creates a new [build](https://hathora.dev/docs/concepts/hathora-entities#build) to be used with `runBuildRegistry`. Responds with a `buildId` that you must pass to [`RunBuildRegistry()`](https://hathora.dev/api#tag/BuildV3/operation/RunBuildRegistry) to build the game server artifact. You can optionally pass in a `buildTag` to associate an external version with a build.

### Example Usage

<!-- UsageSnippet language="unity" operationID="CreateBuildRegistry" method="post" path="/builds/v3/builds/registry" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

CreateBuildRegistryRequest req = new CreateBuildRegistryRequest() {
    CreateBuildV3Params = new CreateBuildV3Params() {
        BuildId = "bld-6d4c6a71-2d75-4b42-94e1-f312f57f33c5",
        BuildTag = "0.1.14-14c793",
    },
};


using(var res = await sdk.BuildsV3.CreateBuildRegistryAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [CreateBuildRegistryRequest](../../Models/Operations/CreateBuildRegistryRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[CreateBuildRegistryResponse](../../Models/Operations/CreateBuildRegistryResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 404, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## DeleteBuild

Delete a [build](https://hathora.dev/docs/concepts/hathora-entities#build). All associated metadata is deleted.
Be careful which builds you delete. This endpoint does not prevent you from deleting actively used builds.
Deleting a build that is actively build used by an app's deployment will cause failures when creating rooms.

### Example Usage

<!-- UsageSnippet language="unity" operationID="DeleteBuild" method="delete" path="/builds/v3/builds/{buildId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

DeleteBuildRequest req = new DeleteBuildRequest() {
    BuildId = "bld-6d4c6a71-2d75-4b42-94e1-f312f57f33c5",
};


using(var res = await sdk.BuildsV3.DeleteBuildAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [DeleteBuildRequest](../../Models/Operations/DeleteBuildRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[DeleteBuildResponse](../../Models/Operations/DeleteBuildResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetBuild

Get details for a [build](https://hathora.dev/docs/concepts/hathora-entities#build).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetBuild" method="get" path="/builds/v3/builds/{buildId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetBuildRequest req = new GetBuildRequest() {
    BuildId = "bld-6d4c6a71-2d75-4b42-94e1-f312f57f33c5",
};


using(var res = await sdk.BuildsV3.GetBuildAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [GetBuildRequest](../../Models/Operations/GetBuildRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[GetBuildResponse](../../Models/Operations/GetBuildResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetBuilds

Returns an array of [builds](https://hathora.dev/docs/concepts/hathora-entities#build) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetBuilds" method="get" path="/builds/v3/builds" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetBuildsRequest req = new GetBuildsRequest() {};


using(var res = await sdk.BuildsV3.GetBuildsAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [GetBuildsRequest](../../Models/Operations/GetBuildsRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[GetBuildsResponse](../../Models/Operations/GetBuildsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## RunBuild

Builds a game server artifact from a tarball you provide. Pass in the `buildId` generated from [`CreateBuild()`](https://hathora.dev/api#tag/BuildV1/operation/CreateBuild).

### Example Usage

<!-- UsageSnippet language="unity" operationID="RunBuild" method="post" path="/builds/v3/builds/{buildId}/run" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

RunBuildRequest req = new RunBuildRequest() {
    BuildId = "bld-6d4c6a71-2d75-4b42-94e1-f312f57f33c5",
};


using(var res = await sdk.BuildsV3.RunBuildAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [RunBuildRequest](../../Models/Operations/RunBuildRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[RunBuildResponse](../../Models/Operations/RunBuildResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 404, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## RunBuildRegistry

Builds a game server artifact from a public or private registry. Pass in the `buildId` generated from [`CreateBuild()`](https://hathora.dev/api#tag/BuildV1/operation/CreateBuild).

### Example Usage

<!-- UsageSnippet language="unity" operationID="RunBuildRegistry" method="post" path="/builds/v3/builds/{buildId}/runRegistry" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

RunBuildRegistryRequest req = new RunBuildRegistryRequest() {
    RegistryConfig = new RegistryConfig() {
        Image = "https://picsum.photos/seed/3gDPgtj/723/1525",
    },
    BuildId = "bld-6d4c6a71-2d75-4b42-94e1-f312f57f33c5",
};


using(var res = await sdk.BuildsV3.RunBuildRegistryAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [RunBuildRegistryRequest](../../Models/Operations/RunBuildRegistryRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[RunBuildRegistryResponse](../../Models/Operations/RunBuildRegistryResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 404, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |