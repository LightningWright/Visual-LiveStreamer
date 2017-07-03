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
    public partial class Channels_AddBtn : Form
    {
        public Channels_AddBtn()
        {
            InitializeComponent();
        }

        public string url;
        public int svc;
        public string qlty;

        private void okBtn_Click(object sender, EventArgs e)
        {
            Channels c = new Channels();
            c.addToListView(urlBox.Text, svcComboBox.SelectedIndex, qltyComboBox.Text);
            Close();
        }

        private void svcComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            svc = svcComboBox.SelectedIndex;

            if (svc == 0)
            {
                qltyComboBox.Items.Clear();
                for (int i = 0; i < Services.twitchQlist.Length; i++) { qltyComboBox.Items.Insert(i, Services.twitchQlist[i]); }
            }
            else if (svc == 1)
            {
                qltyComboBox.Items.Clear();
                for (int i = 0; i < Services.ytQlist.Length; i++) { qltyComboBox.Items.Insert(i, Services.ytQlist[i]); }
            }
            else if (svc == 2)
            {
                qltyComboBox.Items.Clear();
                for (int i = 0; i < Services.uStreamQlist.Length; i++) { qltyComboBox.Items.Insert(i, Services.uStreamQlist[i]); }
            }
            else { qltyComboBox.Items.Clear(); return; }
        }

        private void qltyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            qlty = qltyComboBox.SelectedItem.ToString();
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            url = urlBox.Text;
        }
    }
}
