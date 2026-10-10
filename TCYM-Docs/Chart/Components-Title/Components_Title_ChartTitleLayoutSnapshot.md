# ChartTitleLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Title`　**Chart 版本**：`0.1.1.25`

## 概述

保存一次成功 Layout 阶段产生的全部 Title 不可变布局。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Items` | 获取按 Title 同主类型索引排列的只读布局项。 |

## 方法

### `TryGet(Int32,TCYM.UI.Chart.Components.Title.ChartTitleItemLayoutSnapshot@)`

按同主类型索引尝试取得一个可见 Title 布局。

| 参数 | 说明 |
| --- | --- |
| `componentIndex` | Title 同类索引。 |
| `item` | 找到时返回不可变布局项。 |

**返回：** 存在对应可见布局时为 `true`。
