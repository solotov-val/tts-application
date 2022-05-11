using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tts_application
{
    public class UserList
    {
        private List<User> userList = new List<User>();
        public const int MINPWDLENGTH = 8;
       
        public UserList()
        {
            userList.Add(new User("Alex", "12345678", "Deutsch", true, 1));
        }

        
        //Add User to the List and write them to the XML file
        public void addUser(String username, String password, String language, bool translator, int inputType){

            userList.Add(new User(username, password, language, translator, inputType));
        }


        //Remove User from List and from the XML file
        public void remUser(String username, String password){

            userList.Remove(new User(username, password));
        }


        //Function to search for an existing User with Password
        public bool searchUser(String loginN, String loginP)
        {
            bool found = false;

            foreach (User user in userList) {

                if(user.getUsername().Equals(loginN)&& user.getPassword().Equals(loginP))
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
    }
}
