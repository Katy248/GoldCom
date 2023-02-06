using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldCom.Commands;

namespace GoldCom.Navigations;
public class NavigationCommand : CommandBase
{
    private readonly INavigationService navigation;

    public NavigationCommand(INavigationService navigation)
    {
        this.navigation = navigation;
    }
    public override void Execute(object? parameter) =>
        navigation.Navigate();
}
