# ChartValue

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

图表数据单元。常用数值不装箱，同时保留字符串、日期和自定义对象扩展能力。
自定义对象在进入该类型时必须满足不可变或快照契约，防止候选构建污染已发布数据。

## 属性

| 名称 | 说明 |
| --- | --- |
| `IsNull` | 获取当前值是否为空值。 |
| `Kind` | 获取当前值的存储类型。 |
| `Null` | 获取空数据值。 |

## 方法

### `AsString(IFormatProvider)`

按指定区域性格式化为字符串。

| 参数 | 说明 |
| --- | --- |
| `formatProvider` | 格式提供程序；为空时使用当前区域性。 |

**返回：** 格式化文本；空值返回 `null`。

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Data.ChartValue)`

按类型、数值和引用载荷比较两个数据值。

### `From(Boolean)`

从布尔值创建数据值。

### `From(DateTime)`

从日期时间创建数据值，并使用其自身 ticks 作为覆盖公元 1 至 9999 年的无装箱数值表示。
`Kind` 仍由引用载荷原样保留，不在此入口隐式改变时区语义。

### `From(DateTimeOffset)`

从带时区偏移的日期时间创建数据值，并使用 UTC ticks 作为覆盖公元 1 至 9999 年的无装箱数值表示。
原始 offset 仍由引用载荷保留。

### `From(Double)`

从双精度数值创建数据值。

### `From(String)`

从字符串创建数据值；`null` 转换为空值。

### `FromObject(Object)`

从对象创建数据值。常见标量会规范化，自定义引用必须实现
`IChartImmutableDataValue` 或 `IChartDataValueSnapshot`。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换值。 |

**返回：** 已规范化并隔离的数据值。

### `GetHashCode`

### `ToObject`

将数据值还原为相应的 CLR 对象。

**返回：** 标量、自定义不可变对象或 `null`。

### `ToString`

### `TryGetDouble(Double@)`

尝试取得可用于连续坐标或计算的有限双精度值。日期值返回 ticks：DateTime 使用自身 ticks，
DateTimeOffset 使用 UTC ticks；该数值不是 OLE Automation 日期或 Unix 时间。

| 参数 | 说明 |
| --- | --- |
| `value` | 成功时得到的数值；失败时为 `NaN`。 |

**返回：** 值可转换且结果有限时返回 `true`。
