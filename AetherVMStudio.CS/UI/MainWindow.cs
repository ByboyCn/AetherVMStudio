using AetherVMStudio.Core;
using SkiaSharp;
using TCYM.UI.Core;
using TCYM.UI.Elements;
using TCYM.UI.Elements.Input;

namespace AetherVMStudio.UI;

/// <summary>
/// 用 TCYM.UI 组件树搭建主界面(CSS flex 布局)。
/// 结构:
///   ┌──────────────────────────────────────────────┐
///   │ 顶栏:架构切换 / 运行 / 单步 / 重置 / 状态      │
///   ├──────────────┬───────────────────────────────┤
///   │ 左栏          │ 寄存器面板                     │
///   │  · 文件路径    ├───────────────────────────────┤
///   │  · 代码编辑    │ Trace / 寄存器趋势图 / 内存     │
///   │  · 初始寄存器  │                               │
///   │  · 事件开关    │                               │
///   └──────────────┴───────────────────────────────┘
/// </summary>
public sealed class MainWindow
{
    private readonly EmulationViewModel _vm;

    private UILabel _statusLabel = null!;
    private UIButton _archArmButton = null!;
    private UIButton _archX86Button = null!;
    private UILabel _registerLabel = null!;
    private UILabel _traceLabel = null!;
    private UILabel _memoryLabel = null!;
    private UILabel _consoleLabel = null!;

    public MainWindow(EmulationViewModel vm)
    {
        _vm = vm;
        _vm.StateChanged += () => RefreshDynamicViews();
    }

    public void UpdateStatus(string msg)
    {
        _statusLabel.Text = msg;
        _statusLabel.Style!.Color = msg.StartsWith("❌") ? SKColor.Parse("#e5484d") : SKColor.Parse("#3fb950");
    }

    public UIView Build()
    {
        var root = new UIView();
        var s = root.Style ??= new DefaultUIStyle();
        s.Display = "flex";
        s.FlexDirection = "column";
        s.Width = UnitValue.FromPercent(100f);
        s.Height = UnitValue.FromPercent(100f);
        s.BackgroundColor = SKColor.Parse("#161b22");
        s.PaddingTop = 8;
        s.PaddingLeft = 8;
        s.PaddingRight = 8;
        s.PaddingBottom = 8;

        root.AddChild(BuildTopBar());
        root.AddChild(BuildBody());
        root.AddChild(BuildStatusBar());
        return root;
    }

    // ============ 顶栏 ============

    private UIView BuildTopBar()
    {
        var bar = Panel("row");
        bar.Style!.Height = 46;
        bar.Style.AlignItems = "center";
        bar.Style.PaddingBottom = 8;

        var title = new UILabel
        {
            Text = "⚡ AetherVM Studio",
        };
        var ts = title.Style ??= new DefaultUIStyle();
        ts.FontSize = 18;
        ts.Color = SKColor.Parse("#e6edf3");
        ts.MarginRight = 24;
        bar.AddChild(title);

        _archArmButton = ArchButton("ARM64", GuestArch.Arm64);
        _archX86Button = ArchButton("x86_64", GuestArch.X86_64);
        bar.AddChild(_archArmButton);
        bar.AddChild(_archX86Button);

        bar.AddChild(Spacer());

        bar.AddChild(ActionButton("▶ 运行", "#238636", () => _vm.Run()));
        bar.AddChild(ActionButton("⏭ 单步", "#1f6feb", () => _vm.Step()));
        bar.AddChild(ActionButton("↺ 重置", "#6e7681", () => _vm.Reset()));
        return bar;
    }

    private UIButton ArchButton(string text, GuestArch arch)
    {
        var btn = new UIButton { Text = text };
        btn.OnClick += _ =>
        {
            _vm.Arch = arch;
            UpdateArchButtons();
            _vm.Load();
        };
        UpdateArchButtonStyle(btn, _vm.Arch == arch);
        return btn;
    }

    private void UpdateArchButtons()
    {
        UpdateArchButtonStyle(_archArmButton, _vm.Arch == GuestArch.Arm64);
        UpdateArchButtonStyle(_archX86Button, _vm.Arch == GuestArch.X86_64);
    }

    private static void UpdateArchButtonStyle(UIButton btn, bool active)
    {
        var st = btn.Style ??= new DefaultUIStyle();
        st.BackgroundColor = SKColor.Parse(active ? "#1f6feb" : "#21262d");
        st.Color = SKColor.Parse(active ? "#ffffff" : "#8b949e");
        st.BorderRadius = 6;
        st.BorderWidth = 1;
        st.BorderColor = SKColor.Parse("#30363d");
        st.PaddingTop = 6;
        st.PaddingBottom = 6;
        st.PaddingLeft = 14;
        st.PaddingRight = 14;
        st.MarginRight = 6;
        st.FontSize = 13;
    }

