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
    public partial class About : Form
    {
        Form menue;
        public About(Form f)
        {
            InitializeComponent();
            this.menue = f;
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menue.Show();
        }
    }
}
