# CreateLocalLobbyRequestBody


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `InitialConfig`                                                            | Dictionary<String, *object*>                                               | :heavy_check_mark:                                                         | User input to initialize the game state. Object must be smaller than 64KB. |
| `Region`                                                                   | [Region](../../models/shared/Region.md)                                    | :heavy_check_mark:                                                         | N/A                                                                        |