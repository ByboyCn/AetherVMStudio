# ChartElement

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

图表内部轻量场景节点。它不是 UIElement，只保留图表绘制、状态和命中测试所需字段。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BlurStyle` | 获取或设置弱化状态覆盖样式；仅显式字段参与合并。 |
| `BrushHitTestMode` | 获取或设置画刷透明度参与命中的方式。默认使用 `Geometry`，<br />与 ECharts 风格的透明交互代理兼容；需要让已知全透明画刷不命中时可选择<br />`VisiblePaint`。 |
| `ClipRect` | 获取或设置元素局部坐标中的矩形裁剪区域。 |
| `Draggable` | 获取或设置元素是否允许交互控制器把它作为拖拽目标。 |
| `EmphasisStyle` | 获取或设置强调状态覆盖样式；仅显式字段参与合并。 |
| `HoverEmphasisDisabled` | 获取或设置指针悬停是否禁止为当前命中元素启用 emphasis。<br />action 或调用方显式设置的 emphasis 不受该开关影响。 |
| `Id` | 获取或设置元素标识，供调试、场景检索或业务关联使用。 |
| `InteractionState` | 获取当前基础状态与具名来源状态的组合；设置时只替换兼容基础状态，不接管具名来源持有的状态位。 |
| `IsSelected` | 获取或设置是否包含持久选择状态。 |
| `Metadata` | 获取或设置用于事件、tooltip 和状态联动的图表语义元数据。 |
| `Name` | 获取或设置元素显示名称。 |
| `Opacity` | 获取或设置元素透明度；会与父组和样式透明度相乘。 |
| `OriginX` | 获取或设置局部变换原点的 X 坐标。 |
| `OriginY` | 获取或设置局部变换原点的 Y 坐标。 |
| `Rotation` | 获取或设置围绕变换原点顺时针旋转的角度（度）。 |
| `ScaleX` | 获取或设置局部 X 轴缩放比例。 |
| `ScaleY` | 获取或设置局部 Y 轴缩放比例。 |
| `SelectStyle` | 获取或设置选中状态覆盖样式；仅显式字段参与合并。 |
| `Silent` | 获取或设置元素是否忽略命中测试。 |
| `State` | 兼容旧代码的单状态入口。设置 Normal 只清除临时的 emphasis/blur，保留 select；<br />新代码应使用 `InteractionState` 或<br />`SetInteractionState`。 |
| `Style` | 获取或设置普通状态的基础视觉样式。 |
| `SuppressChartEvents` | 获取或设置元素命中后是否只参与引擎内部 hover、Tooltip 等控制器路由，而不向<br />`ChartEvent` 发布公开图元事件。 |
| `Visible` | 获取或设置元素是否参与绘制和命中测试。 |
| `X` | 获取或设置元素相对于父组的 X 平移。 |
| `Y` | 获取或设置元素相对于父组的 Y 平移。 |
| `Z` | 获取或设置同一 ZLevel 内的主要绘制顺序。 |
| `Z2` | 获取或设置同一 Z 值内的次级绘制顺序。 |
| `ZLevel` | 获取或设置全局层级；父组按 ZLevel、Z、Z2 和插入顺序稳定排序。 |

## 方法

### `ClearInteractionState`

清除全部临时状态和选择状态。

### `Dispose`

从父组脱离并释放元素拥有的资源。调用幂等；释放后的元素不能再次加入场景树。

### `HitTest(Single,Single)`

在父坐标系中对元素进行命中测试。

| 参数 | 说明 |
| --- | --- |
| `parentX` | 父坐标系 X 坐标。 |
| `parentY` | 父坐标系 Y 坐标。 |

**返回：** 命中身份；不可见、静默、不可逆变换或未命中时为 `null`。

### `Render(SkiaSharp.SKCanvas,Single)`

在当前父级透明度下绘制元素及其子树。

| 参数 | 说明 |
| --- | --- |
| `canvas` | 目标 Skia 画布。 |
| `inheritedOpacity` | 已由祖先元素合成的透明度。 |

### `Render(SkiaSharp.SKCanvas)`

在给定画布上以根级透明度 1 绘制该元素。

| 参数 | 说明 |
| --- | --- |
| `canvas` | 目标 Skia 画布。 |

### `SetInteractionState(TCYM.UI.Chart.Rendering.ChartInteractionState,Boolean,String)`

按来源启用或关闭一个或多个交互状态，而不破坏其他来源的所有权。

| 参数 | 说明 |
| --- | --- |
| `state` | 要修改的状态位。 |
| `enabled` | 为 `true` 时设置状态，否则仅清除该来源的状态。 |
| `sourceKey` | 区分大小写且非空白的状态来源标识。 |

### `SetInteractionState(TCYM.UI.Chart.Rendering.ChartInteractionState,Boolean)`

启用或关闭一个或多个交互状态，而不破坏其余状态。

| 参数 | 说明 |
| --- | --- |
| `state` | 要修改的状态位。 |
| `enabled` | 为 `true` 时设置状态，否则清除状态。 |
