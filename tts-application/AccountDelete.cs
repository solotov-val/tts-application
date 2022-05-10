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
        bool usernameValid = false;
        bool passwordValid = false;
        UserList userList;

        public AccountDelete(Form f, UserList ul)
        {
            InitializeComponent();
            this.loginPage = f;
            this.userList = ul;
            passwordBox.PasswordChar = '*';
            confirmBox.PasswordChar = '*';
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

        }
    }
}
