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
        private string[] word_list;

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
            }
        }

        public uint Word_Count
        {
            get
            {
                return word_count;
            }
            set
            {
                word_count = value;
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
