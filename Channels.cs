using System;
using System.IO;
using System.Windows.Forms;

namespace VLSSharp
{
    public partial class Channels : Form
    {
        public Channels()
        {
            InitializeComponent();

        }

        VLS vls = new VLS();

        private string channels = ".\\channels.vls"; //File path
        private string[] rawList; // Raw data from channels.vls 
        private string[] list; // Only 1 line of Rawlist ready to be processed in ListView
        private int lineCount;

        private void Channels_Load(object sender, EventArgs e)
        {
            loadPrefs();
        }

        public void loadPrefs()
        {
            try { lineCount = File.ReadAllLines(channels).Length; }
            catch (IOException)
            {
                MessageBox.Show("File not found, a new channels.vls file will be created.");
                File.WriteAllText(channels, "esl_csgo,0,best\n");
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

        private void savePrefs()
        {
            try
            {
                lineCount = File.ReadAllLines(channels).Length;
            }
            catch (IOException)
            {
                MessageBox.Show("Could not save preferences");
                return;
            }
            string[] s = new string[listView.Items.Count];

            for (int i = 0; i < listView.Items.Count; i++)
            {
                s[i] = listView.Items[i].SubItems[0].Text + "," + listView.Items[i].SubItems[1].Text + "," + listView.Items[i].SubItems[2].Text ;
            }
            File.WriteAllLines(channels, s);
        }

        public void addToListView(string url, int svc, string qlty)
        {
            loadPrefs();
            ListViewItem lvi = new ListViewItem(url);
            lvi.SubItems.Add(svc.ToString());
            lvi.SubItems.Add(qlty);
            listView.Items.Add(lvi);
            savePrefs();
        }

        private void Channels_Closed(object sender, EventArgs e)
        {
            //File.WriteAllLines(channels, list);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Channels_AddBtn addBtn = new Channels_AddBtn();
            addBtn.Show();
        }

        private void remBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.SelectedItems)
            {
                listView.Items.Remove(item);
            }

            savePrefs();
        }

        private void listView_ItemActivate(Object sender, EventArgs e)
        {
            try
            {
                string url = listView.SelectedItems[0].Text;
                int svc = Convert.ToInt32(listView.SelectedItems[0].SubItems[1].Text);
                string qlty = listView.SelectedItems[0].SubItems[2].Text;
                vls.launchVLS(url, svc, qlty);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select one item from the list to launch","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
