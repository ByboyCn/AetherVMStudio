# UIFileHelper

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

文件与资源路径帮助类。 将与文件查找、解析、打开等相关的逻辑集中到此处，方便统一管理和单元测试。 所有方法为静态方法，返回值采用安全的空值/异常语义。

## 方法

### ResolveAssetPath(string[])

```csharp
string ResolveAssetPath(string[] parts)
```

解析资源路径：接受多个路径片段（例如目录与文件名），按优先级尝试几种常见位置， 并返回第一个存在的绝对路径。如果未找到文件，返回基目录拼接的路径以便调用方进一步处理。 优先级： 1) 相对于应用程序目录（AppContext.BaseDirectory） 2) 相对于当前工作目录（Environment.CurrentDirectory） 3) 相对于传入的相对路径的绝对路径（Path.GetFullPath） 4) 返回基目录下的路径（保证分隔符正确）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `parts` | `string[]` | 路径片段，例如（"Assets","Images","bg.png"） |

**返回：** 找到的存在的文件路径，或基目录下的组合路径（可能不存在）

### ReadFileAsString(string)

```csharp
string ReadFileAsString(string path)
```

读取文件内容并返回string

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 路径 |

### OpenReadIfExists(string)

```csharp
Stream? OpenReadIfExists(string path)
```

如果指定路径存在，则打开并返回可读流；否则返回 null。 调用方应负责关闭/释放返回的流。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 路径 |

### Exists(string)

```csharp
bool Exists(string path)
```

检查文件是否存在（路径可为相对或绝对）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` |  |
