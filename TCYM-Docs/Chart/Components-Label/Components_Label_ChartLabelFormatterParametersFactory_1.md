# ChartLabelFormatterParametersFactory&lt;T1&gt;

> **类型**：delegate　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

从调用方状态同步创建单个标签的 formatter 参数快照。

## 说明

工厂在 `ApplyTo`` 内同步执行一次，不会被保存，
也不使用反射、动态代码或运行时类型扫描，因此适用于 NativeAOT。工厂抛出的异常会被隔离为诊断，
当前标签则使用 `Empty` 和默认内容继续构建。
