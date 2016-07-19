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
        public static int svcHandler;
        public static string qlty;
        public static bool debug = false;

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        /* PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
         float useless = cpuCounter.NextValue();
         System.Threading.Thread.Sleep(100);
         float cpuval = cpuCounter.NextValue();
         Console.Out.WriteLine(cpuval);*/
        //              PROCESAR SELECCION (al cambiar de opcion)

        private void svc_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int svcIndex = svc_comboBox.SelectedIndex;
            svcHandler = svcIndex;
            if (svcIndex == 0) {
                qlty_comboBox.Items.Clear();
                qlty_comboBox.Items.Insert(0,"best");
                qlty_comboBox.Items.Insert(1, "medium");
                qlty_comboBox.Items.Insert(2, "worst");
                qlty_comboBox.Items.Insert(3, "audio");
                
            }
            else if (svcIndex == 1) {
                qlty_comboBox.Items.Clear();
                qlty_comboBox.Items.Insert(0, "best");
                qlty_comboBox.Items.Insert(1, "360p");
                qlty_comboBox.Items.Insert(2, "worst");
                qlty_comboBox.Items.Insert(3, "audio_webm");
            }
            else if (svcIndex == 2) {
                qlty_comboBox.Items.Clear();
                qlty_comboBox.Items.Insert(0, "best");
                qlty_comboBox.Items.Insert(1, "mobile_360p");
                qlty_comboBox.Items.Insert(2, "worst");
            }
            else { qlty_comboBox.Items.Clear(); return; }
        }

        private void qlty_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qltyItem = qlty_comboBox.SelectedItem.ToString();
            qlty = qltyItem;
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            url = urlBox.Text;
        }

        private void btn_url_Click(object sender, EventArgs e)
        {
            launchVLS(url,qlty);
        }

            //                  LANZAR ARGS
        private void launchVLS(string url, string qlty)
        {
            if (svcHandler == 0)
            {
                Services.Twitch(url,qlty);
                string debug = "Lanzando: Service #" + svcHandler;
                Console.Out.WriteLine(debug);
            }
            else if (svcHandler == 1)
            {
                Services.YouTube(url,qlty);
                string debug = "Lanzando: Service #" + svcHandler;
                Console.Out.WriteLine(debug);
            }
            else if (svcHandler == 2)
            {
                Services.uStream(url,qlty);
                string debug = "Lanzando: Service #" + svcHandler;
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutform = new About();
            aboutform.StartPosition = FormStartPosition.CenterScreen;
            aboutform.Show();
        }
    }
}
