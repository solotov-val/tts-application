using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarrenLee.Translator;
using System.Windows.Forms;

namespace tts_application
{
    internal class Translate
    {
        string translation = Translator.Translate("Hello this is a test.", "en", "de");
        //MessageBox.Show("translation: " + translate);
    }
}
