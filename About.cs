using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace VLSSharp
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            about_img.Image = VLSSharp.Properties.Resources.img256;
            about_img.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void git_1_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/LightningWright");
        }

        private void git_2_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Chrippa");
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
