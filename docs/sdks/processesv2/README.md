# ProcessesV2
(*ProcessesV2*)

## Overview

Operations to get data on active and stopped [processes](https://hathora.dev/docs/concepts/hathora-entities#process).

### Available Operations

* [CreateProcess](#createprocess) - Creates a [process](https://hathora.dev/docs/concepts/hathora-entities#process) without a room. Use this to pre-allocate processes ahead of time so that subsequent room assignment via [CreateRoom()](https://hathora.dev/api#tag/RoomV2/operation/CreateRoom) can be instant.
* [GetLatestProcesses](#getlatestprocesses) - Retrieve the 10 most recent [processes](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an [application](https://hathora.dev/docs/concepts/hathora-entities#application). Filter the array by optionally passing in a `status` or `region`.
* [GetProcessInfo](#getprocessinfo) - Get details for a [process](https://hathora.dev/docs/concepts/hathora-entities#process).
* [StopProcess](#stopprocess) - Stops a [process](https://hathora.dev/docs/concepts/hathora-entities#process) immediately.

## CreateProcess

Creates a [process](https://hathora.dev/docs/concepts/hathora-entities#process) without a room. Use this to pre-allocate processes ahead of time so that subsequent room assignment via [CreateRoom()](https://hathora.dev/api#tag/RoomV2/operation/CreateRoom) can be instant.

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

CreateProcessRequest req = new CreateProcessRequest() {
    Region = Region.Tokyo,
};


using(var res = await sdk.ProcessesV2.CreateProcessAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreateProcessRequest](../../Models/Operations/CreateProcessRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[CreateProcessResponse](../../Models/Operations/CreateProcessResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401,402,404,429,500                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GetLatestProcesses

Retrieve the 10 most recent [processes](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an [application](https://hathora.dev/docs/concepts/hathora-entities#application). Filter the array by optionally passing in a `status` or `region`.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;
using System.Collections.Generic;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

GetLatestProcessesRequest req = new GetLatestProcessesRequest() {};


using(var res = await sdk.ProcessesV2.GetLatestProcessesAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetLatestProcessesRequest](../../Models/Operations/GetLatestProcessesRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetLatestProcessesResponse](../../Models/Operations/GetLatestProcessesResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401,404,429                             | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GetProcessInfo

Get details for a [process](https://hathora.dev/docs/concepts/hathora-entities#process).

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

GetProcessInfoRequest req = new GetProcessInfoRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
};


using(var res = await sdk.ProcessesV2.GetProcessInfoAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetProcessInfoRequest](../../Models/Operations/GetProcessInfoRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetProcessInfoResponse](../../Models/Operations/GetProcessInfoResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401,404,429                             | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## StopProcess

Stops a [process](https://hathora.dev/docs/concepts/hathora-entities#process) immediately.

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

StopProcessRequest req = new StopProcessRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
};


using(var res = await sdk.ProcessesV2.StopProcessAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [StopProcessRequest](../../Models/Operations/StopProcessRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[StopProcessResponse](../../Models/Operations/StopProcessResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401,404,429,500                         | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
