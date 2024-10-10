# AppsV1
(*AppsV1*)

## Overview

### Available Operations

* [~~CreateAppV1Deprecated~~](#createappv1deprecated) - Create a new [application](https://hathora.dev/docs/concepts/hathora-entities#application). :warning: **Deprecated**
* [~~DeleteAppV1Deprecated~~](#deleteappv1deprecated) - Delete an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Your organization will lose access to this application. :warning: **Deprecated**
* [~~GetAppInfoV1Deprecated~~](#getappinfov1deprecated) - Get details for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. :warning: **Deprecated**
* [~~GetAppsV1Deprecated~~](#getappsv1deprecated) - Returns an unsorted list of your organization’s [applications](https://hathora.dev/docs/concepts/hathora-entities#application). An application is uniquely identified by an `appId`. :warning: **Deprecated**
* [~~UpdateAppV1Deprecated~~](#updateappv1deprecated) - Update data for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. :warning: **Deprecated**

## ~~CreateAppV1Deprecated~~

Create a new [application](https://hathora.dev/docs/concepts/hathora-entities#application).

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

AppConfig req = new AppConfig() {
    AppName = "minecraft",
    AuthConfiguration = new AuthConfiguration() {},
};


using(var res = await sdk.AppsV1.CreateAppV1DeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `request`                                     | [AppConfig](../../Models/Shared/AppConfig.md) | :heavy_check_mark:                            | The request object to use for the request.    |

### Response

**[CreateAppV1DeprecatedResponse](../../Models/Operations/CreateAppV1DeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 422, 429, 500                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~DeleteAppV1Deprecated~~

Delete an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Your organization will lose access to this application.

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
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

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
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429, 500                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~GetAppInfoV1Deprecated~~

Get details for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

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
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

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
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~GetAppsV1Deprecated~~

Returns an unsorted list of your organization’s [applications](https://hathora.dev/docs/concepts/hathora-entities#application). An application is uniquely identified by an `appId`.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");


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
| HathoraCloud.Models.Errors.ApiError     | 401, 429                                | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~UpdateAppV1Deprecated~~

Update data for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

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
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

UpdateAppV1DeprecatedRequest req = new UpdateAppV1DeprecatedRequest() {
    AppConfig = new AppConfig() {
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
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429, 500                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |