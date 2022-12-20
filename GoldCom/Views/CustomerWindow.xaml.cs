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

namespace GoldCom.Views
{
    /// <summary>
    /// Логика взаимодействия для CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        public CustomerWindow(FormType formType, Customer? customer = null)
        {
            InitializeComponent();
            if (formType==FormType.Edit && customer is not null)
            {
                _customer = customer;
                _formType = FormType.Edit;
                enterButton.Content = FindResource("FormButtonEdit");
            }
            else
            {
                _customer = new Customer();
                _formType = FormType.Create;
                enterButton.Content = FindResource("FormButtonCreate");
            }
            DataContext = _customer;
        }
        private readonly Customer _customer;
        private readonly FormType _formType;

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            if (_formType == FormType.Create)
            {
                using (var context = new ApplicationContext())
                {
                    //_customer.Id = context.Customers.Last().Id + 1;
                    MessageBox.Show(context.Customers.First().Id.ToString());
                    context.Customers.Add(_customer);
                    context.SaveChanges();
                }
            }
            else
            {
                using (var context = new ApplicationContext())
                {
                    context.Update(_customer);
                    context.SaveChanges();
                }
            }
            Close();
        }
    }
}
