# ExposedPort

Connection details for an active process.


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `host`                                                                              | *string*                                                                            | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `name`                                                                              | *string*                                                                            | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `port`                                                                              | *double*                                                                            | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `transportType`                                                                     | [TransportType](../../models/shared/TransportType.md)                               | :heavy_check_mark:                                                                  | Transport type specifies the underlying communication protocol to the exposed port. |