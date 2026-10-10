# UIWindowCloseReason

> **类型**：枚举　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

窗口关闭请求的来源，类似 Avalonia 的 <c>WindowCloseReason</c>。

## 枚举值

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `UserClose` | - | 用户通过窗口标题栏关闭按钮、系统菜单或 Alt+F4 请求关闭。 |
| `ApplicationQuit` | - | 操作系统或应用发出的整体退出请求（例如 SDL_QUIT）。 |
| `Programmatic` | - | 由代码主动调用关闭（例如 <c>UISystem.Close()</c> / <c>UIWindow.Close()</c>）。 |
