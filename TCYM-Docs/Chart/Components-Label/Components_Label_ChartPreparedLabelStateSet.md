# ChartPreparedLabelStateSet

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

保存 normal 与三个交互状态的一次性准备结果；具体系列只负责提供 anchor、数据参数和默认内容。

## 说明

该类型仅使用泛型委托和静态调用，不依赖反射、动态代码或运行时类型扫描，适用于 NativeAOT。

## 方法

### `ApplyTo(TCYM.UI.Chart.Components.Label.ChartLabelDescriptor,@,TCYM.UI.Chart.Components.Label.ChartLabelFormatterParametersFactory{},TCYM.UI.Chart.Text.ChartTextContent,TCYM.UI.Chart.Core.ChartDiagnostics,Boolean,String)`

同步创建参数并把 normal 和全部状态差异应用到系列已初始化的 descriptor。

| 参数 | 说明 |
| --- | --- |
| `descriptor` | 已由系列填入身份、anchor、基础样式和 metadata 的 descriptor。 |
| `state` | 只在同步参数工厂调用期间有效的数据项状态。 |
| `parameterFactory` | 创建隔离 formatter 参数的 AOT 友好泛型工厂。 |
| `defaultContent` | 全部状态 formatter 的稳定回退内容。 |
| `diagnostics` | 接收参数工厂失败诊断的集合。 |
| `defaultShow` | normal 未声明 show 时使用的系列默认值。 |
| `diagnosticContext` | 参数工厂诊断使用的稳定上下文。 |

### `ApplyTo(TCYM.UI.Chart.Components.Label.ChartLabelDescriptor,TCYM.UI.Chart.Text.ChartFormatterParameters@,TCYM.UI.Chart.Text.ChartTextContent,Boolean)`

使用调用方已经创建的参数，把 normal 和全部状态差异应用到 descriptor。

| 参数 | 说明 |
| --- | --- |
| `descriptor` | 已由系列初始化的 descriptor。 |
| `parameters` | 当前数据项不可变 formatter 参数。 |
| `defaultContent` | 全部状态 formatter 的稳定回退内容。 |
| `defaultShow` | normal 未声明 show 时使用的系列默认值。 |

### `IsVisibleInAnyState(Boolean)`

判断 normal 或任一组合状态是否可能显示标签，供系列避免提交确定永久隐藏的标签。

| 参数 | 说明 |
| --- | --- |
| `defaultShow` | normal 未声明 show 时使用的系列默认值。 |

**返回：** 八种组合状态至少有一种可见时为 `true`。
