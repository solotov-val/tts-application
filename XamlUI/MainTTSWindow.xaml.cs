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
        #region Variables
        Window loginWindow;
        #endregion

        #region Private Methods
        /// <summary>
        /// Function to get back to MainLogin View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void LogOutClick(object sender, RoutedEventArgs e)
        {

            loginWindow.Show();
            Close();
        }
        /// <summary>
        /// Closes the Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CloseClick(object sender, RoutedEventArgs e)
        {
            Close();
            loginWindow.Close();
        }
        /// <summary>
        /// Makes Program Dragable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        #endregion
        public MainTTSWindow(Window w)
        {
            InitializeComponent();
            this.loginWindow = w;
        }
    }
}
