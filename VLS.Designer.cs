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
            this.twitch_rbtn = new System.Windows.Forms.RadioButton();
            this.yt_rbtn = new System.Windows.Forms.RadioButton();
            this.ustream_rbtn = new System.Windows.Forms.RadioButton();
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // twitch_rbtn
            // 
            resources.ApplyResources(this.twitch_rbtn, "twitch_rbtn");
            this.twitch_rbtn.Name = "twitch_rbtn";
            this.twitch_rbtn.TabStop = true;
            this.twitch_rbtn.UseVisualStyleBackColor = true;
            this.twitch_rbtn.CheckedChanged += new System.EventHandler(this.twitch_rbtn_CheckedChanged);
            // 
            // yt_rbtn
            // 
            resources.ApplyResources(this.yt_rbtn, "yt_rbtn");
            this.yt_rbtn.Name = "yt_rbtn";
            this.yt_rbtn.TabStop = true;
            this.yt_rbtn.UseVisualStyleBackColor = true;
            this.yt_rbtn.CheckedChanged += new System.EventHandler(this.yt_rbtn_CheckedChanged);
            // 
            // ustream_rbtn
            // 
            resources.ApplyResources(this.ustream_rbtn, "ustream_rbtn");
            this.ustream_rbtn.Name = "ustream_rbtn";
            this.ustream_rbtn.TabStop = true;
            this.ustream_rbtn.UseVisualStyleBackColor = true;
            this.ustream_rbtn.CheckedChanged += new System.EventHandler(this.ustream_rbtn_CheckedChanged);
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
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
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
            // VLS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ustream_rbtn);
            this.Controls.Add(this.yt_rbtn);
            this.Controls.Add(this.twitch_rbtn);
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
        private System.Windows.Forms.RadioButton twitch_rbtn;
        private System.Windows.Forms.RadioButton yt_rbtn;
        private System.Windows.Forms.RadioButton ustream_rbtn;
        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

