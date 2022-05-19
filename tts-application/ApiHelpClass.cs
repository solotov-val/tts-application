using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tts_application
{
    internal class ApiHelpClass
    {
        public static String tts(String language, String speaker, String text)
        {
            bool writeSuccessful=false;
            var outputFileName = "tempfile.txt";

            try
            {
                File.WriteAllText(outputFileName, text, Encoding.UTF8);
                writeSuccessful=true;
            }
            catch (Exception)
            {
                MessageBox.Show("Temporary file could not be saved!");
            }

            if(writeSuccessful==true)
            {
                String[] args = {outputFileName, language, speaker};
                _ = ConvertTTS.Main(args);
            }

            return "ERROR API-HELP-CLASS";
        }
    }
}
