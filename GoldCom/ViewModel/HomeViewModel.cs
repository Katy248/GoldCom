using System.Diagnostics;
using System.Runtime.CompilerServices;
using GoldCom.Models;
using GoldCom.Services;
using KVVM.ViewModels;

namespace GoldCom.ViewModel;

public class HomeViewModel : ViewModelWithNavigationBar<NavigationBarViewModel>
{
    private readonly IUserManager<User> userManager;

    public HomeViewModel(NavigationBarViewModel navigationBarViewModel, IUserManager<User> userManager) : base(navigationBarViewModel)
	{
        this.userManager = userManager;

        Debug.WriteLine($"{nameof(HomeViewModel)} created");
    }
    public string Username => $"{userManager.User?.FistName} {userManager.User?.LastName}";
}
