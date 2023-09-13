# lobbyV1

### Available Operations

* [~~CreatePrivateLobbyDeprecated~~](#createprivatelobbydeprecated) - :warning: **Deprecated**
* [~~CreatePublicLobbyDeprecated~~](#createpubliclobbydeprecated) - :warning: **Deprecated**
* [~~ListActivePublicLobbiesDeprecated~~](#listactivepubliclobbiesdeprecated) - :warning: **Deprecated**

## ~~CreatePrivateLobbyDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.LobbyV1.CreatePrivateLobbyDeprecatedAsync(new CreatePrivateLobbyDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        Local = false,
        Region = Hathora.Models.Shared.Region.Frankfurt,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [CreatePrivateLobbyDeprecatedRequest](../../models/operations/CreatePrivateLobbyDeprecatedRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |


### Response

**[CreatePrivateLobbyDeprecatedResponse](../../models/operations/CreatePrivateLobbyDeprecatedResponse.md)**


## ~~CreatePublicLobbyDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.LobbyV1.CreatePublicLobbyDeprecatedAsync(new CreatePublicLobbyDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        Local = false,
        Region = Hathora.Models.Shared.Region.Singapore,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [CreatePublicLobbyDeprecatedRequest](../../models/operations/CreatePublicLobbyDeprecatedRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |


### Response

**[CreatePublicLobbyDeprecatedResponse](../../models/operations/CreatePublicLobbyDeprecatedResponse.md)**


## ~~ListActivePublicLobbiesDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Operations;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

using(var res = await sdk.LobbyV1.ListActivePublicLobbiesDeprecatedAsync(new ListActivePublicLobbiesDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        Local = false,
        Region = Hathora.Models.Shared.Region.Singapore,
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                       | [ListActivePublicLobbiesDeprecatedRequest](../../models/operations/ListActivePublicLobbiesDeprecatedRequest.md) | :heavy_check_mark:                                                                                              | The request object to use for the request.                                                                      |


### Response

**[ListActivePublicLobbiesDeprecatedResponse](../../models/operations/ListActivePublicLobbiesDeprecatedResponse.md)**

