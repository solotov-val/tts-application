namespace tts_application
{
    partial class TranslateInput
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
            this.button3 = new System.Windows.Forms.Button();
            this.charCount = new System.Windows.Forms.Label();
            this.wordCount = new System.Windows.Forms.Label();
            this.charLimitExcceded = new System.Windows.Forms.Label();
            this.limitExcceded = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.userInput = new System.Windows.Forms.RichTextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.ofdFileInput = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxInputLanguage = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxOutputLanguage = new System.Windows.Forms.ComboBox();
            this.buttonShowTranslation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(625, 729);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 45);
            this.button3.TabIndex = 38;
            this.button3.Text = "Download";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // charCount
            // 
            this.charCount.AutoSize = true;
            this.charCount.Location = new System.Drawing.Point(359, 696);
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(0, 25);
            this.charCount.TabIndex = 37;
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Location = new System.Drawing.Point(363, 627);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(0, 25);
            this.wordCount.TabIndex = 36;
            // 
            // charLimitExcceded
            // 
            this.charLimitExcceded.AutoSize = true;
            this.charLimitExcceded.ForeColor = System.Drawing.Color.Red;
            this.charLimitExcceded.Location = new System.Drawing.Point(178, 722);
            this.charLimitExcceded.Name = "charLimitExcceded";
            this.charLimitExcceded.Size = new System.Drawing.Size(312, 25);
            this.charLimitExcceded.TabIndex = 35;
            this.charLimitExcceded.Text = "CHAR LIMIT WAS EXCCEDED!";
            // 
            // limitExcceded
            // 
            this.limitExcceded.AutoSize = true;
            this.limitExcceded.ForeColor = System.Drawing.Color.Red;
            this.limitExcceded.Location = new System.Drawing.Point(178, 653);
            this.limitExcceded.Name = "limitExcceded";
            this.limitExcceded.Size = new System.Drawing.Size(319, 25);
            this.limitExcceded.TabIndex = 34;
            this.limitExcceded.Text = "WORD LIMIT WAS EXCCEDED!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(178, 697);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Amount of chars:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(178, 627);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Amount of words:";
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSwitch.ForeColor = System.Drawing.Color.White;
            this.buttonSwitch.Location = new System.Drawing.Point(625, 222);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(200, 45);
            this.buttonSwitch.TabIndex = 31;
            this.buttonSwitch.Text = "Switch languages";
            this.buttonSwitch.UseVisualStyleBackColor = false;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonConvert.ForeColor = System.Drawing.Color.White;
            this.buttonConvert.Location = new System.Drawing.Point(625, 627);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(200, 45);
            this.buttonConvert.TabIndex = 30;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click_1);
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rtbOutput.ForeColor = System.Drawing.Color.White;
            this.rtbOutput.Location = new System.Drawing.Point(625, 286);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(400, 320);
            this.rtbOutput.TabIndex = 29;
            this.rtbOutput.Text = "";
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.userInput.ForeColor = System.Drawing.Color.White;
            this.userInput.Location = new System.Drawing.Point(167, 286);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(400, 320);
            this.userInput.TabIndex = 28;
            this.userInput.Text = "";
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonOpenFile.ForeColor = System.Drawing.Color.White;
            this.buttonOpenFile.Location = new System.Drawing.Point(167, 222);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(175, 44);
            this.buttonOpenFile.TabIndex = 45;
            this.buttonOpenFile.Text = "Open file";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // ofdFileInput
            // 
            this.ofdFileInput.FileName = "openFileDialog1";
            // 
            // comboBoxInputLanguage
            // 
            this.comboBoxInputLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.comboBoxInputLanguage.ForeColor = System.Drawing.Color.White;
            this.comboBoxInputLanguage.FormattingEnabled = true;
            this.comboBoxInputLanguage.Items.AddRange(new object[] {
            "ZH - Chinese",
            "NL - Dutch",
            "EN - English",
            "FR - French",
            "DE - German",
            "IT - Italian",
            "JA - Japanese",
            "ES - Spanish",
            "PT-PT - Portuguese"});
            this.comboBoxInputLanguage.Location = new System.Drawing.Point(167, 117);
            this.comboBoxInputLanguage.Name = "comboBoxInputLanguage";
            this.comboBoxInputLanguage.Size = new System.Drawing.Size(407, 33);
            this.comboBoxInputLanguage.TabIndex = 47;
            this.comboBoxInputLanguage.Text = "Language";
            this.comboBoxInputLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxSprache_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 45);
            this.button2.TabIndex = 49;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxOutputLanguage
            // 
            this.comboBoxOutputLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.comboBoxOutputLanguage.ForeColor = System.Drawing.Color.White;
            this.comboBoxOutputLanguage.FormattingEnabled = true;
            this.comboBoxOutputLanguage.Items.AddRange(new object[] {
            "ZH - Chinese",
            "NL - Dutch",
            "EN - English",
            "FR - French",
            "DE - German",
            "IT - Italian",
            "JA - Japanese",
            "ES - Spanish",
            "PT-PT - Portuguese"});
            this.comboBoxOutputLanguage.Location = new System.Drawing.Point(618, 117);
            this.comboBoxOutputLanguage.Name = "comboBoxOutputLanguage";
            this.comboBoxOutputLanguage.Size = new System.Drawing.Size(407, 33);
            this.comboBoxOutputLanguage.TabIndex = 50;
            this.comboBoxOutputLanguage.Text = "Language";
            this.comboBoxOutputLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutputLanguage_SelectedIndexChanged);
            // 
            // buttonShowTranslation
            // 
            this.buttonShowTranslation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonShowTranslation.ForeColor = System.Drawing.Color.White;
            this.buttonShowTranslation.Location = new System.Drawing.Point(624, 678);
            this.buttonShowTranslation.Name = "buttonShowTranslation";
            this.buttonShowTranslation.Size = new System.Drawing.Size(201, 45);
            this.buttonShowTranslation.TabIndex = 51;
            this.buttonShowTranslation.Text = "Show translation";
            this.buttonShowTranslation.UseVisualStyleBackColor = false;
            this.buttonShowTranslation.Click += new System.EventHandler(this.buttonShowTranslation_Click);
            // 
            // TranslateInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1172, 828);
            this.Controls.Add(this.buttonShowTranslation);
            this.Controls.Add(this.comboBoxOutputLanguage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxInputLanguage);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.charCount);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.charLimitExcceded);
            this.Controls.Add(this.limitExcceded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.userInput);
            this.Name = "TranslateInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TranslateFileInput";
            this.Load += new System.EventHandler(this.TranslateFileInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label charCount;
        private System.Windows.Forms.Label wordCount;
        private System.Windows.Forms.Label charLimitExcceded;
        private System.Windows.Forms.Label limitExcceded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.RichTextBox userInput;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog ofdFileInput;
        private System.Windows.Forms.ComboBox comboBoxInputLanguage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxOutputLanguage;
        private System.Windows.Forms.Button buttonShowTranslation;
    }
}