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
    public partial class AccountDelete : Form
    {
        Form loginPage;
        UserList userList;
        bool validUsername=false;
        bool validPasswords=false;

        public AccountDelete(Form f, UserList ul)
        {
            InitializeComponent();
            this.loginPage = f;
            this.userList = ul;
            passwordBox.PasswordChar = '*';
            confirmBox.PasswordChar = '*';
            userNotExist.Hide();
            invalidPassword.Hide();
        }
    
        private void AccountDelete_Load(object sender, EventArgs e)
        {

        }


        //Give username and password to the remUser function in UserList
        private void delete_Click(object sender, EventArgs e)
        {
            userList.remUser(usernameBox.Text, passwordBox.Text);
        }



        //Go back to the Login Window
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage.ShowDialog();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            if (!usernameBox.Text.Equals("") && userList.userExists(usernameBox.Text))
            {
                validUsername = true;
                userNotExist.Hide();               
            }
            else
            {
                validUsername=false;
                userNotExist.Show();    
            }
        }

        private void passwordCheck()
        {
            if (userList.passwordIsValid(passwordBox.Text) && passwordBox.Text.Equals(confirmBox.Text))
            {
                validPasswords = true;
                invalidPassword.Hide();
                
            }
            else
            {
                validPasswords=false;
                invalidPassword.Show();
            }

            accountDeletable();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordCheck();
        }

        private void confirmBox_TextChanged(object sender, EventArgs e)
        {
            passwordCheck();
        }

        private void accountDeletable()
        {
            delete.Enabled = validPasswords && validUsername;
        }
    }
}
