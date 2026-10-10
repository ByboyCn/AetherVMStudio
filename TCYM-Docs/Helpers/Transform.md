# Transform

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

CSS变换数据结构，支持多种2D和3D变换操作

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `TransformType` | `enum` | 变换类型枚举 |
| `Type` | `TransformType` | 变换类型 |
| `Values` | `float[]` | 值列表（根据类型有不同含义） |
| `Lengths` | `UnitValue[]?` | CSS 长度参数，保留 px/%/calc 到绘制时按元素尺寸求值；为空时沿用 Values 的历史像素含义。 |

## 方法

### Clone()

```csharp
Transform Clone()
```

克隆变换及其全部数组，避免动画和样式实例共享可变长度表达式。

### ResolveLength(int, float, float)

```csharp
float ResolveLength(int index, float basis, float dpiScale)
```

把 CSS 长度解析成物理像素；百分比使用传入的物理基准，px 仅应用一次布局 DPI。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `index` | `int` |  |
| `basis` | `float` |  |
| `dpiScale` | `float` |  |

### None()

```csharp
Transform None()
```

创建无变换

### Rotate(float)

```csharp
Transform Rotate(float degrees)
```

创建2D旋转（角度：度）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `degrees` | `float` |  |

### RotateX(float)

```csharp
Transform RotateX(float degrees)
```

创建X轴旋转（角度：度）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `degrees` | `float` |  |

### RotateY(float)

```csharp
Transform RotateY(float degrees)
```

创建Y轴旋转（角度：度）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `degrees` | `float` |  |

### RotateZ(float)

```csharp
Transform RotateZ(float degrees)
```

创建Z轴旋转（角度：度）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `degrees` | `float` |  |

### Rotate3D(float, float, float, float)

```csharp
Transform Rotate3D(float x, float y, float z, float degrees)
```

创建3D旋转（轴向量 + 角度：度）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | 轴X分量 |
| `y` | `float` | 轴Y分量 |
| `z` | `float` | 轴Z分量 |
| `degrees` | `float` | 旋转角度（度） |

### Scale(float, float)

```csharp
Transform Scale(float sx, float sy)
```

创建2D缩放

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `sx` | `float` |  |
| `sy` | `float` |  |

### Scale(float)

```csharp
Transform Scale(float s)
```

创建2D缩放（单一值）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `s` | `float` |  |

### ScaleX(float)

```csharp
Transform ScaleX(float sx)
```

创建X轴缩放

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `sx` | `float` |  |

### ScaleY(float)

```csharp
Transform ScaleY(float sy)
```

创建Y轴缩放

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `sy` | `float` |  |

### ScaleZ(float)

```csharp
Transform ScaleZ(float sz)
```

创建Z轴缩放

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `sz` | `float` |  |

### Scale3D(float, float, float)

```csharp
Transform Scale3D(float sx, float sy, float sz)
```

创建三个轴各自独立的缩放。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `sx` | `float` |  |
| `sy` | `float` |  |
| `sz` | `float` |  |

### Translate(float, float)

```csharp
Transform Translate(float tx, float ty)
```

创建2D平移（像素）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `tx` | `float` |  |
| `ty` | `float` |  |

### TranslateX(float)

```csharp
Transform TranslateX(float tx)
```

创建X轴平移（像素）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `tx` | `float` |  |

### TranslateY(float)

```csharp
Transform TranslateY(float ty)
```

创建Y轴平移（像素）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `ty` | `float` |  |

### TranslateZ(float)

```csharp
Transform TranslateZ(float tz)
```

创建Z轴平移（像素）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `tz` | `float` |  |

### Translate3D(float, float, float)

```csharp
Transform Translate3D(float tx, float ty, float tz)
```

创建3D平移（像素）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `tx` | `float` |  |
| `ty` | `float` |  |
| `tz` | `float` |  |

### SkewX(float)

```csharp
Transform SkewX(float degrees)
```

创建X轴斜切（角度：度）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `degrees` | `float` |  |

### SkewY(float)

```csharp
Transform SkewY(float degrees)
```

创建Y轴斜切（角度：度）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `degrees` | `float` |  |

### Skew(float, float)

```csharp
Transform Skew(float sx, float sy)
```

创建2D斜切（两个轴的角度：度）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `sx` | `float` |  |
| `sy` | `float` |  |

### Perspective(float)

```csharp
Transform Perspective(float distance)
```

创建透视变换

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `distance` | `float` | 透视距离 |

### ToString()

```csharp
string ToString()
```

返回CSS字符串表示
