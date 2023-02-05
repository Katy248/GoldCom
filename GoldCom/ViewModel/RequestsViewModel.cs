using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVVM.ViewModels;

namespace GoldCom.ViewModel;
public class RequestsViewModel : ViewModelWithNavigationBar<NavigationBarViewModel>
{
	public RequestsViewModel(NavigationBarViewModel navigationBar) : base(navigationBar)
	{

	}
}
