﻿using System;
using GoldCom.ViewModel;
using KVVM.Navigation;
using Microsoft.Extensions.DependencyInjection;

namespace GoldCom.Extensions;

public static class NavigationServicesExtensions
{
    public static IServiceCollection AddNavigations(this IServiceCollection services)
    {
        return services
            .AddTransient(CreateHomeNavigationService)
            .AddTransient(CreateLoginNavigationService)
            .AddTransient(CreateCustomersNavigationService)
            .AddTransient(CreateCustomerNavigationService)
            .AddTransient(CreateRequestsNavigationService)
            .AddTransient(CreateRequestNavigationService)
            .AddTransient(CreateStockNavigationService)
            .AddTransient(CreateAccountNavigationService);
    }

    public static NavigationService<LoginViewModel> CreateLoginNavigationService(IServiceProvider provider)
    {
        var nav = new NavigationService<LoginViewModel>(
            provider.GetRequiredService<NavigationStore>(), 
            () => provider.GetRequiredService<LoginViewModel>());

        return nav;
    }
    public static NavigationService<HomeViewModel> CreateHomeNavigationService(IServiceProvider provider)
    {
        var nav = new NavigationService<HomeViewModel>(
            provider.GetRequiredService<NavigationStore>(), 
            () => provider.GetRequiredService<HomeViewModel>());

        return nav;
    }
    public static NavigationService<CustomersViewModel> CreateCustomersNavigationService(IServiceProvider provider)
    {
        var nav = new NavigationService<CustomersViewModel>(
            provider.GetRequiredService<NavigationStore>(), 
            () => provider.GetRequiredService<CustomersViewModel>());

        return nav;
    }
    public static NavigationService<CustomerViewModel> CreateCustomerNavigationService(IServiceProvider provider)
    {
        var nav = new NavigationService<CustomerViewModel>(
            provider.GetRequiredService<NavigationStore>(), 
            () => provider.GetRequiredService<CustomerViewModel>());

        return nav;
    }
    public static NavigationService<RequestsViewModel> CreateRequestsNavigationService(IServiceProvider provider)
    {
        var nav = new NavigationService<RequestsViewModel>(
            provider.GetRequiredService<NavigationStore>(), 
            () => provider.GetRequiredService<RequestsViewModel>());

        return nav;
    }
    public static NavigationService<RequestViewModel> CreateRequestNavigationService(IServiceProvider provider)
    {
        var nav = new NavigationService<RequestViewModel>(
            provider.GetRequiredService<NavigationStore>(), 
            () => provider.GetRequiredService<RequestViewModel>());

        return nav;
    }
    public static NavigationService<StockViewModel> CreateStockNavigationService(IServiceProvider provider)
    {
        var nav = new NavigationService<StockViewModel>(
            provider.GetRequiredService<NavigationStore>(), 
            () => provider.GetRequiredService<StockViewModel>());

        return nav;
    }public static NavigationService<AccontViewModel> CreateAccountNavigationService(IServiceProvider provider)
    {
        var nav = new NavigationService<AccontViewModel>(
            provider.GetRequiredService<NavigationStore>(), 
            () => provider.GetRequiredService<AccontViewModel>());

        return nav;
    }
}
