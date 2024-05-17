using LunitelyOS_Desktop_Environment.Core.Models;

namespace LunitelyOS_Desktop_Environment.Core.Contracts.Services;

// Remove this class once your pages/features are using your data.
public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
}
