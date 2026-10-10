# UIFontManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

字体管理与缓存工具类。 职责： 1. 根据字体族名称获取并缓存对应的 <see cref="SKTypeface"/> 实例，避免重复创建。 2. 当指定字体族不存在或加载失败时，回退到 <see cref="SKTypeface.Default"/>。 使用方式： var face = UIFontManager.Get("Arial"); 线程安全说明： 字体查询和缓存清理共用内部锁，可以安全地从多个线程访问。 字体族名称大小写敏感（与 SkiaSharp 行为一致），如需忽略大小写可在外部统一处理。

## 方法

### Get(string)

```csharp
SKTypeface Get(string family)
```

获取指定字体族对应的 SKTypeface（带缓存）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `family` | `string` | 字体族名称，例如 "Arial"、"Microsoft YaHei"。为空或 null 时返回默认字体。 |

**返回：** 成功加载的字体类型；若不可用则返回 <see cref="SKTypeface.Default"/>。
