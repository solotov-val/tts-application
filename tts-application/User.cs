using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tts_application
{
    public class User
    {

        private String username;
        private String password;
        private int ttsLanguage;
        private int speaker;
        private int translateIn;
        private int translateOut;


        public User(String username, String password, int language, int speaker, int translateIn, int translateOut)
        {
            this.username = username;
            this.password = password;
            this.ttsLanguage = language;
            this.speaker = speaker;
            this.translateIn = translateIn;
            this.translateOut = translateOut;
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

        public int getLanguage()
        {
            return ttsLanguage;
        }

        public int getSpeaker()
        {
            return speaker;
        }

        public int gettranslateIn()
        {
            return translateIn;
        }

        public int getTranslateOut()
        {
            return translateOut;
        }


        public void setTtsLanguage(int language)
        {
            this.ttsLanguage = language;
            this.speaker = 0;
        }

        public void setSpeaker(int speaker)
        {
            this.speaker=speaker;
        }

        public void setTranslateIn(int translateIn)
        {
            this.translateIn=translateIn;
        }

        public void setTranslateOut(int translateOut)
        {
            this.translateOut = translateOut;
        }



        public bool checkUser(){
            bool exists = false;

            return exists;
        }

        public void setDefaultLanguage(int language){

            this.ttsLanguage = language;
        }

    }
}
