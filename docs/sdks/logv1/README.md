# logV1

## Overview

Operations to get logs by [applications](https://hathora.dev/docs/concepts/hathora-entities#application), [processes](https://hathora.dev/docs/concepts/hathora-entities#process), and [deployments](https://hathora.dev/docs/concepts/hathora-entities#deployment). We store 20GB of logs data.

### Available Operations

* [GetLogsForApp](#getlogsforapp) - Returns a stream of logs for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
* [GetLogsForDeployment](#getlogsfordeployment) - Returns a stream of logs for a [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) using `appId` and `deploymentId`.
* [GetLogsForProcess](#getlogsforprocess) - Returns a stream of logs for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

## GetLogsForApp

Returns a stream of logs for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.LogV1.GetLogsForAppAsync(new GetLogsForAppSecurity() {
        HathoraDevToken = "",
    }, new GetLogsForAppRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        Follow = false,
        Region = Hathora.Models.Shared.Region.SaoPaulo,
        TailLines = 272656,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetLogsForAppRequest](../../models/operations/GetLogsForAppRequest.md)   | :heavy_check_mark:                                                        | The request object to use for the request.                                |
| `security`                                                                | [GetLogsForAppSecurity](../../models/operations/GetLogsForAppSecurity.md) | :heavy_check_mark:                                                        | The security requirements to use for the request.                         |


### Response

**[GetLogsForAppResponse](../../models/operations/GetLogsForAppResponse.md)**


## GetLogsForDeployment

Returns a stream of logs for a [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) using `appId` and `deploymentId`.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.LogV1.GetLogsForDeploymentAsync(new GetLogsForDeploymentSecurity() {
        HathoraDevToken = "",
    }, new GetLogsForDeploymentRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        DeploymentId = 1,
        Follow = false,
        TailLines = 383441,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetLogsForDeploymentRequest](../../models/operations/GetLogsForDeploymentRequest.md)   | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |
| `security`                                                                              | [GetLogsForDeploymentSecurity](../../models/operations/GetLogsForDeploymentSecurity.md) | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |


### Response

**[GetLogsForDeploymentResponse](../../models/operations/GetLogsForDeploymentResponse.md)**


## GetLogsForProcess

Returns a stream of logs for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.LogV1.GetLogsForProcessAsync(new GetLogsForProcessSecurity() {
        HathoraDevToken = "",
    }, new GetLogsForProcessRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        Follow = false,
        ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
        TailLines = 477665,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetLogsForProcessRequest](../../models/operations/GetLogsForProcessRequest.md)   | :heavy_check_mark:                                                                | The request object to use for the request.                                        |
| `security`                                                                        | [GetLogsForProcessSecurity](../../models/operations/GetLogsForProcessSecurity.md) | :heavy_check_mark:                                                                | The security requirements to use for the request.                                 |


### Response

**[GetLogsForProcessResponse](../../models/operations/GetLogsForProcessResponse.md)**

