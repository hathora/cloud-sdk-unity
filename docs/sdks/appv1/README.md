# appV1

## Overview

Operations that allow you manage your [applications](https://hathora.dev/docs/concepts/hathora-entities#application).

### Available Operations

* [CreateApp](#createapp) - Create a new [application](https://hathora.dev/docs/concepts/hathora-entities#application).
* [DeleteApp](#deleteapp) - Delete an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Your organization will lose access to this application.
* [GetAppInfo](#getappinfo) - Get details for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
* [GetApps](#getapps) - Returns an unsorted list of your organization’s [applications](https://hathora.dev/docs/concepts/hathora-entities#application). An application is uniquely identified by an `appId`.
* [UpdateApp](#updateapp) - Update data for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

## CreateApp

Create a new [application](https://hathora.dev/docs/concepts/hathora-entities#application).

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Shared;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.AppV1.CreateAppAsync(new CreateAppSecurity() {
        HathoraDevToken = "",
    }, new AppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {
            Anonymous = new RecordStringNever() {},
            Google = new AuthConfigurationGoogle() {
                ClientId = "provident",
            },
            Nickname = new RecordStringNever() {},
        },
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [AppConfig](../../models/shared/AppConfig.md)                     | :heavy_check_mark:                                                | The request object to use for the request.                        |
| `security`                                                        | [CreateAppSecurity](../../models/operations/CreateAppSecurity.md) | :heavy_check_mark:                                                | The security requirements to use for the request.                 |


### Response

**[CreateAppResponse](../../models/operations/CreateAppResponse.md)**


## DeleteApp

Delete an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Your organization will lose access to this application.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.AppV1.DeleteAppAsync(new DeleteAppSecurity() {
        HathoraDevToken = "",
    }, new DeleteAppRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [DeleteAppRequest](../../models/operations/DeleteAppRequest.md)   | :heavy_check_mark:                                                | The request object to use for the request.                        |
| `security`                                                        | [DeleteAppSecurity](../../models/operations/DeleteAppSecurity.md) | :heavy_check_mark:                                                | The security requirements to use for the request.                 |


### Response

**[DeleteAppResponse](../../models/operations/DeleteAppResponse.md)**


## GetAppInfo

Get details for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.AppV1.GetAppInfoAsync(new GetAppInfoSecurity() {
        HathoraDevToken = "",
    }, new GetAppInfoRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetAppInfoRequest](../../models/operations/GetAppInfoRequest.md)   | :heavy_check_mark:                                                  | The request object to use for the request.                          |
| `security`                                                          | [GetAppInfoSecurity](../../models/operations/GetAppInfoSecurity.md) | :heavy_check_mark:                                                  | The security requirements to use for the request.                   |


### Response

**[GetAppInfoResponse](../../models/operations/GetAppInfoResponse.md)**


## GetApps

Returns an unsorted list of your organization’s [applications](https://hathora.dev/docs/concepts/hathora-entities#application). An application is uniquely identified by an `appId`.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.AppV1.GetAppsAsync(new GetAppsSecurity() {
        HathoraDevToken = "",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `security`                                                    | [GetAppsSecurity](../../models/operations/GetAppsSecurity.md) | :heavy_check_mark:                                            | The security requirements to use for the request.             |


### Response

**[GetAppsResponse](../../models/operations/GetAppsResponse.md)**


## UpdateApp

Update data for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.AppV1.UpdateAppAsync(new UpdateAppSecurity() {
        HathoraDevToken = "",
    }, new UpdateAppRequest() {
        AppConfig = new AppConfig() {
            AppName = "minecraft",
            AuthConfiguration = new AuthConfiguration() {
                Anonymous = new RecordStringNever() {},
                Google = new AuthConfigurationGoogle() {
                    ClientId = "distinctio",
                },
                Nickname = new RecordStringNever() {},
            },
        },
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [UpdateAppRequest](../../models/operations/UpdateAppRequest.md)   | :heavy_check_mark:                                                | The request object to use for the request.                        |
| `security`                                                        | [UpdateAppSecurity](../../models/operations/UpdateAppSecurity.md) | :heavy_check_mark:                                                | The security requirements to use for the request.                 |


### Response

**[UpdateAppResponse](../../models/operations/UpdateAppResponse.md)**

