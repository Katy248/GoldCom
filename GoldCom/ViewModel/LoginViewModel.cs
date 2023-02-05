using System.Diagnostics;
using System.Security;
using System.Windows.Input;
using GoldCom.Database;
using GoldCom.Models;
using GoldCom.Services;
using KVVM.Navigation;
using KVVM.ViewModels;

namespace GoldCom.ViewModel;

public class LoginViewModel : ViewModelBase
{
    private readonly INavigationService homeNavigationService;
    private readonly IUserManager<User> userManager;
    private readonly ApplicationDbContext context;

    public LoginViewModel(NavigationService<HomeViewModel> homeNavigationService, IUserManager<User> userManager, ApplicationDbContext context)
    {
        this.homeNavigationService = homeNavigationService;
        this.userManager = userManager;
        this.context = context;

        LoginCommand = new KVVM.Commands.Command(p =>
        {
            if (userManager.Login(Login, Password, context) is not null)
            {
                homeNavigationService.Navigate();
                Debug.WriteLine("Logged in");
            }
            else Debug.WriteLine("Not logged");
        });
    }
    public string Login { get; set; } = "";
    public string Password { get; set; } = "";
    public ICommand LoginCommand { get; set; } 
}
