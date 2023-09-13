<!-- Start SDK Example Usage -->


```csharp
using Hathora;
using Hathora.Models.Shared;
using Hathora.Models.Operations;

var sdk = new HathoraSDK();

using(var res = await sdk.AppV1.CreateAppAsync(new CreateAppSecurity() {
        HathoraDevToken = "",
    }, new AppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AuthConfiguration() {
            Anonymous = new RecordStringNever() {},
            Google = new AuthConfigurationGoogle() {
                ClientId = "corrupti",
            },
            Nickname = new RecordStringNever() {},
        },
    }))
{
    // handle response
}
```
<!-- End SDK Example Usage -->