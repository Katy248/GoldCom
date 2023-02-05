using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using GoldCom.Database;
using GoldCom.Models;
using KVVM.ViewModels;

namespace GoldCom.ViewModel;

public class CustomersViewModel : ViewModelWithNavigationBar<NavigationBarViewModel>
{
    private readonly ApplicationDbContext context;

    public CustomersViewModel(NavigationBarViewModel navigationBar, ApplicationDbContext context) : base(navigationBar)
    {
        this.context = context;
    }

    public IEnumerable<Customer> Customers => context.Customers.ToArray();

    public ICommand AddCustomersCommand { get; set; }
    public ICommand DeleteCustomersCommand { get; set; }
    public ICommand EditCustomersCommand { get; set; }
}
