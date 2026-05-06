# LogsV1

## Overview

### Available Operations

* [DownloadLogForProcess](#downloadlogforprocess) - DownloadLogForProcess
* [GetLogsForProcess](#getlogsforprocess) - GetLogsForProcess

## DownloadLogForProcess

Download entire log file for a stopped process.

### Example Usage

<!-- UsageSnippet language="unity" operationID="DownloadLogForProcess" method="get" path="/logs/v1/{appId}/process/{processId}/download" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

DownloadLogForProcessRequest req = new DownloadLogForProcessRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
};


using(var res = await sdk.LogsV1.DownloadLogForProcessAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [DownloadLogForProcessRequest](../../Models/Operations/DownloadLogForProcessRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[DownloadLogForProcessResponse](../../Models/Operations/DownloadLogForProcessResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 404, 408, 410, 429            | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetLogsForProcess

Returns a stream of logs for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetLogsForProcess" method="get" path="/logs/v1/{appId}/process/{processId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetLogsForProcessRequest req = new GetLogsForProcessRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    TailLines = 100,
};


using(var res = await sdk.LogsV1.GetLogsForProcessAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetLogsForProcessRequest](../../Models/Operations/GetLogsForProcessRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetLogsForProcessResponse](../../Models/Operations/GetLogsForProcessResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 404, 408, 410, 429            | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |