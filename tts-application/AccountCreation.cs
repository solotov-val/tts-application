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
    public partial class AccountCreation : Form
    {
        Form loginPage;
        bool usernameValid = false;
        bool passwordValid = false;
        UserList userList;
        
        public AccountCreation(Form f, UserList ul)
        {
            InitializeComponent();
            this.loginPage = f;
            this.userList = ul;
            passwordBox.PasswordChar = '*';
            confirmBox.PasswordChar = '*';
            userExists.Hide();
        }


        public void createClick()
        {


        }

        public void backClick()
        {

        }

        private void AccountCreation_Load(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            if(!usernameBox.Text.Equals("") && userList.userExists(usernameBox.Text))
            {
                userExists.Show();
                usernameValid = false;
            }
            else
            {
                userExists.Hide();
                usernameValid = true;
            }

            accountCreatable();
        }


        private void passwordCheck()
        {
            if(userList.passwordIsValid(passwordBox.Text) && passwordBox.Text.Equals(confirmBox.Text))
            {
                passwordValid = true;
            }
            else
            {
                passwordValid=false;
            }

            accountCreatable();
        }


        private void accountCreatable()
        {
            createButton.Enabled = usernameValid && passwordValid;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordCheck();
        }

        private void confirmBox_TextChanged(object sender, EventArgs e)
        {
            passwordCheck();
        }
    }
}
