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
    private readonly INavigationService _homeNavigationService;
    private readonly IUserManager<User> _userManager;

    public LoginViewModel(NavigationServiceFactory navigation, IUserManager<User> userManager)
    {
        _homeNavigationService = navigation.GetNavigationService<HomeViewModel>();
        _userManager = userManager;

        LoginCommand = new Command(p =>
        {
            if (userManager.Login(Login, Password) is not null)
            {
                _homeNavigationService.Navigate();
                Debug.WriteLine("Logged in");
            }
            else Debug.WriteLine("Not logged");
        });
    }
    public string Login { get; set; } = "";
    public string Password { get; set; } = "";
    public ICommand LoginCommand { get; set; } 
}
