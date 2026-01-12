# FleetsV2

## Overview

### Available Operations

* [CreateFleet](#createfleet) - CreateFleet
* [~~DeprecatedUpdateFleetRegionV2~~](#deprecatedupdatefleetregionv2) - DeprecatedUpdateFleetRegionV2 :warning: **Deprecated**
* [GetFleet](#getfleet) - GetFleet
* [GetFleetMetrics](#getfleetmetrics) - GetFleetMetrics
* [GetFleetRegion](#getfleetregion) - GetFleetRegion
* [GetFleetRegionMetrics](#getfleetregionmetrics) - GetFleetRegionMetrics
* [GetFleets](#getfleets) - GetFleets
* [GetNodeShapes](#getnodeshapes) - GetNodeShapes
* [UpdateFleet](#updatefleet) - UpdateFleet
* [UpdateFleetRegion](#updatefleetregion) - UpdateFleetRegion

## CreateFleet

CreateFleet

### Example Usage

<!-- UsageSnippet language="unity" operationID="CreateFleet" method="post" path="/fleets/v2/fleets" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

CreateFleetRequest req = new CreateFleetRequest() {
    CreateFleetV2 = new CreateFleetV2() {
        AutoscalerConfig = new AutoscalerConfig() {
            ScaleUpThreshold = 599396,
        },
        Name = "production",
        NodeShapeId = NodeShapeId.ShapeL414,
    },
};


using(var res = await sdk.FleetsV2.CreateFleetAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [CreateFleetRequest](../../Models/Operations/CreateFleetRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[CreateFleetResponse](../../Models/Operations/CreateFleetResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~DeprecatedUpdateFleetRegionV2~~

Updates the configuration for a given [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet) in a region.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="DeprecatedUpdateFleetRegionV2" method="put" path="/fleets/v2/fleets/{fleetId}/regions/{region}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

DeprecatedUpdateFleetRegionV2Request req = new DeprecatedUpdateFleetRegionV2Request() {
    FleetRegionConfig = new FleetRegionConfig() {
        CloudMinVcpus = 735068,
    },
    FleetId = "<id>",
    Region = Region.Singapore,
};


using(var res = await sdk.FleetsV2.DeprecatedUpdateFleetRegionV2Async(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [DeprecatedUpdateFleetRegionV2Request](../../Models/Operations/DeprecatedUpdateFleetRegionV2Request.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[DeprecatedUpdateFleetRegionV2Response](../../Models/Operations/DeprecatedUpdateFleetRegionV2Response.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleet

Returns a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetFleet" method="get" path="/fleets/v2/fleets/{fleetId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetFleetRequest req = new GetFleetRequest() {
    FleetId = "<id>",
};


using(var res = await sdk.FleetsV2.GetFleetAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [GetFleetRequest](../../Models/Operations/GetFleetRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[GetFleetResponse](../../Models/Operations/GetFleetResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleetMetrics

Gets aggregate metrics for a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetFleetMetrics" method="get" path="/fleets/v2/fleets/{fleetId}/metrics" -->
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
};


using(var res = await sdk.FleetsV2.GetFleetMetricsAsync(req))
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
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleetRegion

Gets the configuration for a given [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet) in a region.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetFleetRegion" method="get" path="/fleets/v2/fleets/{fleetId}/regions/{region}" -->
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


using(var res = await sdk.FleetsV2.GetFleetRegionAsync(req))
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
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleetRegionMetrics

Gets metrics for a region in a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetFleetRegionMetrics" method="get" path="/fleets/v2/fleets/{fleetId}/regions/{region}/metrics" -->
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

GetFleetRegionMetricsRequest req = new GetFleetRegionMetricsRequest() {
    FleetId = "<id>",
    Region = Region.Chicago,
};


using(var res = await sdk.FleetsV2.GetFleetRegionMetricsAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetFleetRegionMetricsRequest](../../Models/Operations/GetFleetRegionMetricsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[GetFleetRegionMetricsResponse](../../Models/Operations/GetFleetRegionMetricsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleets

Returns an array of [fleets](https://hathora.dev/docs/concepts/hathora-entities#fleet).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetFleets" method="get" path="/fleets/v2/fleets" -->
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


using(var res = await sdk.FleetsV2.GetFleetsAsync(req))
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
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetNodeShapes

GetNodeShapes

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetNodeShapes" method="get" path="/fleets/v2/nodeShapes" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetNodeShapesRequest req = new GetNodeShapesRequest() {};


using(var res = await sdk.FleetsV2.GetNodeShapesAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetNodeShapesRequest](../../Models/Operations/GetNodeShapesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[GetNodeShapesResponse](../../Models/Operations/GetNodeShapesResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## UpdateFleet

Updates a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet)'s configuration.

### Example Usage

<!-- UsageSnippet language="unity" operationID="UpdateFleet" method="post" path="/fleets/v2/fleets/{fleetId}" -->
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
    UpdateFleetV2 = new UpdateFleetV2() {
        AutoscalerConfig = new AutoscalerConfig() {
            ScaleUpThreshold = 979840,
        },
        Name = "production",
    },
    FleetId = "<id>",
};


using(var res = await sdk.FleetsV2.UpdateFleetAsync(req))
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
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## UpdateFleetRegion

Updates the configuration for a given [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet) in a region.

### Example Usage

<!-- UsageSnippet language="unity" operationID="UpdateFleetRegion" method="put" path="/fleets/v2/fleets/{fleetId}/regions/{region}/v2" -->
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
    FleetRegionConfigV2 = new FleetRegionConfigV2() {
        NodeBaseline = 503995,
    },
    FleetId = "<id>",
    Region = Region.Chicago,
};


using(var res = await sdk.FleetsV2.UpdateFleetRegionAsync(req))
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
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |