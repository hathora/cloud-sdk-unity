# DeploymentsV3
(*DeploymentsV3*)

## Overview

Operations that allow you configure and manage an application's [build](https://hathora.dev/docs/concepts/hathora-entities#build) at runtime.

### Available Operations

* [CreateDeployment](#createdeployment) - CreateDeployment
* [GetDeployment](#getdeployment) - GetDeployment
* [GetDeployments](#getdeployments) - GetDeployments
* [GetLatestDeployment](#getlatestdeployment) - GetLatestDeployment

## CreateDeployment

Create a new [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment). Creating a new deployment means all new rooms created will use the latest deployment configuration, but existing games in progress will not be affected.

### Example Usage

<!-- UsageSnippet language="unity" operationID="CreateDeployment" method="post" path="/deployments/v3/apps/{appId}/deployments" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;
using System.Collections.Generic;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

CreateDeploymentRequest req = new CreateDeploymentRequest() {
    DeploymentConfigV3 = new DeploymentConfigV3() {
        AdditionalContainerPorts = new List<ContainerPort>() {
            new ContainerPort() {
                Name = "default",
                Port = 8000,
                TransportType = TransportType.Udp,
            },
        },
        BuildId = "bld-6d4c6a71-2d75-4b42-94e1-f312f57f33c5",
        ContainerPort = 4000,
        DeploymentTag = "alpha",
        Env = new List<DeploymentConfigV3Env>() {
            new DeploymentConfigV3Env() {
                Name = "EULA",
                Value = "TRUE",
            },
        },
        ExperimentalRequestedGPU = 1D,
        IdleTimeoutEnabled = false,
        RequestedCPU = 0.5D,
        RequestedGPU = 1D,
        RequestedMemoryMB = 1024D,
        RoomsPerProcess = 3,
        TransportType = TransportType.Udp,
    },
};


using(var res = await sdk.DeploymentsV3.CreateDeploymentAsync(req))
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

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 404, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetDeployment

Get details for a [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetDeployment" method="get" path="/deployments/v3/apps/{appId}/deployments/{deploymentId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetDeploymentRequest req = new GetDeploymentRequest() {
    DeploymentId = "dep-6d4c6a71-2d75-4b42-94e1-f312f57f33c5",
};


using(var res = await sdk.DeploymentsV3.GetDeploymentAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetDeploymentRequest](../../Models/Operations/GetDeploymentRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[GetDeploymentResponse](../../Models/Operations/GetDeploymentResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetDeployments

Returns an array of [deployments](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application), optionally filtered by deploymentTag or buildTag.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetDeployments" method="get" path="/deployments/v3/apps/{appId}/deployments" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetDeploymentsRequest req = new GetDeploymentsRequest() {
    BuildTag = "0.1.14-14c793",
    DeploymentTag = "alpha",
};


using(var res = await sdk.DeploymentsV3.GetDeploymentsAsync(req))
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

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetLatestDeployment

Get the latest [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetLatestDeployment" method="get" path="/deployments/v3/apps/{appId}/deployments/latest" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetLatestDeploymentRequest req = new GetLatestDeploymentRequest() {};


using(var res = await sdk.DeploymentsV3.GetLatestDeploymentAsync(req))
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

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |