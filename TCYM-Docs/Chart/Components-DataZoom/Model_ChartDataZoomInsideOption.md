# ChartDataZoomInsideOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义绘图区内部的滚轮缩放、拖拽平移与双击复位交互，等价于 ECharts
`dataZoom.type = 'inside'` 的强类型配置入口。

## 说明

支持 Cartesian category/value/time/log 轴；不处理 Polar 或触摸捏合。

## 属性

| 名称 | 说明 |
| --- | --- |
| `MoveOnMouseMove` | 获取或设置按住指针拖拽平移窗口的启用方式或所需修饰键。 |
| `MoveOnMouseWheel` | 获取或设置滚轮平移窗口的启用方式或所需修饰键。 |
| `ResetOnDoubleClick` | 获取或设置在绘图区双击时是否把数据窗口复位到 0～100。完整复位暂时绕过同代 span<br />约束；普通窗口变更或显式 MinSpan/MaxSpan 补丁会退出旁路并重新应用约束。 |
| `SubType` | 获取 `MainType` 下的具体子类型。系列使用 `line`、`bar` 等值；<br />多数组件不需要子类型。 |
| `ZoomOnMouseWheel` | 获取或设置滚轮缩放的启用方式或所需修饰键。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
