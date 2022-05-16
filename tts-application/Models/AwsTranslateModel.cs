using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tts_application
{
    public class AwsTranslateModel
    {
        public string InputText { get; set; }

        public string LanguageCode { get; set; }

        public string OutputText { get; set; }

        public enum SupportedLanguages
        {
            fr,
            de,
            en,
            cmn,
            nl,
            it,
            es,
            ja,
            ko,
            pt
        }
    }
}
