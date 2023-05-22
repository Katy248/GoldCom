using System.Windows.Input;
using GoldCom.Domain.Models;
using GoldCom.MVVM.ViewModels;
using GoldCom.Navigations;
using GoldCom.Services;
using GoldCom.Views;

namespace GoldCom.ViewModel;
public class NavigationBarViewModel : ViewModelBase
{
    private readonly INavigationService _homeNavigation;
    private readonly INavigationService _customersNavigation;
    private readonly INavigationService _requestsNavigation;
    private readonly INavigationService _stockNavigation;
    private readonly INavigationService _accountNavigation;
    private readonly IUserManager<User> _userManager;

    public NavigationBarViewModel(
		NavigationServiceFactory navigation,
        IUserManager<User> userManager)
	{
        _homeNavigation = navigation.GetNavigationService<HomeViewModel>();
        _customersNavigation = navigation.GetNavigationService<CustomersViewModel>();
        _requestsNavigation = navigation.GetNavigationService<RequestsViewModel>();
        _stockNavigation = navigation.GetNavigationService<StockViewModel>();
        _accountNavigation = navigation.GetNavigationService<AccountViewModel>();
        _userManager = userManager;
        NavigateToHome = new NavigationCommand(_homeNavigation);
        NavigateToRequests = new NavigationCommand(_requestsNavigation);
        NavigateToCustomers = new NavigationCommand(_customersNavigation);
        NavigateToStock = new NavigationCommand(_stockNavigation);
        NavigateToAccount = new NavigationCommand(_accountNavigation);
    }

    public string Username => _userManager?.User?.Email ?? "unknown@user";

    public ICommand NavigateToHome { get; set; }
    public ICommand NavigateToCustomers { get; set; }
    public ICommand NavigateToRequests{ get; set; }
    public ICommand NavigateToStock { get; set; }
    public ICommand NavigateToAccount { get; set; }
}
