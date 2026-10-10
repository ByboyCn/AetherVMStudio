# TextureHelper

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

贴图（位图 / 图像）加载辅助类。 负责从磁盘安全地加载 `SKBitmap` / `SKImage`，并提供一个简单的内存缓存以减少重复解码开销。 所有方法为线程安全。

## 方法

### LoadBitmap(string)

```csharp
SKBitmap? LoadBitmap(string path)
```

从给定路径加载并返回一个可重用的 SKBitmap（弱缓存）。路径可以为相对或绝对。 返回值为借用对象，调用方不得 Dispose；如果加载失败返回 null。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` |  |

### LoadBytes(string)

```csharp
byte[]? LoadBytes(string path)
```

读取图片文件或嵌入资源的原始字节。支持 res://、绝对路径与资源相对路径。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` |  |

### LoadBitmap(byte[]?)

```csharp
SKBitmap? LoadBitmap(byte[]? bytes)
```

从编码后的图片字节解码位图。失败返回 null。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `bytes` | `byte[]?` |  |

### LoadImage(string)

```csharp
SKImage? LoadImage(string path)
```

从路径加载 SKImage（基于 SKBitmap 的封装）。失败返回 null。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` |  |

### LoadImage(byte[]?)

```csharp
SKImage? LoadImage(byte[]? bytes)
```

从编码后的图片字节加载 SKImage。失败返回 null。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `bytes` | `byte[]?` |  |

### ClearCache()

```csharp
void ClearCache()
```

清空并释放缓存中仍存活的所有位图。 调用方必须确保所有窗口已经停止绘制；普通运行期的回收仅移除弱引用， 不调用此方法，因此不会 Dispose 其他线程正在借用的对象。
