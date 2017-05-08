using KeePassLib.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XKCDPasswordGenerator
{
    class PasswordSequenceConfigurationFactory
    {
        private PasswordSequenceConfiguration psc;
        private CryptoRandomStream crs;
        private CryptoRandomRange crr;
        public PasswordSequenceConfigurationFactory(PasswordSequenceConfiguration psc, CryptoRandomStream crs)
        {
            this.psc = psc;
            this.crs = crs;
            crr = new CryptoRandomRange(crs);
        }

        public string Get_Password()
        {
            string word_result = "";

            if (psc.IsAcrostic)
            {
                for (int i = 0; i < psc.AcrosticWord.Length; i++)
                {
                    string random_word = GetRandomWordFromLetter(psc.AcrosticWord.ToLower()[i]);
                    word_result += i == psc.AcrosticWord.Length - 1 ? random_word + "" : random_word + psc.Delimiter;
                }
            }
            else
            {
                for (int i = 0; i < psc.Word_Count; i++)
                {
                    ulong random_num = crr.GetRandomInRange(0, (ulong)psc.WordList.Length);
                    string random_word = psc.WordList[random_num];
                    word_result += i == psc.Word_Count - 1 ? random_word + "" : random_word + psc.Delimiter;
                }
            }

            return word_result;
        }

        public string GetRandomWordFromLetter(char letter)
        {
            Dictionary<char, List<string>> dictionary = psc.WordDictionary;
            ulong random_num = crr.GetRandomInRange(0, (ulong)dictionary[letter].Count);
            return dictionary[letter][(int)random_num];
        }
    }
}
