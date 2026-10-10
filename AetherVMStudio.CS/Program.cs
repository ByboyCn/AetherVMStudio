using AetherVMStudio.Core;
using AetherVMStudio.UI;
using TCYM.UI.Core;

namespace AetherVMStudio;

public static class Program
{
    public static void Main(string[] args)
    {
        // UIApp.Run(Action<UIApp>):在专用逻辑线程初始化并运行多窗口事件循环(阻塞直到所有窗口关闭)
        var uiapp = new UIApp();
        uiapp.Run(new Action<UIApp>(app =>
        {
            var window = app.CreateWindow(
                title: "AetherVM Studio (C# / TCYM.UI)",
                width: 1280,
                height: 800,
                enableGpu: true,
                targetFps: 60,
                autoShow: true,
                resizable: true);

            var vm = new EmulationViewModel();
            var main = new MainWindow(vm);
            window.Manager.Root.AddChild(main.Build());

            vm.StatusChanged += msg => main.UpdateStatus(msg);

            window.Show();
        }));
    }
}
