﻿using System.Diagnostics;
using GoldCom.Domain.Models;
using GoldCom.Services;

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
