using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSL2._0
{
    public partial class TrayForm : Form
    {
        public TrayForm()
        {
            InitializeComponent();
        }

        Process ServerM = new Process();

        ProcessStartInfo StartConf = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/c chcp 65001 && " +
            "cd " + Data.curentPath + " &&" +
            "java -Xmx" + Data.usedRam + "M -Xms" + Data.usedRam + "M -jar server_" + Data.curentVersion + ".jar nogui\"",
            UseShellExecute = false,
            CreateNoWindow = true,
            RedirectStandardInput = true,
        };

            
        public void TrayForm_Load(object sender, EventArgs e)
        {
            ServerM.StartInfo = StartConf;

            ServerM.Start();

            label1.Text += Data.curentVersion;
    }

        public void SendCommand_Click(object sender, EventArgs e)
        {
            StreamWriter ServerInput = ServerM.StandardInput;
            ServerInput.WriteLine(textBox1.Text);
        }

        private void TrayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter ServerInput = ServerM.StandardInput;
            ServerInput.WriteLine("stop");
            Application.Exit();
        }
    }
}
