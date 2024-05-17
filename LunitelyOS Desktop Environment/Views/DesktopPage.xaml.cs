using LunitelyOS_Desktop_Environment.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace LunitelyOS_Desktop_Environment.Views;

public sealed partial class DesktopPage : Page
{
    public DesktopViewModel ViewModel
    {
        get;
    }

    public DesktopPage()
    {
        ViewModel = App.GetService<DesktopViewModel>();
        InitializeComponent();
    }
}
