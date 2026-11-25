using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication2.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string Greeting { get; set; } = "Welcome to Avalonia!";

    // 自动会生成一个 SayHelloCommand
    [RelayCommand]
    private void SayHello()
    {
        // 这里写你点击“打招呼”后的逻辑
        Greeting = $"你好！我是Zane_Du";
    }

    // 自动会生成一个 ClearCommand
    [RelayCommand]
    private void Clear()
    {
        Greeting = "";
    }
}
