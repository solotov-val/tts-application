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
        VerifyInput v = new VerifyInput(); 
        EvaluateParameters ev = new EvaluateParameters();
        UserList ul;
        String input;
        bool fileBrowser;
        String choosenInputLanguage;
        String choosenOutputLanguage;
        String[] tempIn;
        String[] tempOut;
        DateTime convertClicked;


        public TranslateInput(Form f, bool b, UserList ul)
        {
            InitializeComponent();
            this.menue = f;
            this.fileBrowser = b;
            checkFileState();
            this.ul = ul;
            comboBoxInputLanguage.SelectedIndex = ul.getCurrentUser().gettranslateIn();
            comboBoxOutputLanguage.SelectedIndex = ul.getCurrentUser().getTranslateOut();

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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menue.Show();
        }


        //ÜBERARBEITEN, je nach sprache der Trnaslate API!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void comboBoxSprache_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosenInputLanguage = comboBoxInputLanguage.SelectedItem.ToString();
            tempIn = choosenInputLanguage.Split(' ');
            choosenInputLanguage = tempIn[0];
        }


        private void buttonConvert_Click_1(object sender, EventArgs e)
        {
            convertClicked=DateTime.Now;

            ul.getCurrentUser().setTranslateIn(comboBoxInputLanguage.SelectedIndex);
            ul.getCurrentUser().setTranslateOut(comboBoxOutputLanguage.SelectedIndex);
            ul.saveUsers();
            String authKey="";
            if (File.Exists("..\\..\\Keys\\KeyAPI.txt"))
            {
                authKey = File.ReadAllText("..\\..\\Keys\\KeyAPI.txt");
            }
            else
            {
                MessageBox.Show("Error by searching for the KeyAPI file!");
            }

            String input = userInput.Text.ToString();
            ApiHelpClass.translate(authKey, choosenInputLanguage, choosenOutputLanguage, input);

        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            int temp = comboBoxInputLanguage.SelectedIndex;
            comboBoxInputLanguage.SelectedIndex = comboBoxOutputLanguage.SelectedIndex;
            comboBoxOutputLanguage.SelectedIndex = temp;

            //Sprachen noch richtig in die Comboboxen eintragen
            //comboBoxInputLanguage.Text = String.Concat(tempOut);
            //comboBoxOutputLanguage.Text = String.Concat(tempIn);
        }

        private void comboBoxOutputLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosenOutputLanguage = comboBoxOutputLanguage.SelectedItem.ToString();
            tempOut = choosenOutputLanguage.Split(' ');
            choosenOutputLanguage = tempOut[0];
        }

        private void buttonShowTranslation_Click(object sender, EventArgs e)
        {
            if(File.Exists("temptranslate.txt"))
            {
                if (convertClicked < File.GetLastWriteTime("temptranslate.txt"))
                {
               
                    String text = File.ReadAllText("temptranslate.txt");
                    rtbOutput.Text = text;
                }
                else
                {
                    MessageBox.Show("No answer yet from API");
                }
            }
            else{
                MessageBox.Show("No answer yet from API");
            }
            
        }
    }
}
