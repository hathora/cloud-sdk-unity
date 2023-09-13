# processesV1

## Overview

Operations to get data on active and stopped [processes](https://hathora.dev/docs/concepts/hathora-entities#process).

### Available Operations

* [GetProcessInfo](#getprocessinfo) - Get details for an existing [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.
* [GetRunningProcesses](#getrunningprocesses) - Returns an array of active [process](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a region.
* [GetStoppedProcesses](#getstoppedprocesses) - Returns an array of stopped [process](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a region.

## GetProcessInfo

Get details for an existing [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.ProcessesV1.GetProcessInfoAsync(new GetProcessInfoSecurity() {
        HathoraDevToken = "",
    }, new GetProcessInfoRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetProcessInfoRequest](../../models/operations/GetProcessInfoRequest.md)   | :heavy_check_mark:                                                          | The request object to use for the request.                                  |
| `security`                                                                  | [GetProcessInfoSecurity](../../models/operations/GetProcessInfoSecurity.md) | :heavy_check_mark:                                                          | The security requirements to use for the request.                           |


### Response

**[GetProcessInfoResponse](../../models/operations/GetProcessInfoResponse.md)**


## GetRunningProcesses

Returns an array of active [process](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a region.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.ProcessesV1.GetRunningProcessesAsync(new GetRunningProcessesSecurity() {
        HathoraDevToken = "",
    }, new GetRunningProcessesRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        Region = Hathora.Models.Shared.Region.London,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetRunningProcessesRequest](../../models/operations/GetRunningProcessesRequest.md)   | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |
| `security`                                                                            | [GetRunningProcessesSecurity](../../models/operations/GetRunningProcessesSecurity.md) | :heavy_check_mark:                                                                    | The security requirements to use for the request.                                     |


### Response

**[GetRunningProcessesResponse](../../models/operations/GetRunningProcessesResponse.md)**


## GetStoppedProcesses

Returns an array of stopped [process](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a region.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.ProcessesV1.GetStoppedProcessesAsync(new GetStoppedProcessesSecurity() {
        HathoraDevToken = "",
    }, new GetStoppedProcessesRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        Region = Hathora.Models.Shared.Region.SaoPaulo,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetStoppedProcessesRequest](../../models/operations/GetStoppedProcessesRequest.md)   | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |
| `security`                                                                            | [GetStoppedProcessesSecurity](../../models/operations/GetStoppedProcessesSecurity.md) | :heavy_check_mark:                                                                    | The security requirements to use for the request.                                     |


### Response

**[GetStoppedProcessesResponse](../../models/operations/GetStoppedProcessesResponse.md)**

