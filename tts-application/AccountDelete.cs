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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }


        //Give username and password to the remUser function in UserList
        private void delete_Click(object sender, EventArgs e)
        {
            userList.remUser(usernameBox.Text, passwordBox.Text);
            this.Hide();
        }



        //Button to go back to the login window
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
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


        //Checks the password if its long enouth and if the two passwords are equal
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


        //Checks the password everytime the user puts in a new char
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordCheck();
        }

        //Checks the confirmed password everytime the user puts in a new char
        private void confirmBox_TextChanged(object sender, EventArgs e)
        {
            passwordCheck();
        }

        //Handels the button status if the information of the account are correct
        private void accountDeletable()
        {
            delete.Enabled = validPasswords && validUsername;
        }
    }
}
