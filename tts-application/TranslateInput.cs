using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tts_application
{
    public partial class TranslateInput : Form
    {
        Form menue;
        String input;
        bool fileBrowser;
        VerifyInput v = new VerifyInput();
        public TranslateInput(Form f, bool b)
        {
            InitializeComponent();
            this.menue = f;
            this.fileBrowser = b;
            checkFileState();
            toolStripDropDownButton1.ShowDropDown();
            

        }

        private void checkFileState()
        {
            if (fileBrowser==false)
            {
                buttonOpenFile.Hide();
            }
            else
            {
                buttonOpenFile.Show();
            }
        }
        public String getTranslateLang()
        {
            String language = "TEST";

            return language;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            input = userInput.Text;
        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {
            wordCounter(userInput.Text);
            charCounter(userInput.Text);
        }

        private void wordCounter(String text)
        {

            int counter = v.wordCounter(text);

            if (counter > 50)
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


        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            ofdFileInput.ShowDialog();
            String path = ofdFileInput.FileName;
            String text = "";


            if (path == null)
            {
                MessageBox.Show("No path selected!");
            }
            else
            {
                try
                {
                    text = File.ReadAllText(path);

                }
                catch (Exception)
                {

                    MessageBox.Show("Loading of the file failed!");
                }

                userInput.Text = text;
                wordCounter(text);
                charCounter(text);
            }
        }

        private void TranslateFileInput_Load(object sender, EventArgs e)
        {

        }
    }
}
