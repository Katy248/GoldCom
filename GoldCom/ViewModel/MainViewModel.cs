using KVVM.Navigation;
using KVVM.ViewModels;

namespace GoldCom.ViewModel;

public class MainViewModel : ViewModelBase
{
    private readonly NavigationStore navigationStore;

    public MainViewModel(NavigationStore navigationStore)
    {
        this.navigationStore = navigationStore;

        navigationStore.CurrentViewModelChanged += (s, e) => RaisePropertyChanged(nameof(CurrentViewModel));
    }

    public ViewModelBase CurrentViewModel => navigationStore.CurrentViewModel;

}
