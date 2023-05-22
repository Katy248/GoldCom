using System;
using GoldCom.Domain.Models;
using GoldCom.MVVM.ViewModels;
using GoldCom.Navigations;
using GoldCom.Services;

namespace GoldCom.ViewModel;

public class AccountViewModel : ViewModelBase
{
    private readonly IUserManager<User> _userManager;
    private readonly NavigationService<LoginViewModel> _loginNavigation;
    private readonly NavigationService<HomeViewModel> _homeNavigation;

    public AccountViewModel(
        IUserManager<User> userManager,
        NavigationServiceFactory navigation)
	{
        _userManager = userManager;
        _loginNavigation = navigation.GetNavigationService<LoginViewModel>();
        _homeNavigation = navigation.GetNavigationService<HomeViewModel>();
    }

    public User CurrentUser 
    { 
        get
        {
            if (_userManager.User is null)
            {
                _homeNavigation.Navigate();
                return new User();
            }
            return _userManager.User;
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
