# ChartRegistryChangedEventArgs

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

提供一次已提交注册表事务的元数据和不可变注册项明细。

## 构造函数

### `ChartRegistryChangedEventArgs(String,Int64,Int32,Collections.Generic.IReadOnlyList{TCYM.UI.Chart.Core.ChartRegistryChangeEntry})`

初始化一条原子模块批次通知；调用方传入集合会立即复制，后续修改不会影响通知。

| 参数 | 说明 |
| --- | --- |
| `moduleKey` | 稳定模块键。 |
| `version` | 本次模块事务提交后的注册表版本。 |
| `mutationThreadId` | 执行模块提交并触发通知的托管线程标识。 |
| `entries` | 模块包含的全部具体注册项。 |

### `ChartRegistryChangedEventArgs(TCYM.UI.Chart.Core.ChartRegistryChangeKind,String,Type,Int64,Int32,Boolean,Object)`

初始化注册表修改事件。

| 参数 | 说明 |
| --- | --- |
| `kind` | 注册项类别。 |
| `key` | 注册项键。 |
| `registrationType` | 新注册对象的运行时类型。 |
| `version` | 此次提交产生的注册表版本。 |
| `mutationThreadId` | 执行提交并同步触发通知的托管线程标识。 |
| `isReplacement` | 此次修改是否替换了同键注册项。 |
| `previousRegistration` | 可用时为被替换的注册对象。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Entries` | 获取本事务包含的不可变注册项明细。普通注册恰好包含一项，模块通知包含整个原子批次。 |
| `IsReplacement` | 获取此次修改是否替换了同键注册项。 |
| `Key` | 获取单项注册键；模块批次通知返回稳定模块键。 |
| `Kind` | 获取事务类别；原子模块提交为 `Module`。 |
| `MutationThreadId` | 获取提交修改并同步触发通知的托管线程标识。 |
| `PreviousRegistration` | 获取可用的旧注册对象。它主要作为生命周期交接令牌：引擎据此只取消被替换 action<br />所拥有的运行时工作，而不使其他处理器失效。新增和模块批次注册时为 `null`。 |
| `RegistrationType` | 获取单项注册对象的运行时类型；模块批次通知返回<br />`ChartModuleRegistration`。 |
| `Version` | 获取本通知代表的已提交注册表版本。 |
