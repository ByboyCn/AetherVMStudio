# ChartDataDiffer

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

按稳定 key 计算数据增删改，供所有系列共享过渡动画和增量渲染。

## 方法

### `Diff(Collections.Generic.IReadOnlyList{},Collections.Generic.IReadOnlyList{},Func{,})`

按稳定键比较前后数据。重复键按出现顺序一一配对，未配对的新项为新增，未配对的旧项为移除。

| 参数 | 说明 |
| --- | --- |
| `previous` | 更新前的数据。 |
| `current` | 更新后的数据。 |
| `keySelector` | 从数据项提取稳定键的函数。 |

**返回：** 包含新增、更新和移除项的差异结果。
