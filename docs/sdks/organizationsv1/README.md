# OrganizationsV1
(*OrganizationsV1*)

## Overview

### Available Operations

* [AcceptInvite](#acceptinvite) - AcceptInvite
* [GetOrgMembers](#getorgmembers) - GetOrgMembers
* [GetOrgPendingInvites](#getorgpendinginvites) - GetOrgPendingInvites
* [GetOrgs](#getorgs) - GetOrgs
* [GetUsageLimits](#getusagelimits) - GetUsageLimits
* [GetUserPendingInvites](#getuserpendinginvites) - GetUserPendingInvites
* [InviteUser](#inviteuser) - InviteUser
* [RejectInvite](#rejectinvite) - RejectInvite
* [RescindInvite](#rescindinvite) - RescindInvite
* [UpdateUserInvite](#updateuserinvite) - UpdateUserInvite

## AcceptInvite

AcceptInvite

### Example Usage

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

AcceptInviteRequest req = new AcceptInviteRequest() {
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
};


using(var res = await sdk.OrganizationsV1.AcceptInviteAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [AcceptInviteRequest](../../Models/Operations/AcceptInviteRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[AcceptInviteResponse](../../Models/Operations/AcceptInviteResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetOrgMembers

GetOrgMembers

### Example Usage

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

GetOrgMembersRequest req = new GetOrgMembersRequest() {
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
};


using(var res = await sdk.OrganizationsV1.GetOrgMembersAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetOrgMembersRequest](../../Models/Operations/GetOrgMembersRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[GetOrgMembersResponse](../../Models/Operations/GetOrgMembersResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 429                                | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetOrgPendingInvites

GetOrgPendingInvites

### Example Usage

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

GetOrgPendingInvitesRequest req = new GetOrgPendingInvitesRequest() {
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
};


using(var res = await sdk.OrganizationsV1.GetOrgPendingInvitesAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetOrgPendingInvitesRequest](../../Models/Operations/GetOrgPendingInvitesRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetOrgPendingInvitesResponse](../../Models/Operations/GetOrgPendingInvitesResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 429                                | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetOrgs

Returns an unsorted list of all organizations that you are a member of (an accepted membership invite). An organization is uniquely identified by an `orgId`.

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");


using(var res = await sdk.OrganizationsV1.GetOrgsAsync())
{
    // handle response
}


```

### Response

**[GetOrgsResponse](../../Models/Operations/GetOrgsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetUsageLimits

GetUsageLimits

### Example Usage

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

GetUsageLimitsRequest req = new GetUsageLimitsRequest() {};


using(var res = await sdk.OrganizationsV1.GetUsageLimitsAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetUsageLimitsRequest](../../Models/Operations/GetUsageLimitsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetUsageLimitsResponse](../../Models/Operations/GetUsageLimitsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetUserPendingInvites

GetUserPendingInvites

### Example Usage

```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK(
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    },
    appId: "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39");


using(var res = await sdk.OrganizationsV1.GetUserPendingInvitesAsync())
{
    // handle response
}


```

### Response

**[GetUserPendingInvitesResponse](../../Models/Operations/GetUserPendingInvitesResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 429                                | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## InviteUser

InviteUser

### Example Usage

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

InviteUserRequest req = new InviteUserRequest() {
    CreateUserInvite = new CreateUserInvite() {
        UserEmail = "noreply@hathora.dev",
    },
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
};


using(var res = await sdk.OrganizationsV1.InviteUserAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [InviteUserRequest](../../Models/Operations/InviteUserRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[InviteUserResponse](../../Models/Operations/InviteUserResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 422, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## RejectInvite

RejectInvite

### Example Usage

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

RejectInviteRequest req = new RejectInviteRequest() {
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
};


using(var res = await sdk.OrganizationsV1.RejectInviteAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [RejectInviteRequest](../../Models/Operations/RejectInviteRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[RejectInviteResponse](../../Models/Operations/RejectInviteResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## RescindInvite

RescindInvite

### Example Usage

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

RescindInviteRequest req = new RescindInviteRequest() {
    RescindUserInvite = new RescindUserInvite() {
        UserEmail = "noreply@hathora.dev",
    },
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
};


using(var res = await sdk.OrganizationsV1.RescindInviteAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [RescindInviteRequest](../../Models/Operations/RescindInviteRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[RescindInviteResponse](../../Models/Operations/RescindInviteResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 422, 429                      | application/json                        |
| HathoraCloud.Models.Errors.ApiError     | 500                                     | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## UpdateUserInvite

UpdateUserInvite

### Example Usage

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

UpdateUserInviteRequest req = new UpdateUserInviteRequest() {
    UpdateUserInvite = new UpdateUserInvite() {
        Scopes = UpdateUserInviteScopes.CreateUserRole(
            UserRole.Viewer,
        ),
        UserEmail = "noreply@hathora.dev",
    },
    OrgId = "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
};


using(var res = await sdk.OrganizationsV1.UpdateUserInviteAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateUserInviteRequest](../../Models/Operations/UpdateUserInviteRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateUserInviteResponse](../../Models/Operations/UpdateUserInviteResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 422, 429                           | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |