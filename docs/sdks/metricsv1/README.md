# MetricsV1
(*MetricsV1*)

## Overview

Operations to get metrics by [process](https://hathora.dev/docs/concepts/hathora-entities#process). We store 72 hours of metrics data.

### Available Operations

* [GetMetrics](#getmetrics) - Get metrics for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

## GetMetrics

Get metrics for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;
using System.Collections.Generic;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2"
);

using(var res = await sdk.MetricsV1.GetMetricsAsync(new GetMetricsRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    Metrics = new List<MetricName>() {
        MetricName.RateEgress,
    },
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetMetricsRequest](../../models/operations/GetMetricsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[GetMetricsResponse](../../models/operations/GetMetricsResponse.md)**

