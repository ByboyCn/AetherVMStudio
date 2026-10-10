# ChartRectBatchElement

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

用一个节点和复用 paint 绘制一批柱/矩形，并用均匀网格加速命中。

## 构造函数

### `ChartRectBatchElement`

初始化一个不包含矩形的批量矩形元素。

### `ChartRectBatchElement(Collections.Generic.IEnumerable{SkiaSharp.SKRect})`

使用指定矩形初始化批量矩形元素。

| 参数 | 说明 |
| --- | --- |
| `rects` | 以元素局部坐标表示的矩形；构造函数会复制该序列。 |

### `ChartRectBatchElement(Int32)`

初始化一个不包含矩形、但预留指定容量的批量矩形元素。

| 参数 | 说明 |
| --- | --- |
| `initialCapacity` | 无需再次分配即可容纳的矩形数量。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Capacity` | 获取当前内部缓冲无需重新分配即可容纳的矩形数量。 |
| `Count` | 获取当前已原子提交、可参与绘制和命中的矩形数量。 |
| `HitTestTolerance` | 获取或设置描边外侧追加的命中容差（像素）。负值会被归零。 |
| `LastHitIndex` | 获取最近一次命中的矩形索引；未命中或数据重置时为 `-1`。 |
| `MetadataProvider` | 获取或设置按矩形索引延迟生成命中元数据的回调。 |
| `RadiusX` | 获取或设置圆角在水平方向上的半径；绘制和命中时负值按零处理。 |
| `RadiusY` | 获取或设置圆角在垂直方向上的半径；绘制和命中时负值按零处理。 |
| `Rects` | 获取当前已提交矩形的只读快照视图。 |

## 方法

### `AppendRects(Collections.Generic.IEnumerable{SkiaSharp.SKRect})`

把一个候选矩形块原子追加到已提交尾部，并保留全部既有逐项交互状态。

| 参数 | 说明 |
| --- | --- |
| `rects` | 以元素局部坐标表示、边界及尺寸均有限的矩形块；提交前会完整复制和验证。 |

**说明：** 新矩形的逐项状态为默认值。候选枚举、验证或容量计算失败时，已提交矩形、命中结果和状态均不改变。

### `AppendRects(ReadOnlySpan{SkiaSharp.SKRect})`

把一个连续内存候选块原子追加到已提交尾部，并保留全部既有逐项交互状态。

| 参数 | 说明 |
| --- | --- |
| `rects` | 边界及尺寸均有限的矩形块；提交前会完整验证。 |

**说明：** 该重载允许 large/progressive 生产者直接提交已有连续 chunk，避免为候选块创建中间数组。
新矩形的逐项状态为默认值；验证或容量计算失败时，已提交状态不改变。

### `ClearItemInteractionStates`

清除全部数据项的交互状态。

### `EnsureCapacity(Int32)`

保证内部缓冲至少可容纳指定数量，而不改变任何已提交矩形或交互状态。

| 参数 | 说明 |
| --- | --- |
| `capacity` | 所需的最小容量。 |

### `GetItemInteractionState(Int32)`

获取指定批量数据项的组合交互状态。

| 参数 | 说明 |
| --- | --- |
| `itemIndex` | 批量元素内部的数据项索引。 |

### `ReplaceRects(Int32,Collections.Generic.IEnumerable{SkiaSharp.SKRect})`

原子替换一个等长的已提交矩形块，并保留替换范围外的逐项交互状态。

| 参数 | 说明 |
| --- | --- |
| `startIndex` | 待替换块在已提交矩形中的起始索引。 |
| `rects` | 边界及尺寸均有限、且不得越过已提交尾部的替换块；提交前会完整复制和验证。 |

**说明：** 成功提交会清除替换范围内的全部来源逐项状态。候选枚举、验证或范围检查失败时，
已提交矩形、只读视图、命中结果和全部逐项状态均保持不变。

### `ReplaceRects(Int32,ReadOnlySpan{SkiaSharp.SKRect})`

原子替换一个连续内存、等长的已提交矩形块，并保留替换范围外的逐项交互状态。

| 参数 | 说明 |
| --- | --- |
| `startIndex` | 待替换块在已提交矩形中的起始索引。 |
| `rects` | 边界及尺寸均有限、且不得越过已提交尾部的替换块。 |

**说明：** 该重载直接消费 large/progressive 生产者的连续 chunk。成功提交清除替换范围内的全部来源逐项状态；
验证或范围检查失败时，已提交矩形、命中结果和状态均保持不变。

### `ResetRects(Collections.Generic.IEnumerable{SkiaSharp.SKRect},Int32)`

原子重置全部矩形，并清除全部逐项交互状态和最近命中结果。

| 参数 | 说明 |
| --- | --- |
| `rects` | 边界及尺寸均有限的完整候选矩形块；提交前会完整复制和验证。 |
| `minimumCapacity` | 提交后至少保留的内部容量。 |

**说明：** 候选枚举、验证或容量检查失败时，已提交矩形、只读视图、命中结果和状态均保持不变。

### `ResetRects(Int32)`

原子清空全部矩形，并清除全部逐项交互状态和最近命中结果。

| 参数 | 说明 |
| --- | --- |
| `minimumCapacity` | 清空后预留的最小容量。 |

### `ResetRects(ReadOnlySpan{SkiaSharp.SKRect},Int32)`

从一个连续内存候选块原子重置全部矩形，并清除全部逐项交互状态和最近命中结果。

| 参数 | 说明 |
| --- | --- |
| `rects` | 边界及尺寸均有限的完整候选矩形块。 |
| `minimumCapacity` | 提交后至少保留的内部容量。 |

**说明：** 提交前会完整验证并取得自有副本；验证或容量检查失败时，已提交状态不改变。

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

### `SetRects(Collections.Generic.IEnumerable{SkiaSharp.SKRect})`

替换全部矩形，并清除逐项交互状态和最近命中结果。

| 参数 | 说明 |
| --- | --- |
| `rects` | 以元素局部坐标表示的矩形；方法会立即复制该序列。 |
