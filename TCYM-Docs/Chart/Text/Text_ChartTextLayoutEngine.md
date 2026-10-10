# ChartTextLayoutEngine

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Text`　**Chart 版本**：`0.1.1.25`

## 概述

提供与具体组件和 series 无关的文本测量、rich run、换行和截断布局。

## 说明

当前实现使用 Skia `SKFont` 的 basic shaping 测量路径，不引入
HarfBuzz。拉丁文字、数字和常规 CJK 标签可以确定布局；依赖复杂字形重排、完整双向算法或
浏览器字体回退链的脚本，可能与 ECharts Canvas 的像素和断行位置不同。该边界是 M1.3 的
显式兼容范围，不应把结果描述为浏览器 Canvas 的逐像素等价物。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Shared` | 获取无可变共享状态的布局引擎实例。 |

## 方法

### `Layout(TCYM.UI.Chart.Text.ChartTextLayoutRequest@)`

根据不可变请求创建可供绘制、测量和命中共同使用的布局快照。

| 参数 | 说明 |
| --- | --- |
| `request` | 已捕获内容、普通样式和 rich 样式的布局请求。 |

**返回：** 包含逐行逐 run 几何、逻辑框和像素框的不可变结果。
