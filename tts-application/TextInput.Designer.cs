namespace tts_application
{
    partial class TextInput
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
            this.userInput = new System.Windows.Forms.RichTextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.wordAmount = new System.Windows.Forms.Label();
            this.wordCount = new System.Windows.Forms.Label();
            this.limitExcceded = new System.Windows.Forms.Label();
            this.charAmount = new System.Windows.Forms.Label();
            this.charLimitExcceded = new System.Windows.Forms.Label();
            this.charCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(31, 174);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(480, 396);
            this.userInput.TabIndex = 0;
            this.userInput.Text = "";
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(199, 751);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(127, 45);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(563, 173);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(563, 239);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown2.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(563, 685);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 33);
            this.progressBar1.TabIndex = 4;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(635, 751);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(127, 45);
            this.buttonDownload.TabIndex = 5;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            // 
            // wordAmount
            // 
            this.wordAmount.AutoSize = true;
            this.wordAmount.Location = new System.Drawing.Point(26, 600);
            this.wordAmount.Name = "wordAmount";
            this.wordAmount.Size = new System.Drawing.Size(178, 25);
            this.wordAmount.TabIndex = 6;
            this.wordAmount.Text = "Amount of words:";
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Location = new System.Drawing.Point(211, 600);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(0, 25);
            this.wordCount.TabIndex = 7;
            // 
            // limitExcceded
            // 
            this.limitExcceded.AutoSize = true;
            this.limitExcceded.ForeColor = System.Drawing.Color.Red;
            this.limitExcceded.Location = new System.Drawing.Point(26, 625);
            this.limitExcceded.Name = "limitExcceded";
            this.limitExcceded.Size = new System.Drawing.Size(319, 25);
            this.limitExcceded.TabIndex = 8;
            this.limitExcceded.Text = "WORD LIMIT WAS EXCCEDED!";
            // 
            // charAmount
            // 
            this.charAmount.AutoSize = true;
            this.charAmount.Location = new System.Drawing.Point(26, 668);
            this.charAmount.Name = "charAmount";
            this.charAmount.Size = new System.Drawing.Size(174, 25);
            this.charAmount.TabIndex = 9;
            this.charAmount.Text = "Amount of chars:";
            // 
            // charLimitExcceded
            // 
            this.charLimitExcceded.AutoSize = true;
            this.charLimitExcceded.ForeColor = System.Drawing.Color.Red;
            this.charLimitExcceded.Location = new System.Drawing.Point(26, 693);
            this.charLimitExcceded.Name = "charLimitExcceded";
            this.charLimitExcceded.Size = new System.Drawing.Size(312, 25);
            this.charLimitExcceded.TabIndex = 10;
            this.charLimitExcceded.Text = "CHAR LIMIT WAS EXCCEDED!";
            // 
            // charCount
            // 
            this.charCount.AutoSize = true;
            this.charCount.Location = new System.Drawing.Point(199, 668);
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(0, 25);
            this.charCount.TabIndex = 11;
            // 
            // TextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 816);
            this.Controls.Add(this.charCount);
            this.Controls.Add(this.charLimitExcceded);
            this.Controls.Add(this.charAmount);
            this.Controls.Add(this.limitExcceded);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.wordAmount);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.userInput);
            this.Name = "TextInput";
            this.Text = "TextInput";
            this.Load += new System.EventHandler(this.TextInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox userInput;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label wordAmount;
        private System.Windows.Forms.Label wordCount;
        private System.Windows.Forms.Label limitExcceded;
        private System.Windows.Forms.Label charAmount;
        private System.Windows.Forms.Label charLimitExcceded;
        private System.Windows.Forms.Label charCount;
    }
}