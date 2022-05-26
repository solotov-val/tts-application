using Microsoft.Win32;
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
        String input;
        bool fileBrowser;
        String choosenInputLanguage;
        String choosenOutputLanguage;
        String[] tempIn;
        String[] tempOut;



        public TranslateInput(Form f, bool b)
        {
            InitializeComponent();
            this.menue = f;
            this.fileBrowser = b;
            checkFileState();
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
            //String authKey= ""; //= "48b840d9-957f-e91b-ff3d-d5616d26a7b3:fx";
            String authKey = "48b840d9-957f-e91b-ff3d-d5616d26a7b3:fx";
            //String path = Application.StartupPath + "\\APIKey.txt";
            //if (File.Exists(path))
            //{
            //    authKey = File.ReadAllText(path);
            //}
            //else
            //{
            //    MessageBox.Show("Error by searching for the KeyAPI file!");
            //}

            //Ruft anschließend die TranslateText Funktion auf mit den Parametern, um den Text zu übersetzen


            String input = userInput.Text.ToString();
            ApiHelpClass.translate(authKey, choosenInputLanguage, choosenOutputLanguage, input);

        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            string temp = choosenOutputLanguage;
            choosenOutputLanguage = choosenInputLanguage;
            choosenInputLanguage=temp;
            
            //Sprachen noch richtig in die Comboboxen eintragen
            comboBoxInputLanguage.Text = tempOut.ToString();
            comboBoxOutputLanguage.Text = tempIn.ToString();
        }

        private void comboBoxOutputLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosenOutputLanguage = comboBoxOutputLanguage.SelectedItem.ToString();
            tempOut = choosenOutputLanguage.Split(' ');
            choosenOutputLanguage = tempOut[0];
        }

        private void buttonShowTranslation_Click(object sender, EventArgs e)
        {
            String path = Application.StartupPath + "\\temptranslate.txt";
            String text = File.ReadAllText(path);
            rtbOutput.Text = text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("filename.txt"))
            {
                String filename = File.ReadAllText("filename.txt");
                String startPath = Application.StartupPath + "\\" + filename + ".mp3";
                string destinationPath = GetDownloadFolderPath() + "\\" + filename;

                if (File.Exists(filename))
                {
                    try
                    {
                        File.Copy(filename, destinationPath, true);
                    }
                    catch (IOException iox)
                    {
                        Console.WriteLine(iox.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error by searching for the file!");
            }
        }

        string GetDownloadFolderPath()
        {
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
        }
    }
}
