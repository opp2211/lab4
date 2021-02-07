using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class VigenerS
    {
        public string Alphabet { get; private set; } = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ,.():-";

        public string Encode(string text, string key, bool enc = true)
        {
            var gamma = GetRepeatKey(key, text.Length);
            var retValue = "";
            var q = Alphabet.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = Alphabet.IndexOf(text[i]);
                var codeIndex = Alphabet.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    //если буква не найдена, добавляем её в исходном виде
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += Alphabet[(q + letterIndex + ((enc ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }

            return retValue;
        }

        string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }

            return p.Substring(0, n);
        }
        public void GenerateAlph()
        {
            Random rand = new Random();

            var chars = Alphabet.ToCharArray();
            for (int i = chars.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i);
                (chars[i], chars[j]) = (chars[j], chars[i]);
            }

            Alphabet = new string(chars);
        }
    }
}
