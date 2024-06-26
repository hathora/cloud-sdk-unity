# DeploymentV2
(*DeploymentV2*)

## Overview

Operations that allow you configure and manage an application's [build](https://hathora.dev/docs/concepts/hathora-entities#build) at runtime.

### Available Operations

* [CreateDeployment](#createdeployment) - Create a new [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment). Creating a new deployment means all new rooms created will use the latest deployment configuration, but existing games in progress will not be affected.
* [GetDeploymentInfo](#getdeploymentinfo) - Get details for a [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment).
* [GetDeployments](#getdeployments) - Returns an array of [deployments](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).
* [GetLatestDeployment](#getlatestdeployment) - Get the latest [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

## CreateDeployment

Create a new [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment). Creating a new deployment means all new rooms created will use the latest deployment configuration, but existing games in progress will not be affected.

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

CreateDeploymentRequest req = new CreateDeploymentRequest() {
    DeploymentConfigV2 = new DeploymentConfigV2() {
        AdditionalContainerPorts = new List<ContainerPort>() {
            new ContainerPort() {
                Name = "default",
                Port = 8000,
                TransportType = TransportType.Udp,
            },
        },
        ContainerPort = 4000,
        Env = new List<DeploymentConfigV2Env>() {
            new DeploymentConfigV2Env() {
                Name = "EULA",
                Value = "TRUE",
            },
        },
        IdleTimeoutEnabled = false,
        RequestedCPU = 0.5D,
        RequestedMemoryMB = 1024D,
        RoomsPerProcess = 3,
        TransportType = TransportType.Tcp,
    },
    BuildId = 1,
};


using(var res = await sdk.DeploymentV2.CreateDeploymentAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [CreateDeploymentRequest](../../Models/Operations/CreateDeploymentRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[CreateDeploymentResponse](../../Models/Operations/CreateDeploymentResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400,401,404,429,500                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GetDeploymentInfo

Get details for a [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment).

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

GetDeploymentInfoRequest req = new GetDeploymentInfoRequest() {
    DeploymentId = 1,
};


using(var res = await sdk.DeploymentV2.GetDeploymentInfoAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetDeploymentInfoRequest](../../Models/Operations/GetDeploymentInfoRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetDeploymentInfoResponse](../../Models/Operations/GetDeploymentInfoResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401,404                                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GetDeployments

Returns an array of [deployments](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

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

GetDeploymentsRequest req = new GetDeploymentsRequest() {};


using(var res = await sdk.DeploymentV2.GetDeploymentsAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetDeploymentsRequest](../../Models/Operations/GetDeploymentsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetDeploymentsResponse](../../Models/Operations/GetDeploymentsResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401,404                                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GetLatestDeployment

Get the latest [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

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

GetLatestDeploymentRequest req = new GetLatestDeploymentRequest() {};


using(var res = await sdk.DeploymentV2.GetLatestDeploymentAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetLatestDeploymentRequest](../../Models/Operations/GetLatestDeploymentRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GetLatestDeploymentResponse](../../Models/Operations/GetLatestDeploymentResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401,404                                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
