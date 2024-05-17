using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using LunitelyOS_Desktop_Environment.Contracts.ViewModels;
using LunitelyOS_Desktop_Environment.Core.Contracts.Services;
using LunitelyOS_Desktop_Environment.Core.Models;

namespace LunitelyOS_Desktop_Environment.ViewModels;

public partial class FileExplorerViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    [ObservableProperty]
    private SampleOrder? selected;

    public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

    public FileExplorerViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        SampleItems.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetListDetailsDataAsync();

        foreach (var item in data)
        {
            SampleItems.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }

    public void EnsureItemSelected()
    {
        Selected ??= SampleItems.First();
    }
}
