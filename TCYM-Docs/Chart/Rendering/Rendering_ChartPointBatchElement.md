# ChartPointBatchElement

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

用一个场景节点和两次 DrawPoints 绘制一批散点，避免为每个数据项创建节点/paint。

## 构造函数

### `ChartPointBatchElement`

初始化一个不包含数据点的批量散点元素。

### `ChartPointBatchElement(Collections.Generic.IEnumerable{SkiaSharp.SKPoint})`

使用指定数据点初始化批量散点元素。

| 参数 | 说明 |
| --- | --- |
| `points` | 以元素局部坐标表示的数据点；构造函数会复制该序列。 |

### `ChartPointBatchElement(Int32)`

初始化一个不包含数据点、但预留指定容量的批量散点元素。

| 参数 | 说明 |
| --- | --- |
| `initialCapacity` | 无需再次分配即可容纳的数据点数量。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Capacity` | 获取当前内部缓冲无需重新分配即可容纳的数据点数量。 |
| `Count` | 获取当前已原子提交、可参与绘制和命中的数据点数量。 |
| `HitTestTolerance` | 获取或设置在可见几何之外追加的有限命中容差（像素）。负值会被归零。 |
| `LastHitIndex` | 获取最近一次命中的点索引；未命中或数据重置时为 `-1`。 |
| `MetadataProvider` | 获取或设置按点索引延迟生成命中元数据的回调。 |
| `Points` | 获取当前已提交数据点的只读快照视图。 |
| `PointSize` | 获取或设置散点的有限直径（像素）。负值会被归零。 |
| `Shape` | 获取或设置所有散点使用的几何外形。 |

## 方法

### `AppendPoints(Collections.Generic.IEnumerable{SkiaSharp.SKPoint})`

原子追加一个已完整物化的点序列，并保留既有逐项状态。

### `AppendPoints(ReadOnlySpan{SkiaSharp.SKPoint})`

原子追加一个连续点块，并保留既有逐项状态。

### `ClearItemInteractionStates`

清除全部数据项的交互状态。

### `EnsureCapacity(Int32)`

保证内部缓冲至少可容纳指定数量，而不改变任何已提交数据点或交互状态。

### `GetItemInteractionState(Int32)`

获取指定批量数据项的组合交互状态。

| 参数 | 说明 |
| --- | --- |
| `itemIndex` | 批量元素内部的数据项索引。 |

### `ResetPoints(Collections.Generic.IEnumerable{SkiaSharp.SKPoint},Int32)`

原子重置全部数据点，并清除逐项状态和最近命中结果。

### `ResetPoints(Int32)`

原子清空全部数据点，并可预留最小容量。

### `ResetPoints(ReadOnlySpan{SkiaSharp.SKPoint},Int32)`

从连续点块原子重置全部数据点，并清除逐项状态和最近命中结果。

### `SetItemInteractionState(Int32,TCYM.UI.Chart.Rendering.ChartInteractionState,Boolean,String)`

启用或关闭指定批量数据项的一个或多个交互状态。

| 参数 | 说明 |
| --- | --- |
| `itemIndex` | 批量元素内部的数据项索引。 |
| `state` | 要修改的状态位。 |
| `enabled` | 为 `true` 时设置状态，否则清除状态。 |

### `SetItemInteractionState(Int32,TCYM.UI.Chart.Rendering.ChartInteractionState,Boolean)`

启用或关闭指定批量数据项的一个或多个交互状态。

| 参数 | 说明 |
| --- | --- |
| `itemIndex` | 批量元素内部的数据项索引。 |
| `state` | 要修改的状态位。 |
| `enabled` | 为 `true` 时设置状态，否则清除状态。 |

### `SetPoints(Collections.Generic.IEnumerable{SkiaSharp.SKPoint})`

替换全部数据点，并清除逐项交互状态和最近命中结果。

| 参数 | 说明 |
| --- | --- |
| `points` | 以元素局部坐标表示的数据点；方法会立即复制该序列。 |
