using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLSSharp
{
    public partial class Version : Form
    {
        public Version()
        {
            InitializeComponent();
            about_img.Image = VLSSharp.Properties.Resources.img256;
            about_img.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void aboutok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Version_Load(object sender, EventArgs e)
        {

        }
    }
}
