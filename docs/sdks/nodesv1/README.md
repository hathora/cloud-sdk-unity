# NodesV1
(*NodesV1*)

## Overview

### Available Operations

* [GetNode](#getnode) - GetNode
* [ListProvisionedNodes](#listprovisionednodes) - ListProvisionedNodes

## GetNode

Returns information about the node identified by `appId`.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetNode" method="get" path="/nodes/v1/{nodeId}" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

GetNodeRequest req = new GetNodeRequest() {
    NodeId = "<id>",
};


using(var res = await sdk.NodesV1.GetNodeAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetNodeRequest](../../Models/Operations/GetNodeRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[GetNodeResponse](../../Models/Operations/GetNodeResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## ListProvisionedNodes

List nodes that are running or draining. Filter the array by optionally passing in a `region`.

### Example Usage

<!-- UsageSnippet language="unity" operationID="ListProvisionedNodes" method="get" path="/nodes/v1/fleet/{fleetId}/listProvisioned" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

ListProvisionedNodesRequest req = new ListProvisionedNodesRequest() {
    FleetId = "<id>",
};


using(var res = await sdk.NodesV1.ListProvisionedNodesAsync(req))
{
    // handle response
}


```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListProvisionedNodesRequest](../../Models/Operations/ListProvisionedNodesRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListProvisionedNodesResponse](../../Models/Operations/ListProvisionedNodesResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.ApiError     | 401, 404, 408, 429                      | application/json                        |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |