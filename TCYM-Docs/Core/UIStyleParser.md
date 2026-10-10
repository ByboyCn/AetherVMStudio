# UIStyleParser

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

UIStyleParser 样式解析器 职责： 1. 将简化的 CSS 声明字符串解析为 UIStyle 对象属性（长度、颜色、布局、定位、动画等）。 2. 支持普通声明块和 @keyframes 动画语法的解析。 3. 长度单位支持 px / % / calc(表达式)。calc 内部解析为 CalcParts 数组，延迟到布局或动画阶段再计算。 4. 对 transition / animation 做基础拆分，填充到样式的过渡和动画相关字段。 5.解析全局选择器 *{ ... } 写入 StyleGlobals统一默认值。 设计要点： -解析容错：遇到未知或格式不完整的声明跳过，不抛异常。 -仅支持与当前渲染/布局系统相关的子集属性，非目标属性忽略。

## 方法

### ParseInto(UIStyle, string)

```csharp
void ParseInto(UIStyle style, string cssText)
```

将 cssText 中的声明解析写入指定 style。 支持两种输入： 1. "selector { a:b; c:d; }" 会提取花括号内部内容。 2.直接传递 "a:b; c:d;"。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `style` | `UIStyle` |  |
| `cssText` | `string` |  |

### ParseGlobal(string)

```csharp
void ParseGlobal(string cssText)
```

解析通配符 *规则并写入 StyleGlobals（全局默认设置）。 仅处理与字体/颜色/光标等通用默认有关的属性。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `cssText` | `string` |  |
