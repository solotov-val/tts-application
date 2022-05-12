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
    public partial class TextInput : Form
    {
        Form loginPage;
        String input;
        

        public TextInput(Form f)
        {
            InitializeComponent();
            this.loginPage = f;
            limitExcceded.Hide();
            charLimitExcceded.Hide();
        }

        public void setStandLang(String language)
        {

        }

        public void setTranslate(bool translate)
        {

        }

        public void setInputType(int inputtype)
        {

        }


        public void basicsClick()
        {

        }

        public void aboutClick()
        {

        }

        public void downloadClick()
        {

        }



        private void TextInput_Load(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            input= userInput.Text;
        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {
            wordCounter(userInput.Text);
            charCounter(userInput.Text);
        }

        private void wordCounter(String text)
        {

            int counter = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if(text[i] == ' ' && Char.IsLetter(text[i + 1]) && (i > 0)) {
                    counter++;

                }    
            }
            counter++;

            if(counter > 50)
            {
                limitExcceded.Show();
                buttonConvert.Enabled = false;
            }
            else
            {
                limitExcceded.Hide();
                buttonConvert.Enabled = true;
            }
            wordCount.Text = "" + counter;
        }

        private void charCounter(String text)
        {

            int counter = 0;

            foreach(char c in text)
            {
                counter++;
            }


            if (counter > 250)
            {
                charLimitExcceded.Show();
                buttonConvert.Enabled = false;
            }
            else
            {
                charLimitExcceded.Hide();
                buttonConvert.Enabled = true;
            }
            charCount.Text = "" + counter;
        }
    }
}
