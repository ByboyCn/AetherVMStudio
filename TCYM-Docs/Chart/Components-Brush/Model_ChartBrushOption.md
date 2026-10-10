# ChartBrushOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义 Cartesian Brush 的系列范围、链接、cover 行为、throttle 与 InBrush/OutOfBrush 视觉。
Brush areas 属于 Engine-local action/runtime 状态，不保存在此 canonical option 中。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BrushLink` | 获取或设置按稳定数据身份接收选择投影的系列；空值恢复不链接，不能替代 SeriesIndex 过滤器。 |
| `BrushMode` | 获取或设置新建区域替换旧区域还是与旧区域并存。 |
| `BrushStyle` | 获取或设置 Brush cover 样式；赋空或全新空节点表示整块重置。 |
| `BrushType` | 获取或设置 takeGlobalCursor 激活时使用的默认 Brush 几何类型。 |
| `ComponentType` | 获取组件注册与合并所使用的类型名。 |
| `InBrush` | 获取或设置区域内数据项的固定 color/opacity 覆盖。 |
| `OutOfBrush` | 获取或设置区域外数据项的固定 color/opacity 覆盖。 |
| `RemoveOnClick` | 获取或设置 Single 模式下短点击是否移除现有 cover。 |
| `SeriesIndex` | 获取或设置允许空间 selector 直接检查的系列；空值恢复全部系列，显式空集合表示无系列。 |
| `ThrottleDelay` | 获取或设置非负 throttle 延迟，单位为毫秒；零表示每个候选都可发布。 |
| `ThrottleType` | 获取或设置 brushselected 高频结果采用固定频率还是防抖合并。 |
| `Transformable` | 获取或设置已提交 cover 是否允许移动和调整有效边。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。

### `Reset`

显式清除 Brush 专属字段和嵌套块；组件 ID、布局、Show、Z 与 Silent 等基类字段保持不变。
