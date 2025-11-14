# AppsV1
(*AppsV1*)

## Overview

### Available Operations

* [~~CreateAppV1Deprecated~~](#createappv1deprecated) - CreateAppV1Deprecated :warning: **Deprecated**
* [~~DeleteAppV1Deprecated~~](#deleteappv1deprecated) - DeleteAppV1Deprecated :warning: **Deprecated**
* [~~GetAppInfoV1Deprecated~~](#getappinfov1deprecated) - GetAppInfoV1Deprecated :warning: **Deprecated**
* [~~GetAppsV1Deprecated~~](#getappsv1deprecated) - GetAppsV1Deprecated :warning: **Deprecated**
* [~~UpdateAppV1Deprecated~~](#updateappv1deprecated) - UpdateAppV1Deprecated :warning: **Deprecated**

## ~~CreateAppV1Deprecated~~

Create a new [application](https://hathora.dev/docs/concepts/hathora-entities#application).

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="CreateAppV1Deprecated" method="post" path="/apps/v1/create" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

CreateAppConfig req = new CreateAppConfig() {
    AppName = "minecraft",
    AuthConfiguration = new AuthConfiguration() {},
};


using(var res = await sdk.AppsV1.CreateAppV1DeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | [CreateAppConfig](../../Models/Shared/CreateAppConfig.md) | :heavy_check_mark:                                        | The request object to use for the request.                |

### Response

**[CreateAppV1DeprecatedResponse](../../Models/Operations/CreateAppV1DeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~DeleteAppV1Deprecated~~

Delete an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Your organization will lose access to this application.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="DeleteAppV1Deprecated" method="delete" path="/apps/v1/delete/{appId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

DeleteAppV1DeprecatedRequest req = new DeleteAppV1DeprecatedRequest() {};


using(var res = await sdk.AppsV1.DeleteAppV1DeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [DeleteAppV1DeprecatedRequest](../../Models/Operations/DeleteAppV1DeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[DeleteAppV1DeprecatedResponse](../../Models/Operations/DeleteAppV1DeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~GetAppInfoV1Deprecated~~

Get details for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetAppInfoV1Deprecated" method="get" path="/apps/v1/info/{appId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetAppInfoV1DeprecatedRequest req = new GetAppInfoV1DeprecatedRequest() {};


using(var res = await sdk.AppsV1.GetAppInfoV1DeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetAppInfoV1DeprecatedRequest](../../Models/Operations/GetAppInfoV1DeprecatedRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[GetAppInfoV1DeprecatedResponse](../../Models/Operations/GetAppInfoV1DeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~GetAppsV1Deprecated~~

Returns an unsorted list of your organization’s [applications](https://hathora.dev/docs/concepts/hathora-entities#application). An application is uniquely identified by an `appId`.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetAppsV1Deprecated" method="get" path="/apps/v1/list" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });


using(var res = await sdk.AppsV1.GetAppsV1DeprecatedAsync())
{
    // handle response
}


```

### Response

**[GetAppsV1DeprecatedResponse](../../Models/Operations/GetAppsV1DeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 408, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~UpdateAppV1Deprecated~~

Update data for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="UpdateAppV1Deprecated" method="post" path="/apps/v1/update/{appId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

UpdateAppV1DeprecatedRequest req = new UpdateAppV1DeprecatedRequest() {
    CreateAppConfig = new CreateAppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {},
    },
};


using(var res = await sdk.AppsV1.UpdateAppV1DeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateAppV1DeprecatedRequest](../../Models/Operations/UpdateAppV1DeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateAppV1DeprecatedResponse](../../Models/Operations/UpdateAppV1DeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |