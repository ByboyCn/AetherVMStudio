# ChartImageResolveResult

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering.Symbols`　**Chart 版本**：`0.1.1.25`

## 概述

图片解析器返回的所有权容器。成功结果独占一个 `SKImage`；调用方必须释放结果，
符号工厂则会把图片所有权安全转移给新建的 `ChartImageElement`。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Diagnostic` | 获取失败诊断；成功时为 `null`。 |
| `Image` | 获取解析出来的图片；所有权仍属于当前结果，不得由读取方释放。 |
| `IsSuccess` | 获取解析是否成功且图片所有权尚未转移。 |

## 方法

### `Dispose`

释放尚未转移的图片；调用幂等。

### `Failure(String,String,Exception)`

创建不持有图片资源的失败结果。

| 参数 | 说明 |
| --- | --- |
| `code` | 稳定诊断代码。 |
| `message` | 失败说明。 |
| `exception` | 可选的原始异常。 |

**返回：** 失败结果。

### `Success(SkiaSharp.SKImage)`

创建独占指定图片的成功结果。

| 参数 | 说明 |
| --- | --- |
| `image` | 新建且尚未交给其他所有者的图片。 |

**返回：** 必须释放或交给符号工厂消费的成功结果。
