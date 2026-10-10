using System.Runtime.InteropServices;
using SkiaSharp;

namespace AetherVMStudio.UI;

public enum ThemeMode { Auto, Light, Dark }

/// <summary>主题配色。日间/夜间两套,Auto 跟随系统。</summary>
public sealed record AppTheme(
    string Name,
    SKColor WindowBg, SKColor PanelBg, SKColor BoxBg, SKColor Border,
    SKColor TextPrimary, SKColor TextSecondary, SKColor TextMuted,
    SKColor Accent, SKColor Green, SKColor TitleColor,
    SKColor InputBg, SKColor InputBorder, SKColor InputFocusBorder,
    SKColor ChipActiveBg, SKColor ChipActiveText)
{
    public static readonly AppTheme Dark = new(
        "夜间",
        Parse("#161b22"), Parse("#1c2129"), Parse("#0d1117"), Parse("#30363d"),
        Parse("#e6edf3"), Parse("#c9d1d9"), Parse("#8b949e"),
        Parse("#1f6feb"), Parse("#3fb950"), Parse("#58a6ff"),
        Parse("#0d1117"), Parse("#30363d"), Parse("#1f6feb"),
        Parse("#1f6feb"), Parse("#ffffff"));

    public static readonly AppTheme Light = new(
        "日间",
        Parse("#f5f6f8"), Parse("#ffffff"), Parse("#f0f2f5"), Parse("#d0d7de"),
        Parse("#1f2328"), Parse("#424a53"), Parse("#656d76"),
        Parse("#0969da"), Parse("#1a7f37"), Parse("#0969da"),
        Parse("#ffffff"), Parse("#d0d7de"), Parse("#0969da"),
        Parse("#0969da"), Parse("#ffffff"));

    private static SKColor Parse(string hex) => SKColor.Parse(hex);

    public static AppTheme Resolve(ThemeMode mode) => mode switch
    {
        ThemeMode.Light => Light,
        ThemeMode.Dark => Dark,
        _ => DetectSystemTheme() ? Dark : Light,
    };

    /// <summary>跨平台检测系统深色模式;无法判断时返回 false(日间)。</summary>
    public static bool DetectSystemTheme()
    {
        try
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                using var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
                return key?.GetValue("AppsUseLightTheme") is int v && v == 0;
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                var outp = Run("defaults", "read -g AppleInterfaceStyle");
                return outp.Contains("Dark", StringComparison.OrdinalIgnoreCase);
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                var outp = Run("gsettings", "get org.gnome.desktop.interface color-scheme");
                return outp.Contains("dark", StringComparison.OrdinalIgnoreCase);
            }
        }
        catch { /* 检测失败按日间处理 */ }
        return false;
    }

    private static string Run(string file, string args)
    {
        using var p = System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName = file,
            Arguments = args,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
        });
        var text = p?.StandardOutput.ReadToEnd() ?? "";
        p?.WaitForExit(2000);
        return text;
    }
}
