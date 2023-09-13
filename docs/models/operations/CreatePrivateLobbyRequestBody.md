# CreatePrivateLobbyRequestBody


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `initialConfig`                                                            | [LobbyInitialConfig](../../models/shared/LobbyInitialConfig.md)            | :heavy_check_mark:                                                         | User input to initialize the game state. Object must be smaller than 64KB. |
| `region`                                                                   | [Region](../../models/shared/Region.md)                                    | :heavy_check_mark:                                                         | N/A                                                                        |