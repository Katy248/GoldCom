using GoldCom.Navigations;
using GoldCom.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace GoldCom.Extensions;

static class ServiceProviderSetupExtension
{
    public static ServiceProvider Setup(this ServiceProvider provider)
    {
        provider.GetRequiredService<NavigationStore>().CurrentViewModel = provider.GetRequiredService<LoginViewModel>();
        return provider;
    }
}
