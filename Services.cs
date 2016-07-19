using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace VLSSharp
{
    public class Services
    {
        public Services() {

        }

        public static void Twitch(string url, int qltyHandler) {

            string qlty = "";

            if (qltyHandler == 0) { qlty = "best"; } else if (qltyHandler == 1) { qlty = "worst"; } else if (qltyHandler == 2) { qlty = "audio"; }

            Process twitchprocess = new Process();
            twitchprocess.StartInfo.FileName = "bin\\livestreamer-core.exe";
            twitchprocess.StartInfo.Arguments = "--hds-live-edge 1 http://twitch.tv/" + url + " " + qlty + " --config ./cfg/config.cfg";
            twitchprocess.StartInfo.UseShellExecute = false;
            if (!VLS.debug)
            {
                twitchprocess.StartInfo.RedirectStandardOutput = true;
                twitchprocess.StartInfo.CreateNoWindow = true;
                twitchprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            twitchprocess.Start();
            //twitchprocess.WaitForExit();
            twitchprocess.Close();

        }

        public static void YouTube(string url, int qltyHandler) {

            string qlty = "";

            if (qltyHandler == 0) { qlty = "best"; } else if (qltyHandler == 1) { qlty = "worst"; } else if (qltyHandler == 2) { qlty = "audio_webm"; }

            Process ytprocess = new Process();
            ytprocess.StartInfo.FileName = "bin\\livestreamer-core.exe";
            ytprocess.StartInfo.Arguments = "--hds-live-edge 1 http://youtube.com/" + url + " "+ qlty + " --config ./cfg/config.cfg";
            ytprocess.StartInfo.UseShellExecute = false;
            if (!VLS.debug){
                ytprocess.StartInfo.RedirectStandardOutput = true;
                ytprocess.StartInfo.CreateNoWindow = true;
                ytprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            ytprocess.Start();
            //twitchprocess.WaitForExit();
            ytprocess.Close();
        }

        public static void uStream(string url, int qltyHandler) {

            string qlty = "";

            if (qltyHandler == 0) { qlty = "best"; }
            else if (qltyHandler == 1) { qlty = "worst"; }
            else if (qltyHandler == 2) { qlty = "mobile_480p"; MessageBox.Show("uStream can't serve only audio, using 480p video quality", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }

            Process ustreamprocess = new Process();
            ustreamprocess.StartInfo.FileName = "bin\\livestreamer-core.exe";
            ustreamprocess.StartInfo.Arguments = "--hds-live-edge 1 http://www.ustream.tv/" + url + " " + qlty + " --config ./cfg/config.cfg";
            ustreamprocess.StartInfo.UseShellExecute = false;
            if (!VLS.debug) {
                ustreamprocess.StartInfo.RedirectStandardOutput = false;
                ustreamprocess.StartInfo.CreateNoWindow = true;
                ustreamprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            ustreamprocess.Start();
            //twitchprocess.WaitForExit();
            ustreamprocess.Close();
        }
    }
}
