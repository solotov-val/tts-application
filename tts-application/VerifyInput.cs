using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tts_application
{
    internal class VerifyInput
    {
        public int wordCounter(String text)
        {

            int counter = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == ' ' && Char.IsLetter(text[i + 1]) && (i > 0))
                {
                    counter++;
                }
            }

            counter++;
            return counter;
        }

        public int charCounter(String text)
        {

            int counter = 0;

            foreach (char c in text)
            {
                counter++;
            }
            return counter;
        }
    }
}
