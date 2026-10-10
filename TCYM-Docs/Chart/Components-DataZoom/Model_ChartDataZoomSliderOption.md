# ChartDataZoomSliderOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义可见 dataZoom slider 的布局方向、数据缩略图、handle、detail、moveHandle 与面板拖选配置。
所有字段均保留 presence，使普通 `SetOption` 能区分省略、显式空值和整块重置。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BackgroundColor` | 获取或设置 slider 面板背景画刷。 |
| `BorderColor` | 获取或设置 slider 面板边框画刷。 |
| `BorderRadius` | 获取或设置 slider 面板四角半径。 |
| `BrushSelect` | 获取或设置 slider 面板拖选新范围的配置。 |
| `DataBackground` | 获取或设置完整数据缩略图样式；赋空或全新空节点表示整块重置。 |
| `Detail` | 获取或设置端点 detail 文本配置；不执行 delegate 或运行时代码生成。 |
| `FillerColor` | 获取或设置当前选中窗口的填充画刷。 |
| `HandleSize` | 获取或设置两端 handle 的像素或百分比尺寸。 |
| `HandleStyle` | 获取或设置两端 handle 样式；赋空或全新空节点表示整块重置。 |
| `MoveHandle` | 获取或设置中央 moveHandle 配置；当前渲染器使用固定内置 glyph。 |
| `Orient` | 获取或设置 slider 排列方向；空值表示恢复自动选择。 |
| `Realtime` | 获取或设置拖动过程中是否实时提交 dataZoom 窗口。 |
| `SelectedDataBackground` | 获取或设置选中窗口内的数据缩略图样式；赋空或全新空节点表示整块重置。 |
| `ShowDataShadow` | 获取或设置数据缩略图的自动、显示或隐藏策略。 |
| `SubType` | 获取 `MainType` 下的具体子类型。系列使用 `line`、`bar` 等值；<br />多数组件不需要子类型。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
