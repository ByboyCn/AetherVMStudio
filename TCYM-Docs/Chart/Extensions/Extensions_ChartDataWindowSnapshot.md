# ChartDataWindowSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

包含零个或多个 dataZoom 窗口的深度不可变快照。
多个 producer 通过 `Append` 返回新快照，不共享可变集合。

## 构造函数

### `ChartDataWindowSnapshot(Collections.Generic.IEnumerable{TCYM.UI.Chart.Extensions.ChartDataWindow})`

创建并复制全部数据窗口。

| 参数 | 说明 |
| --- | --- |
| `windows` | 按稳定 producer 顺序排列的窗口。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取窗口数量。 |
| `Empty` | 获取可安全共享的空快照。 |
| `Windows` | 获取按 producer 顺序冻结的数据窗口。 |

## 方法

### `Append(TCYM.UI.Chart.Extensions.ChartDataWindow)`

返回在末尾追加一个窗口的新快照。

| 参数 | 说明 |
| --- | --- |
| `window` | 要追加的不可变窗口。 |

**返回：** 不修改当前实例的新快照。
