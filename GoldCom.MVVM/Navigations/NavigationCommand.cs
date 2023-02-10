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
