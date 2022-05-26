using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tts_application
{
    //Fully exported to XAML UI
    public partial class LoginPage : Form
    {
        UserList ul = new UserList();
        public LoginPage()
        {
            InitializeComponent();
            passwordText.PasswordChar = '*';
        }


        private void LoginPage_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void  deleteInput()
        {
            passwordText.Text = "";
            usernameText.Text = "";
        }


        //Check if user exists and get to the textInput Form
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(ul.searchUser(usernameText.Text, passwordText.Text))
            {
                MessageBox.Show("Login successful! Welcome back "+usernameText.Text+" !");
                this.Hide();
                var menue = new Menue(this);
                menue.Show();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var accountCreation = new AccountCreation(this, ul);
            accountCreation.ShowDialog();
        }

        private void deleteAccount_Click(object sender, EventArgs e)
        {
            var accountDelete = new AccountDelete(this, ul);
            accountDelete.ShowDialog();
        }


        private void LoginPage_VisibleChanged(object sender, EventArgs e)
        {
            deleteInput();
        }
    }
}
