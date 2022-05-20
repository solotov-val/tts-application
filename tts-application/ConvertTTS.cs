using Amazon.Polly;
using Amazon.Polly.Model;
using System;
using System.IO;
using System.Threading.Tasks;

namespace tts_application
{
    internal class ConvertTTS
    {
        public static async Task <String> Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Please provide text file, language code, and voice id.");
                Console.ReadLine();
                return "ERROR";
            }

            var fileName = args[0];
            var langCode = args[1];
            var voiceId = args[2];

            try
            {
                await ConvertTextToAudio(fileName, langCode, voiceId);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception caught:\n{0}", e);
                Console.ReadLine();
            }
            return "";
        }

        public static async Task ConvertTextToAudio(string fileName, string targetLanguageCode, string voiceId)
        {
            var text = File.ReadAllText(fileName);
            var voice = VoiceId.FindValue(voiceId);
            var outputFileName = $"{fileName}-{targetLanguageCode}"+DateTime.Now.ToString().Replace(":", " - ").Replace(" ", "_")+".mp3";
            File.WriteAllText("filename.txt", outputFileName);

            using (var pollyClient = new AmazonPollyClient(Amazon.RegionEndpoint.USEast1))
            {
                var speechRequest = new SynthesizeSpeechRequest
                {
                    LanguageCode = targetLanguageCode,
                    Text = text,
                    OutputFormat = OutputFormat.Mp3,
                    VoiceId = voice
                };
                

                var speechResponse = await pollyClient.SynthesizeSpeechAsync(speechRequest);
                var output = File.Open(outputFileName, FileMode.Create);
                speechResponse.AudioStream.CopyTo(output);
                output.Close();

            }
        }
    }
}
