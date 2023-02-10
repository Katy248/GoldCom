using System.Windows.Input;
using GoldCom.Domen.Models;
using GoldCom.MVVM.ViewModels;
using GoldCom.Navigations;
using GoldCom.Services;

namespace GoldCom.ViewModel;
public class NavigationBarViewModel : ViewModelBase
{
    private readonly INavigationService homeNavigation;
    private readonly INavigationService customersNavigation;
    private readonly INavigationService requestsNavigation;
    private readonly INavigationService stockNavigation;
    private readonly INavigationService accountNavigation;
    private readonly IUserManager<User> userManager;

    public NavigationBarViewModel(
		NavigationService<HomeViewModel> homeNavigation, 
		NavigationService<CustomersViewModel> customersNavigation, 
		NavigationService<RequestsViewModel> requestsNavigation,
        NavigationService<StockViewModel> stockNavigation,
        NavigationService<AccountViewModel> accountNavigation,
        IUserManager<User> userManager)
	{
        this.homeNavigation = homeNavigation;
        this.customersNavigation = customersNavigation;
        this.requestsNavigation = requestsNavigation;
        this.stockNavigation = stockNavigation;
        this.accountNavigation = accountNavigation;
        this.userManager = userManager;
        NavigateToHome = new NavigationCommand(homeNavigation);
        NavigateToRequests = new NavigationCommand(requestsNavigation);
        NavigateToCustomers = new NavigationCommand(customersNavigation);
        NavigateToStock = new NavigationCommand(stockNavigation);
        NavigateToStock = new NavigationCommand(accountNavigation);
    }

    public string Username => userManager?.User?.Email ?? "unknown@user";

    public ICommand NavigateToHome { get; set; }
    public ICommand NavigateToCustomers { get; set; }
    public ICommand NavigateToRequests{ get; set; }
    public ICommand NavigateToStock { get; set; }
    public ICommand NavigateToAccount { get; set; }
}
