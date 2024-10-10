# FleetRegion

A fleet region is a region in which a fleet can be deployed.
You can update cloudMinVcpus once every five minutes. It must be a multiple of
scaleIncrementVcpus


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `CloudMinVcpus`                                                                       | *int*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `CloudMinVcpusUpdatedAt`                                                              | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `ScaleIncrementVcpus`                                                                 | *int*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |