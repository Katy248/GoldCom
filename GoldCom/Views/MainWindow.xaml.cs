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
using GoldCom.Database;
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

    private void UpdateDataGrid(DataGrid dataGrid, IEnumerable<object> items)
    {
        //dataGrid.Items.Clear();
        dataGrid.ItemsSource = items;
    }

    private void requestTab_Loaded(object sender, RoutedEventArgs e)
    {
        using (var context = new ApplicationContext())
            UpdateDataGrid(requestsDataGrid, context.Requests.ToArray());
    }


    private void addCustomerButton_Click(object sender, RoutedEventArgs e)
        => new CustomerWindow(FormType.Create).ShowDialog();

    private void editCustomerButton_Click(object sender, RoutedEventArgs e) 
    {
        if (customersDataGrid.SelectedItem is not null) 
            new CustomerWindow(FormType.Edit, customersDataGrid.SelectedItem as Customer).ShowDialog();
    }

    private void customersTab_GotFocus(object sender, RoutedEventArgs e)
    {
        using (var context = new ApplicationContext())
            UpdateDataGrid(customersDataGrid, context.Customers.ToArray());
    }
}
