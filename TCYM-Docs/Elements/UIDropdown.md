# UIDropdown

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, IDisposable, IUIElementDisposalPreflight`

## 概述

下拉菜单组件

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `DropdownStyle` | `UIStyle?` | 下拉菜单面板样式。 |
| `IsArrow` | `bool` | 是否显示下拉箭头。 true：渲染一个 45° 旋转的小方块作为箭头； false：不渲染箭头。 |
| `CloseOnContentClick` | `bool` | 点击到内容区域时，是否自动关闭下拉菜单。 |
| `AutoAdjustOverflow` | `bool` | 下拉框被遮挡时是否自动调整位置。 true：当菜单超出窗口边界时，尝试向上翻转或进行边界夹取。 |
| `DestroyOnHidden` | `bool` | 下拉关闭后是否销毁 overlay。 false：仅隐藏（Display=none），下次打开复用； true：移除 overlay 并释放引用，下次打开重新创建。 |
| `MenuWidth` | `float` | 菜单面板默认宽度（像素）。 外部可修改该值以改变下拉菜单宽度。 |
| `MenuHeight` | `float` | 菜单面板默认高度（像素）。 外部可修改该值以改变下拉菜单高度。 |
| `ArrowStyle` | `UIStyle?` | 箭头样式。 默认 白色背景 。 |
| `ArrowOffsetLeft` | `float` | 箭头相对菜单面板左侧的偏移（像素）。 用于控制箭头水平位置。 |
| `ArrowGap` | `float` | 箭头与触发器之间的间隙（像素）。 目的是让菜单面板与 arrow 留出空间，避免 arrow 覆盖在面板内容上。 当前实现通过勾股定理计算 45° 旋转方块的“投影高度”， 从而得到一个近似的间隙值。 |
| `Menu` | `List<UIElement>` | 菜单项列表。 |
| `Open` | `bool` | 控制菜单是否显示。 当值变化时会更新 overlay 显示状态，并触发 OnOpenChange（由调用方/触发源决定）。 |
| `OnOpenChange` | `Action<bool>?` | 菜单显示状态改变时触发。 参数：true=打开，false=关闭。 说明：按照需求约定，某些“由触发器点击导致的关闭”可能不触发（由调用处决定）。 |
| `OnOpenChangeAsync` | `Func<bool, Task>?` | 下拉菜单打开状态变化时触发的异步回调。 |

## 方法

### Update(float)

```csharp
void Update(float deltaTime)
```

每帧更新： - 先执行基类 Update - 检测 open 状态变化并同步 overlay - 打开状态下持续更新菜单位置（在布局变化/窗口变化时保持对齐）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaTime` | `float` |  |

### VerifyCanDispose()

```csharp
void VerifyCanDispose()
```

释放挂载到 Root 的菜单弹层，并解除 UIManager 保存的命中测试闭包。
无副作用地验证挂载在 Root 上的菜单子树允许拥有型释放。

### Dispose()

```csharp
void Dispose()
```
