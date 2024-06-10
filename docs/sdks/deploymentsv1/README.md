# DeploymentsV1
(*DeploymentsV1*)

### Available Operations

* [~~CreateDeploymentDeprecated~~](#createdeploymentdeprecated) - Create a new [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment). Creating a new deployment means all new rooms created will use the latest deployment configuration, but existing games in progress will not be affected. :warning: **Deprecated**
* [~~GetDeploymentInfoDeprecated~~](#getdeploymentinfodeprecated) - Get details for a [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment). :warning: **Deprecated**
* [~~GetDeploymentsDeprecated~~](#getdeploymentsdeprecated) - Returns an array of [deployments](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application). :warning: **Deprecated**
* [~~GetLatestDeploymentDeprecated~~](#getlatestdeploymentdeprecated) - Get the latest [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application). :warning: **Deprecated**

## ~~CreateDeploymentDeprecated~~

Create a new [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment). Creating a new deployment means all new rooms created will use the latest deployment configuration, but existing games in progress will not be affected.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

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

CreateDeploymentDeprecatedRequest req = new CreateDeploymentDeprecatedRequest() {
    DeploymentConfig = new DeploymentConfig() {
        AdditionalContainerPorts = new List<ContainerPort>() {
            new ContainerPort() {
                Name = "default",
                Port = 8000,
                TransportType = TransportType.Udp,
            },
        },
        ContainerPort = 4000,
        Env = new List<DeploymentConfigEnv>() {
            new DeploymentConfigEnv() {
                Name = "EULA",
                Value = "TRUE",
            },
        },
        PlanName = PlanName.Tiny,
        RoomsPerProcess = 3,
        TransportType = TransportType.Tls,
    },
    BuildId = 1,
};


using(var res = await sdk.DeploymentsV1.CreateDeploymentDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [CreateDeploymentDeprecatedRequest](../../Models/Operations/CreateDeploymentDeprecatedRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |


### Response

**[CreateDeploymentDeprecatedResponse](../../Models/Operations/CreateDeploymentDeprecatedResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400,401,404,422,429,500                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## ~~GetDeploymentInfoDeprecated~~

Get details for a [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment).

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

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

GetDeploymentInfoDeprecatedRequest req = new GetDeploymentInfoDeprecatedRequest() {
    DeploymentId = 1,
};


using(var res = await sdk.DeploymentsV1.GetDeploymentInfoDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [GetDeploymentInfoDeprecatedRequest](../../Models/Operations/GetDeploymentInfoDeprecatedRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |


### Response

**[GetDeploymentInfoDeprecatedResponse](../../Models/Operations/GetDeploymentInfoDeprecatedResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401,404                                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## ~~GetDeploymentsDeprecated~~

Returns an array of [deployments](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

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

GetDeploymentsDeprecatedRequest req = new GetDeploymentsDeprecatedRequest() {};


using(var res = await sdk.DeploymentsV1.GetDeploymentsDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetDeploymentsDeprecatedRequest](../../Models/Operations/GetDeploymentsDeprecatedRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[GetDeploymentsDeprecatedResponse](../../Models/Operations/GetDeploymentsDeprecatedResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401,404                                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## ~~GetLatestDeploymentDeprecated~~

Get the latest [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

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

GetLatestDeploymentDeprecatedRequest req = new GetLatestDeploymentDeprecatedRequest() {};


using(var res = await sdk.DeploymentsV1.GetLatestDeploymentDeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetLatestDeploymentDeprecatedRequest](../../Models/Operations/GetLatestDeploymentDeprecatedRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[GetLatestDeploymentDeprecatedResponse](../../Models/Operations/GetLatestDeploymentDeprecatedResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401,404                                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
