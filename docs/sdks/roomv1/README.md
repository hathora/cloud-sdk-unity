# RoomV1

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
using HathoraCloud.Models.Operations;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK();

using(var res = await sdk.RoomV1.CreateRoomDeprecatedAsync(new CreateRoomDeprecatedSecurity() {
        HathoraDevToken = "",
    }, new CreateRoomDeprecatedRequest() {
        CreateRoomRequest = new Models.Shared.CreateRoomRequest() {
            Region = HathoraCloud.Models.Shared.Region.Sydney,
            RoomConfig = "{\"name\":\"my-room\"}",
        },
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [CreateRoomDeprecatedRequest](../../models/operations/CreateRoomDeprecatedRequest.md)   | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |
| `security`                                                                              | [CreateRoomDeprecatedSecurity](../../models/operations/CreateRoomDeprecatedSecurity.md) | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |


### Response

**[CreateRoomDeprecatedResponse](../../models/operations/CreateRoomDeprecatedResponse.md)**


## ~~DestroyRoomDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK();

using(var res = await sdk.RoomV1.DestroyRoomDeprecatedAsync(new DestroyRoomDeprecatedSecurity() {
        HathoraDevToken = "",
    }, new DestroyRoomDeprecatedRequest() {
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
| `request`                                                                                 | [DestroyRoomDeprecatedRequest](../../models/operations/DestroyRoomDeprecatedRequest.md)   | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |
| `security`                                                                                | [DestroyRoomDeprecatedSecurity](../../models/operations/DestroyRoomDeprecatedSecurity.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |


### Response

**[DestroyRoomDeprecatedResponse](../../models/operations/DestroyRoomDeprecatedResponse.md)**


## ~~GetActiveRoomsForProcessDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK();

using(var res = await sdk.RoomV1.GetActiveRoomsForProcessDeprecatedAsync(new GetActiveRoomsForProcessDeprecatedSecurity() {
        HathoraDevToken = "",
    }, new GetActiveRoomsForProcessDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [GetActiveRoomsForProcessDeprecatedRequest](../../models/operations/GetActiveRoomsForProcessDeprecatedRequest.md)   | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |
| `security`                                                                                                          | [GetActiveRoomsForProcessDeprecatedSecurity](../../models/operations/GetActiveRoomsForProcessDeprecatedSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |


### Response

**[GetActiveRoomsForProcessDeprecatedResponse](../../models/operations/GetActiveRoomsForProcessDeprecatedResponse.md)**


## ~~GetConnectionInfoDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK();

using(var res = await sdk.RoomV1.GetConnectionInfoDeprecatedAsync(new GetConnectionInfoDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        RoomId = "2swovpy1fnunu",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [GetConnectionInfoDeprecatedRequest](../../models/operations/GetConnectionInfoDeprecatedRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |


### Response

**[GetConnectionInfoDeprecatedResponse](../../models/operations/GetConnectionInfoDeprecatedResponse.md)**


## ~~GetInactiveRoomsForProcessDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK();

using(var res = await sdk.RoomV1.GetInactiveRoomsForProcessDeprecatedAsync(new GetInactiveRoomsForProcessDeprecatedSecurity() {
        HathoraDevToken = "",
    }, new GetInactiveRoomsForProcessDeprecatedRequest() {
        AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
        ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    }))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                               | [GetInactiveRoomsForProcessDeprecatedRequest](../../models/operations/GetInactiveRoomsForProcessDeprecatedRequest.md)   | :heavy_check_mark:                                                                                                      | The request object to use for the request.                                                                              |
| `security`                                                                                                              | [GetInactiveRoomsForProcessDeprecatedSecurity](../../models/operations/GetInactiveRoomsForProcessDeprecatedSecurity.md) | :heavy_check_mark:                                                                                                      | The security requirements to use for the request.                                                                       |


### Response

**[GetInactiveRoomsForProcessDeprecatedResponse](../../models/operations/GetInactiveRoomsForProcessDeprecatedResponse.md)**


## ~~GetRoomInfoDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK();

using(var res = await sdk.RoomV1.GetRoomInfoDeprecatedAsync(new GetRoomInfoDeprecatedSecurity() {
        HathoraDevToken = "",
    }, new GetRoomInfoDeprecatedRequest() {
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
| `request`                                                                                 | [GetRoomInfoDeprecatedRequest](../../models/operations/GetRoomInfoDeprecatedRequest.md)   | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |
| `security`                                                                                | [GetRoomInfoDeprecatedSecurity](../../models/operations/GetRoomInfoDeprecatedSecurity.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |


### Response

**[GetRoomInfoDeprecatedResponse](../../models/operations/GetRoomInfoDeprecatedResponse.md)**


## ~~SuspendRoomDeprecated~~

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK();

using(var res = await sdk.RoomV1.SuspendRoomDeprecatedAsync(new SuspendRoomDeprecatedSecurity() {
        HathoraDevToken = "",
    }, new SuspendRoomDeprecatedRequest() {
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
| `request`                                                                                 | [SuspendRoomDeprecatedRequest](../../models/operations/SuspendRoomDeprecatedRequest.md)   | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |
| `security`                                                                                | [SuspendRoomDeprecatedSecurity](../../models/operations/SuspendRoomDeprecatedSecurity.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |


### Response

**[SuspendRoomDeprecatedResponse](../../models/operations/SuspendRoomDeprecatedResponse.md)**

