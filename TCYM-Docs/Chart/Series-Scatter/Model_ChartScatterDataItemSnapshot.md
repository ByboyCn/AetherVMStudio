# ChartScatterDataItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

公共数据快照中保存的不可变 Scatter 逐项配置。可变嵌套 option 只通过克隆 getter 暴露，
因而不能反向修改已经发布的 RawItem。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ChildGroupId` | 获取 universal transition 子数据组 ID。 |
| `Cursor` | 获取建议使用的原生指针光标名称。 |
| `GroupId` | 获取 universal transition 当前数据组 ID。 |
| `HasSymbol` | 获取逐项 symbol 类型是否显式声明。 |
| `HasSymbolKeepAspect` | 获取逐项 image symbol 宽高比是否显式声明。 |
| `HasSymbolOffset` | 获取逐项 symbol 偏移是否显式声明。 |
| `HasSymbolRotate` | 获取逐项 symbol 旋转是否显式声明。 |
| `HasSymbolSize` | 获取逐项 symbol 尺寸是否显式声明。 |
| `Id` | 获取数据项业务 ID。 |
| `IsScalarSyntax` | 获取来源数据项是否由标量构造入口创建。 |
| `Key` | 获取 TCYM 稳定 diff 键。 |
| `Name` | 获取数据项显示名称。 |
| `Selected` | 获取数据项初始选择种子。 |
| `Symbol` | 获取逐项 symbol 类型、路径或图片 URI。 |
| `SymbolKeepAspect` | 获取逐项 image symbol 宽高比开关。 |
| `SymbolOffset` | 获取逐项 symbol 偏移。 |
| `SymbolRotate` | 获取逐项 symbol 旋转角度。 |
| `SymbolSize` | 获取逐项 symbol 尺寸。 |
| `Values` | 获取不可变值向量。 |

## 方法

### `GetBlur`

创建逐项 blur 状态的独立副本。

**返回：** 不能反向修改当前快照的新状态。

### `GetEmphasis`

创建逐项 emphasis 状态的独立副本。

**返回：** 不能反向修改当前快照的新状态。

### `GetItemStyle`

创建逐项图元样式的独立副本。

**返回：** 不能反向修改当前快照的新样式。

### `GetLabel`

创建逐项常态标签的独立副本。

**返回：** 不能反向修改当前快照的新标签。

### `GetSelect`

创建逐项 select 状态的独立副本。

**返回：** 不能反向修改当前快照的新状态。

### `GetTooltip`

创建逐项 Tooltip 的独立副本。

**返回：** 不能反向修改当前快照的新 Tooltip。
