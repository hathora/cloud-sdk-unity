
<div align="center">
    <img src="https://user-images.githubusercontent.com/6267663/235110661-00e586cc-7489-4daf-82e8-7ae3c2c7143e.svg" width="350px">
    <p>Serverless cloud hosting for multiplayer games</p>
    <h1>Unity SDK</h1>
    <a href="https://hathora.dev/docs"><img src="https://img.shields.io/static/v1?label=Docs&message=API Ref&color=000&style=for-the-badge" /></a>
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>    
</div>

<!-- Start Summary [summary] -->
## Summary

Hathora Cloud API: Welcome to the Hathora Cloud API documentation! Learn how to use the Hathora Cloud APIs to build and scale your game servers globally.
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Global Parameters](#global-parameters)
  * [Server Selection](#server-selection)
  * [Error Handling](#error-handling)
  * [Authentication](#authentication)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

The SDK can either be compiled using `dotnet build` and the resultant `.dll` file can be copied into your Unity project's `Assets` folder, or you can copy the source code directly into your project.

The SDK relies on Newtonsoft's JSON.NET Package which can be installed via the Unity Package Manager.

To do so open the Package Manager via `Window > Package Manager` and click the `+` button then `Add package from git URL...` and enter `com.unity.nuget.newtonsoft-json` and click `Add`.
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

CreateAppRequest req = new CreateAppRequest() {
    AppConfig = new AppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {},
    },
};


using(var res = await sdk.AppsV2.CreateAppAsync(req))
{
    // handle response
}


```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [~~AppsV1~~](docs/sdks/appsv1/README.md)

* [~~CreateAppV1Deprecated~~](docs/sdks/appsv1/README.md#createappv1deprecated) - CreateAppV1Deprecated :warning: **Deprecated**
* [~~DeleteAppV1Deprecated~~](docs/sdks/appsv1/README.md#deleteappv1deprecated) - DeleteAppV1Deprecated :warning: **Deprecated**
* [~~GetAppInfoV1Deprecated~~](docs/sdks/appsv1/README.md#getappinfov1deprecated) - GetAppInfoV1Deprecated :warning: **Deprecated**
* [~~GetAppsV1Deprecated~~](docs/sdks/appsv1/README.md#getappsv1deprecated) - GetAppsV1Deprecated :warning: **Deprecated**
* [~~UpdateAppV1Deprecated~~](docs/sdks/appsv1/README.md#updateappv1deprecated) - UpdateAppV1Deprecated :warning: **Deprecated**

### [AppsV2](docs/sdks/appsv2/README.md)

* [CreateApp](docs/sdks/appsv2/README.md#createapp) - CreateApp
* [DeleteApp](docs/sdks/appsv2/README.md#deleteapp) - DeleteApp
* [GetApp](docs/sdks/appsv2/README.md#getapp) - GetApp
* [GetApps](docs/sdks/appsv2/README.md#getapps) - GetApps
* [UpdateApp](docs/sdks/appsv2/README.md#updateapp) - UpdateApp

### [AuthV1](docs/sdks/authv1/README.md)

* [LoginAnonymous](docs/sdks/authv1/README.md#loginanonymous) - LoginAnonymous
* [LoginGoogle](docs/sdks/authv1/README.md#logingoogle) - LoginGoogle
* [LoginNickname](docs/sdks/authv1/README.md#loginnickname) - LoginNickname

### [BillingV1](docs/sdks/billingv1/README.md)

* [~~GetBalance~~](docs/sdks/billingv1/README.md#getbalance) - GetBalance :warning: **Deprecated**
* [GetInvoices](docs/sdks/billingv1/README.md#getinvoices) - GetInvoices
* [GetPaymentMethod](docs/sdks/billingv1/README.md#getpaymentmethod) - GetPaymentMethod
* [GetUpcomingInvoiceItems](docs/sdks/billingv1/README.md#getupcominginvoiceitems) - GetUpcomingInvoiceItems
* [GetUpcomingInvoiceTotal](docs/sdks/billingv1/README.md#getupcominginvoicetotal) - GetUpcomingInvoiceTotal
* [InitStripeCustomerPortalUrl](docs/sdks/billingv1/README.md#initstripecustomerportalurl) - InitStripeCustomerPortalUrl

### [~~BuildsV1~~](docs/sdks/buildsv1/README.md)

* [~~CreateBuildDeprecated~~](docs/sdks/buildsv1/README.md#createbuilddeprecated) - CreateBuildDeprecated :warning: **Deprecated**
* [~~DeleteBuildDeprecated~~](docs/sdks/buildsv1/README.md#deletebuilddeprecated) - DeleteBuildDeprecated :warning: **Deprecated**
* [~~GetBuildInfoDeprecated~~](docs/sdks/buildsv1/README.md#getbuildinfodeprecated) - GetBuildInfoDeprecated :warning: **Deprecated**
* [~~GetBuildsDeprecated~~](docs/sdks/buildsv1/README.md#getbuildsdeprecated) - GetBuildsDeprecated :warning: **Deprecated**
* [~~RunBuildDeprecated~~](docs/sdks/buildsv1/README.md#runbuilddeprecated) - RunBuildDeprecated :warning: **Deprecated**

### [~~BuildsV2~~](docs/sdks/buildsv2/README.md)

* [~~CreateBuildV2Deprecated~~](docs/sdks/buildsv2/README.md#createbuildv2deprecated) - CreateBuildV2Deprecated :warning: **Deprecated**
* [~~CreateBuildWithUploadUrlV2Deprecated~~](docs/sdks/buildsv2/README.md#createbuildwithuploadurlv2deprecated) - CreateBuildWithUploadUrlV2Deprecated :warning: **Deprecated**
* [~~CreateWithMultipartUploadsV2Deprecated~~](docs/sdks/buildsv2/README.md#createwithmultipartuploadsv2deprecated) - CreateWithMultipartUploadsV2Deprecated :warning: **Deprecated**
* [~~DeleteBuildV2Deprecated~~](docs/sdks/buildsv2/README.md#deletebuildv2deprecated) - DeleteBuildV2Deprecated :warning: **Deprecated**
* [~~GetBuildInfoV2Deprecated~~](docs/sdks/buildsv2/README.md#getbuildinfov2deprecated) - GetBuildInfoV2Deprecated :warning: **Deprecated**
* [~~GetBuildsV2Deprecated~~](docs/sdks/buildsv2/README.md#getbuildsv2deprecated) - GetBuildsV2Deprecated :warning: **Deprecated**
* [~~RunBuildV2Deprecated~~](docs/sdks/buildsv2/README.md#runbuildv2deprecated) - RunBuildV2Deprecated :warning: **Deprecated**

### [BuildsV3](docs/sdks/buildsv3/README.md)

* [CreateBuild](docs/sdks/buildsv3/README.md#createbuild) - CreateBuild
* [DeleteBuild](docs/sdks/buildsv3/README.md#deletebuild) - DeleteBuild
* [GetBuild](docs/sdks/buildsv3/README.md#getbuild) - GetBuild
* [GetBuilds](docs/sdks/buildsv3/README.md#getbuilds) - GetBuilds
* [RunBuild](docs/sdks/buildsv3/README.md#runbuild) - RunBuild

### [~~DeploymentsV1~~](docs/sdks/deploymentsv1/README.md)

* [~~CreateDeploymentV1Deprecated~~](docs/sdks/deploymentsv1/README.md#createdeploymentv1deprecated) - CreateDeploymentV1Deprecated :warning: **Deprecated**
* [~~GetDeploymentInfoV1Deprecated~~](docs/sdks/deploymentsv1/README.md#getdeploymentinfov1deprecated) - GetDeploymentInfoV1Deprecated :warning: **Deprecated**
* [~~GetDeploymentsV1Deprecated~~](docs/sdks/deploymentsv1/README.md#getdeploymentsv1deprecated) - GetDeploymentsV1Deprecated :warning: **Deprecated**
* [~~GetLatestDeploymentV1Deprecated~~](docs/sdks/deploymentsv1/README.md#getlatestdeploymentv1deprecated) - GetLatestDeploymentV1Deprecated :warning: **Deprecated**

### [~~DeploymentsV2~~](docs/sdks/deploymentsv2/README.md)

* [~~CreateDeploymentV2Deprecated~~](docs/sdks/deploymentsv2/README.md#createdeploymentv2deprecated) - CreateDeploymentV2Deprecated :warning: **Deprecated**
* [~~GetDeploymentInfoV2Deprecated~~](docs/sdks/deploymentsv2/README.md#getdeploymentinfov2deprecated) - GetDeploymentInfoV2Deprecated :warning: **Deprecated**
* [~~GetDeploymentsV2Deprecated~~](docs/sdks/deploymentsv2/README.md#getdeploymentsv2deprecated) - GetDeploymentsV2Deprecated :warning: **Deprecated**
* [~~GetLatestDeploymentV2Deprecated~~](docs/sdks/deploymentsv2/README.md#getlatestdeploymentv2deprecated) - GetLatestDeploymentV2Deprecated :warning: **Deprecated**

### [DeploymentsV3](docs/sdks/deploymentsv3/README.md)

* [CreateDeployment](docs/sdks/deploymentsv3/README.md#createdeployment) - CreateDeployment
* [GetDeployment](docs/sdks/deploymentsv3/README.md#getdeployment) - GetDeployment
* [GetDeployments](docs/sdks/deploymentsv3/README.md#getdeployments) - GetDeployments
* [GetLatestDeployment](docs/sdks/deploymentsv3/README.md#getlatestdeployment) - GetLatestDeployment

### [~~DiscoveryV1~~](docs/sdks/discoveryv1/README.md)

* [~~GetPingServiceEndpointsDeprecated~~](docs/sdks/discoveryv1/README.md#getpingserviceendpointsdeprecated) - GetPingServiceEndpointsDeprecated :warning: **Deprecated**

### [DiscoveryV2](docs/sdks/discoveryv2/README.md)

* [GetPingServiceEndpoints](docs/sdks/discoveryv2/README.md#getpingserviceendpoints) - GetPingServiceEndpoints

### [FleetsV1](docs/sdks/fleetsv1/README.md)

* [GetFleetMetrics](docs/sdks/fleetsv1/README.md#getfleetmetrics) - GetFleetMetrics
* [GetFleetRegion](docs/sdks/fleetsv1/README.md#getfleetregion) - GetFleetRegion
* [GetFleets](docs/sdks/fleetsv1/README.md#getfleets) - GetFleets
* [UpdateFleetRegion](docs/sdks/fleetsv1/README.md#updatefleetregion) - UpdateFleetRegion


### [~~LobbiesV1~~](docs/sdks/lobbiesv1/README.md)

* [~~CreatePrivateLobbyDeprecated~~](docs/sdks/lobbiesv1/README.md#createprivatelobbydeprecated) - CreatePrivateLobbyDeprecated :warning: **Deprecated**
* [~~CreatePublicLobbyDeprecated~~](docs/sdks/lobbiesv1/README.md#createpubliclobbydeprecated) - CreatePublicLobbyDeprecated :warning: **Deprecated**
* [~~ListActivePublicLobbiesDeprecatedV1~~](docs/sdks/lobbiesv1/README.md#listactivepubliclobbiesdeprecatedv1) - ListActivePublicLobbiesDeprecatedV1 :warning: **Deprecated**

### [~~LobbiesV2~~](docs/sdks/lobbiesv2/README.md)

* [~~CreateLobbyDeprecated~~](docs/sdks/lobbiesv2/README.md#createlobbydeprecated) - CreateLobbyDeprecated :warning: **Deprecated**
* [~~CreateLocalLobby~~](docs/sdks/lobbiesv2/README.md#createlocallobby) - CreateLocalLobby :warning: **Deprecated**
* [~~CreatePrivateLobby~~](docs/sdks/lobbiesv2/README.md#createprivatelobby) - CreatePrivateLobby :warning: **Deprecated**
* [~~CreatePublicLobby~~](docs/sdks/lobbiesv2/README.md#createpubliclobby) - CreatePublicLobby :warning: **Deprecated**
* [~~GetLobbyInfo~~](docs/sdks/lobbiesv2/README.md#getlobbyinfo) - GetLobbyInfo :warning: **Deprecated**
* [~~ListActivePublicLobbiesDeprecatedV2~~](docs/sdks/lobbiesv2/README.md#listactivepubliclobbiesdeprecatedv2) - ListActivePublicLobbiesDeprecatedV2 :warning: **Deprecated**
* [~~SetLobbyState~~](docs/sdks/lobbiesv2/README.md#setlobbystate) - SetLobbyState :warning: **Deprecated**

### [LobbiesV3](docs/sdks/lobbiesv3/README.md)

* [CreateLobby](docs/sdks/lobbiesv3/README.md#createlobby) - CreateLobby
* [GetLobbyInfoByRoomId](docs/sdks/lobbiesv3/README.md#getlobbyinfobyroomid) - GetLobbyInfoByRoomId
* [GetLobbyInfoByShortCode](docs/sdks/lobbiesv3/README.md#getlobbyinfobyshortcode) - GetLobbyInfoByShortCode
* [ListActivePublicLobbies](docs/sdks/lobbiesv3/README.md#listactivepubliclobbies) - ListActivePublicLobbies

### [LogsV1](docs/sdks/logsv1/README.md)

* [DownloadLogForProcess](docs/sdks/logsv1/README.md#downloadlogforprocess) - DownloadLogForProcess
* [GetLogsForProcess](docs/sdks/logsv1/README.md#getlogsforprocess) - GetLogsForProcess

### [ManagementV1](docs/sdks/managementv1/README.md)

* [SendVerificationEmail](docs/sdks/managementv1/README.md#sendverificationemail) - SendVerificationEmail

### [~~MetricsV1~~](docs/sdks/metricsv1/README.md)

* [~~GetMetricsDeprecated~~](docs/sdks/metricsv1/README.md#getmetricsdeprecated) - GetMetricsDeprecated :warning: **Deprecated**

### [OrganizationsV1](docs/sdks/organizationsv1/README.md)

* [AcceptInvite](docs/sdks/organizationsv1/README.md#acceptinvite) - AcceptInvite
* [GetOrgMembers](docs/sdks/organizationsv1/README.md#getorgmembers) - GetOrgMembers
* [GetOrgPendingInvites](docs/sdks/organizationsv1/README.md#getorgpendinginvites) - GetOrgPendingInvites
* [GetOrgs](docs/sdks/organizationsv1/README.md#getorgs) - GetOrgs
* [GetUsageLimits](docs/sdks/organizationsv1/README.md#getusagelimits) - GetUsageLimits
* [GetUserPendingInvites](docs/sdks/organizationsv1/README.md#getuserpendinginvites) - GetUserPendingInvites
* [InviteUser](docs/sdks/organizationsv1/README.md#inviteuser) - InviteUser
* [RejectInvite](docs/sdks/organizationsv1/README.md#rejectinvite) - RejectInvite
* [RescindInvite](docs/sdks/organizationsv1/README.md#rescindinvite) - RescindInvite
* [UpdateUserInvite](docs/sdks/organizationsv1/README.md#updateuserinvite) - UpdateUserInvite

### [~~ProcessesV1~~](docs/sdks/processesv1/README.md)

* [~~GetProcessInfoDeprecated~~](docs/sdks/processesv1/README.md#getprocessinfodeprecated) - GetProcessInfoDeprecated :warning: **Deprecated**
* [~~GetRunningProcesses~~](docs/sdks/processesv1/README.md#getrunningprocesses) - GetRunningProcesses :warning: **Deprecated**
* [~~GetStoppedProcesses~~](docs/sdks/processesv1/README.md#getstoppedprocesses) - GetStoppedProcesses :warning: **Deprecated**

### [~~ProcessesV2~~](docs/sdks/processesv2/README.md)

* [~~CreateProcessV2Deprecated~~](docs/sdks/processesv2/README.md#createprocessv2deprecated) - CreateProcessV2Deprecated :warning: **Deprecated**
* [~~GetLatestProcessesV2Deprecated~~](docs/sdks/processesv2/README.md#getlatestprocessesv2deprecated) - GetLatestProcessesV2Deprecated :warning: **Deprecated**
* [~~GetProcessInfoV2Deprecated~~](docs/sdks/processesv2/README.md#getprocessinfov2deprecated) - GetProcessInfoV2Deprecated :warning: **Deprecated**
* [~~GetProcessesCountExperimentalV2Deprecated~~](docs/sdks/processesv2/README.md#getprocessescountexperimentalv2deprecated) - GetProcessesCountExperimentalV2Deprecated :warning: **Deprecated**
* [~~StopProcessV2Deprecated~~](docs/sdks/processesv2/README.md#stopprocessv2deprecated) - StopProcessV2Deprecated :warning: **Deprecated**

### [ProcessesV3](docs/sdks/processesv3/README.md)

* [CreateProcess](docs/sdks/processesv3/README.md#createprocess) - CreateProcess
* [GetLatestProcesses](docs/sdks/processesv3/README.md#getlatestprocesses) - GetLatestProcesses
* [GetProcess](docs/sdks/processesv3/README.md#getprocess) - GetProcess
* [GetProcessMetrics](docs/sdks/processesv3/README.md#getprocessmetrics) - GetProcessMetrics
* [GetProcessesCountExperimental](docs/sdks/processesv3/README.md#getprocessescountexperimental) - GetProcessesCountExperimental
* [StopProcess](docs/sdks/processesv3/README.md#stopprocess) - StopProcess

### [~~RoomsV1~~](docs/sdks/roomsv1/README.md)

* [~~CreateRoomDeprecated~~](docs/sdks/roomsv1/README.md#createroomdeprecated) - CreateRoomDeprecated :warning: **Deprecated**
* [~~DestroyRoomDeprecated~~](docs/sdks/roomsv1/README.md#destroyroomdeprecated) - DestroyRoomDeprecated :warning: **Deprecated**
* [~~GetActiveRoomsForProcessDeprecated~~](docs/sdks/roomsv1/README.md#getactiveroomsforprocessdeprecated) - GetActiveRoomsForProcessDeprecated :warning: **Deprecated**
* [~~GetConnectionInfoDeprecated~~](docs/sdks/roomsv1/README.md#getconnectioninfodeprecated) - GetConnectionInfoDeprecated :warning: **Deprecated**
* [~~GetInactiveRoomsForProcessDeprecated~~](docs/sdks/roomsv1/README.md#getinactiveroomsforprocessdeprecated) - GetInactiveRoomsForProcessDeprecated :warning: **Deprecated**
* [~~GetRoomInfoDeprecated~~](docs/sdks/roomsv1/README.md#getroominfodeprecated) - GetRoomInfoDeprecated :warning: **Deprecated**
* [~~SuspendRoomDeprecated~~](docs/sdks/roomsv1/README.md#suspendroomdeprecated) - SuspendRoomDeprecated :warning: **Deprecated**

### [RoomsV2](docs/sdks/roomsv2/README.md)

* [CreateRoom](docs/sdks/roomsv2/README.md#createroom) - CreateRoom
* [DestroyRoom](docs/sdks/roomsv2/README.md#destroyroom) - DestroyRoom
* [GetActiveRoomsForProcess](docs/sdks/roomsv2/README.md#getactiveroomsforprocess) - GetActiveRoomsForProcess
* [GetConnectionInfo](docs/sdks/roomsv2/README.md#getconnectioninfo) - GetConnectionInfo
* [GetInactiveRoomsForProcess](docs/sdks/roomsv2/README.md#getinactiveroomsforprocess) - GetInactiveRoomsForProcess
* [GetRoomInfo](docs/sdks/roomsv2/README.md#getroominfo) - GetRoomInfo
* [ResumeRoom](docs/sdks/roomsv2/README.md#resumeroom) - ResumeRoom
* [~~SuspendRoomV2Deprecated~~](docs/sdks/roomsv2/README.md#suspendroomv2deprecated) - SuspendRoomV2Deprecated :warning: **Deprecated**
* [UpdateRoomConfig](docs/sdks/roomsv2/README.md#updateroomconfig) - UpdateRoomConfig

### [TokensV1](docs/sdks/tokensv1/README.md)

* [CreateOrgToken](docs/sdks/tokensv1/README.md#createorgtoken) - CreateOrgToken
* [GetOrgTokens](docs/sdks/tokensv1/README.md#getorgtokens) - GetOrgTokens
* [RevokeOrgToken](docs/sdks/tokensv1/README.md#revokeorgtoken) - RevokeOrgToken

</details>
<!-- End Available Resources and Operations [operations] -->





<!-- Start Global Parameters [global-parameters] -->
## Global Parameters

Certain parameters are configured globally. These parameters may be set on the SDK client instance itself during initialization. When configured as an option during SDK initialization, These global values will be used as defaults on the operations that use them. When such operations are called, there is a place in each to override the global value, if needed.

For example, you can set `appId` to `"app-af469a92-5b45-4565-b3c4-b79878de67d2"` at SDK initialization and then you do not have to pass the same value on calls to operations like `CreateApp`. But if you want to do so you may, which will locally override the global setting. See the example code below for a demonstration.


### Available Globals

The following global parameters are available.

| Name  | Type   | Description          |
| ----- | ------ | -------------------- |
| AppId | string | The AppId parameter. |
| OrgId | string | The OrgId parameter. |

### Example

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

CreateAppRequest req = new CreateAppRequest() {
    AppConfig = new AppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {},
    },
};


using(var res = await sdk.AppsV2.CreateAppAsync(req))
{
    // handle response
}


```
<!-- End Global Parameters [global-parameters] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: int` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| #   | Server                    | Description |
| --- | ------------------------- | ----------- |
| 0   | `https://api.hathora.dev` |             |
| 1   | `/`                       |             |

#### Example

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    serverIndex: 1,
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

CreateAppRequest req = new CreateAppRequest() {
    AppConfig = new AppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {},
    },
};


using(var res = await sdk.AppsV2.CreateAppAsync(req))
{
    // handle response
}


```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    serverUrl: "https://api.hathora.dev",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

CreateAppRequest req = new CreateAppRequest() {
    AppConfig = new AppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {},
    },
};


using(var res = await sdk.AppsV2.CreateAppAsync(req))
{
    // handle response
}


```
<!-- End Server Selection [server] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `HathoraCloud.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `StatusCode`  | *int*                 | The raw HTTP response |
| `RawResponse` | *HttpResponseMessage* | The raw HTTP response |
| `Body`        | *string*              | The response content  |

When custom error responses are specified for an operation, the SDK may also throw their associated exception. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `CreateAppAsync` method throws the following exceptions:

| Error Type                              | Status Code        | Content Type     |
| --------------------------------------- | ------------------ | ---------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429 | application/json |
| HathoraCloud.Models.Errors.ApiError     | 500                | application/json |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX           | \*/\*            |

### Example

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using System;
using HathoraCloud.Models.Errors;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

CreateAppRequest req = new CreateAppRequest() {
    AppConfig = new AppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {},
    },
};

try
{
    using(var res = await sdk.AppsV2.CreateAppAsync(req))
    {
            // handle response
    }
}
catch (Exception ex)
{
    if (ex is ApiError)
    {
        // handle exception
    }
    else if (ex is ApiError)
    {
        // handle exception
    }
    else if (ex is HathoraCloud.Models.Errors.SDKException)
    {
        // handle exception
    }
}

```
<!-- End Error Handling [errors] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name              | Type | Scheme      |
| ----------------- | ---- | ----------- |
| `HathoraDevToken` | http | HTTP Bearer |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

CreateAppRequest req = new CreateAppRequest() {
    AppConfig = new AppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {},
    },
};


using(var res = await sdk.AppsV2.CreateAppAsync(req))
{
    // handle response
}


```

### Per-Operation Security Schemes

Some operations in this SDK require the security scheme to be specified at the request level. For example:
```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

CreateLobbyRequest req = new CreateLobbyRequest() {
    CreateLobbyV3Params = new CreateLobbyV3Params() {
        Region = Region.Seattle,
        RoomConfig = "{\"name\":\"my-room\"}",
        Visibility = LobbyVisibility.Private,
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    RoomId = "2swovpy1fnunu",
    ShortCode = "LFG4",
};


using(var res = await sdk.LobbiesV3.CreateLobbyAsync(
    security: new CreateLobbySecurity() {
        PlayerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    req))
{
    // handle response
}


```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->



### Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

### Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
