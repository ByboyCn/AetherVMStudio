# RelativeBindingSource

> **类型**：类　**分类**：Binding　**框架版本**：`0.1.1.24`

## 概述

描述从目标元素层级解析的 Binding 源。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Self` | `RelativeBindingSource` | 当前目标元素。 |
| `Parent` | `RelativeBindingSource` | 当前目标元素的直接父元素。 |
| `Mode` | `RelativeBindingSourceMode` | 查找模式。 |
| `AncestorType` | `Type?` | Ancestor 模式要求的祖先类型。 |
| `AncestorLevel` | `int` | Ancestor 模式匹配的层级序号。 |

## 方法

### Ancestor(int)

```csharp
RelativeBindingSource Ancestor(int level = 1)
```

查找指定类型的第 N 个祖先，level 从 1 开始。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `level` | `int` |  |
