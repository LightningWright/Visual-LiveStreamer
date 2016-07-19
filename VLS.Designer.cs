namespace VLSSharp
{
    partial class VLS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VLS));
            this.btn_url = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.svc_comboBox = new System.Windows.Forms.ComboBox();
            this.qlty_comboBox = new System.Windows.Forms.ComboBox();
            this.mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_url
            // 
            resources.ApplyResources(this.btn_url, "btn_url");
            this.btn_url.Name = "btn_url";
            this.btn_url.UseVisualStyleBackColor = true;
            this.btn_url.Click += new System.EventHandler(this.btn_url_Click);
            // 
            // urlBox
            // 
            resources.ApplyResources(this.urlBox, "urlBox");
            this.urlBox.Name = "urlBox";
            this.urlBox.TextChanged += new System.EventHandler(this.urlBox_TextChanged);
            // 
            // mainmenu
            // 
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.mainmenu, "mainmenu");
            this.mainmenu.Name = "mainmenu";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            resources.ApplyResources(this.programToolStripMenuItem, "programToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            resources.ApplyResources(this.debugToolStripMenuItem, "debugToolStripMenuItem");
            // 
            // activateToolStripMenuItem
            // 
            this.activateToolStripMenuItem.Name = "activateToolStripMenuItem";
            resources.ApplyResources(this.activateToolStripMenuItem, "activateToolStripMenuItem");
            this.activateToolStripMenuItem.Click += new System.EventHandler(this.activateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // svc_comboBox
            // 
            this.svc_comboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.svc_comboBox.FormattingEnabled = true;
            this.svc_comboBox.Items.AddRange(new object[] {
            resources.GetString("svc_comboBox.Items"),
            resources.GetString("svc_comboBox.Items1"),
            resources.GetString("svc_comboBox.Items2")});
            resources.ApplyResources(this.svc_comboBox, "svc_comboBox");
            this.svc_comboBox.Name = "svc_comboBox";
            this.svc_comboBox.SelectedIndexChanged += new System.EventHandler(this.svc_comboBox_SelectedIndexChanged);
            // 
            // qlty_comboBox
            // 
            this.qlty_comboBox.FormattingEnabled = true;
            this.qlty_comboBox.Items.AddRange(new object[] {
            resources.GetString("qlty_comboBox.Items"),
            resources.GetString("qlty_comboBox.Items1"),
            resources.GetString("qlty_comboBox.Items2")});
            resources.ApplyResources(this.qlty_comboBox, "qlty_comboBox");
            this.qlty_comboBox.Name = "qlty_comboBox";
            this.qlty_comboBox.SelectedIndexChanged += new System.EventHandler(this.qlty_comboBox_SelectedIndexChanged);
            // 
            // VLS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.qlty_comboBox);
            this.Controls.Add(this.svc_comboBox);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.btn_url);
            this.Controls.Add(this.mainmenu);
            this.MainMenuStrip = this.mainmenu;
            this.MaximizeBox = false;
            this.Name = "VLS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_url;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox svc_comboBox;
        private System.Windows.Forms.ComboBox qlty_comboBox;
    }
}

