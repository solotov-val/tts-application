namespace tts_application
{
    partial class Menue
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
            this.buttonTextInput = new System.Windows.Forms.Button();
            this.buttonFileInput = new System.Windows.Forms.Button();
            this.buttonTranslateText = new System.Windows.Forms.Button();
            this.buttonTranslateFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTextInput
            // 
            this.buttonTextInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonTextInput.ForeColor = System.Drawing.Color.White;
            this.buttonTextInput.Location = new System.Drawing.Point(271, 114);
            this.buttonTextInput.Name = "buttonTextInput";
            this.buttonTextInput.Size = new System.Drawing.Size(250, 45);
            this.buttonTextInput.TabIndex = 0;
            this.buttonTextInput.Text = "Text Input";
            this.buttonTextInput.UseVisualStyleBackColor = false;
            this.buttonTextInput.Click += new System.EventHandler(this.buttonTextInput_Click);
            // 
            // buttonFileInput
            // 
            this.buttonFileInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonFileInput.ForeColor = System.Drawing.Color.White;
            this.buttonFileInput.Location = new System.Drawing.Point(271, 165);
            this.buttonFileInput.Name = "buttonFileInput";
            this.buttonFileInput.Size = new System.Drawing.Size(250, 45);
            this.buttonFileInput.TabIndex = 1;
            this.buttonFileInput.Text = "File Input";
            this.buttonFileInput.UseVisualStyleBackColor = false;
            this.buttonFileInput.Click += new System.EventHandler(this.buttonFileInput_Click);
            // 
            // buttonTranslateText
            // 
            this.buttonTranslateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonTranslateText.ForeColor = System.Drawing.Color.White;
            this.buttonTranslateText.Location = new System.Drawing.Point(271, 374);
            this.buttonTranslateText.Name = "buttonTranslateText";
            this.buttonTranslateText.Size = new System.Drawing.Size(250, 45);
            this.buttonTranslateText.TabIndex = 3;
            this.buttonTranslateText.Text = "Translate text input";
            this.buttonTranslateText.UseVisualStyleBackColor = false;
            this.buttonTranslateText.Click += new System.EventHandler(this.buttonTranslateText_Click);
            // 
            // buttonTranslateFile
            // 
            this.buttonTranslateFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonTranslateFile.ForeColor = System.Drawing.Color.White;
            this.buttonTranslateFile.Location = new System.Drawing.Point(271, 323);
            this.buttonTranslateFile.Name = "buttonTranslateFile";
            this.buttonTranslateFile.Size = new System.Drawing.Size(250, 45);
            this.buttonTranslateFile.TabIndex = 2;
            this.buttonTranslateFile.Text = "Translate file input";
            this.buttonTranslateFile.UseVisualStyleBackColor = false;
            this.buttonTranslateFile.Click += new System.EventHandler(this.buttonTranslateFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text To Speech";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text To Speech + translation";
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Location = new System.Drawing.Point(27, 165);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(112, 45);
            this.buttonAbout.TabIndex = 6;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTranslateFile);
            this.Controls.Add(this.buttonTranslateText);
            this.Controls.Add(this.buttonFileInput);
            this.Controls.Add(this.buttonTextInput);
            this.Name = "Menue";
            this.Text = "Menue";
            this.Load += new System.EventHandler(this.Menue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTextInput;
        private System.Windows.Forms.Button buttonFileInput;
        private System.Windows.Forms.Button buttonTranslateText;
        private System.Windows.Forms.Button buttonTranslateFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button button1;
    }
}