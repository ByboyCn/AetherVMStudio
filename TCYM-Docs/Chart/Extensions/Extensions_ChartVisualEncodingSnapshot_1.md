# ChartVisualEncodingSnapshot&lt;T1&gt;

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

包含同一种强类型视觉编码的深度不可变快照。
值类型由泛型参数参与 Artifact 槽身份，不需要字符串或反射分派。

## 构造函数

### `ChartVisualEncodingSnapshot<T1>(Collections.Generic.IEnumerable{TCYM.UI.Chart.Extensions.ChartVisualEncodingEntry{}})`

创建并复制全部视觉编码条目。

| 参数 | 说明 |
| --- | --- |
| `entries` | 按稳定 producer 顺序排列的条目。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取编码条目数量。 |
| `Empty` | 获取当前编码负载类型可安全共享的空快照。 |
| `Entries` | 获取按 producer 顺序冻结的视觉编码条目。 |

## 方法

### `Append(TCYM.UI.Chart.Extensions.ChartVisualEncodingEntry{})`

返回在末尾追加一个条目的新快照。

| 参数 | 说明 |
| --- | --- |
| `entry` | 要追加的非空条目。 |

**返回：** 不修改当前实例的新快照。
