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
            userList.Add(new User("Alex", "1234", "Deutsch", true, 1));
        }

        

        public void addUser(String crerateN, String createP){

        }

        public void remUser(String crerateN, String createP){

        }

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
