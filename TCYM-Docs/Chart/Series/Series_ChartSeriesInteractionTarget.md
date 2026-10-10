# ChartSeriesInteractionTarget

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

保存场景 metadata 使用的稳定系列/数据身份、最终坐标系作用域与 focus 策略。
实例只由公共交互投影创建，具体 View 只负责把它附加到场景 metadata。

## 属性

| 名称 | 说明 |
| --- | --- |
| `CoordinateSystemIdentity` | 获取最终坐标系作用域的稳定身份。 |
| `DataKey` | 获取数据项稳定键；系列级目标返回空。 |
| `IsSeriesTarget` | 获取当前目标是否代表整个系列而不是单个数据项。 |
| `Policy` | 获取目标进入 emphasis 时使用的最终 focus/blurScope 策略。 |
| `PresentationKey` | 获取数据项公开表示的精确稳定身份；源目标与系列目标返回空。 |
| `SeriesId` | 获取目标所属系列的可选业务 ID。 |
| `SeriesIndex` | 获取目标所属系列在当前有效 option 中的索引。 |
| `SeriesType` | 获取目标所属系列类型。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断目标是否仍属于给定的规范系列节点。

| 参数 | 说明 |
| --- | --- |
| `series` | 待核对的当前有效系列。 |

**返回：** 系列运行时身份相同时为真。
