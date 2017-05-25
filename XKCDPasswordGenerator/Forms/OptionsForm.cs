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
        PasswordSequenceConfiguration psc;

        public OptionsForm(PasswordSequenceConfiguration psc)
        {
            InitializeComponent();
            this.psc = psc;
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            LoadWordList();
            SetRadioButtons();
            SetTextFields(); 
        }

        public void LoadWordList()
        {

            txt_Word_List_Location.Text = Properties.Settings.Default.WordListLocation;
            psc.WordList = System.IO.File.ReadAllLines(Properties.Settings.Default.WordListLocation);
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

        private void SetRadioButtons()
        {
            cb_WordCount.Checked = Properties.Settings.Default.IsWordCountEnabled;
            cb_Acrostic.Checked = Properties.Settings.Default.IsAcrostic;
            cb_Delimiter.Checked = Properties.Settings.Default.IsDelimited;
            cb_Max_Chars.Checked = Properties.Settings.Default.IsMaxCharEnabled;
            cb_Min_Chars.Checked = Properties.Settings.Default.IsMinCharEnabled;
        }

        private void SetTextFields()
        {
            txt_WordCount.Text = Properties.Settings.Default.WordCountEnabled_Value.ToString();
            txt_Acrostic.Text = Properties.Settings.Default.Acrostic_Value;
            txt_Delimiter.Text = Properties.Settings.Default.Delimited_Value;
            txt_Max_Chars.Text = Properties.Settings.Default.MaxCharEnabled_Value;
            txt_Min_Chars.Text = Properties.Settings.Default.MinCharEnabled_Value;
        }

        private void btn_OptionFormOK_Click(object sender, EventArgs e)
        {
            psc.IsWordCountEnabled = is_wordcount_enabled();
            psc.IsAcrostic = is_acrostic();
            psc.IsDelimited = is_delimited();
            psc.IsMaxCharEnabled = is_maxchar_enabled();
            psc.IsMinCharEnabled = is_minchar_enabled();

            uint temp_word_count;
            if (uint.TryParse(txt_WordCount.Text, out temp_word_count))
            {
                psc.Word_Count = temp_word_count;
            }

            Properties.Settings.Default.IsWordCountEnabled = psc.IsWordCountEnabled;
            Properties.Settings.Default.IsAcrostic = psc.IsAcrostic;
            Properties.Settings.Default.IsDelimited = psc.IsDelimited;
            Properties.Settings.Default.IsMaxCharEnabled = psc.IsMaxCharEnabled;
            Properties.Settings.Default.IsMinCharEnabled = psc.IsMinCharEnabled;
            Properties.Settings.Default.WordCountEnabled_Value = psc.Word_Count;
            Properties.Settings.Default.Acrostic_Value = txt_Acrostic.Text;
            Properties.Settings.Default.Delimited_Value = txt_Delimiter.Text;

            psc.Delimiter = txt_Delimiter.Text;
            psc.AcrosticWord = txt_Acrostic.Text;

            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void btn_OpenWordList_Click(object sender, EventArgs e)
        {
            if (wordListFileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.WordListLocation = wordListFileDialog.FileName;
                LoadWordList();
            }
        }

        private void txt_WordCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
