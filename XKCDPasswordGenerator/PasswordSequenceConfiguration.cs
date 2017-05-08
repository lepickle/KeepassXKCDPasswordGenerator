using KeePassLib.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XKCDPasswordGenerator
{
    public class PasswordSequenceConfiguration
    {
        private bool is_wordcount_enabled;
        private bool is_acrostic;
        private bool is_delimited;
        private bool is_maxchar_enabled;
        private bool is_minchar_enabled;

        private uint word_count;
        private string delimiter;
        private string acrostic_word;

        private readonly uint DEFAULT_NUM_WORD = 6;
        private readonly string  DEFAULT_DELIMITER = " ";
        private string[] word_list;

        private CryptoRandomStream crs;

        private Dictionary<char, List<string>> dictionary = new Dictionary<char, List<string>>();

        public PasswordSequenceConfiguration()
        {

        }

        public string[] WordList
        {
            get
            {
                return word_list;
            }
            set
            {
                word_list = value;
                char last_char = word_list[0].ToCharArray()[0];
                List<string> temp_list = new List<string>();
                foreach (string words in word_list)
                {
                    if (dictionary.ContainsKey(words.ToCharArray()[0]))
                    {
                        dictionary[words.ToCharArray()[0]].Add(words);
                    }
                    else
                    {
                        dictionary[words.ToCharArray()[0]] = new List<string>();
                    }
                }
            }
        }

        public Dictionary<char, List<string>> WordDictionary
        {
            get
            {
                return dictionary;
            }
        }

        public CryptoRandomStream RandomStreamSource
        {
            set
            {
                crs = value;
            }
        }

        public string Delimiter
        {
            get
            {
                if (is_delimited)
                {
                    return delimiter;
                }
                else
                {
                    return DEFAULT_DELIMITER;
                }
            }
            set
            {
                delimiter = value.Length > 0 ? value : DEFAULT_DELIMITER;
            }
        }

        public uint Word_Count
        {
            get
            {
                return is_wordcount_enabled ? word_count : DEFAULT_NUM_WORD;
            }
            set
            {
                word_count = value;
            }
        }

        public string AcrosticWord
        {
            get
            {
                return acrostic_word;
            }
            set
            {
                acrostic_word = value.Length > 0 ? value : "";
            }
        }
        public bool IsWordCountEnabled
        {
            get
            {
                return is_wordcount_enabled;
            }
            set
            {
                is_wordcount_enabled = value;
            }
        }
        public bool IsAcrostic
        {
            get
            {
                return is_acrostic;
            }
            set
            {
                is_acrostic = value;
            }
        }

        public bool IsDelimited
        {
            get
            {
                return is_delimited;
            }
            set
            {
                is_delimited = value;
            }
        }

        public bool IsMaxCharEnabled
        {
            get
            {
                return is_maxchar_enabled;
            }
            set
            {
                is_maxchar_enabled = value;
            }
        }

        public bool IsMinCharEnabled
        {
            get
            {
                return is_minchar_enabled;
            }
            set
            {
                is_minchar_enabled = value;
            }
        }

    }
}
