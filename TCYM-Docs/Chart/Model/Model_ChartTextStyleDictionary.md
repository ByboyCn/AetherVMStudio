# ChartTextStyleDictionary

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示使用序号键比较并保留选项补丁操作的富文本样式字典。

## 说明

该类型支持普通字典和只读字典接口，也可直接用于对象初始化器。写入、删除和清空操作会
分别保留 set、remove 和 clear 意图，供标签选项的 presence-aware 合并使用。

作为 `Rich` 或
`Rich` 的值赋入时，选项会深复制字典及其中的
`ChartTextStyle`，之后修改来源字典不会影响选项。

样式实例及其中的画刷会形成隔离快照；`Typeface` 引用仍按
借用资源契约共享，不会被复制或释放。

## 构造函数

### `ChartTextStyleDictionary`

创建使用 `Ordinal` 比较键的空字典。

### `ChartTextStyleDictionary(TCYM.UI.Chart.Model.ChartTrackedDictionary{String,TCYM.UI.Chart.Rendering.ChartTextStyle})`

从已经隔离的跟踪字典创建包装。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取当前样式数量。 |
| `IsReadOnly` | 获取字典是否只读；该类型始终可写。 |
| `Item(String)` | 获取或显式赋值指定名称的富文本样式。 |
| `Keys` | 获取当前样式名称集合。 |
| `Values` | 获取当前样式集合。 |

## 方法

### `Add(Collections.Generic.KeyValuePair{String,TCYM.UI.Chart.Rendering.ChartTextStyle})`

添加一个富文本样式并记录赋值意图。

| 参数 | 说明 |
| --- | --- |
| `item` | 要添加的名称和样式。 |

### `Add(String,TCYM.UI.Chart.Rendering.ChartTextStyle)`

添加一个富文本样式并记录赋值意图。

| 参数 | 说明 |
| --- | --- |
| `key` | 富文本样式名称。 |
| `value` | 富文本样式。 |

### `Clear`

清空当前样式并记录整体清空意图。

### `Contains(Collections.Generic.KeyValuePair{String,TCYM.UI.Chart.Rendering.ChartTextStyle})`

判断字典是否包含指定名称和样式。

| 参数 | 说明 |
| --- | --- |
| `item` | 要查找的名称和样式。 |

**返回：** 名称和值都匹配时返回 `true`。

### `ContainsKey(String)`

判断字典是否包含指定样式名称。

| 参数 | 说明 |
| --- | --- |
| `key` | 要查找的样式名称。 |

**返回：** 包含指定名称时返回 `true`。

### `CopyTo(Collections.Generic.KeyValuePair{String,TCYM.UI.Chart.Rendering.ChartTextStyle}[],Int32)`

从指定下标开始把当前名称和样式复制到数组。

| 参数 | 说明 |
| --- | --- |
| `array` | 目标数组。 |
| `arrayIndex` | 目标起始下标。 |

### `GetEnumerator`

获取当前名称和样式的枚举器。

**返回：** 当前字典枚举器。

### `Remove(Collections.Generic.KeyValuePair{String,TCYM.UI.Chart.Rendering.ChartTextStyle})`

在名称和值都匹配时删除样式并记录删除意图。

| 参数 | 说明 |
| --- | --- |
| `item` | 要删除的名称和样式。 |

**返回：** 找到并删除匹配项时返回 `true`。

### `Remove(String)`

删除指定名称并记录删除意图。

| 参数 | 说明 |
| --- | --- |
| `key` | 要删除的样式名称。 |

**返回：** 调用前存在并成功删除时返回 `true`。

### `TryGetValue(String,TCYM.UI.Chart.Rendering.ChartTextStyle@)`

尝试获取指定名称的样式。

| 参数 | 说明 |
| --- | --- |
| `key` | 要查找的样式名称。 |
| `value` | 成功时返回对应样式。 |

**返回：** 存在指定名称时返回 `true`。
