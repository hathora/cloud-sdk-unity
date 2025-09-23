# DeploymentsV1
(*DeploymentsV1*)

## Overview

### Available Operations

* [~~CreateDeploymentV1Deprecated~~](#createdeploymentv1deprecated) - CreateDeploymentV1Deprecated :warning: **Deprecated**
* [~~GetDeploymentInfoV1Deprecated~~](#getdeploymentinfov1deprecated) - GetDeploymentInfoV1Deprecated :warning: **Deprecated**
* [~~GetDeploymentsV1Deprecated~~](#getdeploymentsv1deprecated) - GetDeploymentsV1Deprecated :warning: **Deprecated**
* [~~GetLatestDeploymentV1Deprecated~~](#getlatestdeploymentv1deprecated) - GetLatestDeploymentV1Deprecated :warning: **Deprecated**

## ~~CreateDeploymentV1Deprecated~~

Create a new [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment). Creating a new deployment means all new rooms created will use the latest deployment configuration, but existing games in progress will not be affected.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="CreateDeploymentV1Deprecated" method="post" path="/deployments/v1/{appId}/create/{buildId}" -->
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

CreateDeploymentV1DeprecatedRequest req = new CreateDeploymentV1DeprecatedRequest() {
    DeploymentConfig = new DeploymentConfig() {
        AdditionalContainerPorts = new List<ContainerPort>() {
            new ContainerPort() {
                Name = "default",
                Port = 8000,
                TransportType = TransportType.Tls,
            },
        },
        ContainerPort = 4000,
        Env = new List<Env>() {},
        PlanName = PlanName.Tiny,
        RoomsPerProcess = 3,
        TransportType = TransportType.Udp,
    },
    BuildId = 1,
};


using(var res = await sdk.DeploymentsV1.CreateDeploymentV1DeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [CreateDeploymentV1DeprecatedRequest](../../Models/Operations/CreateDeploymentV1DeprecatedRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[CreateDeploymentV1DeprecatedResponse](../../Models/Operations/CreateDeploymentV1DeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 404, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~GetDeploymentInfoV1Deprecated~~

Get details for a [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment).

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetDeploymentInfoV1Deprecated" method="get" path="/deployments/v1/{appId}/info/{deploymentId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetDeploymentInfoV1DeprecatedRequest req = new GetDeploymentInfoV1DeprecatedRequest() {
    DeploymentId = 1,
};


using(var res = await sdk.DeploymentsV1.GetDeploymentInfoV1DeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetDeploymentInfoV1DeprecatedRequest](../../Models/Operations/GetDeploymentInfoV1DeprecatedRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[GetDeploymentInfoV1DeprecatedResponse](../../Models/Operations/GetDeploymentInfoV1DeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~GetDeploymentsV1Deprecated~~

Returns an array of [deployments](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetDeploymentsV1Deprecated" method="get" path="/deployments/v1/{appId}/list" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetDeploymentsV1DeprecatedRequest req = new GetDeploymentsV1DeprecatedRequest() {};


using(var res = await sdk.DeploymentsV1.GetDeploymentsV1DeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GetDeploymentsV1DeprecatedRequest](../../Models/Operations/GetDeploymentsV1DeprecatedRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[GetDeploymentsV1DeprecatedResponse](../../Models/Operations/GetDeploymentsV1DeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~GetLatestDeploymentV1Deprecated~~

Get the latest [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetLatestDeploymentV1Deprecated" method="get" path="/deployments/v1/{appId}/latest" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetLatestDeploymentV1DeprecatedRequest req = new GetLatestDeploymentV1DeprecatedRequest() {};


using(var res = await sdk.DeploymentsV1.GetLatestDeploymentV1DeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [GetLatestDeploymentV1DeprecatedRequest](../../Models/Operations/GetLatestDeploymentV1DeprecatedRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |

### Response

**[GetLatestDeploymentV1DeprecatedResponse](../../Models/Operations/GetLatestDeploymentV1DeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |