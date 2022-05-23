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
            bool writeSuccessful = false;
            var outputFileName = "tempfile.txt";

            try
            {
                File.WriteAllText(outputFileName, text, Encoding.UTF8);
                writeSuccessful = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Temporary file could not be saved!");
            }

            if (writeSuccessful == true)
            {
                String[] args = { outputFileName, language, speaker };
                _ = ConvertTTS.Main(args);
            }

            return "ERROR API-HELP-CLASS";
        }

        public static String translate(String authKey, String inputLang, String outputLang, String text)
        {
            bool writeSuccessful = false;
            var outputFileName = "tempfile2_" + DateTime.Now.ToString().Replace(":", "-").Replace(" ", "_") + ".txt";
            //authKey = "48b840d9-957fe91b-ff3d-d5616d26a7b3:fx";

            try
            {
                File.WriteAllText(outputFileName, text, Encoding.UTF8);
                writeSuccessful = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Temporary file could not be saved!");
            }

            if (writeSuccessful == true)
            {
                String[] args = { authKey, outputFileName, inputLang, outputLang };
                _ = Translate.Main(args);
            }

            return "ERROR API-HELP-CLASS";
        }
    }
}