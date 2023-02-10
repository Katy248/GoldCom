using System;
using GoldCom.MVVM.ViewModels;

namespace GoldCom.Navigations;
public class NavigationService<TViewModel> : INavigationService where TViewModel: ViewModelBase 
{
    private readonly NavigationStore navigationStore;
    private readonly Func<TViewModel> createViewModel;

    public NavigationService(NavigationStore navigationStore, Func<TViewModel> createViewModel)
    {
        this.navigationStore = navigationStore;
        this.createViewModel = createViewModel;
    }
    public void Navigate()
    {
        navigationStore.CurrentViewModel = createViewModel();
    }
}
