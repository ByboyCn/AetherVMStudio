# UIRangePicker

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, IDisposable, IUIElementDisposalPreflight`

## 概述

日期范围选择器（简化版，风格参考 antd RangePicker）。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Style` | `UIStyle?` | 元素样式。支持直接赋值 <see cref="UpdateUIStyle"/>，会与默认样式合并。 |
| `AllowClear` | `bool` | 是否允许清空。 |
| `DateRender` | `Func<DateTime, UIElement>?` | 自定义日期单元格渲染。 |
| `Disabled` | `bool` | 是否禁用组件。 |
| `DisabledDate` | `Func<DateTime, bool>?` | 不可选日期判断。返回 <c>true</c> 表示禁用。 |
| `InputReadOnly` | `bool` | 输入框是否只读（用于移动端避免唤起虚拟键盘）。 |
| `MinDate` | `DateTime?` | 最小可选日期。 |
| `MaxDate` | `DateTime?` | 最大可选日期。 |
| `Mode` | `DatePickerPanelMode` | 面板模式。 |
| `Picker` | `DatePickerType` | 选择器类型。 |
| `Placeholder` | `string` | 占位文本。 |
| `PlaceholderColor` | `SKColor` | 占位文本颜色。 |
| `Format` | `string` | 展示日期格式（默认：<c>YYYY-MM-DD</c>）。 |
| `Placement` | `DatePickerPlacement` | 弹层位置。 |
| `SuffixIcon` | `string` | 后缀图标（默认日历图标）。 |
| `PrevIcon` | `string` | 上一个图标。 |
| `NextIcon` | `string` | 下一个图标。 |
| `SuperNextIcon` | `string` | 双向下一页图标（>>）。 |
| `SuperPrevIcon` | `string` | 双向上一页图标（&lt;&lt;）。 |
| `ClearButton` | `UIElement?` | 可选：自定义清除按钮（AllowClear=true 时生效）。 |
| `StartDate` | `DateTime?` |  |
| `EndDate` | `DateTime?` |  |
| `OnChange` | `Action<DateTime?, DateTime?>?` | 值变化回调。 |
| `OnChangeAsync` | `Func<DateTime?, DateTime?, Task>?` | 日期范围变化时触发的异步回调。 |
| `OnOk` | `Action<DateTime?, DateTime?>?` | 点击确定回调。 |
| `OnOkAsync` | `Func<DateTime?, DateTime?, Task>?` | 确认日期范围时触发的异步回调。 |

## 方法

### Update(float)

```csharp
void Update(float deltaTime)
```

每帧更新。弹层打开时实时同步弹层位置。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaTime` | `float` | 帧间隔（秒）。 |

### VerifyCanDispose()

```csharp
void VerifyCanDispose()
```

释放挂载到 Root 的日期范围面板，并解除 UIManager 保存的 outside-click 闭包。
无副作用地验证挂载在 Root 上的日期范围面板子树允许拥有型释放。

### Dispose()

```csharp
void Dispose()
```

## 相关类型

### DatePickerPanelMode

> **类型**：枚举

日期面板显示模式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Time` | - | 时间面板。 |
| `Date` | - | 日期面板。 |
| `Month` | - | 月份面板。 |
| `Year` | - | 年份面板。 |
| `Decade` | - | 十年面板。 |

### DatePickerPlacement

> **类型**：枚举

弹层位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `BottomLeft` | - | 左下。 |
| `BottomRight` | - | 右下。 |
| `TopLeft` | - | 左上。 |
| `TopRight` | - | 右上。 |

### DatePickerType

> **类型**：枚举

日期选择器类型。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Date` | - | 按日选择。 |
| `Week` | - | 按周选择。 |
| `Month` | - | 按月选择。 |
| `Quarter` | - | 按季度选择。 |
| `Year` | - | 按年选择。 |
