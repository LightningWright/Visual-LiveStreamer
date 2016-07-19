namespace VLSSharp
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aboutok_btn = new System.Windows.Forms.Button();
            this.about_img = new System.Windows.Forms.PictureBox();
            this.about_1_lbl = new System.Windows.Forms.Label();
            this.about_2_lbl = new System.Windows.Forms.Label();
            this.git_2_llbl = new System.Windows.Forms.LinkLabel();
            this.git_1_llbl = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.about_img)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutok_btn
            // 
            this.aboutok_btn.Location = new System.Drawing.Point(93, 107);
            this.aboutok_btn.Name = "aboutok_btn";
            this.aboutok_btn.Size = new System.Drawing.Size(75, 23);
            this.aboutok_btn.TabIndex = 0;
            this.aboutok_btn.Text = "OK";
            this.aboutok_btn.UseVisualStyleBackColor = true;
            this.aboutok_btn.Click += new System.EventHandler(this.aboutok_btn_Click);
            // 
            // about_img
            // 
            this.about_img.Image = global::VLSSharp.Properties.Resources.img256;
            this.about_img.Location = new System.Drawing.Point(13, 13);
            this.about_img.Name = "about_img";
            this.about_img.Size = new System.Drawing.Size(78, 81);
            this.about_img.TabIndex = 1;
            this.about_img.TabStop = false;
            // 
            // about_1_lbl
            // 
            this.about_1_lbl.AutoSize = true;
            this.about_1_lbl.Location = new System.Drawing.Point(22, 1);
            this.about_1_lbl.Name = "about_1_lbl";
            this.about_1_lbl.Size = new System.Drawing.Size(120, 13);
            this.about_1_lbl.TabIndex = 2;
            this.about_1_lbl.Text = "Visual Live Streamer C#";
            // 
            // about_2_lbl
            // 
            this.about_2_lbl.AutoSize = true;
            this.about_2_lbl.Location = new System.Drawing.Point(3, 24);
            this.about_2_lbl.Name = "about_2_lbl";
            this.about_2_lbl.Size = new System.Drawing.Size(163, 13);
            this.about_2_lbl.TabIndex = 3;
            this.about_2_lbl.Text = "VLS is a C# GUI for Livestreamer";
            // 
            // git_2_llbl
            // 
            this.git_2_llbl.AutoSize = true;
            this.git_2_llbl.LinkColor = System.Drawing.Color.Navy;
            this.git_2_llbl.Location = new System.Drawing.Point(41, 69);
            this.git_2_llbl.Name = "git_2_llbl";
            this.git_2_llbl.Size = new System.Drawing.Size(77, 13);
            this.git_2_llbl.TabIndex = 5;
            this.git_2_llbl.TabStop = true;
            this.git_2_llbl.Text = "Chrippa Github";
            this.git_2_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.git_2_llbl_LinkClicked);
            // 
            // git_1_llbl
            // 
            this.git_1_llbl.AutoSize = true;
            this.git_1_llbl.LinkColor = System.Drawing.Color.Navy;
            this.git_1_llbl.Location = new System.Drawing.Point(27, 47);
            this.git_1_llbl.Name = "git_1_llbl";
            this.git_1_llbl.Size = new System.Drawing.Size(115, 13);
            this.git_1_llbl.TabIndex = 6;
            this.git_1_llbl.TabStop = true;
            this.git_1_llbl.Text = "LightningWright Github";
            this.git_1_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.git_1_llbl_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.git_1_llbl);
            this.panel1.Controls.Add(this.about_2_lbl);
            this.panel1.Controls.Add(this.git_2_llbl);
            this.panel1.Controls.Add(this.about_1_lbl);
            this.panel1.Location = new System.Drawing.Point(97, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 82);
            this.panel1.TabIndex = 8;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 142);
            this.Controls.Add(this.about_img);
            this.Controls.Add(this.aboutok_btn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About - VLS C#";
            ((System.ComponentModel.ISupportInitialize)(this.about_img)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aboutok_btn;
        private System.Windows.Forms.PictureBox about_img;
        private System.Windows.Forms.Label about_1_lbl;
        private System.Windows.Forms.Label about_2_lbl;
        private System.Windows.Forms.LinkLabel git_2_llbl;
        private System.Windows.Forms.LinkLabel git_1_llbl;
        private System.Windows.Forms.Panel panel1;
    }
}