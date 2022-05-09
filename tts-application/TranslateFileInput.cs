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
    public partial class TranslateFileInput : Form
    {
        public TranslateFileInput()
        {
            InitializeComponent();
        }

        public String getTranslateLang()
        {
            String language = "TEST";

            return language;
        }

        private void TranslateFileInput_Load(object sender, EventArgs e)
        {

        }
    }
}
