using System.Diagnostics;
using System.Windows.Input;
using GoldCom.Commands;
using GoldCom.Database;
using GoldCom.Domain.Models;
using GoldCom.MVVM.ViewModels;
using GoldCom.Navigations;
using GoldCom.Services;

namespace GoldCom.ViewModel;

public class LoginViewModel : ViewModelBase
{
    private readonly INavigationService homeNavigationService;
    private readonly IUserManager<User> userManager;

    public LoginViewModel(NavigationService<HomeViewModel> homeNavigationService, IUserManager<User> userManager)
    {
        this.homeNavigationService = homeNavigationService;
        this.userManager = userManager;

        LoginCommand = new Command(p =>
        {
            if (userManager.Login(Login, Password) is not null)
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
