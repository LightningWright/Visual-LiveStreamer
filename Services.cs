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

        public static void Twitch(string url, string qlty) {
            //MessageBox.Show("--hds-live-edge 1 http://twitch.tv/" + url + " " + qlty + " --config ./cfg/config.cfg");
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
            twitchprocess.Close();
        }

        public static void YouTube(string url, string qlty) {
            //MessageBox.Show("--hds-live-edge 1 http://youtube.com/" + url + " " + qlty + " --config ./cfg/config.cfg");
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
            ytprocess.Close();
        }

        public static void uStream(string url, string qlty) {
            //MessageBox.Show("--hds-live-edge 1 http://www.ustream.tv/" + url + " " + qlty + " --config ./cfg/config.cfg");
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
            ustreamprocess.Close();
        }
    }
}
