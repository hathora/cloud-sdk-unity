# FleetsV1
(*FleetsV1*)

## Overview

Operations to manage and view a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet).

### Available Operations

* [GetFleetMetrics](#getfleetmetrics) - GetFleetMetrics
* [GetFleetRegion](#getfleetregion) - GetFleetRegion
* [GetFleets](#getfleets) - GetFleets
* [UpdateFleet](#updatefleet) - UpdateFleet
* [UpdateFleetRegion](#updatefleetregion) - UpdateFleetRegion

## GetFleetMetrics

Gets metrics for a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet) in a region.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;
using System.Collections.Generic;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetFleetMetricsRequest req = new GetFleetMetricsRequest() {
    FleetId = "<id>",
    Region = Region.WashingtonDC,
};


using(var res = await sdk.FleetsV1.GetFleetMetricsAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetFleetMetricsRequest](../../Models/Operations/GetFleetMetricsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[GetFleetMetricsResponse](../../Models/Operations/GetFleetMetricsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleetRegion

Gets the configuration for a given [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet) in a region.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetFleetRegionRequest req = new GetFleetRegionRequest() {
    FleetId = "<id>",
    Region = Region.Singapore,
};


using(var res = await sdk.FleetsV1.GetFleetRegionAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetFleetRegionRequest](../../Models/Operations/GetFleetRegionRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetFleetRegionResponse](../../Models/Operations/GetFleetRegionResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleets

Returns an array of [fleets](https://hathora.dev/docs/concepts/hathora-entities#fleet).

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetFleetsRequest req = new GetFleetsRequest() {};


using(var res = await sdk.FleetsV1.GetFleetsAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [GetFleetsRequest](../../Models/Operations/GetFleetsRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[GetFleetsResponse](../../Models/Operations/GetFleetsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## UpdateFleet

Updates a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet)'s configuration.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

UpdateFleetRequest req = new UpdateFleetRequest() {
    UpdateFleet = new UpdateFleet() {
        AutoscalerConfig = new AutoscalerConfig() {
            ScaleUpThreshold = 979840,
        },
    },
    FleetId = "<id>",
};


using(var res = await sdk.FleetsV1.UpdateFleetAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [UpdateFleetRequest](../../Models/Operations/UpdateFleetRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[UpdateFleetResponse](../../Models/Operations/UpdateFleetResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## UpdateFleetRegion

Updates the configuration for a given [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet) in a region.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

UpdateFleetRegionRequest req = new UpdateFleetRegionRequest() {
    FleetRegionConfig = new FleetRegionConfig() {
        CloudMinVcpus = 503995,
    },
    FleetId = "<id>",
    Region = Region.Chicago,
};


using(var res = await sdk.FleetsV1.UpdateFleetRegionAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateFleetRegionRequest](../../Models/Operations/UpdateFleetRegionRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateFleetRegionResponse](../../Models/Operations/UpdateFleetRegionResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |