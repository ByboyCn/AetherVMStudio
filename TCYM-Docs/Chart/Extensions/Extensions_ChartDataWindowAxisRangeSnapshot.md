# ChartDataWindowAxisRangeSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

保存按坐标轴身份唯一索引的已解析连续轴窗口端点。

## 构造函数

### `ChartDataWindowAxisRangeSnapshot(Collections.Generic.IEnumerable{TCYM.UI.Chart.Extensions.ChartDataWindowAxisRange})`

创建并深度复制连续轴窗口端点集合。

| 参数 | 说明 |
| --- | --- |
| `ranges` | 每根目标轴至多一项的窗口端点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取窗口轴域数量。 |
| `Empty` | 获取可安全共享的空轴域快照。 |

## 方法

### `TryGet(TCYM.UI.Chart.Extensions.ChartDataWindowTarget,TCYM.UI.Chart.Extensions.ChartDataWindowAxisRange@)`

尝试取得指定目标轴的窗口端点。

| 参数 | 说明 |
| --- | --- |
| `target` | 目标轴。 |
| `range` | 成功时返回不可变窗口端点。 |

**返回：** 目标轴已发布端点覆盖时为 `true`。
