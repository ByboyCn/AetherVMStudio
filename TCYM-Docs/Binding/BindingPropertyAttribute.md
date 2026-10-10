# BindingPropertyAttribute

> **类型**：类　**分类**：Binding　**框架版本**：`0.1.1.24`

**继承 / 实现**：`Attribute`

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `DefaultMode` | `BindingMode` | 目标属性的默认绑定模式。 |
| `UpdateSourceTrigger` | `BindingUpdateSourceTrigger` | 目标属性的默认源更新触发器。 |
| `SetterMethod` | `string?` | 可选的目标写入方法名。用于必须通过 SetValue/SetChecked 等方法维护副作用的属性。 方法签名必须接受一个属性值参数。 |
| `Invalidation` | `BindingInvalidation` | Binding 写入目标属性后需要执行的界面失效策略。 |
| `SupportsTargetNotifications` | `bool` | 控件是否会在用户操作改变该属性时调用 NotifyBindableValueChanged。 TwoWay 和 OneWayToSource 默认模式会被 Generator 自动视为支持通知。 |
