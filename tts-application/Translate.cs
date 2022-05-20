using System;
using System.Threading.Tasks;
using DeepL;

namespace tts_application
{
    internal class Translate
    {
        static async Task Main(string[] args)
        {
            //parameters
            //--------------------------
            //authKey
            //source_lang (optional)
            //"BG" - Bulgarian
            //"CS" - Czech
            //"DA" - Danish
            //"DE" - German
            //"EL" - Greek
            //"EN" - English
            //"ES" - Spanish
            //"ET" - Estonian
            //"FI" - Finnish
            //"FR" - French
            //"HU" - Hungarian
            //"ID" - Indonesian
            //"IT" - Italian
            //"JA" - Japanese
            //"LT" - Lithuanian
            //"LV" - Latvian
            //"NL" - Dutch
            //"PL" - Polish
            //"PT" - Portuguese
            //"RO" - Romanian
            //"RU" - Russian
            //"SK" - Slovak
            //"SL" - Slovenian
            //"SV" - Swedish
            //"TR" - Turkish
            //"ZH" - Chinese
            //target_lang (required)
            //"BG" - Bulgarian
            //"CS" - Czech
            //"DA" - Danish
            //"DE" - German
            //"EL" - Greek
            //"EN-GB" - English(British)
            //"EN-US" - English(American)
            //"ES" - Spanish
            //"ET" - Estonian
            //"FI" - Finnish
            //"FR" - French
            //"HU" - Hungarian
            //"ID" - Indonesian
            //"IT" - Italian
            //"JA" - Japanese
            //"LT" - Lithuanian
            //"LV" - Latvian
            //"NL" - Dutch
            //"PL" - Polish
            //"PT-PT" - Portuguese
            //"PT-BR" - Portuguese(Brazilian)
            //"RO" - Romanian
            //"RU" - Russian
            //"SK" - Slovak
            //"SL" - Slovenian
            //"SV" - Swedish
            //"TR" - Turkish
            //"ZH" - Chinese
            //split_sentences (optional)
            //"0" - no splitting at all, whole input is treated as one sentence
            //"1" (default) - splits on punctuation and on newlines
            //"nonewlines" - splits on punctuation only, ignoring newlines

            var authKey = "48b840d9-957f-e91b-ff3d-d5616d26a7b3:fx"; //von datei auslesen
            var translator = new Translator(authKey);
            // Translate text into a target language, in this case, French:
            string source = "Hello world!";

            string textInput="";
            string inputLanguage="";
            string outputLanguage="";

            var translatedText = await translator.TranslateTextAsync(textInput, inputLanguage, outputLanguage);

            Console.WriteLine("Source: " + source);
            Console.WriteLine("Translated: " + translatedText + "\n");

            /*
            string first_lang = "お元気ですか？";
            string second_lang = "¿Cómo estás?";
            // Translate multiple texts into British English:
            var translations = await translator.TranslateTextAsync(
                  new[] { first_lang, second_lang }, null, "EN-GB");
            Console.WriteLine("First Input: "
                    + first_lang
                    + "\tTranslation: "
                    + translations[0].Text); // "How are you?"
            Console.WriteLine("Detected languagecode: "
                    + translations[0].DetectedSourceLanguageCode + "\n"); // "JA"

            Console.WriteLine("Second Input: "
                    + second_lang
                    + "\tTranslation: "
                    + translations[1].Text); // "How are you?"
            Console.WriteLine("Detected languagecode: "
                    + translations[1].DetectedSourceLanguageCode + "\n"); // "ES"
            */
            Console.ReadLine();
        }
    }
}
