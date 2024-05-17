using CommunityToolkit.WinUI.UI.Controls;

using LunitelyOS_Desktop_Environment.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace LunitelyOS_Desktop_Environment.Views;

public sealed partial class FileExplorerPage : Page
{
    public FileExplorerViewModel ViewModel
    {
        get;
    }

    public FileExplorerPage()
    {
        ViewModel = App.GetService<FileExplorerViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
