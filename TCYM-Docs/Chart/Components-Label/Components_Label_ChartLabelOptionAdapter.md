# ChartLabelOptionAdapter

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

把 presence-aware `ChartLabelOption` 预编译为可供同一系列全部数据项复用的不可变绑定。

## 说明

`Prepare` 会立即快照 option、rich 样式和画刷，并且只编译一次有效模板。
返回的绑定不会保留诊断集合。旧式 callback 只被转换为中央文本回调，不在此处执行或吞掉异常；
最终异常仍由 `ChartTextResolver` 使用统一诊断代码隔离。

## 字段

| 名称 | 说明 |
| --- | --- |
| `InvalidPositionDiagnosticCode` | 位置关键字未知并回退到系列默认位置时使用的稳定诊断代码。 |
| `TemplatePreparationFailureDiagnosticCode` | 模板预编译失败并回退到默认内容时使用的稳定诊断代码。 |

## 方法

### `Prepare(TCYM.UI.Chart.Model.ChartLabelOption,TCYM.UI.Chart.Core.ChartDiagnostics,TCYM.UI.Chart.Components.Label.ChartLabelPosition,String,String)`

快照标签选项并准备可跨同一系列数据项复用的 formatter、模板和位置绑定。

| 参数 | 说明 |
| --- | --- |
| `option` | 当前有效系列或状态标签选项。 |
| `diagnostics` | 接收一次性准备诊断的当前构建诊断集合。 |
| `defaultPosition` | 位置缺失或无效时由系列几何决定的默认位置。 |
| `defaultFormatterTemplate` | option 未提供 formatter 字符串时使用的可选系列默认模板。 |
| `optionPath` | 标签块的稳定 option 基础路径，例如 `series[2].label`；适配器会为字段诊断追加子路径。 |

**返回：** 与源 option 后续修改隔离、可重复逐项应用的绑定。

### `PrepareStates(TCYM.UI.Chart.Model.ChartLabelOption,TCYM.UI.Chart.Core.ChartDiagnostics,TCYM.UI.Chart.Model.ChartLabelOption,TCYM.UI.Chart.Model.ChartLabelOption,TCYM.UI.Chart.Model.ChartLabelOption,TCYM.UI.Chart.Components.Label.ChartLabelPosition,String,String)`

一次准备 normal、emphasis、blur 与 select 的公共标签绑定，供具体系列逐数据项复用。

| 参数 | 说明 |
| --- | --- |
| `normal` | normal 标签选项。 |
| `diagnostics` | 接收一次性位置与模板准备诊断的集合。 |
| `emphasis` | 可选 emphasis 标签补丁。 |
| `blur` | 可选 blur 标签补丁。 |
| `select` | 可选 select 标签补丁。 |
| `defaultPosition` | normal 缺失或无效位置时使用的系列默认位置。 |
| `defaultFormatterTemplate` | normal 未提供 formatter 时使用的系列默认模板。 |
| `optionPath` | normal 标签块的稳定 option 路径。 |

**返回：** 与四个源 option 后续修改隔离、可重复应用的状态集绑定。
