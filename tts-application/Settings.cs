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
    public partial class Settings : Form
    {
        Form menue;
        public Settings(Form f)
        {
            InitializeComponent();
            this.menue = f;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            String language = comboBoxLanguage.SelectedItem.ToString();
        }
    }
}
