# FleetsV1
(*FleetsV1*)

## Overview

### Available Operations

* [GetFleetRegion](#getfleetregion)
* [GetFleets](#getfleets)
* [UpdateFleetRegion](#updatefleetregion)

## GetFleetRegion

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

GetFleetRegionRequest req = new GetFleetRegionRequest() {
    FleetId = "<id>",
    Region = Region.SaoPaulo,
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
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

GetFleetsRequest req = new GetFleetsRequest() {
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
};


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

## UpdateFleetRegion

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

UpdateFleetRegionRequest req = new UpdateFleetRegionRequest() {
    FleetRegionConfig = new FleetRegionConfig() {
        CloudMinVcpus = 511402,
    },
    FleetId = "<id>",
    Region = Region.Singapore,
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
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
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429, 500                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |