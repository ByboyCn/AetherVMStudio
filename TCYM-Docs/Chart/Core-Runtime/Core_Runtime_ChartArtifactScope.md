# ChartArtifactScope

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

标识制品所属的全局、系列、组件或坐标系实例。

## 构造函数

### `ChartArtifactScope(TCYM.UI.Chart.Core.Runtime.ChartArtifactScopeKind,Int32,String,String,Int64)`

使用完整作用域信息创建作用域。

| 参数 | 说明 |
| --- | --- |
| `kind` | 作用域类别。 |
| `index` | 兼容索引；稳定规范作用域使用 -1。 |
| `id` | 坐标系标识。 |
| `mainType` | 规范配置节点的主类型。 |
| `canonicalIdentity` | 配置合并保留的运行时身份。 |

### `ChartArtifactScope(TCYM.UI.Chart.Core.Runtime.ChartArtifactScopeKind,Int32,String)`

使用兼容索引或标识创建作用域。

| 参数 | 说明 |
| --- | --- |
| `kind` | 作用域类别。 |
| `index` | 系列或组件索引；不适用时通常为 -1。 |
| `id` | 坐标系标识；不适用时为空。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `CanonicalIdentity` | 获取规范节点运行时身份；非规范节点作用域为零。 |
| `Global` | 获取全局作用域。 |
| `Id` | 获取坐标系标识。 |
| `Index` | 获取兼容系列或组件索引；规范身份作用域通常为 -1。 |
| `Kind` | 获取作用域类别。 |
| `MainType` | 获取规范节点主类型。 |

## 方法

### `ForComponent(Int32)`

按组件索引创建兼容作用域。

| 参数 | 说明 |
| --- | --- |
| `componentIndex` | 组件在相同主类型中的索引。 |

**返回：** 组件索引作用域。

### `ForComponent(String,Int64)`

按主类型和规范身份创建稳定组件作用域。

| 参数 | 说明 |
| --- | --- |
| `mainType` | 组件主类型。 |
| `canonicalIdentity` | 正数规范运行时身份。 |

**返回：** 稳定组件作用域。

### `ForCoordinateSystem(String)`

按坐标系标识创建作用域。

| 参数 | 说明 |
| --- | --- |
| `id` | 非空坐标系标识。 |

**返回：** 坐标系作用域。

### `ForSeries(Int32)`

按系列索引创建兼容作用域。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 系列索引。 |

**返回：** 系列索引作用域。

### `ForSeries(String,Int64)`

按主类型和规范身份创建稳定系列作用域。

| 参数 | 说明 |
| --- | --- |
| `mainType` | 系列主类型。 |
| `canonicalIdentity` | 正数规范运行时身份。 |

**返回：** 稳定系列作用域。
