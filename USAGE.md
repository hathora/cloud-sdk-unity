<!-- Start SDK Example Usage [usage] -->
```csharp
using HathoraCloud;
using HathoraCloud.Models.Shared;
using HathoraCloud.Models.Operations;

var sdk = new HathoraCloudSDK(
    orgId: "org-6f706e83-0ec1-437a-9a46-7d4281eb2f39",
    security: new Security() {
        HathoraDevToken = "<YOUR_BEARER_TOKEN_HERE>",
    });

CreateAppRequest req = new CreateAppRequest() {
    AppConfig = new AppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {},
    },
};


using(var res = await sdk.AppsV2.CreateAppAsync(req))
{
    // handle response
}


```
<!-- End SDK Example Usage [usage] -->