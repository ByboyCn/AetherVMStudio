# ChartPolylineBatchElement

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

把一条或多条折线合并为单节点/单 path 绘制。命中测试按线段建立空间索引，不使用整条路径包围盒。

## 构造函数

### `ChartPolylineBatchElement`

初始化一个不包含折线点的批量折线元素。

### `ChartPolylineBatchElement(Collections.Generic.IEnumerable{SkiaSharp.SKPoint})`

使用一条连续折线的数据点初始化批量折线元素。

| 参数 | 说明 |
| --- | --- |
| `points` | 按绘制顺序排列、以元素局部坐标表示的点；构造函数会复制该序列。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Capacity` | 获取点缓冲区当前可容纳的点数量。 |
| `Count` | 获取当前已经提交的点数量，不包含预留容量。 |
| `HitTestTolerance` | 获取或设置描边中心线两侧追加的命中容差（像素）。负值会被归零。 |
| `LastHitSegmentIndex` | 获取最近一次命中的线段索引；未命中或数据重置时为 `-1`。 |
| `PartStarts` | 获取每条独立折线在 `Points` 中的起始索引。 |
| `Points` | 获取当前折线点的只读快照视图。 |
| `SegmentCount` | 获取当前已经提交的独立线段数量。 |
| `SegmentMetadataProvider` | 获取或设置按线段索引延迟生成命中元数据的回调。 |

## 方法

### `AppendPoints(Collections.Generic.IEnumerable{SkiaSharp.SKPoint},Collections.Generic.IEnumerable{Int32})`

原子追加一组折线；候选的首个分段始终从新的点前缀开始，不会连接到旧折线尾点。

| 参数 | 说明 |
| --- | --- |
| `points` | 候选折线点；提交前完整快照和有限性验证。 |
| `partStarts` | 候选内部各独立折线的相对起点。 |

### `AppendPoints(ReadOnlySpan{SkiaSharp.SKPoint},ReadOnlySpan{Int32})`

原子追加带相对分段起点的连续点块。

### `AppendPoints(ReadOnlySpan{SkiaSharp.SKPoint})`

原子追加一个连续点块；省略分段时整个候选作为一条与旧尾部隔离的新折线。

### `ClearItemInteractionStates`

清除全部数据项的交互状态。

### `EnsureCapacity(Int32)`

确保点缓冲区至少具有指定容量；不改变 Count、Points、分段、状态或命中语义。

| 参数 | 说明 |
| --- | --- |
| `minimumCapacity` | 所需最小点容量。 |

### `GetItemInteractionState(Int32)`

获取指定批量数据项的组合交互状态。

| 参数 | 说明 |
| --- | --- |
| `itemIndex` | 批量元素内部的数据项索引。 |

### `ResetPoints(Collections.Generic.IEnumerable{SkiaSharp.SKPoint},Collections.Generic.IEnumerable{Int32},Int32)`

原子替换全部折线点与分段，并可预留后续追加容量；成功后清除逐线段状态和最近命中。

| 参数 | 说明 |
| --- | --- |
| `points` | 按绘制顺序排列的有限点。 |
| `partStarts` | 各独立折线在点序列中的起点；规则与 `SetPoints` 相同。 |
| `minimumCapacity` | 提交后至少保留的点容量。 |

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

### `SetPoints(Collections.Generic.IEnumerable{SkiaSharp.SKPoint},Collections.Generic.IEnumerable{Int32})`

替换折线点及其分段信息，并清除逐线段交互状态和最近命中结果。

| 参数 | 说明 |
| --- | --- |
| `points` | 按绘制顺序排列的折线点。 |
| `partStarts` | 每个独立折线在 `points` 中的起始索引；方法会忽略越界值、排序并去重，<br />且在有数据时自动补入零。省略时所有点属于一条折线。 |
