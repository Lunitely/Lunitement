using LunitelyOS_Desktop_Environment.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace LunitelyOS_Desktop_Environment.Views;

public sealed partial class TaskbarMinimizedPage : Page
{
    public TaskbarMinimizedViewModel ViewModel
    {
        get;
    }

    public TaskbarMinimizedPage()
    {
        ViewModel = App.GetService<TaskbarMinimizedViewModel>();
        InitializeComponent();
    }
}
