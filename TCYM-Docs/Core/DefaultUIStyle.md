# DefaultUIStyle

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIStyle`

## 概述

默认 UI 样式实现。负责把样式数据（长度/颜色/字体/阴影等） 转换为像素并应用到具体的 <see cref="UIElement"/> 上。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Padding` | `IReadOnlyList<UnitValue>` | 获取或设置四方向内边距快照，索引顺序固定为上、右、下、左。 设置时接受 CSS 标准的一到四项简写；值会立即展开到现有四个单边属性，不保留调用方集合引用。 |

## 方法

### ApplyTo(UIElement)

```csharp
void ApplyTo(UIElement element)
```

将当前样式应用到指定元素。 - 像素单位会根据 DPI 进行换算 - 百分比尺寸不直接设为显式宽高，留待布局阶段解析 - 同步背景、边框、字体、阴影、布局与定位等属性

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `element` | `UIElement` | 要应用样式的 UI 元素。 |

### ParseFromCss(string)

```csharp
void ParseFromCss(string cssText)
```

从 CSS 文本解析并写入当前样式（同时更新全局样式设置）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `cssText` | `string` | CSS 样式文本。 |

### MergeWith(UIStyle)

```csharp
void MergeWith(UIStyle other)
```

将另一个样式对象的属性合并到当前样式中。 只更新那些在 other 中被显式修改过的属性（即与 UIStyle 默认值不同的属性）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `other` | `UIStyle` | 要合并的样式对象。 |

### UpdateStyle(UpdateUIStyle)

```csharp
UIStyle UpdateStyle(UpdateUIStyle other)
```

将另一个 UpdateUIStyle 对象的更新应用到当前样式中。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `other` | `UpdateUIStyle` | 样式 |

### Clone()

```csharp
DefaultUIStyle Clone()
```

创建当前样式的深拷贝（使用 MemberwiseClone，不依赖反射）。 所有值类型/字符串属性自动复制，引用类型属性（集合等）单独深拷贝。
