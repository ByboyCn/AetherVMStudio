# SKFontPool

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

共享只读使用的 SKFont，减少文本测量和绘制热路径上的原生对象分配。 调用方不能 Dispose 返回值，也不要修改返回字体的属性。

## 方法

### Get(SKTypeface?, float)

```csharp
SKFont Get(SKTypeface? typeface, float size)
```

获取指定字体和字号对应的共享实例。字号按 0.1px 分桶，避免浮点抖动扩大缓存。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `typeface` | `SKTypeface?` |  |
| `size` | `float` |  |
