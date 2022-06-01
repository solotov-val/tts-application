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
using tts_application;
using XamlUI.MVVM.View;

namespace XamlUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables
        UserList ul = new UserList();
        #endregion

        #region Private Methods
        /// <summary>
        /// Closes Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Swaps to MainTTSWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void LoginClick(object sender, RoutedEventArgs e)
        {
            var user = FindElementByName<TextBox>(LoginContent, "User");
            var pass = FindElementByName<PasswordBox>(LoginContent, "Password");
            if (ul.searchUser(user.Text, pass.Password))
            {
                this.Hide();
                var mainTTS = new MainTTSWindow(this);
                mainTTS.Show();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        /// <summary>
        /// Shows Register Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RegisterClickHere(object sender, RoutedEventArgs e)
        {
            Click_Register.Visibility = Visibility.Hidden;
            Click_Delete.Visibility = Visibility.Hidden;
            Login_Button.Visibility = Visibility.Hidden;

            Register_Button.Visibility = Visibility.Visible;
            Back_Button.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Shows Delete Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DeleteClickHere(object sender, RoutedEventArgs e)
        {
            Click_Register.Visibility = Visibility.Hidden;
            Click_Delete.Visibility = Visibility.Hidden;
            Login_Button.Visibility = Visibility.Hidden;

            Delete_Button.Visibility = Visibility.Visible;
            Back_Button.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Creates Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RegisterClick(object sender, RoutedEventArgs e)
        {
            var user = FindElementByName<TextBox>(LoginContent, "User");
            var pass1 = FindElementByName<PasswordBox>(LoginContent, "Password1");
            var pass2 = FindElementByName<PasswordBox>(LoginContent, "Password2");
            if (pass1.Password.Equals(pass2.Password))
            {
                if (!ul.searchUser(user.Text, pass1.Password))
                {
                    MessageBox.Show("Account Created Successfully!");
                    ul.addUser(user.Text, pass1.Password);
                }
                else
                {
                    MessageBox.Show("Account Creation Failed. User already exists.");
                }
            }
            else
            {
                MessageBox.Show("Account Creation Failed! Passwords were not equal.");
            }
            Click_Register.Visibility = Visibility.Visible;
            Click_Delete.Visibility = Visibility.Visible;
            Login_Button.Visibility = Visibility.Visible;

            Register_Button.Visibility = Visibility.Hidden;
            Back_Button.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Deletes Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DeleteClick(object sender, RoutedEventArgs e)
        {
            var user = FindElementByName<TextBox>(LoginContent, "User");
            var pass1 = FindElementByName<PasswordBox>(LoginContent, "Password1");
            var pass2 = FindElementByName<PasswordBox>(LoginContent, "Password2");
            if (pass1.Password.Equals(pass2.Password))
            {
                if (ul.searchUser(user.Text, pass1.Password))
                {
                    MessageBox.Show("Account Deleted Successfully");
                    ul.remUser(user.Text, pass1.Password);
                }
                else
                {
                    MessageBox.Show("Account Deletion Failed. No Such User Found.");
                }
            }
            else
            {
                MessageBox.Show("Account Deletion Failed. Passwords not equal.");
            }
            Click_Register.Visibility = Visibility.Visible;
            Click_Delete.Visibility = Visibility.Visible;
            Login_Button.Visibility = Visibility.Visible;

            Delete_Button.Visibility = Visibility.Hidden;
            Back_Button.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Shows Login Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BackClick(object sender, RoutedEventArgs e)
        {
            Click_Register.Visibility = Visibility.Visible;
            Click_Delete.Visibility = Visibility.Visible;
            Login_Button.Visibility = Visibility.Visible;

            Delete_Button.Visibility = Visibility.Hidden;
            Back_Button.Visibility = Visibility.Hidden;
            Register_Button.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Makes Program dragable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Returns View Fields such as Buttons
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <param name="sChildName"></param>
        /// <returns></returns>
        public T FindElementByName<T>(FrameworkElement element, string sChildName) where T : FrameworkElement
        {
            T childElement = null;
            var nChildCount = VisualTreeHelper.GetChildrenCount(element);
            for (int i = 0; i < nChildCount; i++)
            {
                FrameworkElement child = VisualTreeHelper.GetChild(element, i) as FrameworkElement;

                if (child == null)
                    continue;

                if (child is T && child.Name.Equals(sChildName))
                {
                    childElement = (T)child;
                    break;
                }

                childElement = FindElementByName<T>(child, sChildName);

                if (childElement != null)
                    break;
            }
            return childElement;
        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
