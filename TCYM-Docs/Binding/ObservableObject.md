# ObservableObject

> **类型**：类　**分类**：Binding　**框架版本**：`0.1.1.24`

**继承 / 实现**：`INotifyPropertyChangedEx`

## 概述

可观察对象基类，提供属性变更通知的实现。 继承自 INotifyPropertyChangedEx，方便子类在属性变化时通知绑定系统。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `PropertyChanged` | `event PropertyChangedEventHandler?` | 属性变更事件，订阅该事件以在属性值变化时接收通知。 |

## 方法

### RaisePropertyChanged(string)

```csharp
void RaisePropertyChanged(string propertyName = "")
```

触发 PropertyChanged 事件，通知绑定系统指定属性已更改。 可由子类在需要时手动调用以强制刷新绑定。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `propertyName` | `string` | 已更改的属性名称（由编译器自动填充） |
