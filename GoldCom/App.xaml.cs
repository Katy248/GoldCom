using System.Configuration;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GoldCom.Extensions;
using GoldCom.ViewModel;
using GoldCom.Database;
using GoldCom.Services;
using GoldCom.Navigations;
using GoldCom.Domen.Models;

namespace GoldCom;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly IServiceCollection services = new ServiceCollection();
    private ServiceProvider serviceProvider;

    public App()
    {
        // Add database context
        var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        serviceProvider = services
            .AddDbContext<ApplicationDbContext>(
            options => options.UseSqlite(connectionString))
            .AddSingleton<NavigationStore>()
            .AddSingleton<IUserManager<User>, UserManager>()

            .AddViews()
            .AddNavigations()

            .AddSingleton<MainWindow>()

            .BuildServiceProvider();
    }
    protected override void OnStartup(StartupEventArgs e)
    {
        serviceProvider.GetRequiredService<NavigationStore>().CurrentViewModel = serviceProvider.GetRequiredService<LoginViewModel>();

        MainWindow = serviceProvider.GetRequiredService<MainWindow>();
        MainWindow.Show();
        base.OnStartup(e);
    }
}
