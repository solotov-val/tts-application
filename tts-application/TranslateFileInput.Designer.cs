namespace tts_application
{
    partial class TranslateFileInput
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1122, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 44;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1210, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Volume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1210, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Speed";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1215, 506);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 40);
            this.progressBar1.TabIndex = 41;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(1308, 322);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown2.TabIndex = 40;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1308, 270);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 39;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1283, 673);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 45);
            this.button3.TabIndex = 38;
            this.button3.Text = "Download";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // charCount
            // 
            this.charCount.AutoSize = true;
            this.charCount.Location = new System.Drawing.Point(387, 590);
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(0, 25);
            this.charCount.TabIndex = 37;
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Location = new System.Drawing.Point(391, 521);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(0, 25);
            this.wordCount.TabIndex = 36;
            // 
            // charLimitExcceded
            // 
            this.charLimitExcceded.AutoSize = true;
            this.charLimitExcceded.ForeColor = System.Drawing.Color.Red;
            this.charLimitExcceded.Location = new System.Drawing.Point(206, 616);
            this.charLimitExcceded.Name = "charLimitExcceded";
            this.charLimitExcceded.Size = new System.Drawing.Size(312, 25);
            this.charLimitExcceded.TabIndex = 35;
            this.charLimitExcceded.Text = "CHAR LIMIT WAS EXCCEDED!";
            // 
            // limitExcceded
            // 
            this.limitExcceded.AutoSize = true;
            this.limitExcceded.ForeColor = System.Drawing.Color.Red;
            this.limitExcceded.Location = new System.Drawing.Point(206, 547);
            this.limitExcceded.Name = "limitExcceded";
            this.limitExcceded.Size = new System.Drawing.Size(319, 25);
            this.limitExcceded.TabIndex = 34;
            this.limitExcceded.Text = "WORD LIMIT WAS EXCCEDED!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Amount of chars:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Amount of words:";
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(565, 52);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(197, 37);
            this.buttonSwitch.TabIndex = 31;
            this.buttonSwitch.Text = "Switch languages";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(697, 548);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(175, 55);
            this.buttonConvert.TabIndex = 30;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(653, 160);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(400, 320);
            this.rtbOutput.TabIndex = 29;
            this.rtbOutput.Text = "";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(195, 160);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(400, 320);
            this.userInput.TabIndex = 28;
            this.userInput.Text = "";
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(514, 715);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(125, 43);
            this.buttonOpenFile.TabIndex = 45;
            this.buttonOpenFile.Text = "Open file";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // ofdFileInput
            // 
            this.ofdFileInput.FileName = "openFileDialog1";
            // 
            // TranslateFileInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 816);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
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
            this.Name = "TranslateFileInput";
            this.Text = "TranslateFileInput";
            this.Load += new System.EventHandler(this.TranslateFileInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
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
    }
}