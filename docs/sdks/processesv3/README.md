# ProcessesV3
(*ProcessesV3*)

## Overview

Operations to get data on active and stopped [processes](https://hathora.dev/docs/concepts/hathora-entities#process).

### Available Operations

* [CreateProcess](#createprocess) - CreateProcess
* [GetLatestProcesses](#getlatestprocesses) - GetLatestProcesses
* [GetProcess](#getprocess) - GetProcess
* [GetProcessMetrics](#getprocessmetrics) - GetProcessMetrics
* [GetProcessesCountExperimental](#getprocessescountexperimental) - GetProcessesCountExperimental
* [StopProcess](#stopprocess) - StopProcess

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
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

CreateProcessRequest req = new CreateProcessRequest() {
    Region = Region.SaoPaulo,
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.ProcessesV3.CreateProcessAsync(req))
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

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 402, 404, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

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
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

GetLatestProcessesRequest req = new GetLatestProcessesRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.ProcessesV3.GetLatestProcessesAsync(req))
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

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetProcess

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
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

GetProcessRequest req = new GetProcessRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.ProcessesV3.GetProcessAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetProcessRequest](../../Models/Operations/GetProcessRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetProcessResponse](../../Models/Operations/GetProcessResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetProcessMetrics

GetProcessMetrics

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
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

GetProcessMetricsRequest req = new GetProcessMetricsRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.ProcessesV3.GetProcessMetricsAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetProcessMetricsRequest](../../Models/Operations/GetProcessMetricsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetProcessMetricsResponse](../../Models/Operations/GetProcessMetricsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetProcessesCountExperimental

Count the number of [processes](https://hathora.dev/docs/concepts/hathora-entities#process) objects for an [application](https://hathora.dev/docs/concepts/hathora-entities#application). Filter by optionally passing in a `status` or `region`.

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
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

GetProcessesCountExperimentalRequest req = new GetProcessesCountExperimentalRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.ProcessesV3.GetProcessesCountExperimentalAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetProcessesCountExperimentalRequest](../../Models/Operations/GetProcessesCountExperimentalRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[GetProcessesCountExperimentalResponse](../../Models/Operations/GetProcessesCountExperimentalResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

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
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

StopProcessRequest req = new StopProcessRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.ProcessesV3.StopProcessAsync(req))
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

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |