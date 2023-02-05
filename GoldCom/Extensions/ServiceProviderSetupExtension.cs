using System;
using GoldCom.ViewModel;
using KVVM.Navigation;
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
