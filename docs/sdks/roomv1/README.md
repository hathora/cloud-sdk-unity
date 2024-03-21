# RoomV1
(*RoomV1*)

## Overview

Deprecated. Use [RoomV2](https://hathora.dev/api#tag/RoomV2).

### Available Operations

* [~~CreateRoomDeprecated~~](#createroomdeprecated) - :warning: **Deprecated**
* [~~DestroyRoomDeprecated~~](#destroyroomdeprecated) - :warning: **Deprecated**
* [~~GetActiveRoomsForProcessDeprecated~~](#getactiveroomsforprocessdeprecated) - :warning: **Deprecated**
* [~~GetConnectionInfoDeprecated~~](#getconnectioninfodeprecated) - :warning: **Deprecated**
* [~~GetInactiveRoomsForProcessDeprecated~~](#getinactiveroomsforprocessdeprecated) - :warning: **Deprecated**
* [~~GetRoomInfoDeprecated~~](#getroominfodeprecated) - :warning: **Deprecated**
* [~~SuspendRoomDeprecated~~](#suspendroomdeprecated) - :warning: **Deprecated**

## ~~CreateRoomDeprecated~~

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

CreateRoomDeprecatedRequest req = new CreateRoomDeprecatedRequest() {
    CreateRoomParams = new CreateRoomParams() {
        Region = Region.Chicago,
        RoomConfig = "{\"name\":\"my-room\"}",
    },
    RoomId = "2swovpy1fnunu",
};

using(var res = await sdk.RoomV1.CreateRoomDeprecatedAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [CreateRoomDeprecatedRequest](../../Models/Operations/CreateRoomDeprecatedRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[CreateRoomDeprecatedResponse](../../Models/Operations/CreateRoomDeprecatedResponse.md)**


## ~~DestroyRoomDeprecated~~

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

DestroyRoomDeprecatedRequest req = new DestroyRoomDeprecatedRequest() {
    RoomId = "2swovpy1fnunu",
};

using(var res = await sdk.RoomV1.DestroyRoomDeprecatedAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [DestroyRoomDeprecatedRequest](../../Models/Operations/DestroyRoomDeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[DestroyRoomDeprecatedResponse](../../Models/Operations/DestroyRoomDeprecatedResponse.md)**


## ~~GetActiveRoomsForProcessDeprecated~~

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

GetActiveRoomsForProcessDeprecatedRequest req = new GetActiveRoomsForProcessDeprecatedRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
};

using(var res = await sdk.RoomV1.GetActiveRoomsForProcessDeprecatedAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [GetActiveRoomsForProcessDeprecatedRequest](../../Models/Operations/GetActiveRoomsForProcessDeprecatedRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |


### Response

**[GetActiveRoomsForProcessDeprecatedResponse](../../Models/Operations/GetActiveRoomsForProcessDeprecatedResponse.md)**


## ~~GetConnectionInfoDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

GetConnectionInfoDeprecatedRequest req = new GetConnectionInfoDeprecatedRequest() {
    RoomId = "2swovpy1fnunu",
};

using(var res = await sdk.RoomV1.GetConnectionInfoDeprecatedAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [GetConnectionInfoDeprecatedRequest](../../Models/Operations/GetConnectionInfoDeprecatedRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |


### Response

**[GetConnectionInfoDeprecatedResponse](../../Models/Operations/GetConnectionInfoDeprecatedResponse.md)**


## ~~GetInactiveRoomsForProcessDeprecated~~

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

GetInactiveRoomsForProcessDeprecatedRequest req = new GetInactiveRoomsForProcessDeprecatedRequest() {
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
};

using(var res = await sdk.RoomV1.GetInactiveRoomsForProcessDeprecatedAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                             | [GetInactiveRoomsForProcessDeprecatedRequest](../../Models/Operations/GetInactiveRoomsForProcessDeprecatedRequest.md) | :heavy_check_mark:                                                                                                    | The request object to use for the request.                                                                            |


### Response

**[GetInactiveRoomsForProcessDeprecatedResponse](../../Models/Operations/GetInactiveRoomsForProcessDeprecatedResponse.md)**


## ~~GetRoomInfoDeprecated~~

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

GetRoomInfoDeprecatedRequest req = new GetRoomInfoDeprecatedRequest() {
    RoomId = "2swovpy1fnunu",
};

using(var res = await sdk.RoomV1.GetRoomInfoDeprecatedAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetRoomInfoDeprecatedRequest](../../Models/Operations/GetRoomInfoDeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[GetRoomInfoDeprecatedResponse](../../Models/Operations/GetRoomInfoDeprecatedResponse.md)**


## ~~SuspendRoomDeprecated~~

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

SuspendRoomDeprecatedRequest req = new SuspendRoomDeprecatedRequest() {
    RoomId = "2swovpy1fnunu",
};

using(var res = await sdk.RoomV1.SuspendRoomDeprecatedAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [SuspendRoomDeprecatedRequest](../../Models/Operations/SuspendRoomDeprecatedRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[SuspendRoomDeprecatedResponse](../../Models/Operations/SuspendRoomDeprecatedResponse.md)**

