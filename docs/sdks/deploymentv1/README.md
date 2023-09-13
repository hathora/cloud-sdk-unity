# deploymentV1

## Overview

Operations that allow you configure and manage an application's [build](https://hathora.dev/docs/concepts/hathora-entities#build) at runtime.

### Available Operations

* [CreateDeployment](#createdeployment) - Create a new [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment). Creating a new deployment means all new rooms created will use the latest deployment configuration, but existing games in progress will not be affected.
* [GetDeploymentInfo](#getdeploymentinfo) - Get details for a [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment).
* [GetDeployments](#getdeployments) - Returns an array of [deployments](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

## CreateDeployment

Create a new [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment). Creating a new deployment means all new rooms created will use the latest deployment configuration, but existing games in progress will not be affected.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK();

using(var res = await sdk.DeploymentV1.CreateDeploymentAsync(new CreateDeploymentSecurity() {
        HathoraDevToken = "",
    }, new CreateDeploymentRequest() {
        DeploymentConfig = new DeploymentConfig() {
            AdditionalContainerPorts = new List<ContainerPort>() {
                new ContainerPort() {
                    Name = "default",
                    Port = 8000,
                    TransportType = HathoraCloud.Models.Shared.TransportType.Udp,
                },
            },
            ContainerPort = 4000,
            Env = new List<DeploymentConfigEnv>() {
                new DeploymentConfigEnv() {
                    Name = "EULA",
                    Value = "TRUE",
                },
            },
            PlanName = HathoraCloud.Models.Shared.PlanName.Tiny,
            RoomsPerProcess = 3,
            TransportType = HathoraCloud.Models.Shared.TransportType.Tls,
        },
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        BuildId = 1,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [CreateDeploymentRequest](../../models/operations/CreateDeploymentRequest.md)   | :heavy_check_mark:                                                              | The request object to use for the request.                                      |
| `security`                                                                      | [CreateDeploymentSecurity](../../models/operations/CreateDeploymentSecurity.md) | :heavy_check_mark:                                                              | The security requirements to use for the request.                               |


### Response

**[CreateDeploymentResponse](../../models/operations/CreateDeploymentResponse.md)**


## GetDeploymentInfo

Get details for a [deployment](https://hathora.dev/docs/concepts/hathora-entities#deployment).

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK();

using(var res = await sdk.DeploymentV1.GetDeploymentInfoAsync(new GetDeploymentInfoSecurity() {
        HathoraDevToken = "",
    }, new GetDeploymentInfoRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        DeploymentId = 1,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetDeploymentInfoRequest](../../models/operations/GetDeploymentInfoRequest.md)   | :heavy_check_mark:                                                                | The request object to use for the request.                                        |
| `security`                                                                        | [GetDeploymentInfoSecurity](../../models/operations/GetDeploymentInfoSecurity.md) | :heavy_check_mark:                                                                | The security requirements to use for the request.                                 |


### Response

**[GetDeploymentInfoResponse](../../models/operations/GetDeploymentInfoResponse.md)**


## GetDeployments

Returns an array of [deployments](https://hathora.dev/docs/concepts/hathora-entities#deployment) for an [application](https://hathora.dev/docs/concepts/hathora-entities#application).

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK();

using(var res = await sdk.DeploymentV1.GetDeploymentsAsync(new GetDeploymentsSecurity() {
        HathoraDevToken = "",
    }, new GetDeploymentsRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetDeploymentsRequest](../../models/operations/GetDeploymentsRequest.md)   | :heavy_check_mark:                                                          | The request object to use for the request.                                  |
| `security`                                                                  | [GetDeploymentsSecurity](../../models/operations/GetDeploymentsSecurity.md) | :heavy_check_mark:                                                          | The security requirements to use for the request.                           |


### Response

**[GetDeploymentsResponse](../../models/operations/GetDeploymentsResponse.md)**

