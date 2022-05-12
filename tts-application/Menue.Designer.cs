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
            this.SuspendLayout();
            // 
            // buttonTextInput
            // 
            this.buttonTextInput.Location = new System.Drawing.Point(189, 198);
            this.buttonTextInput.Name = "buttonTextInput";
            this.buttonTextInput.Size = new System.Drawing.Size(155, 41);
            this.buttonTextInput.TabIndex = 0;
            this.buttonTextInput.Text = "Text Input";
            this.buttonTextInput.UseVisualStyleBackColor = true;
            this.buttonTextInput.Click += new System.EventHandler(this.buttonTextInput_Click);
            // 
            // buttonFileInput
            // 
            this.buttonFileInput.Location = new System.Drawing.Point(433, 198);
            this.buttonFileInput.Name = "buttonFileInput";
            this.buttonFileInput.Size = new System.Drawing.Size(144, 47);
            this.buttonFileInput.TabIndex = 1;
            this.buttonFileInput.Text = "File Input";
            this.buttonFileInput.UseVisualStyleBackColor = true;
            this.buttonFileInput.Click += new System.EventHandler(this.buttonFileInput_Click);
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFileInput);
            this.Controls.Add(this.buttonTextInput);
            this.Name = "Menue";
            this.Text = "Menue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTextInput;
        private System.Windows.Forms.Button buttonFileInput;
    }
}