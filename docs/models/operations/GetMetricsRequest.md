# GetMetricsRequest


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           | Example                                               |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `appId`                                               | *string*                                              | :heavy_check_mark:                                    | N/A                                                   | app-af469a92-5b45-4565-b3c4-b79878de67d2              |
| `end`                                                 | *double*                                              | :heavy_minus_sign:                                    | Unix timestamp. Default is current time.              |                                                       |
| `metrics`                                             | List<[MetricName](../../models/shared/MetricName.md)> | :heavy_minus_sign:                                    | Available metrics to query over time.                 |                                                       |
| `processId`                                           | *string*                                              | :heavy_check_mark:                                    | N/A                                                   | cbfcddd2-0006-43ae-996c-995fff7bed2e                  |
| `start`                                               | *double*                                              | :heavy_minus_sign:                                    | Unix timestamp. Default is -1 hour from `end`.        |                                                       |
| `step`                                                | *int*                                                 | :heavy_minus_sign:                                    | N/A                                                   |                                                       |