    // ============ 主体 ============

    private UIView BuildBody()
    {
        var body = Panel("row");
        body.Style!.FlexGrow = 1;
        body.Style.Overflow = "hidden";

        body.AddChild(BuildLeftPanel());
        body.AddChild(BuildRightPanel());
        return body;
    }

    private UIView BuildLeftPanel()
    {
        var left = Panel("column");
        left.Style!.Width = 400;
        left.Style.MarginRight = 8;

        left.AddChild(CardTitle("代码 (Shellcode)"));

        // 文件路径行
        var fileRow = Panel("row");
        fileRow.Style!.MarginBottom = 6;
        var pathInput = new UIInput { Text = _vm.FilePathText, Placeholder = "输入 .bin 文件路径…" };
        var ps = pathInput.Style ??= new DefaultUIStyle();
        ps.FlexGrow = 1;
        ps.FontSize = 12;
        pathInput.OnValuesChange += t => _vm.FilePathText = t;
        fileRow.AddChild(pathInput);
        fileRow.AddChild(ActionButton("加载文件", "#30363d", () =>
        {
            if (!string.IsNullOrWhiteSpace(_vm.FilePathText)) _vm.LoadFile(_vm.FilePathText.Trim());
        }));
        left.AddChild(fileRow);

        // 代码编辑区
        var codeArea = new UITextArea
        {
            Text = _vm.CodeText,
            Placeholder = "粘贴十六进制字节流,如:1f 20 03 d5",
            Rows = 8,
        };
        codeArea.OnValuesChange += t => _vm.CodeText = t;
        ApplyEditorStyle(codeArea);
        left.AddChild(codeArea);

        left.AddChild(CardTitle("初始寄存器 (每行: 名 = hex值)"));
        var regInput = new UITextArea
        {
            Text = _vm.InitialRegisterText,
            Rows = 3,
        };
        regInput.OnValuesChange += t => _vm.InitialRegisterText = t;
        ApplyEditorStyle(regInput);
        left.AddChild(regInput);

        left.AddChild(CardTitle("事件 / 插桩 (EventConfig)"));
        var eventPanel = Panel("row");
        eventPanel.Style!.FlexWrap = "wrap";
        foreach (var (flag, name) in EventConfigNames.All)
        {
            var chip = EventChipTracked(flag, name);
            eventPanel.AddChild(chip);
        }
        left.AddChild(eventPanel);

        left.AddChild(CardTitle("控制台"));
        _consoleLabel = MonospaceLabel("");
        _consoleLabel.Style!.FlexGrow = 1;
        _consoleLabel.Style.OverflowY = "auto";
        left.AddChild(_consoleLabel);

        return left;
    }

    private UIView EventChip(EventConfig flag, string name)
    {
        var active = _vm.Events.HasFlag(flag);
        var chip = new UILabel { Text = name };
        var st = chip.Style ??= new DefaultUIStyle();
        st.BackgroundColor = SKColor.Parse(active ? "#1f6feb" : "#21262d");
        st.Color = SKColor.Parse(active ? "#ffffff" : "#8b949e");
        st.BorderRadius = 10;
        st.PaddingTop = 3;
        st.PaddingBottom = 3;
        st.PaddingLeft = 10;
        st.PaddingRight = 10;
        st.MarginRight = 6;
        st.MarginBottom = 6;
        st.FontSize = 11;
        chip.OnClick += _ =>
        {
            if (_vm.Events.HasFlag(flag)) _vm.Events &= ~flag;
            else _vm.Events |= flag;
            UpdateEventChips();
        };
        return chip;
    }

    private readonly List<(UILabel Label, EventConfig Flag)> _eventChips = new();

    private UIView EventChipTracked(EventConfig flag, string name)
    {
        var chip = EventChip(flag, name);
        _eventChips.Add(((UILabel)chip, flag));
        return chip;
    }

    private void UpdateEventChips()
    {
        foreach (var (label, flag) in _eventChips)
        {
            var active = _vm.Events.HasFlag(flag);
            var st = label.Style!;
            st.BackgroundColor = SKColor.Parse(active ? "#1f6feb" : "#21262d");
            st.Color = SKColor.Parse(active ? "#ffffff" : "#8b949e");
        }
    }

    private UIView BuildRightPanel()
    {
        var right = Panel("column");
        right.Style!.FlexGrow = 1;

        // 寄存器面板
        right.AddChild(CardTitle("寄存器"));
        _registerLabel = MonospaceLabel(_vm.FormatRegisters());
        var regContainer = ScrollPanel(220);
        regContainer.AddChild(_registerLabel);
        right.AddChild(regContainer);

        // Trace 面板
        right.AddChild(CardTitle("执行 Trace"));
        _traceLabel = MonospaceLabel("");
        var traceContainer = ScrollPanel(260);
        traceContainer.AddChild(_traceLabel);
        right.AddChild(traceContainer);

        // 内存查看
        var memRow = Panel("row");
        memRow.Style!.AlignItems = "center";
        memRow.Style.MarginTop = 4;
        memRow.AddChild(CardTitle("内存"));
        var addrInput = new UIInput { Text = "0x100000", Placeholder = "地址 (hex)" };
        var asx = addrInput.Style ??= new DefaultUIStyle();
        asx.Width = 200;
        asx.FontSize = 12;
        asx.MarginLeft = 8;
        memRow.AddChild(addrInput);
        memRow.AddChild(ActionButton("读取", "#1f6feb", () =>
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
        memRow.AddChild(Spacer());
        right.AddChild(memRow);

        _memoryLabel = MonospaceLabel("输入地址后点「读取」查看 256 字节");
        var memContainer = ScrollPanel(160);
        memContainer.AddChild(_memoryLabel);
        right.AddChild(memContainer);

        return right;
    }

    // ============ 状态栏 ============

    private UIView BuildStatusBar()
    {
        var bar = Panel("row");
        bar.Style!.Height = 34;
        bar.Style.AlignItems = "center";
        bar.Style.MarginTop = 6;
        bar.Style.BackgroundColor = SKColor.Parse("#0d1117");
        bar.Style.BorderRadius = 6;
        bar.Style.PaddingLeft = 12;
        bar.Style.PaddingRight = 12;

        _statusLabel = new UILabel { Text = _vm.StatusMessage };
        var st = _statusLabel.Style ??= new DefaultUIStyle();
        st.FontSize = 12;
        st.Color = SKColor.Parse("#3fb950");
        bar.AddChild(_statusLabel);
        return bar;
    }

    // ============ 构建辅助 ============

    private static UIView Panel(string direction)
    {
        var view = new UIView();
        var st = view.Style ??= new DefaultUIStyle();
        st.Display = "flex";
        st.FlexDirection = direction;
        return view;
    }

    private static UIView ScrollPanel(float height)
    {
        var view = Panel("column");
        var st = view.Style!;
        st.Height = height;
        st.OverflowY = "auto";
        st.BackgroundColor = SKColor.Parse("#0d1117");
        st.BorderRadius = 6;
        st.BorderWidth = 1;
        st.BorderColor = SKColor.Parse("#30363d");
        st.PaddingTop = 8;
        st.PaddingBottom = 8;
        st.PaddingLeft = 10;
        st.PaddingRight = 10;
        st.MarginBottom = 8;
        return view;
    }

    private static UILabel CardTitle(string text)
    {
        var label = new UILabel { Text = text };
        var st = label.Style ??= new DefaultUIStyle();
        st.FontSize = 13;
        st.Color = SKColor.Parse("#58a6ff");
        st.MarginBottom = 6;
        st.MarginTop = 4;
        return label;
    }

    private static UILabel MonospaceLabel(string text)
    {
        var label = new UILabel { Text = text, Wrap = true };
        var st = label.Style ??= new DefaultUIStyle();
        st.FontSize = 12;
        st.Color = SKColor.Parse("#c9d1d9");
        return label;
    }

    private static void ApplyEditorStyle(UITextArea area)
    {
        var st = area.Style ??= new DefaultUIStyle();
        st.MarginBottom = 8;
        area.InputBackground = SKColor.Parse("#0d1117");
        area.InputTextColor = SKColor.Parse("#c9d1d9");
        area.InputBorderColor = SKColor.Parse("#30363d");
        area.InputFocusBorderColor = SKColor.Parse("#1f6feb");
        area.CursorColor = SKColor.Parse("#58a6ff");
    }

    private static UIButton ActionButton(string text, string color, Action onClick)
    {
        var btn = new UIButton { Text = text };
        var st = btn.Style ??= new DefaultUIStyle();
        st.BackgroundColor = SKColor.Parse(color);
        st.Color = SKColor.Parse("#ffffff");
        st.BorderRadius = 6;
        st.PaddingTop = 6;
        st.PaddingBottom = 6;
        st.PaddingLeft = 14;
        st.PaddingRight = 14;
        st.MarginRight = 6;
        st.FontSize = 13;
        btn.OnClick += _ => onClick();
        return btn;
    }

    private static UIView Spacer()
    {
        var view = new UIView();
        var st = view.Style ??= new DefaultUIStyle();
        st.FlexGrow = 1;
        return view;
    }

    // ============ 动态刷新 ============

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
