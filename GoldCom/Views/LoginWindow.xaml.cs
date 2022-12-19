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
using System.Windows.Shapes;
using GoldCom.Database;
using GoldCom.Models;

namespace GoldCom.Views;
/// <summary>
/// Логика взаимодействия для LoginWindow.xaml
/// </summary>
public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }
    public User? LoggedUser { get; set; }

    private void enterButton_Click(object sender, RoutedEventArgs e)
    {
        using (ApplicationContext context = new ApplicationContext())
        {
            /*var role1 = new Position() { Id = 1, Name = "Admin" };
            var role2 = new Position() { Id = 2, Name = "Консультант" };
            var user1 = new User() { Id = 1, FistName="admin", LastName="", Surname="", Email = "admin", Password = "admin", Position = role1 };
            var user2 = new User() { Id = 2, FistName = "admin", LastName = "", Surname = "", Email = "admin2", Password = "admin", Position = role2 };

            context.Add(user2);
            context.Add(user1);
            context.SaveChanges();*/

            LoggedUser = context.Users
                .FirstOrDefault(u => u.Email == loginBox.Text && u.Password == passwordBox.Password);
        }
        if (LoggedUser is not null) Close();
        else
        {
            MessageWindow.ShowDialog(dialog => 
                {
                    dialog.Text = FindResource("LoginWindowWrongPasswordDialogText").ToString();
                    dialog.TitleText = FindResource("LoginWindowWrongPasswordDialogTitle").ToString();
                    dialog.ButtonText = "Ok";
                });
        }
    }
}
