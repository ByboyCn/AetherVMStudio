# ChartLabelLayoutOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

配置中央标签布局 callback、自动平移与隐藏重叠语义。

## 构造函数

### `ChartLabelLayoutOption`

创建不绑定所属选项节点的独立 labelLayout。

### `ChartLabelLayoutOption(Action)`

创建字段修改时通知所属选项节点的 labelLayout。

| 参数 | 说明 |
| --- | --- |
| `onChanged` | 任一公开字段设置后调用的 presence 通知。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Formatter` | 获取或设置受保护的布局 callback；异常会由中央 pass 诊断并忽略。 |
| `HideOverlap` | 获取或设置是否在中央 pass 中隐藏与更高优先级标签重叠的当前标签。 |
| `MoveOverlap` | 获取或设置在隐藏判断前执行的稳定水平或垂直平移策略。 |

## 方法

### `Clone`

创建值和 callback 引用等价的独立配置副本。

**返回：** 可由 descriptor 独占的配置副本。

### `Clone(Action)`

创建值和 callback 引用等价、并绑定新 presence 通知的副本。

| 参数 | 说明 |
| --- | --- |
| `onChanged` | 副本字段修改时的通知。 |

**返回：** 可由新所有者独占的配置副本。

### `Reset`

显式清除所有字段，并保留整块重置意图供后续合并。
