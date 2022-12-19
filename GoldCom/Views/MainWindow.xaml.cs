using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GoldCom.Models;
using GoldCom.Views;

namespace GoldCom;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        CurrentUser = LogIn();
        if (CurrentUser is null) Close();
        else Prepare();
    }

    private void Prepare()
    {
        userFullNameLabel.Content = $"{CurrentUser?.Surname} {CurrentUser?.FistName} {CurrentUser?.LastName}";
    }

    private User? LogIn()
    {
        Hide();
        var login = new LoginWindow();
        login.ShowDialog();
        Show();
        return login.LoggedUser;
    }
    private User? CurrentUser { get; set; }
}
