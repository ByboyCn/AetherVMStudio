# Sdl3FileDialog

> **类型**：类　**分类**：Storage　**框架版本**：`0.1.1.24`

## 概述

基于 SDL3 原生文件对话框（SDL_ShowOpenFileDialog / SaveFileDialog / OpenFolderDialog）的文件选择封装。 这是 SDL3 新增能力（SDL2 没有原生文件对话框），跨平台由 SDL3 统一提供，作为 <c>NativePickerService</c> 之外的可选后端。 已存在 UI 调度线程时会自动 marshaling 到窗口线程；事件循环启动前调用时， 调用方仍需位于 SDL 窗口创建线程。结果通过 SDL 事件循环异步回调返回。

## 方法

### OpenFilesAsync(FilePickerOpenOptions?)

```csharp
Task<IReadOnlyList<string>> OpenFilesAsync(FilePickerOpenOptions? options = null)
```

打开文件选择对话框（可多选、可按类型过滤）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `options` | `FilePickerOpenOptions?` | 文件选择参数（复用现有 <see cref="FilePickerOpenOptions"/>）。 |

**返回：** 所选文件完整路径列表；取消或出错返回空列表。

### OpenFoldersAsync(bool, string?)

```csharp
Task<IReadOnlyList<string>> OpenFoldersAsync(bool allowMultiple = false, string? suggestedStartLocation = null)
```

打开文件夹选择对话框（可多选）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `allowMultiple` | `bool` | 是否允许多选。 |
| `suggestedStartLocation` | `string?` | 建议起始目录。 |

**返回：** 所选文件夹完整路径列表；取消或出错返回空列表。

### SaveFileAsync(string?, IReadOnlyList<FilePickerFileType>?)

```csharp
Task<string?> SaveFileAsync(string? suggestedStartLocation = null, IReadOnlyList<FilePickerFileType>? filters = null)
```

打开保存文件对话框，返回单个目标路径。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `suggestedStartLocation` | `string?` | 建议起始目录或文件名。 |
| `filters` | `IReadOnlyList<FilePickerFileType>?` | 文件类型过滤列表。 |

**返回：** 保存目标路径；取消或出错返回 null。
'}),Ob=Object.assign