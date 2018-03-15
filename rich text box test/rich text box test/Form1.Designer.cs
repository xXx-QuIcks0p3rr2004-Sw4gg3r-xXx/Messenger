namespace rich_text_box_test
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonlinks = new System.Windows.Forms.Button();
            this.buttonrechts = new System.Windows.Forms.Button();
            this.textBoxlinks = new System.Windows.Forms.TextBox();
            this.textBoxrechts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 173);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonlinks
            // 
            this.buttonlinks.Location = new System.Drawing.Point(12, 229);
            this.buttonlinks.Name = "buttonlinks";
            this.buttonlinks.Size = new System.Drawing.Size(77, 20);
            this.buttonlinks.TabIndex = 1;
            this.buttonlinks.Text = "button1";
            this.buttonlinks.UseVisualStyleBackColor = true;
            this.buttonlinks.Click += new System.EventHandler(this.buttonlinks_Click);
            // 
            // buttonrechts
            // 
            this.buttonrechts.Location = new System.Drawing.Point(195, 229);
            this.buttonrechts.Name = "buttonrechts";
            this.buttonrechts.Size = new System.Drawing.Size(77, 20);
            this.buttonrechts.TabIndex = 2;
            this.buttonrechts.Text = "button2";
            this.buttonrechts.UseVisualStyleBackColor = true;
            this.buttonrechts.Click += new System.EventHandler(this.buttonrechts_Click);
            // 
            // textBoxlinks
            // 
            this.textBoxlinks.Location = new System.Drawing.Point(12, 203);
            this.textBoxlinks.Name = "textBoxlinks";
            this.textBoxlinks.Size = new System.Drawing.Size(100, 20);
            this.textBoxlinks.TabIndex = 3;
            // 
            // textBoxrechts
            // 
            this.textBoxrechts.Location = new System.Drawing.Point(172, 203);
            this.textBoxrechts.Name = "textBoxrechts";
            this.textBoxrechts.Size = new System.Drawing.Size(100, 20);
            this.textBoxrechts.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxrechts);
            this.Controls.Add(this.textBoxlinks);
            this.Controls.Add(this.buttonrechts);
            this.Controls.Add(this.buttonlinks);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "r";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonlinks;
        private System.Windows.Forms.Button buttonrechts;
        private System.Windows.Forms.TextBox textBoxlinks;
        private System.Windows.Forms.TextBox textBoxrechts;
    }
}

