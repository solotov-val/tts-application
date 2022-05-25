using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tts_application
{
    public class UserList
    {
        private List<User> userList = new List<User>();
        public const int MINPWDLENGTH = 8;
        private static string userName = Environment.UserName;
        private String PATH = Application.StartupPath + "\\users.txt";
        private bool pathExists = false;
        private const String HASHSALT = "アレックス・パストーレ";

        public UserList()
        {
            pathExists = File.Exists(PATH);
            readFromFile();
        }

        
        //Add User to the List and write them to the txt file
        public void addUser(String username, String password, String language){

            userList.Add(new User(username, hashString(password), language));
            saveUsers();
        }


        //Remove User from List and from the txt file
        //Funktioniert noch nicht, umbedingt nachfragen!
        public void remUser(String username, String password){

            bool found = false;

            for(int i=0; i<userList.Count(); i++)
            {
                if(userList[i].getUsername().Equals(username)&& userList[i].getPassword().Equals(hashString(password))){
                    found = true;
                    userList.RemoveAt(i); 
                    saveUsers();
                    break;
                }
                
                
            }
            if(found==false){
                MessageBox.Show("Delete failed!");
            }
        }


        //Function to search for an existing User with Password
        public bool searchUser(String loginN, String loginP)
        {
            bool found = false;

            foreach (User user in userList) {

                if(user.getUsername().Equals(loginN)&& user.getPassword().Equals(hashString(loginP)))
                {
                    found = true;
                    break;
                }
            }
            return found;
        }


        //Function to proove if a User with this username exists
        public bool userExists(String username)
        {
            foreach (User user in userList)
            {
                if (user.getUsername().Equals(username))
                {
                    return true;
                }
            }
            return false;
        }


        //Function to check if the password is long enough
        public bool passwordIsValid(String password)
        {
            if(password.Length>=MINPWDLENGTH)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Function to read users from users.txt file
        private void readFromFile()
        {
            if (pathExists == false)
            {
                MessageBox.Show("Invalid path to users File!");
            }
            else
            {
                String users = "";
                try
                {
                    users = File.ReadAllText(PATH);
                }
                catch (Exception)
                {
                    MessageBox.Show("Users could not be loaded!");
                }

                string[] lines = users.Split(
                    new string[] { "\r\n", "\r", "\n" },
                    StringSplitOptions.None
                );

                foreach (String user in lines)
                {
                    String[] splitted = user.Split('\t');
                
                    if(splitted.Length==3)
                    {
                        userList.Add(new User(splitted[0], splitted[1], splitted[2]));
                    }
                }
            }    
        }


        //Function to save new users in the uers.txt file
        private void saveUsers()
        {
            if(pathExists==false)
            {
                MessageBox.Show("Invalid path to users File!");
            }
            else
            {
                String allUsers = "";

                foreach(User user in userList)
                {
                    allUsers = allUsers + user.getUsername() + "\t" + user.getPassword() + "\t" + user.getLanguage()+ "\n";
                }

                try
                {
                    File.WriteAllText(PATH, allUsers, Encoding.UTF8);
                }
                catch (Exception)
                {
                    MessageBox.Show("Users could not be saved!");
                }
            }
        }


        //Hash function to hash passwords
        private string hashString(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return String.Empty;
            }

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text + HASHSALT);
                byte[] hashBytes = sha.ComputeHash(textBytes);

                string hash = BitConverter
                    .ToString(hashBytes)
                    .Replace("-", String.Empty);

                return hash;
            }
        }
    }
}
