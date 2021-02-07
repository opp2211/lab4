using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class CaesarS
    {
        string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ,.():-";
        public string Encode(string text, int K)
        {
            string result = "";

            int qty = alphabet.Length;

            for (int i = 0; i < text.Length; i++)
            {
                int index = alphabet.IndexOf(text[i]);
                if (index < 0)
                {
                    result += text[i];
                }
                else
                {
                    int newindex = (qty + index + K) % qty;
                    result += alphabet[newindex];
                }
            }

            return result;
        }
    }
}
