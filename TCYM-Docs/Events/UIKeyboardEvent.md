# UIKeyboardEvent

> **类型**：类　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

键盘事件

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Type` | `UIKeyboardEventType` | 事件类型（KeyDown、KeyUp） |
| `KeyCode` | `int` | 按键的 SDL Scancode 或虚拟键值 |
| `Element` | `UIElement?` | 当前目标元素。 |
| `Text` | `string?` | 输入字符（仅在 TextInput 时有效） 优先返回构造时提供的文本（用于 SDL_TEXTINPUT），否则根据 KeyCode 计算简单 ASCII 字符。 |
| `Modifiers` | `UIKeyModifiers` | 修饰键状态（Shift、Ctrl、Alt等） |
| `IsRepeat` | `bool` | 是否为自动重复（长按） |
| `IsComposition` | `bool` | 是否处于输入法合成状态 |
| `Composition` | `string?` | 合成中的文本 |
| `CompositionCursor` | `int` | 合成光标位置 |
| `CompositionSelectionLength` | `int` | 合成选中长度 |
| `Handled` | `bool` | 是否已被处理（消费）。默认 false。 框架在一次派发中会把<b>同一个事件实例</b>依次传给所有全局订阅者 （<see cref="UIElement"/> 的键盘回调以及 OnAnyKeyboardEvent），因此先处理的 订阅者可将其置为 true，后续订阅者据此 <c>if (e.Handled) return;</c> 跳过， 从而避免同一按键被多个组件重复响应（例如同一快捷键被两个工具同时处理）。 与 <see cref="UIPointerEvent.Handled"/> 语义一致：由业务代码读写，框架本身不会 因此自动短路派发（仍会把事件继续派发给焦点元素，是否忽略由各订阅者自行判断）。 |
| `Tag` | `object?` | 自定义标识（默认 null）。业务可在某个订阅回调中写入任意标记，并在<b>同一次派发</b> 的后续回调中读取，用于在多个订阅者之间传递自定义信息（如来源/处理者标识等）。 注意：事件实例不跨派发复用，每次按键都是新实例，因此该值不会跨按键残留。 |
| `IsTextInput` | `bool` | 是否为“文本输入”事件（来自 SDL_TEXTINPUT，由输入法/键盘布局产出的已成形字符）， 而非物理按键的 KeyDown。默认 false。 <para> 背景：按下可打印字符键（如字母）时，SDL 会先后产生 <c>SDL_KEYDOWN</c> 与 <c>SDL_TEXTINPUT</c> 两个事件，框架都会派发为 <see cref="UIKeyboardEventType.KeyDown"/>， 且两者的 <see cref="Text"/> 相同（KeyDown 由 KeyCode 计算、TextInput 来自文本载荷）， 这会导致以 <c>e.Text</c> 判断的快捷键被触发两次。由于是两次独立派发、两个不同的 事件实例，<see cref="Handled"/> 无法跨这两次传递（第二次仍为 false）。 </para> <para> 用法：快捷键 / 物理按键逻辑应忽略文本输入事件，在回调开头加 <c>if (e.IsTextInput) return;</c>（等价于 <c>if (e.KeyCode == 0) return;</c>）即可只触发一次； 文本框等需要接收输入字符的组件则应处理 <c>IsTextInput == true</c> 的事件。 </para> |
| `modifiers` | `UIKeyboardEvent(             UIKeyboardEventType type,             int keyCode,             UIKeyModifiers` | 构造函数：创建一个新的 UIKeyboardEvent 实例。 |

## 方法

### ToString()

```csharp
string ToString()
```

重写 ToString() 以便调试输出事件信息

**返回：** 事件信息的字符串表示
