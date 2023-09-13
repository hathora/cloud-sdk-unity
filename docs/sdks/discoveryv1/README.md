# discoveryV1

## Overview

Service that allows clients to directly ping all Hathora regions to get latency information

### Available Operations

* [GetPingServiceEndpoints](#getpingserviceendpoints) - Returns an array of all regions with a host and port that a client can directly ping. Open a websocket connection to `wss://<host>:<port>/ws` and send a packet. To calculate ping, measure the time it takes to get an echo packet back.

## GetPingServiceEndpoints

Returns an array of all regions with a host and port that a client can directly ping. Open a websocket connection to `wss://<host>:<port>/ws` and send a packet. To calculate ping, measure the time it takes to get an echo packet back.

### Example Usage

```csharp
using Hathora;

var sdk = new HathoraSDK();

using(var res = await sdk.DiscoveryV1.GetPingServiceEndpointsAsync())
{
    // handle response
}
```


### Response

**[GetPingServiceEndpointsResponse](../../models/operations/GetPingServiceEndpointsResponse.md)**

