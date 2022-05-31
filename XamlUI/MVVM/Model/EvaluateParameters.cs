using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlUI.MVVM.Model
{
    internal class EvaluateParameters
    {

        public String evaluateSpeaker(String choosenLanguage)
        {
            String speaker="";

            switch (choosenLanguage)
            {
                case "cmn-CN":
                    speaker = "Zhiyu";
                    break;

                case "de-DE":
                    speaker = "Marlene Vicki Hans";
                    break;

                case "en-GB":
                    speaker = "Amy Emma Brian";
                    break;

                case "fr-FR":
                    speaker = "Celine Léa Mathieu";
                    break;

                case "nl-NL":
                    speaker = "Lotte Ruben";
                    break;

                case "it-IT":
                    speaker = "Carla Bianca Giorgio";
                    break;

                case "es-ES":
                    speaker = "Conchita, Lucia, Enrique";
                    break;

                case "ja-JA":
                    speaker = "Mizuki Takumi";
                    break;

                case "ko-KR":
                    speaker = "Seoyeon";
                    break;

                case "pt-PT":
                    speaker = "Ines Cristiano";
                    break;
            }
            return speaker;
        }

        public String evaluateLanguage(String chosenlanguage)
        {
            String language = "";
            switch (chosenlanguage)
            {
                case "cmn-CN":
                    language = "CN";
                    break;

                case "de-DE":
                    language = "DE";
                    break;

                case "en-GB":
                    language = "EN";
                    break;

                case "fr-FR":
                    language = "FR";
                    break;

                case "nl-NL":
                    language = "NL";
                    break;

                case "it-IT":
                    language = "IT";
                    break;

                case "es-ES":
                    language = "ES";
                    break;

                case "ja-JA":
                    language = "JA";
                    break;

                case "ko-KR":
                    language = "KR";
                    break;

                case "pt-PT":
                    language = "PT";
                    break;
            }
            return language;
        }
    }
}
