using System;
using System.IO;
using System.Threading.Tasks;
using DeepL;

namespace tts_application
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
            string path = "temptranslate.txt";
            //var output = File.Open("temp", FileMode.Create);
            File.WriteAllText(path, temp);
            //output.Close();
        }
    }
}