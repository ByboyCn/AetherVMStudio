# ChartMarkResolvedPositionSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个 Point、Line 端点或 Area 端点的规范化数据域位置。屏幕 X/Y 独立覆盖对应维，
未覆盖维仍可保留 schema/统计解析结果；本类型不包含任何像素投影结果。

## 构造函数

### `ChartMarkResolvedPositionSnapshot(Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartMarkRelativeTo},Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Mark.ChartMarkResolvedDimensionSnapshot},Boolean)`

创建一个可选择接受 markArea 空边界占位的内部位置快照。

| 参数 | 说明 |
| --- | --- |
| `screenX` | 可选屏幕 X 覆盖。 |
| `screenY` | 可选屏幕 Y 覆盖。 |
| `relativeTo` | 屏幕百分比参考边界。 |
| `dimensions` | 零至两个规范坐标维。 |
| `allowsEmptyAreaBoundary` | 无任何定位输入时是否允许作为 Area 边界占位。 |

### `ChartMarkResolvedPositionSnapshot(Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartMarkRelativeTo},Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Mark.ChartMarkResolvedDimensionSnapshot})`

创建一个已经冻结位置优先级的数据域位置快照。

| 参数 | 说明 |
| --- | --- |
| `screenX` | 可选屏幕 X 覆盖。 |
| `screenY` | 可选屏幕 Y 覆盖。 |
| `relativeTo` | 屏幕百分比参考边界；没有屏幕覆盖时必须为空。 |
| `dimensions` | 零至两个规范坐标维。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Dimensions` | 获取按规范坐标序号排列的只读维快照。 |
| `HasCoordinate` | 获取当前位置是否包含至少一个数据域坐标维。 |
| `HasScreenOverride` | 获取当前位置是否至少包含一个屏幕维覆盖。 |
| `RelativeTo` | 获取可选屏幕百分比参考边界。 |
| `ScreenX` | 获取可选屏幕 X 覆盖。 |
| `ScreenY` | 获取可选屏幕 Y 覆盖。 |

## 方法

### `TryGetDimension(Int32,TCYM.UI.Chart.Components.Mark.ChartMarkResolvedDimensionSnapshot@)`

按规范坐标序号读取一个已解析维。

| 参数 | 说明 |
| --- | --- |
| `coordinateDimensionIndex` | 二维坐标序号。 |
| `dimension` | 成功时返回查询自有维快照。 |

**返回：** 该序号存在时为 `true`。
