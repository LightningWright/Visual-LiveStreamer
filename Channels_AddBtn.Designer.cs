namespace VLSSharp
{
    partial class Channels_AddBtn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Channels_AddBtn));
            this.urlBox = new System.Windows.Forms.TextBox();
            this.svcComboBox = new System.Windows.Forms.ComboBox();
            this.qltyComboBox = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(12, 12);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(124, 20);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = "Video URL";
            this.urlBox.TextChanged += new System.EventHandler(this.urlBox_TextChanged);
            // 
            // svcComboBox
            // 
            this.svcComboBox.FormattingEnabled = true;
            this.svcComboBox.Items.AddRange(new object[] {
            "Twitch",
            "YouTube",
            "uStream"});
            this.svcComboBox.Location = new System.Drawing.Point(142, 11);
            this.svcComboBox.Name = "svcComboBox";
            this.svcComboBox.Size = new System.Drawing.Size(101, 21);
            this.svcComboBox.TabIndex = 1;
            this.svcComboBox.Text = "Choose Service";
            this.svcComboBox.SelectedIndexChanged += new System.EventHandler(this.svcComboBox_SelectedIndexChanged);
            // 
            // qltyComboBox
            // 
            this.qltyComboBox.FormattingEnabled = true;
            this.qltyComboBox.Location = new System.Drawing.Point(249, 12);
            this.qltyComboBox.Name = "qltyComboBox";
            this.qltyComboBox.Size = new System.Drawing.Size(98, 21);
            this.qltyComboBox.TabIndex = 2;
            this.qltyComboBox.Text = "Choose Quality";
            this.qltyComboBox.SelectedIndexChanged += new System.EventHandler(this.qltyComboBox_SelectedIndexChanged);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(353, 12);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(40, 21);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "Save";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // Channels_AddBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 47);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.qltyComboBox);
            this.Controls.Add(this.svcComboBox);
            this.Controls.Add(this.urlBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Channels_AddBtn";
            this.Text = "Channel_AddBtn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.ComboBox svcComboBox;
        private System.Windows.Forms.ComboBox qltyComboBox;
        private System.Windows.Forms.Button okBtn;
    }
}