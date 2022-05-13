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
        public Menue(Form f)
        {
            InitializeComponent();
            this.loginPage = f;
        }

        private void buttonTextInput_Click(object sender, EventArgs e)
        {
            this.Hide();
            var textInput = new TextInput(this);
            textInput.Show();


        }

        private void buttonFileInput_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fileInput = new FileInput(this);
            fileInput.Show();

        }

        private void buttonTranslateFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            var translateFileInput = new TranslateFileInput(this);
            translateFileInput.Show();
        }

        private void buttonTranslateText_Click(object sender, EventArgs e)
        {
            this.Hide();
            var translateTextInput = new TranslateTextInput(this);
            translateTextInput.Show();
        }
    }
}
