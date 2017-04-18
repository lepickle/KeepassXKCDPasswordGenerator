using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XKCDPasswordGenerator.Forms
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        PasswordSequenceConfiguration psc = new PasswordSequenceConfiguration();

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            txt_Word_List_Location.Text = Properties.Resources.WordListLocation;
            psc.WordList = System.IO.File.ReadAllLines(Properties.Resources.WordListLocation);
        }

        public PasswordSequenceConfiguration PasswordSequenceConfiguration
        {
            get
            {
                return psc;
            }
        }

        private bool is_wordcount_enabled()
        {
            return cb_WordCount.Checked ? true : false;
        }

        private bool is_acrostic()
        {
            return cb_Acrostic.Checked ? true : false;
        }

        private bool is_delimited()
        {
            return cb_Delimiter.Checked ? true : false;
        }

        private bool is_maxchar_enabled()
        {
            return cb_Max_Chars.Checked ? true : false;
        }

        private bool is_minchar_enabled()
        {
            return cb_Min_Chars.Checked ? true : false;
        }

        private void btn_OptionFormOK_Click(object sender, EventArgs e)
        {
            psc.IsAcrostic = is_acrostic();
            psc.IsDelimited = is_delimited();
            psc.IsMaxCharEnabled = is_maxchar_enabled();
            psc.IsMinCharEnabled = is_minchar_enabled();
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
