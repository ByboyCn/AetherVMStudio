# ChartTimeValue

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Scales`　**Chart 版本**：`0.1.1.25`

## 概述

提供时间比例尺使用的确定性 UTC/Unix 毫秒转换。数值始终解释为 Unix 毫秒；
`Unspecified` 明确解释为 UTC，避免随运行机器时区改变。

## 属性

| 名称 | 说明 |
| --- | --- |
| `MaximumUnixMilliseconds` | 获取受支持的最晚 UTC 时刻对应的完整 Unix 毫秒。 |
| `MinimumUnixMilliseconds` | 获取受支持的最早 UTC 时刻对应的完整 Unix 毫秒。 |

## 方法

### `ToUnixMilliseconds(DateTime)`

把 `DateTime` 转换为 UTC Unix 毫秒。UTC 原样使用，Local 按系统时区转换为 UTC，
Unspecified 不使用系统时区而是明确按 UTC 解释。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换时间。 |

**返回：** UTC Unix 毫秒。

### `ToUnixMilliseconds(DateTimeOffset)`

把带偏移时间按同一瞬间转换为 UTC Unix 毫秒，并在 double 可安全表示时保留毫秒以下的 tick 精度；
最晚日期不足一毫秒的尾部会吸附到最后一个完整可表示 Unix 毫秒。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换时间。 |

**返回：** UTC Unix 毫秒。

### `TryFromUnixMilliseconds(Double,DateTimeOffset@)`

尝试把有限 UTC Unix 毫秒转换为 UTC `DateTimeOffset`。

| 参数 | 说明 |
| --- | --- |
| `unixMilliseconds` | 待转换 Unix 毫秒，可包含小数。 |
| `value` | 成功时得到的 UTC 时间。 |

**返回：** 输入有限且转换后的 tick 位于受支持日期范围内时返回 `true`。

### `TryGetUnixMilliseconds(TCYM.UI.Chart.Data.ChartValue,Double@)`

尝试读取时间比例尺值。DateTimeOffset 和 DateTime 按 UTC 规则转换；有限数字解释为 Unix 毫秒；
字符串仅接受 invariant ISO-8601 日期或时间，缺少 offset 时按 UTC 解释。

| 参数 | 说明 |
| --- | --- |
| `value` | 待读取图表值。 |
| `unixMilliseconds` | 成功时得到的有限 UTC Unix 毫秒；失败时为 NaN。 |

**返回：** 值具有确定时间语义且位于 `DateTimeOffset` 范围内时返回 `true`。

### `TryParseIso8601(String,DateTimeOffset@)`

尝试把 invariant ISO-8601 文本解析为 UTC 时间。

| 参数 | 说明 |
| --- | --- |
| `text` | `yyyy-MM-dd` 或使用大写 T 的 ISO 时间；允许大写 Z、显式 `±HH:mm` 或无 offset。 |
| `value` | 成功时得到的 UTC 时间。 |

**返回：** 文本完全符合受支持格式且日期有效时返回 `true`。
