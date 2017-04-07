namespace VLSSharp
{
    partial class Version
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Version));
            this.about_img = new System.Windows.Forms.PictureBox();
            this.aboutok_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.about_img)).BeginInit();
            this.SuspendLayout();
            // 
            // about_img
            // 
            this.about_img.Image = global::VLSSharp.Properties.Resources.img256;
            this.about_img.Location = new System.Drawing.Point(13, 13);
            this.about_img.Name = "about_img";
            this.about_img.Size = new System.Drawing.Size(78, 81);
            this.about_img.TabIndex = 2;
            this.about_img.TabStop = false;
            // 
            // aboutok_btn
            // 
            this.aboutok_btn.Location = new System.Drawing.Point(100, 106);
            this.aboutok_btn.Name = "aboutok_btn";
            this.aboutok_btn.Size = new System.Drawing.Size(75, 23);
            this.aboutok_btn.TabIndex = 3;
            this.aboutok_btn.Text = "OK";
            this.aboutok_btn.UseVisualStyleBackColor = true;
            this.aboutok_btn.Click += new System.EventHandler(this.aboutok_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(100, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 87);
            this.panel1.TabIndex = 9;
            // 
            // Version
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 141);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aboutok_btn);
            this.Controls.Add(this.about_img);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Version";
            this.Text = "WIP";
            this.Load += new System.EventHandler(this.Version_Load);
            ((System.ComponentModel.ISupportInitialize)(this.about_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox about_img;
        private System.Windows.Forms.Button aboutok_btn;
        private System.Windows.Forms.Panel panel1;
    }
}