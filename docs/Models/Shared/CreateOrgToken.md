# CreateOrgToken


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       | Example                                                           |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Name`                                                            | *string*                                                          | :heavy_check_mark:                                                | Readable name for a token. Must be unique within an organization. | ci-token                                                          |
| `Scopes`                                                          | [Scopes](../../Models/Shared/Scopes.md)                           | :heavy_minus_sign:                                                | If not defined, the token has Admin access.                       |                                                                   |