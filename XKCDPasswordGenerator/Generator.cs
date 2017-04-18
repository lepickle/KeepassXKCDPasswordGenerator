﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KeePassLib;
using KeePassLib.Cryptography;
using KeePassLib.Cryptography.PasswordGenerator;
using KeePassLib.Security;

using XKCDPasswordGenerator.Forms;

namespace XKCDPasswordGenerator
{
    public class Generator : CustomPwGenerator
    {
        private static readonly PwUuid UUID = new PwUuid(Guid.NewGuid().ToByteArray());
        PasswordSequenceConfiguration psc = new PasswordSequenceConfiguration();

        public override PwUuid Uuid
        {
            get
            {
                return UUID;
            }
        }

        public override string Name
        {
            get
            {
                return "XKCDPasswordGenerator";
            }
        }

        public override bool SupportsOptions
        {
            get
            {
                return true;
            }
        }

        public override string GetOptions(string strCurrentOptions)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog();

            if (optionsForm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                psc = optionsForm.PasswordSequenceConfiguration;
            }

            return "";
            
        }

        public override ProtectedString Generate(PwProfile prf, CryptoRandomStream crsRandomSource)
        {
            return new ProtectedString(true, ChooseWords(psc.WordList, 6, crsRandomSource));
        }

        public string ChooseWords(string[] wordlist, uint numwords, CryptoRandomStream crs)
        {
            CryptoRandomRange crr = new CryptoRandomRange(crs);
            Random rnd = new Random();
            string word_result = "";
            for(int i = 0; i < numwords; i++)
            {
                ulong random_num = crr.GetRandomInRange(0, (ulong)wordlist.Length);
                //int random_num = rnd.Next(0, wordlist.Length);
                word_result += i == numwords-1 ? wordlist[random_num] + "" : wordlist[random_num] + " ";
            }
            return word_result;
        }
    }
}
