# LobbiesV3
(*LobbiesV3*)

## Overview

### Available Operations

* [CreateLobby](#createlobby) - CreateLobby
* [GetLobbyInfoByRoomId](#getlobbyinfobyroomid) - GetLobbyInfoByRoomId
* [GetLobbyInfoByShortCode](#getlobbyinfobyshortcode) - GetLobbyInfoByShortCode
* [ListActivePublicLobbies](#listactivepubliclobbies) - ListActivePublicLobbies

## CreateLobby

Create a new lobby for an [application](https://hathora.dev/docs/concepts/hathora-entities#application). A lobby object is a wrapper around a [room](https://hathora.dev/docs/concepts/hathora-entities#room) object. With a lobby, you get additional functionality like configuring the visibility of the room, managing the state of a match, and retrieving a list of public lobbies to display to players.

### Example Usage

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

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `request`                                                                                            | [CreateLobbyRequest](../../Models/Operations/CreateLobbyRequest.md)                                  | :heavy_check_mark:                                                                                   | The request object to use for the request.                                                           |
| `security`                                                                                           | [HathoraCloud.Models.Operations.CreateLobbySecurity](../../models/operations/CreateLobbySecurity.md) | :heavy_check_mark:                                                                                   | The security requirements to use for the request.                                                    |

### Response

**[CreateLobbyResponse](../../Models/Operations/CreateLobbyResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 400, 401, 402, 404, 422, 429            | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetLobbyInfoByRoomId

Get details for a lobby.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

GetLobbyInfoByRoomIdRequest req = new GetLobbyInfoByRoomIdRequest() {
    RoomId = "2swovpy1fnunu",
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.LobbiesV3.GetLobbyInfoByRoomIdAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetLobbyInfoByRoomIdRequest](../../Models/Operations/GetLobbyInfoByRoomIdRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetLobbyInfoByRoomIdResponse](../../Models/Operations/GetLobbyInfoByRoomIdResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 404, 422, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetLobbyInfoByShortCode

Get details for a lobby. If 2 or more lobbies have the same `shortCode`, then the most recently created lobby will be returned.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

GetLobbyInfoByShortCodeRequest req = new GetLobbyInfoByShortCodeRequest() {
    ShortCode = "LFG4",
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.LobbiesV3.GetLobbyInfoByShortCodeAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetLobbyInfoByShortCodeRequest](../../Models/Operations/GetLobbyInfoByShortCodeRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[GetLobbyInfoByShortCodeResponse](../../Models/Operations/GetLobbyInfoByShortCodeResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 404, 429                                | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ListActivePublicLobbies

Get all active lobbies for a given [application](https://hathora.dev/docs/concepts/hathora-entities#application). Filter the array by optionally passing in a `region`. Use this endpoint to display all public lobbies that a player can join in the game client.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");

ListActivePublicLobbiesRequest req = new ListActivePublicLobbiesRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
};


using(var res = await sdk.LobbiesV3.ListActivePublicLobbiesAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListActivePublicLobbiesRequest](../../Models/Operations/ListActivePublicLobbiesRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListActivePublicLobbiesResponse](../../Models/Operations/ListActivePublicLobbiesResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 429                                | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |