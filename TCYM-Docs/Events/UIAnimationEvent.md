# UIAnimationEvent

> **类型**：类　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

CSS 动画事件。时间单位为秒，不包含正向延迟；事件从动画所属元素向父级冒泡。 异步处理器不会阻塞绘制，阻止冒泡须在首次 await 之前调用。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Type` | `UIAnimationEventType` | 当前动画生命周期阶段。 |
| `AnimationName` | `string` | 区分大小写的 @keyframes 名称。 |
| `ElapsedTime` | `double` | 有效播放区间内的经过时间，单位为秒，不受缓动函数影响。 |
| `Target` | `UIElement` | 真正持有动画的元素，冒泡期间不变。 |
| `CurrentTarget` | `UIElement` | 当前正在接收事件的元素；异步回调保存此事件后仍保持稳定。 |
| `Element` | `UIElement` | 兼容其它框架事件的元素访问名称，指向动画所属元素。 |
| `Bubbles` | `bool` | 动画事件可以向父元素冒泡。 |
| `PropagationStopped` | `bool` | 是否已请求停止向祖先冒泡；不会阻止当前元素的其它订阅者。 |

## 方法

### StopPropagation()

```csharp
void StopPropagation()
```

停止当前事件继续向父元素冒泡。
