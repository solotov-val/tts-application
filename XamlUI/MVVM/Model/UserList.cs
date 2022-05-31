using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace XamlUI.MVVM.Model
{
    internal class UserList
    {
        private List<User> userList = new List<User>();
        private User currentUser;
        public const int MINPWDLENGTH = 8;

        //private const String PATH = "..\\..\\users.txt";
        private static string userName = Environment.UserName;
        private String path = System.AppDomain.CurrentDomain.BaseDirectory + "\\users.txt";

        private bool pathExists = false;
        private const String HASHSALT = "アレックス・パストーレ";

        public UserList()
        {
            pathExists = File.Exists(path);
            if(pathExists == false)
            {
                using (FileStream fs = File.Create(path));
            } 
            readFromFile();
        }

        
        //Add User to the List and write them to the txt file
        public void addUser(String username, String password){

            userList.Add(new User(username, hashString(password), 0,0,0,0));
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
                    currentUser = user;
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
                //String temp = Application.StartupPath;
                //using (StreamWriter sw = File.CreateText(temp));
                MessageBox.Show("Invalid path to users File!");
            }
            else
            {
                String users = "";
                try
                {
                    users = File.ReadAllText(path);
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
                
                    if(splitted.Length==6)
                    {
                        userList.Add(new User(splitted[0], splitted[1], Int32.Parse(splitted[2]), Int32.Parse(splitted[3]), Int32.Parse(splitted[4]), Int32.Parse(splitted[5])));
                    }
                }
            }    
        }


        //Function to save new users in the uers.txt file
        public void saveUsers()
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
                    allUsers = allUsers + user.getUsername() + "\t" + user.getPassword() + "\t" + user.getLanguage()+ "\t"+ user.getSpeaker() + "\t"+ user.gettranslateIn()+ "\t"+ user.getTranslateOut()+"\n";
                }

                try
                {
                    File.WriteAllText(path, allUsers, Encoding.UTF8);
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


        public User getCurrentUser()
        {
            return currentUser;
        }
    }
}
