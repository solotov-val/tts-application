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

namespace XamlUI
{
    /// <summary>
    /// Interaktionslogik für MainTTSWindow.xaml
    /// </summary>
    public partial class MainTTSWindow : Window
    {
        Window loginWindow;

        void LogOutClick(object sender, RoutedEventArgs e)
        {

            loginWindow.Show();
            Close();
        }
        void CloseClick(object sender, RoutedEventArgs e)
        {
            Close();
            loginWindow.Close();
        }

        public MainTTSWindow(Window w)
        {
            InitializeComponent();
            this.loginWindow = w;
        }
    }
}
