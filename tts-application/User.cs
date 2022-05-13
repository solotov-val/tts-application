using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tts_application
{
    internal class User
    {

        private String username;
        private String password;
        private String language;


        public User(String username, String password, String language)
        {
            this.username = username;
            this.password = password;
            this.language = language;

        }

        public User(String username, String password)
        {
            this.username = username;
            this.password = password;
        }


        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }

        public String getLanguage()
        {
            return language;
        }

        public bool checkUser(){
            bool exists = false;

            return exists;
        }

        public void setDefaultLanguage(String language){

            this.language = language;
        }

    }
}
