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

namespace GoldCom.Views;
/// <summary>
/// Логика взаимодействия для MessageWindow.xaml
/// </summary>
public partial class MessageWindow : Window
{
    public MessageWindow()
    {
        InitializeComponent();
    }
    public string? TitleText
    {
        set
        { 
            Title = value;
            titleLabel.Content = value;
        }
    }
    public string? Text
    {
        set
        {
            textBlock.Text = value;
        }
    }
    public string? ButtonText
    {
        set
        {
            button.Content = value;
        }
    }
    public static bool ShowDialog(Action<MessageWindow>? action)
    {
        var window = new MessageWindow();
        action?.Invoke(window);
        bool? result = window.ShowDialog();
        return result.Value;
    }
}
