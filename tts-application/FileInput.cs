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
    public partial class FileInput : Form
    {
        VerifyInput v = new VerifyInput();
        Form menue;
        public FileInput(Form f)
        {
            InitializeComponent();
            limitExcceded.Hide();
            charLimitExcceded.Hide();
            this.menue= f;

        }


        public void openClick()
        {

        }

        private void FileInput_Load(object sender, EventArgs e)
        {

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
    }
}
