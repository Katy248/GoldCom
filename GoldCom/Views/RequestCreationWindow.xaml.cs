using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using GoldCom.ViewModel;
using GoldCom.Models;

namespace GoldCom.Views
{
    /// <summary>
    /// Логика взаимодействия для RequestCreationWindow.xaml
    /// </summary>
    public partial class RequestCreationWindow : Window
    {
        public RequestCreationWindow(User employee)
        {
            viewModel = new RequestViewModel(employee);
            InitializeComponent();
            this.DataContext = viewModel;
            customersBox.ItemsSource = viewModel.Customers;
            typesBox.ItemsSource = viewModel.MaterialTypes;

        }
        private readonly RequestViewModel viewModel;

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            if (!viewModel.Validate())
            {
                viewModel.UpdateData();
                Close();
            }
            else
                MessageWindow.ShowDialog(dialog =>
                {
                    dialog.Text = FindResource("FormMessageErroIncorrectInputData").ToString();
                    dialog.TitleText = FindResource("FormMessageErrorIncorrectInputDataTitle").ToString();
                    dialog.ButtonText = "Ok";
                });
            
        }
    }
}
