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
    public partial class LoginPage : Form
    {
        UserList ul = new UserList();
        public LoginPage()
        {
            InitializeComponent();
            passwordText.PasswordChar = '*';
        }

        public void loginClick()
        {

        }

        public void createClick()
        {

        }


        /*
        public void deleteClick()
        {

        }
        */


        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if(ul.searchUser(usernameText.Text, passwordText.Text))
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var accountCreation = new AccountCreation(this, ul);
            accountCreation.Show();
        }
    }
}
