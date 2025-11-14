# DiscoveryV2
(*DiscoveryV2*)

## Overview

Service that allows clients to directly ping all Hathora regions to get latency information

### Available Operations

* [GetPingServiceEndpoints](#getpingserviceendpoints) - GetPingServiceEndpoints

## GetPingServiceEndpoints

Returns an array of all regions with a host and port that a client can directly ping. Open a websocket connection to `wss://<host>:<port>/ws` and send a packet. To calculate ping, measure the time it takes to get an echo packet back.

### Example Usage

<!-- UsageSnippet language="unity" operationID="GetPingServiceEndpoints" method="get" path="/discovery/v2/ping" -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;

var sdk = new HathoraCloudSDK();


using(var res = await sdk.DiscoveryV2.GetPingServiceEndpointsAsync())
{
    // handle response
}


```

### Response

**[GetPingServiceEndpointsResponse](../../Models/Operations/GetPingServiceEndpointsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| HathoraCloud.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |