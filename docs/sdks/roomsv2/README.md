# RoomsV2

## Overview

### Available Operations

* [CreateRoom](#createroom) - CreateRoom
* [DestroyRoom](#destroyroom) - DestroyRoom
* [GetActiveRoomsForProcess](#getactiveroomsforprocess) - GetActiveRoomsForProcess
* [GetConnectionInfo](#getconnectioninfo) - GetConnectionInfo
* [GetInactiveRoomsForProcess](#getinactiveroomsforprocess) - GetInactiveRoomsForProcess
* [GetRoomInfo](#getroominfo) - GetRoomInfo
* [ResumeRoom](#resumeroom) - ResumeRoom
* [~~SuspendRoomV2Deprecated~~](#suspendroomv2deprecated) - SuspendRoomV2Deprecated :warning: **Deprecated**
* [UpdateRoomConfig](#updateroomconfig) - UpdateRoomConfig

## CreateRoom

Create a new [room](https://hathora.dev/docs/concepts/hathora-entities#room) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application). Poll the [`GetConnectionInfo()`](https://hathora.dev/api#tag/RoomV2/operation/GetConnectionInfo) endpoint to get connection details for an active room.

### Example Usage

<!-- UsageSnippet language="unity" operationID="CreateRoom" method="post" path="/rooms/v2/{appId}/create" -->
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

CreateRoomRequest req = new CreateRoomRequest() {
    CreateRoomParams = new CreateRoomParams() {
        ClientIPs = new List<string>() {
            "123.123.123.123",
        },
        DeploymentId = "dep-6d4c6a71-2d75-4b42-94e1-f312f57f33c5",
        Region = Region.Dallas,
        RoomConfig = "{\"name\":\"my-room\"}",
    },
    RoomId = "2swovpy1fnunu",
};


using(var res = await sdk.RoomsV2.CreateRoomAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CreateRoomRequest](../../Models/Operations/CreateRoomRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[CreateRoomResponse](../../Models/Operations/CreateRoomResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 402, 404, 408, 422, 429       | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## DestroyRoom

Destroy a [room](https://hathora.dev/docs/concepts/hathora-entities#room). All associated metadata is deleted.

### Example Usage

<!-- UsageSnippet language="unity" operationID="DestroyRoom" method="post" path="/rooms/v2/{appId}/destroy/{roomId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

DestroyRoomRequest req = new DestroyRoomRequest() {
    RoomId = "2swovpy1fnunu",
};


using(var res = await sdk.RoomsV2.DestroyRoomAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [DestroyRoomRequest](../../Models/Operations/DestroyRoomRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[DestroyRoomResponse](../../Models/Operations/DestroyRoomResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetActiveRoomsForProcess

Get all active [rooms](https://hathora.dev/docs/concepts/hathora-entities#room) for a given [process](https://hathora.dev/docs/concepts/hathora-entities#process).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetActiveRoomsForProcess" method="get" path="/rooms/v2/{appId}/list/{processId}/active" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetActiveRoomsForProcessRequest req = new GetActiveRoomsForProcessRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
};


using(var res = await sdk.RoomsV2.GetActiveRoomsForProcessAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetActiveRoomsForProcessRequest](../../Models/Operations/GetActiveRoomsForProcessRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetActiveRoomsForProcessResponse](../../Models/Operations/GetActiveRoomsForProcessResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetConnectionInfo

Poll this endpoint to get connection details to a [room](https://hathora.dev/docs/concepts/hathora-entities#room). Clients can call this endpoint without authentication.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetConnectionInfo" method="get" path="/rooms/v2/{appId}/connectioninfo/{roomId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

GetConnectionInfoRequest req = new GetConnectionInfoRequest() {
    RoomId = "2swovpy1fnunu",
};


using(var res = await sdk.RoomsV2.GetConnectionInfoAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetConnectionInfoRequest](../../Models/Operations/GetConnectionInfoRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetConnectionInfoResponse](../../Models/Operations/GetConnectionInfoResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 402, 404, 408, 422, 429            | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetInactiveRoomsForProcess

Get all inactive [rooms](https://hathora.dev/docs/concepts/hathora-entities#room) for a given [process](https://hathora.dev/docs/concepts/hathora-entities#process).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetInactiveRoomsForProcess" method="get" path="/rooms/v2/{appId}/list/{processId}/inactive" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetInactiveRoomsForProcessRequest req = new GetInactiveRoomsForProcessRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
};


using(var res = await sdk.RoomsV2.GetInactiveRoomsForProcessAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GetInactiveRoomsForProcessRequest](../../Models/Operations/GetInactiveRoomsForProcessRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[GetInactiveRoomsForProcessResponse](../../Models/Operations/GetInactiveRoomsForProcessResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetRoomInfo

Retreive current and historical allocation data for a [room](https://hathora.dev/docs/concepts/hathora-entities#room).

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetRoomInfo" method="get" path="/rooms/v2/{appId}/info/{roomId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetRoomInfoRequest req = new GetRoomInfoRequest() {
    RoomId = "2swovpy1fnunu",
};


using(var res = await sdk.RoomsV2.GetRoomInfoAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetRoomInfoRequest](../../Models/Operations/GetRoomInfoRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[GetRoomInfoResponse](../../Models/Operations/GetRoomInfoResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ResumeRoom

ResumeRoom

### Example Usage

<!-- UsageSnippet language="unity" operationID="ResumeRoom" method="post" path="/rooms/v2/{appId}/resume/{roomId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

ResumeRoomRequest req = new ResumeRoomRequest() {
    RoomId = "2swovpy1fnunu",
};


using(var res = await sdk.RoomsV2.ResumeRoomAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ResumeRoomRequest](../../Models/Operations/ResumeRoomRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[ResumeRoomResponse](../../Models/Operations/ResumeRoomResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 402, 404, 408, 422, 429       | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ~~SuspendRoomV2Deprecated~~

Suspend a [room](https://hathora.dev/docs/concepts/hathora-entities#room). The room is unallocated from the process but can be rescheduled later using the same `roomId`.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="unity" operationID="SuspendRoomV2Deprecated" method="post" path="/rooms/v2/{appId}/suspend/{roomId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

SuspendRoomV2DeprecatedRequest req = new SuspendRoomV2DeprecatedRequest() {
    RoomId = "2swovpy1fnunu",
};


using(var res = await sdk.RoomsV2.SuspendRoomV2DeprecatedAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [SuspendRoomV2DeprecatedRequest](../../Models/Operations/SuspendRoomV2DeprecatedRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[SuspendRoomV2DeprecatedResponse](../../Models/Operations/SuspendRoomV2DeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## UpdateRoomConfig

UpdateRoomConfig

### Example Usage

<!-- UsageSnippet language="unity" operationID="UpdateRoomConfig" method="post" path="/rooms/v2/{appId}/update/{roomId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

UpdateRoomConfigRequest req = new UpdateRoomConfigRequest() {
    UpdateRoomConfigParams = new UpdateRoomConfigParams() {
        RoomConfig = "{\"name\":\"my-room\"}",
    },
    RoomId = "2swovpy1fnunu",
};


using(var res = await sdk.RoomsV2.UpdateRoomConfigAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateRoomConfigRequest](../../Models/Operations/UpdateRoomConfigRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateRoomConfigResponse](../../Models/Operations/UpdateRoomConfigResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |