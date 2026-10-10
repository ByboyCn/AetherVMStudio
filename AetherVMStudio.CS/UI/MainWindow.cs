using AetherVMStudio.Core;
using SkiaSharp;
using TCYM.UI.Core;
using TCYM.UI.Elements;
using TCYM.UI.Elements.Input;

namespace AetherVMStudio.UI;

/// <summary>
/// 用 TCYM.UI 组件树搭建主界面(日间/夜间/自动主题)。
/// 注意:样式对象必须先完整构建再一次性赋给 element.Style(setter 赋值时快照合并)。
/// </summary>
public sealed class MainWindow
{
    private readonly EmulationViewModel _vm;
    private readonly UIWindow _window;

    private ThemeMode _mode = ThemeMode.Auto;
    private AppTheme T => AppTheme.Resolve(_mode);

    private UILabel _statusLabel = null!;
    private UIButton _archArmButton = null!;
    private UIButton _archX86Button = null!;
    private UIButton _themeButton = null!;
    private UILabel _registerLabel = null!;
    private UILabel _traceLabel = null!;
    private UILabel _memoryLabel = null!;
    private UILabel _consoleLabel = null!;
    private readonly List<(UILabel Label, EventConfig Flag)> _eventChips = new();

    public MainWindow(EmulationViewModel vm, UIWindow window)
    {
        _vm = vm;
        _window = window;
        _vm.StateChanged += RefreshDynamicViews;
    }

    public void UpdateStatus(string msg) => _statusLabel.Text = msg;

    // ============ 主题 ============

    private string ThemeButtonLabel => _mode switch
    {
        ThemeMode.Light => "☀ 日间",
        ThemeMode.Dark => "🌙 夜间",
        _ => AppTheme.Resolve(ThemeMode.Auto).Name == "夜间" ? "🌓 自动·夜" : "🌓 自动·日",
    };

    private void CycleTheme()
    {
        _mode = _mode switch
        {
            ThemeMode.Auto => ThemeMode.Light,
            ThemeMode.Light => ThemeMode.Dark,
            _ => ThemeMode.Auto,
        };
        Rebuild();
    }

    /// <summary>主题切换后整棵 UI 树重建。</summary>
    private void Rebuild()
    {
        var root = _window.Manager.Root;
        root.Children.Clear();
        _eventChips.Clear();
        root.AddChild(Build());
        RefreshDynamicViews();
        _statusLabel.Text = _vm.StatusMessage;
    }

    // ============ 样式构建辅助 ============

    private DefaultUIStyle Flex(string direction, string? align = null) => new()
    {
        Display = "flex",
        FlexDirection = direction,
        AlignItems = align ?? "stretch",
    };

    private UIView Panel(DefaultUIStyle style) => new() { Style = style };

    private UILabel Title(string text) => new()
    {
        Text = text,
        Style = new DefaultUIStyle
        {
            FontSize = 13,
            Color = T.TitleColor,
            MarginTop = 6,
            MarginBottom = 6,
        },
    };

    private UILabel Mono(string text, float size = 12) => new()
    {
        Text = text,
        Wrap = true,
        Style = new DefaultUIStyle
        {
            FontSize = size,
            Color = T.TextSecondary,
        },
    };

    private UIScrollView ScrollBox(float height)
    {
        var box = new UIScrollView
        {
            Style = new DefaultUIStyle
            {
                Display = "flex",
                FlexDirection = "column",
                Height = height,
                BackgroundColor = T.BoxBg,
                BorderRadius = 6,
                BorderWidth = 1,
                BorderColor = T.Border,
                PaddingTop = 8, PaddingBottom = 8, PaddingLeft = 10, PaddingRight = 10,
                MarginBottom = 8,
            },
        };
        return box;
    }

    /// <summary>把长文本放进 ScrollView 内部的纵向容器,保证逐行排列且可滚动。</summary>
    private UIView ScrollContent(UILabel content)
    {
        var inner = Panel(Flex("column"));
        inner.AddChild(content);
        return inner;
    }

    private UIButton TextButton(string text, string bg, string fg, Action onClick)
    {
        var btn = new UIButton
        {
            Text = text,
            Style = new DefaultUIStyle
            {
                BackgroundColor = SKColor.Parse(bg),
                Color = SKColor.Parse(fg),
                BorderRadius = 6,
                PaddingTop = 6, PaddingBottom = 6, PaddingLeft = 14, PaddingRight = 14,
                MarginRight = 6,
                FontSize = 13,
            },
        };
        btn.OnClick += _ => onClick();
        return btn;
    }

    private UITextArea MakeEditor(string text, string placeholder, int rows, float height, Action<string> onChange) =>
        new()
        {
            Text = text,
            Placeholder = placeholder,
            Rows = rows,
            Style = new DefaultUIStyle { MarginBottom = 8, Height = height },
            InputBackground = T.InputBg,
            InputTextColor = T.TextSecondary,
            InputBorderColor = T.InputBorder,
            InputFocusBorderColor = T.InputFocusBorder,
            CursorColor = T.Accent,
        };

    // ============ 主结构 ============

    public UIView Build()
    {
        var rootStyle = Flex("column");
        rootStyle.Width = UnitValue.FromPercent(100f);
        rootStyle.Height = UnitValue.FromPercent(100f);
        rootStyle.BackgroundColor = T.WindowBg;
        rootStyle.PaddingTop = 10; rootStyle.PaddingLeft = 10;
        rootStyle.PaddingRight = 10; rootStyle.PaddingBottom = 8;

        var root = Panel(rootStyle);
        root.AddChild(BuildTopBar());
        root.AddChild(BuildBody());
        root.AddChild(BuildStatusBar());
        return root;
    }

    private UIView BuildTopBar()
    {
        var barStyle = Flex("row", "center");
        barStyle.Height = 48;
        barStyle.PaddingBottom = 8;

        var bar = Panel(barStyle);
        bar.AddChild(new UILabel
        {
            Text = "⚡ AetherVM Studio",
            Style = new DefaultUIStyle
            {
                FontSize = 18,
                Color = T.TextPrimary,
                MarginRight = 24,
            },
        });

        _archArmButton = ArchButton("ARM64", GuestArch.Arm64);
        _archX86Button = ArchButton("x86_64", GuestArch.X86_64);
        bar.AddChild(_archArmButton);
        bar.AddChild(_archX86Button);

        bar.AddChild(Panel(new DefaultUIStyle { FlexGrow = 1 }));

        bar.AddChild(TextButton("▶ 运行", "#238636", "#ffffff", () => _vm.Run()));
        bar.AddChild(TextButton("⏭ 单步", SKColorToHex(T.Accent), "#ffffff", () => _vm.Step()));
        bar.AddChild(TextButton("↺ 重置", SKColorToHex(T.Border), SKColorToHex(T.TextSecondary), () => _vm.Reset()));

        _themeButton = TextButton(ThemeButtonLabel, SKColorToHex(T.PanelBg), SKColorToHex(T.TextPrimary), CycleTheme);
        _themeButton.Style = new DefaultUIStyle
        {
            BackgroundColor = T.PanelBg,
            Color = T.TextPrimary,
            BorderRadius = 6,
            BorderWidth = 1,
            BorderColor = T.Border,
            PaddingTop = 6, PaddingBottom = 6, PaddingLeft = 14, PaddingRight = 14,
            FontSize = 13,
        };
        _themeButton.OnClick += _ => CycleTheme();
        bar.AddChild(_themeButton);
        return bar;
    }

    private static string SKColorToHex(SKColor c) => $"#{c.Red:X2}{c.Green:X2}{c.Blue:X2}";

    private UIButton ArchButton(string text, GuestArch arch)
    {
        var btn = new UIButton { Text = text };
        btn.OnClick += _ =>
        {
            _vm.Arch = arch;
            UpdateArchButtons();
            _vm.Load();
        };
        ApplyArchStyle(btn, _vm.Arch == arch);
        return btn;
    }

    private void ApplyArchStyle(UIButton btn, bool active)
    {
        btn.Style = new DefaultUIStyle
        {
            BackgroundColor = active ? T.Accent : T.PanelBg,
            Color = active ? T.ChipActiveText : T.TextMuted,
            BorderRadius = 6,
            BorderWidth = 1,
            BorderColor = T.Border,
            PaddingTop = 6, PaddingBottom = 6, PaddingLeft = 14, PaddingRight = 14,
            MarginRight = 6,
            FontSize = 13,
        };
    }

    private void UpdateArchButtons()
    {
        ApplyArchStyle(_archArmButton, _vm.Arch == GuestArch.Arm64);
        ApplyArchStyle(_archX86Button, _vm.Arch == GuestArch.X86_64);
    }

    private UIView BuildBody()
    {
        var bodyStyle = Flex("row");
        bodyStyle.FlexGrow = 1;
        bodyStyle.Overflow = "hidden";

        var body = Panel(bodyStyle);
        body.AddChild(BuildLeftPanel());
        body.AddChild(BuildRightPanel());
        return body;
    }

    private UIView BuildLeftPanel()
    {
        var leftStyle = Flex("column");
        leftStyle.Width = 400;
        leftStyle.MarginRight = 8;
        leftStyle.OverflowY = "auto";

        var left = Panel(leftStyle);
        left.AddChild(Title("代码 (Shellcode)"));

        // 文件路径行
        var fileRowStyle = Flex("row", "center");
        fileRowStyle.MarginBottom = 6;
        var fileRow = Panel(fileRowStyle);

        var pathInput = new UIInput
        {
            Text = _vm.FilePathText,
            Placeholder = "输入 .bin 文件路径…",
            Style = new DefaultUIStyle
            {
                FlexGrow = 1,
                FontSize = 12,
                MarginRight = 6,
            },
            InputBackground = T.InputBg,
            InputTextColor = T.TextSecondary,
            InputBorderColor = T.InputBorder,
            InputFocusBorderColor = T.InputFocusBorder,
        };
        pathInput.OnValuesChange += t => _vm.FilePathText = t;
        fileRow.AddChild(pathInput);
        fileRow.AddChild(TextButton("加载文件", SKColorToHex(T.Border), SKColorToHex(T.TextSecondary), () =>
        {
            if (!string.IsNullOrWhiteSpace(_vm.FilePathText)) _vm.LoadFile(_vm.FilePathText.Trim());
        }));
        left.AddChild(fileRow);

        var codeArea = MakeEditor(_vm.CodeText, "粘贴十六进制字节流,如:1f 20 03 d5", 8, 160,
            t => _vm.CodeText = t);
        codeArea.OnValuesChange += t => _vm.CodeText = t;
        left.AddChild(codeArea);

        left.AddChild(Title("初始寄存器 (每行: 名 = hex值)"));
        var regInput = MakeEditor(_vm.InitialRegisterText, "", 3, 90, t => _vm.InitialRegisterText = t);
        regInput.OnValuesChange += t => _vm.InitialRegisterText = t;
        left.AddChild(regInput);

        left.AddChild(Title("事件 / 插桩 (EventConfig)"));
        // 块级布局逐行排列,避免 flex wrap 换行高度计算问题
        var chips = Panel(new DefaultUIStyle { MarginBottom = 10 });
        foreach (var (flag, name) in EventConfigNames.All)
            chips.AddChild(EventChip(flag, name));
        left.AddChild(chips);

        left.AddChild(Title("控制台"));
        var consoleStyle = Flex("column");
        consoleStyle.FlexGrow = 1;
        consoleStyle.BackgroundColor = T.BoxBg;
        consoleStyle.BorderRadius = 6;
        consoleStyle.BorderWidth = 1;
        consoleStyle.BorderColor = T.Border;
        consoleStyle.PaddingTop = 8; consoleStyle.PaddingBottom = 8;
        consoleStyle.PaddingLeft = 10; consoleStyle.PaddingRight = 10;
        var consoleBox = Panel(consoleStyle);
        _consoleLabel = Mono("");
        consoleBox.AddChild(_consoleLabel);
        left.AddChild(consoleBox);

        return left;
    }

    private UIView EventChip(EventConfig flag, string name)
    {
        var active = _vm.Events.HasFlag(flag);
        var chip = new UILabel
        {
            Text = name,
            Style = ChipStyle(active),
        };
        _eventChips.Add((chip, flag));
        chip.OnClick += _ =>
        {
            if (_vm.Events.HasFlag(flag)) _vm.Events &= ~flag;
            else _vm.Events |= flag;
            foreach (var (label, f) in _eventChips)
                label.Style = ChipStyle(_vm.Events.HasFlag(f));
        };
        return chip;
    }

    private DefaultUIStyle ChipStyle(bool active) => new()
    {
        BackgroundColor = active ? T.ChipActiveBg : T.PanelBg,
        Color = active ? T.ChipActiveText : T.TextMuted,
        BorderRadius = 10,
        BorderWidth = 1,
        BorderColor = T.Border,
        PaddingTop = 3, PaddingBottom = 3, PaddingLeft = 10, PaddingRight = 10,
        MarginRight = 6, MarginBottom = 6,
        FontSize = 11,
    };

    private UIView BuildRightPanel()
    {
        var rightStyle = Flex("column");
        rightStyle.FlexGrow = 1;
        var right = Panel(rightStyle);

        right.AddChild(Title("寄存器"));
        _registerLabel = Mono(_vm.FormatRegisters());
        var regBox = ScrollBox(240);
        regBox.AddChild(ScrollContent(_registerLabel));
        right.AddChild(regBox);

        right.AddChild(Title("执行 Trace"));
        _traceLabel = Mono("");
        var traceBox = ScrollBox(200);
        traceBox.AddChild(ScrollContent(_traceLabel));
        right.AddChild(traceBox);

        // 内存查看行
        var memRowStyle = Flex("row", "center");
        memRowStyle.MarginTop = 2;
        var memRow = Panel(memRowStyle);
        memRow.AddChild(Title("内存"));
        var addrInput = new UIInput
        {
            Text = "0x100000",
            Placeholder = "地址 (hex)",
            Style = new DefaultUIStyle
            {
                Width = 200,
                FontSize = 12,
                MarginLeft = 8, MarginRight = 6,
            },
            InputBackground = T.InputBg,
            InputTextColor = T.TextSecondary,
            InputBorderColor = T.InputBorder,
            InputFocusBorderColor = T.InputFocusBorder,
        };
        memRow.AddChild(addrInput);
        memRow.AddChild(TextButton("读取", SKColorToHex(T.Accent), "#ffffff", () =>
        {
            var cleaned = addrInput.Text.Replace("0x", "").Trim();
            if (ulong.TryParse(cleaned, System.Globalization.NumberStyles.HexNumber, null, out var addr))
            {
                var data = _vm.Active.ReadMemory(addr, 256);
                _memoryLabel.Text = data is null
                    ? "❌ 无法读取该地址"
                    : EmulationViewModel.FormatHexDump(data, addr);
            }
        }));
        right.AddChild(memRow);

        _memoryLabel = Mono("输入地址后点「读取」查看 256 字节");
        var memBox = ScrollBox(150);
        memBox.AddChild(ScrollContent(_memoryLabel));
        right.AddChild(memBox);

        return right;
    }

    private UIView BuildStatusBar()
    {
        var barStyle = Flex("row", "center");
        barStyle.Height = 32;
        barStyle.MarginTop = 6;
        barStyle.BackgroundColor = T.BoxBg;
        barStyle.BorderRadius = 6;
        barStyle.PaddingLeft = 12; barStyle.PaddingRight = 12;

        var bar = Panel(barStyle);
        _statusLabel = new UILabel
        {
            Text = _vm.StatusMessage,
            Style = new DefaultUIStyle
            {
                FontSize = 12,
                Color = T.Green,
            },
        };
        bar.AddChild(_statusLabel);
        return bar;
    }

    private void RefreshDynamicViews()
    {
        _registerLabel.Text = _vm.FormatRegisters();
        _traceLabel.Text = _vm.FormatTrace();
        if (_vm.Trace.Count > 0)
        {
            var last = _vm.Trace[^1];
            _consoleLabel.Text += $"[{last.KindTag}] {last.AddressHex}  {last.Text}\n";
        }
        UpdateArchButtons();
    }
}
