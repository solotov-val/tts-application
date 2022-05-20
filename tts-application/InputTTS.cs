//using Microsoft.WindowsAPICodePack.Shell;
//using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace tts_application
{
    public partial class InputTTS : Form
    {
        VerifyInput v = new VerifyInput();
        EvaluateParameters ev = new EvaluateParameters();
        
        Form menue;
        String choosenLanguage;
        String speakers;
        String choosenSpeaker;
        bool fileBrowser;

        public InputTTS(Form f, bool b)
        {
            InitializeComponent();
            limitExcceded.Hide();
            charLimitExcceded.Hide();
            this.menue= f;
            this.fileBrowser= b;
            checkFileState();
            comboBoxSprache.SelectedIndex=0;

        }


        public void openClick()
        {

        }

        private void FileInput_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void checkFileState()
        {
            if (fileBrowser == false)
            {
                buttonOpenFile.Hide();
            }
            else
            {
                buttonOpenFile.Show();
            }
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            ofdFileInput.ShowDialog();
            String path = ofdFileInput.FileName;
            String text="";


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
               
                richTextBox1.Text = text;
                wordCount(text);
                charCount(text);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            wordCount(richTextBox1.Text);
            charCount(richTextBox1.Text);
        }


        //Function to value the Text by the number of words
        private void wordCount(String text)
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
            wordCounter.Text = "" + counter;

        }

        
        //Function to value the Text by the number of chars
        private void charCount(String text)
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
            charCounter.Text = "" + counter;
        }



        //Selected Language
        private void comboBoxSprache_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosenLanguage = comboBoxSprache.SelectedItem.ToString();
            String[] words = choosenLanguage.Split(' ');
            choosenLanguage = words[1];

            speakers = ev.evaluateSpeaker(choosenLanguage);
            int len = v.wordCounter(speakers);

            if(len == 1)
            {
                choosenSpeaker = speakers;

            }else
            {
                String[] sp = speakers.Split(' ');
                

                for(int i = 0; i < len; i++)
                {
                    comboBoxSpeakers.Items.Add(""+sp[i]);
                }
                comboBoxSpeakers.Parent = this;
                comboBoxSpeakers.SelectedIndex = 0;
                comboBoxSpeakers.Show();
            }
        }

        private void comboBoxSpeakers_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosenSpeaker=comboBoxSpeakers.SelectedItem.ToString();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            ApiHelpClass.tts(choosenLanguage, choosenSpeaker, richTextBox1.Text);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if(File.Exists("filename.txt"))
            {
                String filename = File.ReadAllText("filename.txt");

                if(File.Exists(filename))
                {
                    WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                    wplayer.URL = filename;
                    wplayer.controls.play();
                }
            }
            else
            {
                MessageBox.Show("Error by searching for the file!");
            }

        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menue.Show();
        }


        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (File.Exists("filename.txt"))
            {
                String filename = File.ReadAllText("filename.txt");

                if (File.Exists(filename))
                {
                    string destinationFile = "C:\\Users\\alexpastore\\Desktop";

                    try
                    {
                        File.Copy(filename, destinationFile, true);
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
    }
}
