# ChartRegistryChangeEntry

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

描述注册表事务中的一个具体注册项。

## 属性

| 名称 | 说明 |
| --- | --- |
| `IsReplacement` | 获取该项是否替换了同键注册对象。 |
| `Key` | 获取具体注册项键。 |
| `Kind` | 获取具体注册类别。 |
| `PreviousRegistration` | 获取可用的旧注册对象；新增注册时为 `null`。 |
| `RegistrationType` | 获取新注册对象的运行时类型。 |
