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
        private bool translator;
        private int inputType;

        public User(String username, String password, String language, bool translator, int inputType)
        {
            this.username = username;
            this.password = password;
            this.language = language;
            this.translator = translator;
            this.inputType = inputType;
        }


        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }


        public bool checkUser(){
            bool exists = false;

            return exists;
        }

        public void setDefaultLanguage(String language){

        }

        public void activeTranslator(bool translator){

        }

        public void setInputType(int inputType){

        }

    }
}
