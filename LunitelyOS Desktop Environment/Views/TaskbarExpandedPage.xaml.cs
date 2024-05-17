using LunitelyOS_Desktop_Environment.ViewModels;

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace LunitelyOS_Desktop_Environment.Views;

public sealed partial class TaskbarExpandedPage : Page
{
    public TaskbarExpandedViewModel ViewModel
    {
        get;
    }

    public TaskbarExpandedPage()
    {
        ViewModel = App.GetService<TaskbarExpandedViewModel>();
        InitializeComponent();
        ContentFrame.Navigate(typeof(SettingsPage), null, new EntranceNavigationTransitionInfo());
    }
}
