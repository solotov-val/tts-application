namespace tts_application
{
    partial class FileInput
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.limitExcceded = new System.Windows.Forms.Label();
            this.charLimitExcceded = new System.Windows.Forms.Label();
            this.wordCounter = new System.Windows.Forms.Label();
            this.charCounter = new System.Windows.Forms.Label();
            this.ofdFileInput = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(109, 188);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 320);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonOpenFile.ForeColor = System.Drawing.Color.White;
            this.buttonOpenFile.Location = new System.Drawing.Point(109, 664);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(125, 45);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open file";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonConvert.ForeColor = System.Drawing.Color.White;
            this.buttonConvert.Location = new System.Drawing.Point(391, 664);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(125, 45);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(607, 596);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Download";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(700, 268);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.numericUpDown2.ForeColor = System.Drawing.Color.White;
            this.numericUpDown2.Location = new System.Drawing.Point(700, 320);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown2.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(700, 538);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 40);
            this.progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(602, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(602, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Volume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount of words:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amount of chars:";
            // 
            // limitExcceded
            // 
            this.limitExcceded.AutoSize = true;
            this.limitExcceded.ForeColor = System.Drawing.Color.Red;
            this.limitExcceded.Location = new System.Drawing.Point(104, 553);
            this.limitExcceded.Name = "limitExcceded";
            this.limitExcceded.Size = new System.Drawing.Size(319, 25);
            this.limitExcceded.TabIndex = 11;
            this.limitExcceded.Text = "WORD LIMIT WAS EXCCEDED!";
            // 
            // charLimitExcceded
            // 
            this.charLimitExcceded.AutoSize = true;
            this.charLimitExcceded.ForeColor = System.Drawing.Color.Red;
            this.charLimitExcceded.Location = new System.Drawing.Point(104, 622);
            this.charLimitExcceded.Name = "charLimitExcceded";
            this.charLimitExcceded.Size = new System.Drawing.Size(312, 25);
            this.charLimitExcceded.TabIndex = 12;
            this.charLimitExcceded.Text = "CHAR LIMIT WAS EXCCEDED!";
            // 
            // wordCounter
            // 
            this.wordCounter.AutoSize = true;
            this.wordCounter.Location = new System.Drawing.Point(289, 527);
            this.wordCounter.Name = "wordCounter";
            this.wordCounter.Size = new System.Drawing.Size(0, 25);
            this.wordCounter.TabIndex = 13;
            // 
            // charCounter
            // 
            this.charCounter.AutoSize = true;
            this.charCounter.Location = new System.Drawing.Point(285, 596);
            this.charCounter.Name = "charCounter";
            this.charCounter.Size = new System.Drawing.Size(0, 25);
            this.charCounter.TabIndex = 14;
            // 
            // ofdFileInput
            // 
            this.ofdFileInput.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(607, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FileInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(974, 764);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.charCounter);
            this.Controls.Add(this.wordCounter);
            this.Controls.Add(this.charLimitExcceded);
            this.Controls.Add(this.limitExcceded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FileInput";
            this.Text = "FileInput";
            this.Load += new System.EventHandler(this.FileInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label limitExcceded;
        private System.Windows.Forms.Label charLimitExcceded;
        private System.Windows.Forms.Label wordCounter;
        private System.Windows.Forms.Label charCounter;
        private System.Windows.Forms.OpenFileDialog ofdFileInput;
        private System.Windows.Forms.Button button1;
    }
}