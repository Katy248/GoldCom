using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldCom.ViewModel;

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
