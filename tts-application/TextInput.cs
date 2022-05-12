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
        Form menue;
        String input;
        VerifyInput v = new VerifyInput();
        

        public TextInput(Form f)
        {
            InitializeComponent();
            this.menue = f;
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

            int counter = v.wordCounter(text);

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

            int counter = v.charCounter(text);

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
