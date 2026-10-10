# ChartOptionNode

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

所有 component/series/dataset 配置节点的无反射合并基类。每个 setter 同时记录 presence，
`MergeFrom` 只应用来源中显式出现的字段，兼容 NativeAOT 且区分“未提供”与“显式 null”。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Id` | 获取或设置用户业务 ID；显式赋空同样参与后续合并。 |
| `MainType` | 获取节点参与顶层合并与注册表匹配的主类型。 |
| `Name` | 获取或设置显示名称；也可作为节点匹配的次级依据。 |
| `Show` | 获取或设置是否显示；为空表示本补丁未指定或交由默认值决定。 |
| `Silent` | 获取或设置是否忽略交互事件。 |
| `SubType` | 获取 `MainType` 下的具体子类型。系列使用 `line`、`bar` 等值；<br />多数组件不需要子类型。 |
| `Z` | 获取或设置同一画布层内的绘制顺序。 |
| `ZLevel` | 获取或设置独立画布层级。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。

### `MergeFrom(TCYM.UI.Chart.Model.ChartOptionNode)`

将来源补丁合并到当前节点。仅来源 presence 中出现的字段会覆盖；主类型、子类型和 CLR 类型
必须完全兼容。

| 参数 | 说明 |
| --- | --- |
| `source` | 同类型来源补丁。 |
