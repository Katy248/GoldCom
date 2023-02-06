using GoldCom.Navigations;

namespace GoldCom.ViewModel;

public class MainViewModel : ViewModelBase
{
    private readonly NavigationStore navigationStore;

    public MainViewModel(NavigationStore navigationStore)
    {
        this.navigationStore = navigationStore;

        navigationStore.CurrentViewModelChanged += () => RaisePropertyChanged(nameof(CurrentViewModel));
    }

    public ViewModelBase CurrentViewModel => navigationStore.CurrentViewModel;

}
