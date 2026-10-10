# BindingSpec

> **类型**：类　**分类**：Binding　**框架版本**：`0.1.1.24`

## 概述

Binding V2 声明式绑定规范。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `TargetProperty` | `IBindableProperty` | 强类型目标属性描述符。 |
| `SourceProperty` | `LambdaExpression` | 强类型源属性路径。默认从 BindingContext 解析源实例。 |
| `Mode` | `BindingMode` | 绑定模式，默认使用目标属性声明的模式。 |
| `Source` | `object?` | 可选的显式数据源对象。若为 null，则使用元素解析得到的 DataContext。 |
| `UpdateSourceTrigger` | `BindingUpdateSourceTrigger` | 目标变化回写源的触发器。 |
| `Converter` | `IBindingValueConverter?` | 可选值转换器。 |
| `ConverterParameter` | `object?` | 传给转换器的参数。 |
| `FallbackValue` | `object?` | 源路径无法求值时写入目标的值。 |
| `TargetNullValue` | `object?` | 源值为 null 时写入目标的替代值。 |
| `StringFormat` | `string?` | 目标为字符串时使用的格式。 |
| `Delay` | `TimeSpan` | 通知后延迟同步的时间。 |
