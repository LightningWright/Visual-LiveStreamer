using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VLSSharp
{
    public partial class Channels : Form
    {
        public Channels()
        {
            InitializeComponent();
        }

        private string channels = ".\\channels.vls";
        private string[] rawList;
        private string[] list;
        private string selected;
        private int lineCount;

        
        
        


        /*private void channelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = channelList.GetItemText(channelList.SelectedItem);
            File.AppendAllText(".\\log.txt", selected);
        }

        private void channelList_DoubleClick(object sender, EventArgs e)
        {
            if (channelList.SelectedItem != null)
            {
                VLS vls = new VLS();
                vls.launchVLS(channelList.SelectedItem.ToString(),VLS.qlty);
            }
        }*/

        private void Channels_Load(object sender, EventArgs e)
        {
            loadPrefs();
        }

        private void loadPrefs()
        {
            try { lineCount = File.ReadAllLines(channels).Length; }
            catch (IOException)
            {
                MessageBox.Show("File not found, a new channels.vls file will be created.");
                File.WriteAllText(channels, "esl_csgo,0,best");
                return;
            }

            rawList = File.ReadAllLines(channels);

            for (int i = 0; i < lineCount; i++)
            {
                list = rawList[i].Split(',');
                ListViewItem lvi = new ListViewItem(list[0]);
                lvi.SubItems.Add(list[1]);
                lvi.SubItems.Add(list[2]);
                listView.Items.Add(lvi);
            }
        }
        /*private void readList()
        {
            try
            {
                lineCount = File.ReadAllLines(channels).Length;
            }
            catch (IOException)
            {
                MessageBox.Show("File not found, a new channels.vls file will be created.");
                File.WriteAllText(channels, "NewChannel");
                list = File.ReadAllLines(channels);
                channelList.Items.Insert(0,list[0]);
                return;
            }

            list = File.ReadAllLines(channels);

            for (int i = 0; i < lineCount; i++)
            {
                channelList.Items.Insert(i, list[i]);
            }
        }*/

        private void Channels_Closed(object sender, EventArgs e)
        {
            //File.WriteAllLines(channels, list);
        }
    }
}
