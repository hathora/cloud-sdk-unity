# FleetsV1

## Overview

Operations to manage and view a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet).

### Available Operations

* [CreateFleetDeprecated](#createfleetdeprecated) - CreateFleetDeprecated
* [GetFleetDeprecated](#getfleetdeprecated) - GetFleetDeprecated
* [GetFleetMetricsDeprecated](#getfleetmetricsdeprecated) - GetFleetMetricsDeprecated
* [GetFleetRegionDeprecated](#getfleetregiondeprecated) - GetFleetRegionDeprecated
* [GetFleetRegionMetricsDeprecated](#getfleetregionmetricsdeprecated) - GetFleetRegionMetricsDeprecated
* [GetFleetsDeprecated](#getfleetsdeprecated) - GetFleetsDeprecated
* [UpdateFleetDeprecated](#updatefleetdeprecated) - UpdateFleetDeprecated
* [UpdateFleetRegionDeprecated](#updatefleetregiondeprecated) - UpdateFleetRegionDeprecated

## CreateFleetDeprecated

CreateFleetDeprecated

### Example Usage

<!-- UsageSnippet language="unity" operationID="CreateFleetDeprecated" method="post" path="/fleets/v1/fleets" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

CreateFleetDeprecatedRequest req = new CreateFleetDeprecatedRequest() {
    CreateFleet = new CreateFleet() {
        AutoscalerConfig = new AutoscalerConfig() {
            ScaleUpThreshold = 78718,
        },
        Name = "production",
        NodeShape = NodeShape.GpuH1004104936,
    },
};


using(var res = await sdk.FleetsV1.CreateFleetDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [CreateFleetDeprecatedRequest](../../Models/Operations/CreateFleetDeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[CreateFleetDeprecatedResponse](../../Models/Operations/CreateFleetDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleetDeprecated

Returns a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetFleetDeprecated" method="get" path="/fleets/v1/fleets/{fleetId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetFleetDeprecatedRequest req = new GetFleetDeprecatedRequest() {
    FleetId = "<id>",
};


using(var res = await sdk.FleetsV1.GetFleetDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetFleetDeprecatedRequest](../../Models/Operations/GetFleetDeprecatedRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[GetFleetDeprecatedResponse](../../Models/Operations/GetFleetDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleetMetricsDeprecated

Gets aggregate metrics for a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetFleetMetricsDeprecated" method="get" path="/fleets/v1/fleets/{fleetId}/metrics" -->
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

GetFleetMetricsDeprecatedRequest req = new GetFleetMetricsDeprecatedRequest() {
    FleetId = "<id>",
};


using(var res = await sdk.FleetsV1.GetFleetMetricsDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetFleetMetricsDeprecatedRequest](../../Models/Operations/GetFleetMetricsDeprecatedRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[GetFleetMetricsDeprecatedResponse](../../Models/Operations/GetFleetMetricsDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleetRegionDeprecated

Gets the configuration for a given [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet) in a region.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetFleetRegionDeprecated" method="get" path="/fleets/v1/fleets/{fleetId}/regions/{region}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetFleetRegionDeprecatedRequest req = new GetFleetRegionDeprecatedRequest() {
    FleetId = "<id>",
    Region = Region.SaoPaulo,
};


using(var res = await sdk.FleetsV1.GetFleetRegionDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetFleetRegionDeprecatedRequest](../../Models/Operations/GetFleetRegionDeprecatedRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetFleetRegionDeprecatedResponse](../../Models/Operations/GetFleetRegionDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleetRegionMetricsDeprecated

Gets metrics for a region in a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetFleetRegionMetricsDeprecated" method="get" path="/fleets/v1/fleets/{fleetId}/regions/{region}/metrics" -->
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

GetFleetRegionMetricsDeprecatedRequest req = new GetFleetRegionMetricsDeprecatedRequest() {
    FleetId = "<id>",
    Region = Region.Dubai,
};


using(var res = await sdk.FleetsV1.GetFleetRegionMetricsDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [GetFleetRegionMetricsDeprecatedRequest](../../Models/Operations/GetFleetRegionMetricsDeprecatedRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |

### Response

**[GetFleetRegionMetricsDeprecatedResponse](../../Models/Operations/GetFleetRegionMetricsDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetFleetsDeprecated

Returns an array of [fleets](https://hathora.dev/docs/concepts/hathora-entities#fleet).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetFleetsDeprecated" method="get" path="/fleets/v1/fleets" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetFleetsDeprecatedRequest req = new GetFleetsDeprecatedRequest() {};


using(var res = await sdk.FleetsV1.GetFleetsDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetFleetsDeprecatedRequest](../../Models/Operations/GetFleetsDeprecatedRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetFleetsDeprecatedResponse](../../Models/Operations/GetFleetsDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## UpdateFleetDeprecated

Updates a [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet)'s configuration.

### Example Usage

<!-- UsageSnippet language="unity" operationID="UpdateFleetDeprecated" method="post" path="/fleets/v1/fleets/{fleetId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

UpdateFleetDeprecatedRequest req = new UpdateFleetDeprecatedRequest() {
    UpdateFleet = new UpdateFleet() {
        AutoscalerConfig = new AutoscalerConfig() {
            ScaleUpThreshold = 638855,
        },
        Name = "production",
    },
    FleetId = "<id>",
};


using(var res = await sdk.FleetsV1.UpdateFleetDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateFleetDeprecatedRequest](../../Models/Operations/UpdateFleetDeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateFleetDeprecatedResponse](../../Models/Operations/UpdateFleetDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## UpdateFleetRegionDeprecated

Updates the configuration for a given [fleet](https://hathora.dev/docs/concepts/hathora-entities#fleet) in a region.

### Example Usage

<!-- UsageSnippet language="unity" operationID="UpdateFleetRegionDeprecated" method="put" path="/fleets/v1/fleets/{fleetId}/regions/{region}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

UpdateFleetRegionDeprecatedRequest req = new UpdateFleetRegionDeprecatedRequest() {
    FleetRegionConfig = new FleetRegionConfig() {
        CloudMinVcpus = 122781,
    },
    FleetId = "<id>",
    Region = Region.Johannesburg,
};


using(var res = await sdk.FleetsV1.UpdateFleetRegionDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [UpdateFleetRegionDeprecatedRequest](../../Models/Operations/UpdateFleetRegionDeprecatedRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[UpdateFleetRegionDeprecatedResponse](../../Models/Operations/UpdateFleetRegionDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |