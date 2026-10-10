# ChartPreparedLabelOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

保存一次准备后的不可变标签公共绑定；同一实例可依次应用到一个系列的多个 descriptor。

## 说明

实例只保留 option 深快照、编译模板和 callback 引用，不保留构建上下文或诊断集合。
`ApplyTo`` 会同步执行参数工厂并立即把返回值写入 descriptor，工厂和状态均不会逃逸。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Show` | 获取 option 快照显式声明的可见性；空值表示由系列自己的默认规则决定。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ParameterFactoryFailureDiagnosticCode` | 参数工厂失败并使用空参数继续构建时使用的稳定诊断代码。 |

## 方法

### `ApplyTo(TCYM.UI.Chart.Components.Label.ChartLabelDescriptor,@,TCYM.UI.Chart.Components.Label.ChartLabelFormatterParametersFactory{},TCYM.UI.Chart.Text.ChartTextContent,TCYM.UI.Chart.Core.ChartDiagnostics,String)`

同步创建当前项参数并把 prepared 公共字段合并到系列已初始化的 descriptor。

| 参数 | 说明 |
| --- | --- |
| `descriptor` | 已由系列填入 Id、Anchor、默认 TextStyle、状态样式、布局、引导线和 metadata 的 descriptor。 |
| `state` | 当前数据项状态；只在同步参数工厂调用期间有效。 |
| `parameterFactory` | 为当前数据项创建隔离参数快照的同步工厂。 |
| `defaultContent` | formatter 和模板缺失、返回空或失败时使用的不可变内容。 |
| `diagnostics` | 接收参数工厂失败诊断的当前构建诊断集合。 |
| `diagnosticContext` | 用于定位参数工厂诊断的稳定组件或数据项上下文。 |

### `ApplyTo(TCYM.UI.Chart.Components.Label.ChartLabelDescriptor,TCYM.UI.Chart.Text.ChartFormatterParameters@,TCYM.UI.Chart.Text.ChartTextContent)`

把 prepared 公共字段合并到系列 descriptor，并使用调用方已经创建的参数快照。

| 参数 | 说明 |
| --- | --- |
| `descriptor` | 已由系列填入 Id、Anchor、默认 TextStyle、状态样式、布局、引导线和 metadata 的 descriptor。 |
| `parameters` | 当前数据项不可变 formatter 参数。 |
| `defaultContent` | formatter 和模板缺失、返回空或失败时使用的不可变内容。 |
