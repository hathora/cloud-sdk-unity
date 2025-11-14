# AuthV1
(*AuthV1*)

## Overview

Operations that allow you to generate a Hathora-signed [JSON web token (JWT)](https://jwt.io/) for [player authentication](https://hathora.dev/docs/lobbies-and-matchmaking/auth-service).

### Available Operations

* [LoginAnonymous](#loginanonymous) - LoginAnonymous
* [LoginGoogle](#logingoogle) - LoginGoogle
* [LoginNickname](#loginnickname) - LoginNickname

## LoginAnonymous

Returns a unique player token for an anonymous user.

### Example Usage

<!-- UsageSnippet language="unity" operationID="LoginAnonymous" method="post" path="/auth/v1/{appId}/login/anonymous" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

LoginAnonymousRequest req = new LoginAnonymousRequest() {};


using(var res = await sdk.AuthV1.LoginAnonymousAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [LoginAnonymousRequest](../../Models/Operations/LoginAnonymousRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[LoginAnonymousResponse](../../Models/Operations/LoginAnonymousResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 404, 408, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## LoginGoogle

Returns a unique player token using a Google-signed OIDC `idToken`.

### Example Usage

<!-- UsageSnippet language="unity" operationID="LoginGoogle" method="post" path="/auth/v1/{appId}/login/google" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

LoginGoogleRequest req = new LoginGoogleRequest() {
    GoogleIdTokenObject = new GoogleIdTokenObject() {
        IdToken = "eyJhbGciOiJSUzI1NiIsImtpZCI6ImZkNDhhNzUxMzhkOWQ0OGYwYWE2MzVlZjU2OWM0ZTE5NmY3YWU4ZDYiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJhY2NvdW50cy5nb29nbGUuY29tIiwiYXpwIjoiODQ4NDEyODI2Nzg4LW00bXNyYjZxNDRkbTJ1ZTNrZ3Z1aTBmcTdrZGE1NWxzLmFwcHMuZ29vZ2xldXNlcmNvbnRlbnQuY29tIiwiYXVkIjoiODQ4NDEyODI2Nzg4LW00bXNyYjZxNDRkbTJ1ZTNrZ3Z1aTBmcTdrZGE1NWxzLmFwcHMuZ29vZ2xldXNlcmNvbnRlbnQuY29tIiwic3ViIjoiMTE0NTQyMzMwNzI3MTU2MTMzNzc2IiwiZW1haWwiOiJocGFdkeivmeuzQGdtYWlsLmNvbSIsImVtYWlsX3ZlcmlmaWVkIjp0cnVlLCJhdF9oYXNoIjoidno1NGhhdTNxbnVR",
    },
};


using(var res = await sdk.AuthV1.LoginGoogleAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [LoginGoogleRequest](../../Models/Operations/LoginGoogleRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[LoginGoogleResponse](../../Models/Operations/LoginGoogleResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 422, 429                 | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## LoginNickname

Returns a unique player token with a specified nickname for a user.

### Example Usage

<!-- UsageSnippet language="unity" operationID="LoginNickname" method="post" path="/auth/v1/{appId}/login/nickname" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2");

LoginNicknameRequest req = new LoginNicknameRequest() {
    NicknameObject = new NicknameObject() {
        Nickname = "squiddytwoshoes",
    },
};


using(var res = await sdk.AuthV1.LoginNicknameAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [LoginNicknameRequest](../../Models/Operations/LoginNicknameRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[LoginNicknameResponse](../../Models/Operations/LoginNicknameResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 404, 408, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |