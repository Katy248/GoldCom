using GoldCom.MVVM.ViewModels;
using GoldCom.Navigations;
using Microsoft.Extensions.DependencyInjection;

namespace GoldCom.Navigations;
public class NavigationServiceFactory
{
    private readonly IServiceProvider _provider;

    public NavigationServiceFactory(IServiceProvider provider)
    {
        _provider = provider;
    }
    public NavigationService<TViewModel> GetNavigationService<TViewModel>() where TViewModel : ViewModelBase
    {
        return new NavigationService<TViewModel>(_provider.GetRequiredService<NavigationStore>(), () => _provider.GetRequiredService<TViewModel>());
    }
}