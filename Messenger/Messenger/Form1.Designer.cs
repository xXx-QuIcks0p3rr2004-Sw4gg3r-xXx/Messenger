namespace Messenger
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
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.NewChatButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.MessageListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(12, 38);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(120, 329);
            this.ContactsListBox.TabIndex = 0;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.MessageTextBox.Location = new System.Drawing.Point(138, 347);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(596, 20);
            this.MessageTextBox.TabIndex = 1;
            this.MessageTextBox.Text = "Type a Message";
            this.MessageTextBox.Click += new System.EventHandler(this.MessageTextBox_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(740, 345);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(89, 23);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send Message";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // NewChatButton
            // 
            this.NewChatButton.Location = new System.Drawing.Point(12, 12);
            this.NewChatButton.Name = "NewChatButton";
            this.NewChatButton.Size = new System.Drawing.Size(120, 23);
            this.NewChatButton.TabIndex = 3;
            this.NewChatButton.Text = "New Chat";
            this.NewChatButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(754, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // MessageListBox
            // 
            this.MessageListBox.FormattingEnabled = true;
            this.MessageListBox.Location = new System.Drawing.Point(138, 41);
            this.MessageListBox.Name = "MessageListBox";
            this.MessageListBox.Size = new System.Drawing.Size(691, 303);
            this.MessageListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 383);
            this.Controls.Add(this.MessageListBox);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.NewChatButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ContactsListBox);
            this.Name = "Form1";
            this.Text = "Messenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button NewChatButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.ListBox MessageListBox;
    }
}

