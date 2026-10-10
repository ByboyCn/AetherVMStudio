# ChartVisualMapPiecewiseOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义离散 piece、category 或等分区间的 piecewise VisualMap。

## 构造函数

### `ChartVisualMapPiecewiseOption`

初始化带 presence 通知的 piece、category 与 selected 集合。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Categories` | 获取或整体设置强类型 category；无显式 piece 时优先于 SplitNumber。 |
| `ItemGap` | 获取或设置相邻 piece 项之间的非负间距。 |
| `ItemSymbol` | 获取或设置 piece 控制器使用的非空 symbol。 |
| `MaxOpen` | 获取或设置是否增加大于 Max 的开放 piece。 |
| `MinOpen` | 获取或设置是否增加小于 Min 的开放 piece。 |
| `Pieces` | 获取或整体设置显式 piece；非空时优先于 Categories 和 SplitNumber。 |
| `Selected` | 获取或整体设置 piece/category 规范键到选择状态的映射。 |
| `SelectedMode` | 获取或设置 multiple 或 single 选择模式。 |
| `SplitNumber` | 获取或设置没有 piece/category 时的等分数量，必须至少为 1。 |
| `SubType` | 获取 `MainType` 下的具体子类型。系列使用 `line`、`bar` 等值；<br />多数组件不需要子类型。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
