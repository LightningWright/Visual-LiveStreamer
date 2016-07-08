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
        //       VARS
        string url;
        public static int serviceHandler;
        public static bool debug = false;

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        /* PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
         float useless = cpuCounter.NextValue();
         System.Threading.Thread.Sleep(100);
         float cpuval = cpuCounter.NextValue();
         Console.Out.WriteLine(cpuval);*/
         
        private void btn_url_Click(object sender, EventArgs e)
        {
            launchVLS(url);
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            url = urlBox.Text;
        }

        private void twitch_rbtn_CheckedChanged(object sender, EventArgs e)
        { if (twitch_rbtn.Checked == true) { serviceHandler = 1; } }

        private void yt_rbtn_CheckedChanged(object sender, EventArgs e)
        { if (yt_rbtn.Checked == true) { serviceHandler = 2; } }

        private void ustream_rbtn_CheckedChanged(object sender, EventArgs e)
        { if (ustream_rbtn.Checked == true) { serviceHandler = 3; } }

        private void launchVLS(string url)
        {
            if (serviceHandler == 1)
            {
                Services.Twitch(url);
                string debug = "Lanzando: Service #" + serviceHandler;
                Console.Out.WriteLine(debug);
            }
            else if (serviceHandler == 2)
            {
                Services.YouTube(url);
                string debug = "Lanzando: Service #" + serviceHandler;
                Console.Out.WriteLine(debug);
            }
            else if (serviceHandler == 3)
            {
                Services.uStream(url);
                string debug = "Lanzando: Service #" + serviceHandler;
                Console.Out.WriteLine(debug);
            }

            else { return; }

            /*Process VLSapp = new Process();
            VLSapp.StartInfo.FileName = "bin\\livestreamer-core.exe";
            VLSapp.StartInfo.Arguments = "--hds-live-edge 1 http://twitch.tv/" + url + " " + "best" + " --config ./cfg/config.cfg";
            VLSapp.StartInfo.UseShellExecute = false;
            //process.StartInfo.RedirectStandardOutput = true;
            VLSapp.Start();

            // Synchronously read the standard output of the spawned process. 
            //StreamReader reader = process.StandardOutput;
            //string output = reader.ReadToEnd();

            // Write the redirected output to this application's window.
            //Console.WriteLine(output);

            VLSapp.WaitForExit();
            VLSapp.Close();*/
            return;

        }


        //                 BARRA DE NAVEGACION

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activateToolStripMenuItem.CheckState == CheckState.Checked)
            {
                debug = false;
                activateToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else {
                debug = true;
                activateToolStripMenuItem.CheckState = CheckState.Checked;
            }
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutform = new About();
            aboutform.StartPosition = FormStartPosition.CenterScreen;
            aboutform.Show();
        }
    }
}
