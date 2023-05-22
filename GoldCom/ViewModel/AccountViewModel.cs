using System;
using GoldCom.Domain.Models;
using GoldCom.MVVM.ViewModels;
using GoldCom.Navigations;
using GoldCom.Services;

namespace GoldCom.ViewModel;

public class AccountViewModel : ViewModelBase
{
    private readonly IUserManager<User> userManager;
    private readonly NavigationService<LoginViewModel> loginNavigation;
    private readonly NavigationService<HomeViewModel> homeNavigation;

    public AccountViewModel(
        IUserManager<User> userManager,
        NavigationService<LoginViewModel> loginNavigation,
        NavigationService<HomeViewModel> homeNavigation)
	{
        this.userManager = userManager;
        this.loginNavigation = loginNavigation;
        this.homeNavigation = homeNavigation;
    }

    public User CurrentUser 
    { 
        get
        {
            if (userManager.User is null)
            {
                homeNavigation.Navigate();
                return new User();
            }
            return userManager.User;
        } 
    }
    public string FirstName 
    { 
        get => CurrentUser.FistName; 
        set => CurrentUser.FistName = value;
    }
    public string Surname
    {
        get => CurrentUser.Surname;
        set => CurrentUser.Surname = value;
    }

    public string LastName
    {
        get => CurrentUser.LastName;
        set => CurrentUser.LastName = value;
    }
    public string Email
    {
        get => CurrentUser.Email;
        set => CurrentUser.Email = value;
    }
}
