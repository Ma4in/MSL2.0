using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace MSL2._0
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            Data.curentVersion = versionList.Text;
            Data.curentPath = Environment.CurrentDirectory + "\\versions\\" + Data.curentVersion;

            if (!File.Exists(Data.curentPath + "\\server_" + versionList.Text + ".jar"))
            {
                Data.versionExist= false;
                versionSelect.Enabled = true;
                versionSelect.Text = "Download";
            }
            else
            {
                Data.versionExist = true;
                versionSelect.Enabled = true;
                versionSelect.Text = "Start";
            }

        }

        private void versionSelect_Click(object sender, EventArgs e)
        {
            if (Data.versionExist) 
            {
                Data.usedRam = curentMemmory.Text;
                Form LF = new LunchForm();
                LF.Show();
                this.Hide();
            } 
            else
            {
                if (!File.Exists(Data.curentPath + "\\server_" + versionList.Text + ".jar"))
                {
                    versionSelect.Enabled = false;
                    Directory.CreateDirectory(Data.curentPath);
                    WebClient webClient = new WebClient();
                    string filePath = Data.curentPath + "\\server_" + versionList.Text + ".jar";
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFinish);

                    webClient.DownloadFileAsync(Data.versionLink(), filePath);
                    using (FileStream fs = File.Create(Data.curentPath + "\\" + "eula.txt"))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes("eula=true");
                        fs.Write(info, 0, info.Length);
                    }
                }
            }
        }

        public void DownloadFinish(object sendert, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            } 
            else
            {
                PL.firstStart();
                versionSelect.Enabled=true;
                versionSelect.Text = "Start";
                Data.versionExist = true;
                PL.firstStart();
            }
        } 

        private void StartForm_Load(object sender, EventArgs e)
        {
            maxMemmory.Text = (new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024*1024)).ToString();
            trackBar1.Maximum = int.Parse(maxMemmory.Text)/512 - 1;
            maxMemmory.Text = ((trackBar1.Maximum+1)*512).ToString();
            testLabel.Text = Data.curentPath;
            if (!Directory.Exists(Data.curentPath))
            {
                Directory.CreateDirectory(Data.curentPath);
            }
            trackBar1.Value = trackBar1.Maximum/2;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            curentMemmory.Text = ((trackBar1.Value+1)*512).ToString();

        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory);
        }
    }
}
