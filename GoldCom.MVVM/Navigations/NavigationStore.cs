using GoldCom.MVVM.ViewModels;

namespace GoldCom.Navigations;
public class NavigationStore
{
    private ViewModelBase currentViewModel;

    public ViewModelBase CurrentViewModel 
    { 
        get => currentViewModel; 
        set
        {
            currentViewModel = value;
            CurrentViewModelChanged?.Invoke();
        }
    }
    public event Action? CurrentViewModelChanged;
}
