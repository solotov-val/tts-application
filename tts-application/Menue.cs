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
    public partial class Menue : Form
    {
        Form loginPage;
        bool fileTts = false;
        bool fileTranslate = false;
        public Menue(Form f)
        {
            InitializeComponent();
            this.loginPage = f;
        }

        private void buttonTextInput_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            var textInput = new InputTTS(this, fileTts);
            textInput.Show();
        }

        private void buttonFileInput_Click(object sender, EventArgs e)
        {
            fileTts = true;
            this.Hide();
            var fileInput = new InputTTS(this, fileTts);
            fileInput.Show();
        }

        private void buttonTranslateFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            var translateFileInput = new TranslateInput(this, fileTranslate);
            translateFileInput.Show();
        }

        private void buttonTranslateText_Click(object sender, EventArgs e)
        {
            fileTranslate = true;
            this.Hide();
            var translateFileInput = new TranslateInput(this, fileTranslate);
            translateFileInput.Show();
        }

        private void Menue_Load(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var about = new About(this);
            about.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage.Show();
        }
    }
}
