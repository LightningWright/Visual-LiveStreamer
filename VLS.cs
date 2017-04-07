using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;


namespace VLSSharp
{
    public partial class VLS : Form
    {
        public VLS()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        public static string url;
        public static int svc;
        public static string qlty;
        public static bool debug = false;

        public void VLS_Load(object sender, EventArgs e)
        {
            
        }

        //Service Combo Box Functions, changed to look like more elegant
        private void svc_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            svc = svc_comboBox.SelectedIndex;
            
            if (svc == 0) {
                qlty_comboBox.Items.Clear();
                for (int i = 0; i < Services.twitchQlist.Length; i++) { qlty_comboBox.Items.Insert(i, Services.twitchQlist[i]); }
            }
            else if (svc == 1) {
                qlty_comboBox.Items.Clear();
                for (int i = 0; i < Services.ytQlist.Length; i++) { qlty_comboBox.Items.Insert(i, Services.ytQlist[i]); }
            }
            else if (svc == 2) {
                qlty_comboBox.Items.Clear();
                for (int i = 0; i < Services.uStreamQlist.Length; i++) { qlty_comboBox.Items.Insert(i, Services.uStreamQlist[i]); }
            }
            else { qlty_comboBox.Items.Clear(); return; }
        }

        private void qlty_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            qlty = qlty_comboBox.SelectedItem.ToString();
        }

        private void urlBox_TextChanged(object sender, EventArgs e) { url = urlBox.Text; } //Update URL

        private void btn_url_Click(object sender, EventArgs e) { launchVLS(url,svc,qlty); } //Pass Url  Svc and Qlty -> selector

        public void launchVLS(string url, int svc, string qlty)
        {
            if (svc == 0) { Services.Twitch(url,qlty); }
            else if (svc == 1) { Services.YouTube(url,qlty); }
            else if (svc == 2) { Services.uStream(url,qlty); }
            else { return; }
            return;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Git gitform = new Git();
            gitform.StartPosition = FormStartPosition.CenterScreen;
            gitform.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //DEBUG DEBUG DEBUG DEBUG DEBUG DEBUG DEBUG DEBUG
        // & TO DO
        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activateToolStripMenuItem.CheckState == CheckState.Checked)
            {
                debug = false;
                activateToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else
            {
                debug = true;
                activateToolStripMenuItem.CheckState = CheckState.Checked;
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Channels channelform = new Channels();
            channelform.StartPosition = FormStartPosition.WindowsDefaultLocation;
            channelform.Show();
        }
    }
}
