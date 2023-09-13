# lobbyV2

## Overview

Operations to create and manage [lobbies](https://hathora.dev/docs/concepts/hathora-entities#lobby).

### Available Operations

* [CreateLobby](#createlobby) - Create a new lobby for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
* [~~CreateLocalLobby~~](#createlocallobby) - :warning: **Deprecated**
* [~~CreatePrivateLobby~~](#createprivatelobby) - :warning: **Deprecated**
* [~~CreatePublicLobby~~](#createpubliclobby) - :warning: **Deprecated**
* [GetLobbyInfo](#getlobbyinfo) - Get details for an existing lobby using `appId` and `roomId`.
* [ListActivePublicLobbies](#listactivepubliclobbies) - Get all active lobbies for a given [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a `region`.
* [SetLobbyState](#setlobbystate) - Set the state of a lobby using `appId` and `roomId`. State is intended to be set by the server and must be smaller than 1MB.

## CreateLobby

Create a new lobby for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.LobbyV2.CreateLobbyAsync(new Models.Operations.CreateLobbyRequest() {
        CreateLobbyRequest = new Models.Shared.CreateLobbyRequest() {
            InitialConfig = new LobbyInitialConfig() {},
            Region = Hathora.Models.Shared.Region.London,
            Visibility = Hathora.Models.Shared.LobbyVisibility.Private,
        },
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [Models.Operations.CreateLobbyRequest](../../models/operations/CreateLobbyRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[CreateLobbyResponse](../../models/operations/CreateLobbyResponse.md)**


## ~~CreateLocalLobby~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.LobbyV2.CreateLocalLobbyAsync(new CreateLocalLobbyRequest() {
        RequestBody = new CreateLocalLobbyRequestBody() {
            InitialConfig = new LobbyInitialConfig() {},
            Region = Hathora.Models.Shared.Region.Frankfurt,
        },
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [CreateLocalLobbyRequest](../../models/operations/CreateLocalLobbyRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[CreateLocalLobbyResponse](../../models/operations/CreateLocalLobbyResponse.md)**


## ~~CreatePrivateLobby~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.LobbyV2.CreatePrivateLobbyAsync(new CreatePrivateLobbyRequest() {
        RequestBody = new CreatePrivateLobbyRequestBody() {
            InitialConfig = new LobbyInitialConfig() {},
            Region = Hathora.Models.Shared.Region.Chicago,
        },
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [CreatePrivateLobbyRequest](../../models/operations/CreatePrivateLobbyRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[CreatePrivateLobbyResponse](../../models/operations/CreatePrivateLobbyResponse.md)**


## ~~CreatePublicLobby~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.LobbyV2.CreatePublicLobbyAsync(new CreatePublicLobbyRequest() {
        RequestBody = new CreatePublicLobbyRequestBody() {
            InitialConfig = new LobbyInitialConfig() {},
            Region = Hathora.Models.Shared.Region.Sydney,
        },
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [CreatePublicLobbyRequest](../../models/operations/CreatePublicLobbyRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[CreatePublicLobbyResponse](../../models/operations/CreatePublicLobbyResponse.md)**


## GetLobbyInfo

Get details for an existing lobby using `appId` and `roomId`.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.LobbyV2.GetLobbyInfoAsync(new GetLobbyInfoRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetLobbyInfoRequest](../../models/operations/GetLobbyInfoRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[GetLobbyInfoResponse](../../models/operations/GetLobbyInfoResponse.md)**


## ListActivePublicLobbies

Get all active lobbies for a given [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a `region`.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.LobbyV2.ListActivePublicLobbiesAsync(new ListActivePublicLobbiesRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        Region = Hathora.Models.Shared.Region.Seattle,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListActivePublicLobbiesRequest](../../models/operations/ListActivePublicLobbiesRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[ListActivePublicLobbiesResponse](../../models/operations/ListActivePublicLobbiesResponse.md)**


## SetLobbyState

Set the state of a lobby using `appId` and `roomId`. State is intended to be set by the server and must be smaller than 1MB.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.LobbyV2.SetLobbyStateAsync(new SetLobbyStateSecurity() {
        HathoraDevToken = "",
    }, new Models.Operations.SetLobbyStateRequest() {
        SetLobbyStateRequest = new Models.Shared.SetLobbyStateRequest() {
            State = new SetLobbyStateRequestState() {},
        },
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [Models.Operations.SetLobbyStateRequest](../../models/operations/SetLobbyStateRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |
| `security`                                                                                | [SetLobbyStateSecurity](../../models/operations/SetLobbyStateSecurity.md)                 | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |


### Response

**[SetLobbyStateResponse](../../models/operations/SetLobbyStateResponse.md)**

