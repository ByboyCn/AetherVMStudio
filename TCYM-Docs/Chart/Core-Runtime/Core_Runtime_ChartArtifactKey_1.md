# ChartArtifactKey&lt;T1&gt;

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

供处理器、布局和渲染器共享的强类型制品键。存储槽按值类型、名称和作用域比较，
因而协作模块无需共享同一个键对象实例。

## 构造函数

### `ChartArtifactKey<T1>(String,TCYM.UI.Chart.Core.Runtime.ChartArtifactScope)`

创建制品键。

| 参数 | 说明 |
| --- | --- |
| `name` | 在类型与作用域内唯一的非空名称。 |
| `scope` | 制品作用域；默认值表示全局。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Name` | 获取制品名称。 |
| `Scope` | 获取制品作用域。 |

## 方法

### `ForComponent(String,Int32)`

按组件索引创建 M0 兼容作用域键。组件索引只在各 mainType 内局部有效，
新制品应优先使用包含 mainType 和规范身份的重载。

| 参数 | 说明 |
| --- | --- |
| `name` | 制品名称。 |
| `componentIndex` | 组件在相同主类型中的索引。 |

**返回：** 索引作用域键。

### `ForComponent(String,String,Int64)`

按主类型和规范运行时身份创建稳定组件作用域键。

| 参数 | 说明 |
| --- | --- |
| `name` | 制品名称。 |
| `mainType` | 组件主类型。 |
| `canonicalIdentity` | 配置合并保留的正数运行时身份。 |

**返回：** 稳定组件作用域键。

### `ForComponent(String,TCYM.UI.Chart.Model.ChartComponentOption)`

按组件节点的规范运行时身份创建稳定作用域键。

| 参数 | 说明 |
| --- | --- |
| `name` | 制品名称。 |
| `component` | 有效配置中的组件节点。 |

**返回：** 稳定组件作用域键。

### `ForSeries(String,Int32)`

按当前系列索引创建兼容作用域键。

| 参数 | 说明 |
| --- | --- |
| `name` | 制品名称。 |
| `seriesIndex` | 系列索引。 |

**返回：** 索引作用域键。

**说明：** 索引会随合并变化；跨更新制品应优先使用规范运行时身份重载。

### `ForSeries(String,String,Int64)`

按主类型和规范运行时身份创建稳定系列作用域键。

| 参数 | 说明 |
| --- | --- |
| `name` | 制品名称。 |
| `mainType` | 系列主类型，通常为 `series`。 |
| `canonicalIdentity` | 配置合并保留的正数运行时身份。 |

**返回：** 稳定系列作用域键。

### `ForSeries(String,TCYM.UI.Chart.Model.ChartSeriesOption)`

按系列节点的规范运行时身份创建稳定作用域键。

| 参数 | 说明 |
| --- | --- |
| `name` | 制品名称。 |
| `series` | 有效配置中的系列节点。 |

**返回：** 稳定系列作用域键。

### `Global(String)`

创建全局作用域键。

| 参数 | 说明 |
| --- | --- |
| `name` | 制品名称。 |

**返回：** 全局键。
