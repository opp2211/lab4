using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab4
{
    public class FileRW
    {
        CaesarS caesarS;
        VigenerS vigenerS;
        public string Full_fn { get; set; }
        public string Short_fn
        {
            get
            {
                return Full_fn.Substring(Full_fn.LastIndexOf("\\") + 1);
            }
        }
        string fDir
        {
            get
            {
                return Full_fn.Substring(0, Full_fn.LastIndexOf("\\") + 1);
            }
        }

        public string OrigT { get; private set; }

        public string EncT { get; private set; }
        public string DecT { get; private set; }

        public FileRW()
        {
            caesarS = new CaesarS();
            vigenerS = new VigenerS();
        }

        public void ReloadOrigT()
        {
            using (StreamReader sr = new StreamReader(Full_fn))
            {
                OrigT = sr.ReadToEnd().ToLower();
            }
        }

        public void CaesarStart(int cVal)
        {
            EncT = caesarS.Encode(OrigT, cVal);
            DecT = caesarS.Encode(EncT, -cVal);

            Save_EncDec('C');
        }
        public void VigenerStart(string key)
        {
            EncT = vigenerS.Encode(OrigT, key);
            DecT = vigenerS.Encode(EncT, key, false);

            Save_EncDec('V');
        }

        public string GetVigAlph()
        {
            return vigenerS.Alphabet;
        }
        public void GenerateVigAlph()
        {
            vigenerS.GenerateAlph();
        }

        void Save_EncDec(char m)
        {
            using (StreamWriter sw = new StreamWriter(fDir + "Enc" + m + "_" + Short_fn, false))
            {
                sw.Write(EncT);
            }
            using (StreamWriter sw = new StreamWriter(fDir + "Dec" + m + "_" + Short_fn, false))
            {
                sw.Write(DecT);
            }
        }
    }
}
