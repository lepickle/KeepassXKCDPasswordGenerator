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

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            txt_Word_List_Location.Text = Properties.Resources.WordListLocation;
            string[] lines = System.IO.File.ReadAllLines(Properties.Resources.WordListLocation);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
