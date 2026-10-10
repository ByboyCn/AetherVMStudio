# ChartMarkPointOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 `markPoint` 的 presence-aware 共享配置。构造器不写入官方默认值；
Mark Normalize processor 会在 effective option 中物化 pin、50、inside、边框宽度 2 和 z=5。

## 构造函数

### `ChartMarkPointOption`

创建空的 markPoint 配置和惰性 presence-aware 数据集合。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置 blur 状态；赋空显式重置该状态。 |
| `Data` | 获取 point 数据集合。读取不会产生 presence；Add、Insert、索引写入、Remove 和 Clear<br />都会记录本次补丁的数据替换或清空意图。 |
| `Emphasis` | 获取或设置 emphasis 状态；赋空显式重置该状态。 |
| `ItemStyle` | 获取或设置常态图元样式；赋空显式重置整块样式。 |
| `Label` | 获取或设置常态标签；赋空显式重置整块标签。 |
| `Precision` | 获取或设置统计标记显示值的小数精度；负数保留 ECharts 的不舍入语义。 |
| `Select` | 获取或设置 select 状态；赋空显式重置该状态。 |
| `Symbol` | 获取或设置公共 symbol 类型、path 或 image URI。 |
| `SymbolCallback` | 获取或设置按规范化数据项动态解析 symbol 的同步回调；返回空值或失败时运行时回退到<br />`Symbol`。 |
| `SymbolKeepAspect` | 获取或设置 image symbol 是否保持原始宽高比。 |
| `SymbolOffset` | 获取或设置公共 symbol 二维像素或百分比偏移。 |
| `SymbolRotate` | 获取或设置公共 symbol 的有限顺时针旋转角度。 |
| `SymbolSize` | 获取或设置公共 symbol 尺寸。 |
| `SymbolSizeCallback` | 获取或设置按规范化数据项动态解析 symbol 尺寸的同步回调；返回空值或失败时运行时回退到<br />`SymbolSize`。 |
| `Z2` | 获取或设置常态 point 图元的局部绘制层级。 |

## 方法

### `Clone`

创建数据、样式、状态、自定义值载荷和 presence 日志均隔离的副本。

**返回：** 内容等价的新 markPoint option。
