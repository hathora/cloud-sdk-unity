# MetricsV1

## Overview

Operations to get metrics by [process](https://hathora.dev/docs/concepts/hathora-entities#process). We store 72 hours of metrics data.

### Available Operations

* [GetMetrics](#getmetrics) - Get metrics for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

## GetMetrics

Get metrics for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK();

using(var res = await sdk.MetricsV1.GetMetricsAsync(new GetMetricsSecurity() {
        HathoraDevToken = "",
    }, new GetMetricsRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        End = 8121.69D,
        Metrics = new List<MetricName>() {
            HathoraCloud.Models.Shared.MetricName.RateEgress,
        },
        ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
        Start = 4799.77D,
        Step = 568045,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetMetricsRequest](../../models/operations/GetMetricsRequest.md)   | :heavy_check_mark:                                                  | The request object to use for the request.                          |
| `security`                                                          | [GetMetricsSecurity](../../models/operations/GetMetricsSecurity.md) | :heavy_check_mark:                                                  | The security requirements to use for the request.                   |


### Response

**[GetMetricsResponse](../../models/operations/GetMetricsResponse.md)**

