# TransformHelper

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

在样式解析期验证整个变换列表，保留相对长度到绘制时求值。

## 方法

### ParseTransform(string)

```csharp
List<Transform> ParseTransform(string transformValue)
```

兼容原有入口；非法值返回 none，新 CSS 声明应使用 TryParseTransform 原子提交。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `transformValue` | `string` |  |

### TryParseTransform(string?, List<Transform>)

```csharp
bool TryParseTransform(string? transformValue, List<Transform> transforms)
```

解析完整变换列表，任一函数、参数或尾随文本无效时整体拒绝。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `transformValue` | `string?` |  |
| `transforms` | `List<Transform>` |  |
