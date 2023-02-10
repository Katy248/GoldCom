using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldCom.MVVM.ViewModels;

namespace GoldCom.ViewModel;
public abstract class ViewModelWithNavigationBar<TNavigationBarViewModel> : ViewModelBase
{
    public ViewModelWithNavigationBar(TNavigationBarViewModel navigationBar)
    {
        NavigationBar = navigationBar;
    }

    public TNavigationBarViewModel NavigationBar { get; }
}
