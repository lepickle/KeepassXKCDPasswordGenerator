namespace XKCDPasswordGenerator.Forms
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_Acrostic = new System.Windows.Forms.CheckBox();
            this.txt_Acrostic = new System.Windows.Forms.TextBox();
            this.cb_Delimiter = new System.Windows.Forms.CheckBox();
            this.txt_Delimiter = new System.Windows.Forms.TextBox();
            this.cb_Min_Chars = new System.Windows.Forms.CheckBox();
            this.cb_Max_Chars = new System.Windows.Forms.CheckBox();
            this.txt_Min_Chars = new System.Windows.Forms.TextBox();
            this.txt_Max_Chars = new System.Windows.Forms.TextBox();
            this.txt_Valid_Chars = new System.Windows.Forms.TextBox();
            this.cb_Valid_Chars = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_OptionFormOK = new System.Windows.Forms.Button();
            this.btn_OpenWordList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Word_List_Location = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Word_List_Location);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_OpenWordList);
            this.panel2.Controls.Add(this.btn_OptionFormOK);
            this.panel2.Controls.Add(this.txt_Valid_Chars);
            this.panel2.Controls.Add(this.cb_Valid_Chars);
            this.panel2.Controls.Add(this.txt_Max_Chars);
            this.panel2.Controls.Add(this.txt_Min_Chars);
            this.panel2.Controls.Add(this.cb_Max_Chars);
            this.panel2.Controls.Add(this.cb_Min_Chars);
            this.panel2.Controls.Add(this.txt_Delimiter);
            this.panel2.Controls.Add(this.cb_Delimiter);
            this.panel2.Controls.Add(this.txt_Acrostic);
            this.panel2.Controls.Add(this.cb_Acrostic);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 271);
            this.panel2.TabIndex = 0;
            // 
            // cb_Acrostic
            // 
            this.cb_Acrostic.AutoSize = true;
            this.cb_Acrostic.Location = new System.Drawing.Point(3, 5);
            this.cb_Acrostic.Name = "cb_Acrostic";
            this.cb_Acrostic.Size = new System.Drawing.Size(64, 17);
            this.cb_Acrostic.TabIndex = 1;
            this.cb_Acrostic.Text = "Acrostic";
            this.cb_Acrostic.UseVisualStyleBackColor = true;
            // 
            // txt_Acrostic
            // 
            this.txt_Acrostic.Location = new System.Drawing.Point(87, 3);
            this.txt_Acrostic.Name = "txt_Acrostic";
            this.txt_Acrostic.Size = new System.Drawing.Size(207, 20);
            this.txt_Acrostic.TabIndex = 3;
            // 
            // cb_Delimiter
            // 
            this.cb_Delimiter.AutoSize = true;
            this.cb_Delimiter.Location = new System.Drawing.Point(3, 31);
            this.cb_Delimiter.Name = "cb_Delimiter";
            this.cb_Delimiter.Size = new System.Drawing.Size(66, 17);
            this.cb_Delimiter.TabIndex = 4;
            this.cb_Delimiter.Text = "Delimiter";
            this.cb_Delimiter.UseVisualStyleBackColor = true;
            // 
            // txt_Delimiter
            // 
            this.txt_Delimiter.Location = new System.Drawing.Point(87, 29);
            this.txt_Delimiter.Name = "txt_Delimiter";
            this.txt_Delimiter.Size = new System.Drawing.Size(207, 20);
            this.txt_Delimiter.TabIndex = 5;
            // 
            // cb_Min_Chars
            // 
            this.cb_Min_Chars.AutoSize = true;
            this.cb_Min_Chars.Location = new System.Drawing.Point(3, 57);
            this.cb_Min_Chars.Name = "cb_Min_Chars";
            this.cb_Min_Chars.Size = new System.Drawing.Size(76, 17);
            this.cb_Min_Chars.TabIndex = 6;
            this.cb_Min_Chars.Text = "Min. Chars";
            this.cb_Min_Chars.UseVisualStyleBackColor = true;
            // 
            // cb_Max_Chars
            // 
            this.cb_Max_Chars.AutoSize = true;
            this.cb_Max_Chars.Location = new System.Drawing.Point(3, 83);
            this.cb_Max_Chars.Name = "cb_Max_Chars";
            this.cb_Max_Chars.Size = new System.Drawing.Size(79, 17);
            this.cb_Max_Chars.TabIndex = 7;
            this.cb_Max_Chars.Text = "Max Chars.";
            this.cb_Max_Chars.UseVisualStyleBackColor = true;
            // 
            // txt_Min_Chars
            // 
            this.txt_Min_Chars.Location = new System.Drawing.Point(87, 55);
            this.txt_Min_Chars.Name = "txt_Min_Chars";
            this.txt_Min_Chars.Size = new System.Drawing.Size(207, 20);
            this.txt_Min_Chars.TabIndex = 8;
            // 
            // txt_Max_Chars
            // 
            this.txt_Max_Chars.Location = new System.Drawing.Point(87, 81);
            this.txt_Max_Chars.Name = "txt_Max_Chars";
            this.txt_Max_Chars.Size = new System.Drawing.Size(207, 20);
            this.txt_Max_Chars.TabIndex = 9;
            // 
            // txt_Valid_Chars
            // 
            this.txt_Valid_Chars.Location = new System.Drawing.Point(87, 107);
            this.txt_Valid_Chars.Name = "txt_Valid_Chars";
            this.txt_Valid_Chars.Size = new System.Drawing.Size(207, 20);
            this.txt_Valid_Chars.TabIndex = 11;
            // 
            // cb_Valid_Chars
            // 
            this.cb_Valid_Chars.AutoSize = true;
            this.cb_Valid_Chars.Location = new System.Drawing.Point(3, 109);
            this.cb_Valid_Chars.Name = "cb_Valid_Chars";
            this.cb_Valid_Chars.Size = new System.Drawing.Size(82, 17);
            this.cb_Valid_Chars.TabIndex = 10;
            this.cb_Valid_Chars.Text = "Valid Chars.";
            this.cb_Valid_Chars.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_OptionFormOK
            // 
            this.btn_OptionFormOK.Location = new System.Drawing.Point(198, 245);
            this.btn_OptionFormOK.Name = "btn_OptionFormOK";
            this.btn_OptionFormOK.Size = new System.Drawing.Size(96, 23);
            this.btn_OptionFormOK.TabIndex = 12;
            this.btn_OptionFormOK.Text = "OK";
            this.btn_OptionFormOK.UseVisualStyleBackColor = true;
            // 
            // btn_OpenWordList
            // 
            this.btn_OpenWordList.Location = new System.Drawing.Point(219, 168);
            this.btn_OpenWordList.Name = "btn_OpenWordList";
            this.btn_OpenWordList.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenWordList.TabIndex = 13;
            this.btn_OpenWordList.Text = "Browse";
            this.btn_OpenWordList.UseVisualStyleBackColor = true;
            this.btn_OpenWordList.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Wordlist Location";
            // 
            // txt_Word_List_Location
            // 
            this.txt_Word_List_Location.Location = new System.Drawing.Point(7, 170);
            this.txt_Word_List_Location.Name = "txt_Word_List_Location";
            this.txt_Word_List_Location.ReadOnly = true;
            this.txt_Word_List_Location.Size = new System.Drawing.Size(206, 20);
            this.txt_Word_List_Location.TabIndex = 15;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 287);
            this.Controls.Add(this.panel2);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Max_Chars;
        private System.Windows.Forms.TextBox txt_Min_Chars;
        private System.Windows.Forms.CheckBox cb_Max_Chars;
        private System.Windows.Forms.CheckBox cb_Min_Chars;
        private System.Windows.Forms.TextBox txt_Delimiter;
        private System.Windows.Forms.CheckBox cb_Delimiter;
        private System.Windows.Forms.TextBox txt_Acrostic;
        private System.Windows.Forms.CheckBox cb_Acrostic;
        private System.Windows.Forms.TextBox txt_Valid_Chars;
        private System.Windows.Forms.CheckBox cb_Valid_Chars;
        private System.Windows.Forms.TextBox txt_Word_List_Location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OpenWordList;
        private System.Windows.Forms.Button btn_OptionFormOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}