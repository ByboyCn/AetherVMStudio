# ChartGridOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个 Cartesian grid 组件。基础 box 字段来自 `ChartComponentOption`；
本类型补充 ECharts 6 的外边界约束以及背景、边框视觉配置。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BackgroundColor` | 获取或设置 grid 背景画刷；仅 Show 为真时绘制。 |
| `BorderColor` | 获取或设置 grid 边框画刷；仅 Show 为真时绘制。 |
| `BorderWidth` | 获取或设置非负有限 grid 边框宽度。 |
| `ComponentType` | 获取组件注册与合并所使用的类型名。 |
| `ContainLabel` | 获取或设置旧式 containLabel 兼容开关。ECharts 6 中应优先使用 OuterBoundsMode 和<br />OuterBoundsContain；显式赋空恢复自动解析。 |
| `OuterBounds` | 获取或设置独立外边界矩形；空或未修改实例表示整块重置。 |
| `OuterBoundsClampHeight` | 获取或设置为防止 grid 过度收缩而保留的最小高度或百分比。 |
| `OuterBoundsClampWidth` | 获取或设置为防止 grid 过度收缩而保留的最小宽度或百分比。 |
| `OuterBoundsContain` | 获取或设置外边界必须包含的轴附属内容。 |
| `OuterBoundsMode` | 获取或设置 grid 外边界约束模式。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
