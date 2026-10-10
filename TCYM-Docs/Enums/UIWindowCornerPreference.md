# UIWindowCornerPreference

> **类型**：枚举　**分类**：Enums　**框架版本**：`0.1.1.24`

## 概述

指定原生窗口的圆角偏好。

## 说明

Windows 11 Build 22000 及更高版本通过 DWM 应用偏好；Windows 10 使用窗口 Region， 外阴影可通过 <see cref="UIWindowShadowPreference"/> 独立配置。不支持的平台保留默认外观。

## 枚举值

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Default` | 0 | 由操作系统决定是否以及如何绘制圆角。 |
| `DoNotRound` | 1 | 请求操作系统保持直角。 |
| `Round` | 2 | 请求操作系统使用标准窗口圆角。 |
| `RoundSmall` | 3 | 请求操作系统使用较小的窗口圆角。 |
