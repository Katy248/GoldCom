using System.Windows.Input;
using KVVM.Navigation;
using KVVM.ViewModels;

namespace GoldCom.ViewModel; 
public class NavigationBarViewModel : ViewModelBase
{
    private readonly INavigationService homeNavigation;
    private readonly INavigationService customersNavigation;
    private readonly INavigationService requestsNavigation;
    private readonly INavigationService stockNavigation;

    public NavigationBarViewModel(
		NavigationService<HomeViewModel> homeNavigation, 
		NavigationService<CustomersViewModel> customersNavigation, 
		NavigationService<RequestsViewModel> requestsNavigation,
        NavigationService<StockViewModel> stockNavigation)
	{
        this.homeNavigation = homeNavigation;
        this.customersNavigation = customersNavigation;
        this.requestsNavigation = requestsNavigation;
        this.stockNavigation = stockNavigation;

        NavigateToHome = new NavigationCommand(homeNavigation);
        NavigateToRequests = new NavigationCommand(requestsNavigation);
        NavigateToCustomers = new NavigationCommand(customersNavigation);
        NavigateToStock = new NavigationCommand(stockNavigation);
    }


    public ICommand NavigateToHome { get; set; }
    public ICommand NavigateToCustomers { get; set; }
    public ICommand NavigateToRequests{ get; set; }
    public ICommand NavigateToStock { get; set; }
}
