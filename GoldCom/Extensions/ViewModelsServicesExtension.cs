﻿using GoldCom.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace GoldCom.Extensions;
public static class ViewModelsServicesExtension
{
    public static IServiceCollection AddViews(this IServiceCollection services)
    {
        return services
            .AddSingleton<MainViewModel>()

            .AddTransient<NavigationBarViewModel>()

            .AddTransient<HomeViewModel>()
            .AddTransient<LoginViewModel>()
            .AddTransient<RequestsViewModel>()
            .AddTransient<RequestViewModel>()
            .AddTransient<CustomersViewModel>()
            .AddTransient<CustomerViewModel>()
            .AddTransient<StockViewModel>()
            .AddTransient<AccountViewModel>();
    }

    /*public static NavigationBarViewModel CreateNavigationBarViewModel(IServiceProvider service)
    {
        var nav = new NavigationBarViewModel(
            NavigationServicesExtensions.CreateHomeNavigationService(service),
            NavigationServicesExtensions.CreateCustomersNavigationService(service),
            NavigationServicesExtensions.CreateRequestsNavigationService(service),
            NavigationServicesExtensions.CreateStockNavigationService(service));

        return nav;
    }
    public static LoginViewModel CreateLoginViewModel(IServiceProvider service)
    {
        var login = new LoginViewModel(
                NavigationServicesExtensions.CreateHomeNavigationService(service),
                service.GetRequiredService<IUserManager<User>>());
        return login;
    }
    public static RequestsViewModel CreateRequestsViewModel(IServiceProvider service)
    {
        var requests = new RequestsViewModel(
            service.GetRequiredService<NavigationBarViewModel>());
            
        return requests;
    }
    public static RequestViewModel CreateRequestViewModel(IServiceProvider service)
    {
        var request = new RequestViewModel(null); //TODO: implement it
        return request;
    }
    *//*public static CustomersViewModel CreateCustomersViewModel(IServiceProvider service)
    {
        var customers = new CustomersViewModel(
            service.GetRequiredService<NavigationBarViewModel>());
        return customers;
    }*//*
    public static CustomerViewModel CreateCustomerViewModel(IServiceProvider service)
    {
        var customer = new CustomerViewModel();
        return customer;
    }
    public static StockViewModel CreateStockViewModel(IServiceProvider service)
    {
        var stock = new StockViewModel(
            service.GetRequiredService<NavigationBarViewModel>());
        return stock;
    }
    public static AccontViewModel CreateAccontViewModel(IServiceProvider service)
    {
        var account = new AccontViewModel();

        return account;
    }*/
}
