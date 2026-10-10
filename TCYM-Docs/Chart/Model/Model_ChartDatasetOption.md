# ChartDatasetOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示可供一个或多个系列共享的顶层二维 dataset。

## 构造函数

### `ChartDatasetOption`

创建带有惰性 presence 跟踪的空 dataset 选项。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataSource` | 获取或设置通用 Dataset 来源，支持表格、树和关系拓扑。与 Source 共用一个来源；<br />最后一次赋值生效。Source 的既有 ChartDataTable 签名保持不变，非表格来源时 Source 返回 null。 |
| `MainType` | 获取节点参与顶层合并与注册表匹配的主类型。 |
| `Source` | 获取或设置 dataset 来源。读取本身没有副作用；通过默认实例修改维度、数据行或布局时才会记录<br />presence，因此只读检查不会在后续 patch 中意外清空已提交的数据。显式赋 `null`<br />仍会清除先前已提交的数据源。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
