using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using DeepL;
using Microsoft.Win32;

namespace XamlUI.MVVM.Model
{
    internal class Translate
    {
        public static async Task Main(string[] args)
        {
            if (args.Length != 4)
            {
                Console.WriteLine("Please provide authKey, textInput, inputLanguage, outputLanguage.");
                Console.ReadLine();
                return;
            }

            var authKey = args[0];
            var fileName = args[1];
            var inputLanguage = args[2];
            var outputLanguage = args[3];

            try
            {
                await TranslateText(authKey, fileName, inputLanguage, outputLanguage);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception caught:\n{0}", e);
                Console.ReadLine();
            }
        }

        public static async Task TranslateText(string authKey, string fileName, string inputLanguage, string outputLanguage)
        {
            var key = authKey;
            var input = File.ReadAllText(fileName);
            var inputLang = inputLanguage;
            var outputLang = outputLanguage;

            var translator = new Translator(key);

            var translatedText = await translator.TranslateTextAsync(input, inputLang, outputLang);
            
            string temp = translatedText.ToString();
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
          
            String path = System.AppDomain.CurrentDomain.BaseDirectory + "temptranslate.txt";
            //var output = File.Open("temp", FileMode.Create);
            try
            {
                File.WriteAllText(path, temp);
            }
            catch(FileNotFoundException exception)
            {
                MessageBox.Show(exception.Message);
            }
            //output.Close();
        }

        public string GetDownloadFolderPath()
        {
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
        }
    }
}
