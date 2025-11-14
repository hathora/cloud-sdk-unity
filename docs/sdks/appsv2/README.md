# AppsV2
(*AppsV2*)

## Overview

Operations that allow you manage your [applications](https://hathora.dev/docs/concepts/hathora-entities#application).

### Available Operations

* [CreateApp](#createapp) - CreateApp
* [DeleteApp](#deleteapp) - DeleteApp
* [GetApp](#getapp) - GetApp
* [GetApps](#getapps) - GetApps
* [PatchApp](#patchapp) - PatchApp
* [UpdateApp](#updateapp) - UpdateApp

## CreateApp

Create a new [application](https://hathora.dev/docs/concepts/hathora-entities#application).

### Example Usage

<!-- UsageSnippet language="unity" operationID="CreateApp" method="post" path="/apps/v2/apps" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

CreateAppRequest req = new CreateAppRequest() {
    CreateAppConfig = new CreateAppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {},
    },
};


using(var res = await sdk.AppsV2.CreateAppAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [CreateAppRequest](../../Models/Operations/CreateAppRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[CreateAppResponse](../../Models/Operations/CreateAppResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## DeleteApp

Delete an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Your organization will lose access to this application.

### Example Usage

<!-- UsageSnippet language="unity" operationID="DeleteApp" method="delete" path="/apps/v2/apps/{appId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

DeleteAppRequest req = new DeleteAppRequest() {};


using(var res = await sdk.AppsV2.DeleteAppAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [DeleteAppRequest](../../Models/Operations/DeleteAppRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[DeleteAppResponse](../../Models/Operations/DeleteAppResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetApp

Get details for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetApp" method="get" path="/apps/v2/apps/{appId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetAppRequest req = new GetAppRequest() {};


using(var res = await sdk.AppsV2.GetAppAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | [GetAppRequest](../../Models/Operations/GetAppRequest.md) | :heavy_check_mark:                                        | The request object to use for the request.                |

### Response

**[GetAppResponse](../../Models/Operations/GetAppResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetApps

Returns an unsorted list of your organization’s [applications](https://hathora.dev/docs/concepts/hathora-entities#application). An application is uniquely identified by an `appId`.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetApps" method="get" path="/apps/v2/apps" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetAppsRequest req = new GetAppsRequest() {};


using(var res = await sdk.AppsV2.GetAppsAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetAppsRequest](../../Models/Operations/GetAppsRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[GetAppsResponse](../../Models/Operations/GetAppsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## PatchApp

Patch data for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

<!-- UsageSnippet language="unity" operationID="PatchApp" method="patch" path="/apps/v2/apps/{appId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;
using System.Collections.Generic;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

PatchAppRequest req = new PatchAppRequest() {
    PartialAppConfigWithServiceConfig = new PartialAppConfigWithServiceConfig() {
        ServiceConfig = new ServiceConfigWrite() {
            StaticProcessAllocation = new List<StaticProcessAllocationConfigWrite>() {
                new StaticProcessAllocationConfigWrite() {
                    MaxProcesses = 3,
                    MinProcesses = 1,
                    Region = Region.Tokyo,
                    TargetProcesses = 2,
                },
            },
        },
    },
};


using(var res = await sdk.AppsV2.PatchAppAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [PatchAppRequest](../../Models/Operations/PatchAppRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[PatchAppResponse](../../Models/Operations/PatchAppResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## UpdateApp

Set application config (will override all fields) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

<!-- UsageSnippet language="unity" operationID="UpdateApp" method="post" path="/apps/v2/apps/{appId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;
using System.Collections.Generic;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

UpdateAppRequest req = new UpdateAppRequest() {
    AppConfigWithServiceConfig = new AppConfigWithServiceConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {},
        ServiceConfig = new ServiceConfigWrite() {
            StaticProcessAllocation = new List<StaticProcessAllocationConfigWrite>() {
                new StaticProcessAllocationConfigWrite() {
                    MaxProcesses = 3,
                    MinProcesses = 1,
                    Region = Region.SaoPaulo,
                    TargetProcesses = 2,
                },
            },
        },
    },
};


using(var res = await sdk.AppsV2.UpdateAppAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [UpdateAppRequest](../../Models/Operations/UpdateAppRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[UpdateAppResponse](../../Models/Operations/UpdateAppResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |