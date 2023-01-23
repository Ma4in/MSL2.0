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
    public partial class LunchForm : Form
    {
        public LunchForm()
        {
            InitializeComponent();
        }

        string[] properties = new string[60];
        string[] header = new string[2];

        private void Form2_Load(object sender, EventArgs e)
        {
            LunchVersionLabel.Text += Data.curentVersion;
            uRam.Text += Data.usedRam;
            try
            {
                StreamReader readPr = new StreamReader("versions\\" + Data.curentVersion + "\\server.properties");

                header[0] = readPr.ReadLine();
                header[1] = readPr.ReadLine();

                for (int i = 0; i < properties.Length; i++)
                {
                    properties[i] = readPr.ReadLine();
                    if (properties[i] != null)
                    {
                        if (properties[i].Contains("motd"))
                        {
                            serverMOTD.Text = properties[i].Substring(5);
                        }

                        if (properties[i].Contains("level-name"))
                        {
                            textBox2.Text = properties[i].Substring(11);
                        }

                        if (properties[i].Contains("resource-pack=") && !properties[i].Contains("require-resource-pack="))
                        {
                            resoursePack.Text = properties[i].Substring(14);
                        }

                        if (properties[i].Contains("max-players="))
                        {
                            numericPlayerCount.Value = int.Parse(properties[i].Substring(12));
                        }

                        if (properties[i].Contains("simulation-distance="))
                        {
                            numericSimDist.Value = int.Parse(properties[i].Substring(20));
                        }

                        if (properties[i].Contains("view-distance="))
                        {
                            numericViewDist.Value = int.Parse(properties[i].Substring(14));
                        }

                        if (properties[i].Contains("spawn-protection="))
                        {
                            numericSpawnProt.Value = int.Parse(properties[i].Substring(17));
                        }

                        if (properties[i].Contains("pvp="))
                        {
                            if (properties[i].Substring(4) == "true")
                            {
                                checkPVP.Checked = true;
                            }
                            else
                            {
                                checkPVP.Checked = false;
                            }
                        }

                        if (properties[i].Contains("spawn-npcs="))
                        {
                            if (properties[i].Substring(11) == "true")
                            {
                                checkNPC.Checked = true;
                            }
                            else
                            {
                                checkNPC.Checked = false;
                            }
                        }

                        if (properties[i].Contains("spawn-animals="))
                        {
                            if (properties[i].Substring(14) == "true")
                            {
                                checkAnimals.Checked = true;
                            }
                            else
                            {
                                checkAnimals.Checked = false;
                            }
                        }

                        if (properties[i].Contains("spawn-monsters="))
                        {
                            if (properties[i].Substring(15) == "true")
                            {
                                checkMonsters.Checked = true;
                            }
                            else
                            {
                                checkMonsters.Checked = false;
                            }
                        }

                        if (properties[i].Contains("online-mode="))
                        {
                            if (properties[i].Substring(12) == "true")
                            {
                                checkOnline.Checked = true;
                            }
                            else
                            {
                                checkOnline.Checked = false;
                            }
                        }

                        if (properties[i].Contains("hardcore="))
                        {
                            if (properties[i].Substring(9) == "true")
                            {
                                checkHardcore.Checked = true;
                            }
                            else
                            {
                                checkHardcore.Checked = false;
                            }
                        }
                    }
                }

                readPr.Close();
            }
            catch
            {
                MessageBox.Show("Config File Dosn't exist");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i] != null)
                {
                    if (properties[i].Contains("motd"))
                    {
                        properties[i] = "motd=" + serverMOTD.Text;
                    }

                    if (properties[i].Contains("level-name"))
                    {
                        properties[i] = "level-name=" + textBox2.Text;
                    }

                    if (properties[i].Contains("resource-pack=") && !properties[i].Contains("require-resource-pack="))
                    {
                        properties[i] = "resource-pack=" + resoursePack.Text;
                    }

                    if (properties[i].Contains("max-players="))
                    {
                        properties[i] = "max-players=" + numericPlayerCount.Value.ToString();
                    }

                    if (properties[i].Contains("simulation-distance="))
                    {
                        properties[i] = "simulation-distance=" + numericSimDist.Value.ToString();
                    }

                    if (properties[i].Contains("view-distance="))
                    {
                        properties[i] = "view-distance=" + numericViewDist.Value.ToString();
                    }

                    if (properties[i].Contains("spawn-protection="))
                    {
                        properties[i] = "spawn-protection=" + numericSpawnProt.Value.ToString();
                    }

                    if (properties[i].Contains("pvp="))
                    {
                        if (checkPVP.Checked)
                        {
                            properties[i] = "pvp=true";
                        }
                        else
                        {
                            properties[i] = "pvp=false";
                        }
                    }

                    if (properties[i].Contains("spawn-npcs="))
                    {
                        if (checkNPC.Checked)
                        {
                            properties[i] = "spawn-npcs=true";
                        }
                        else
                        {
                            properties[i] = "spawn-npcs=false";
                        }
                    }

                    if (properties[i].Contains("spawn-animals="))
                    {
                        if (checkAnimals.Checked)
                        {
                            properties[i] = "spawn-animals=true";
                        }
                        else
                        {
                            properties[i] = "spawn-animals=false";
                        }
                    }

                    if (properties[i].Contains("spawn-monsters="))
                    {
                        if (checkMonsters.Checked)
                        {
                            properties[i] = "spawn-monsters=true";
                        }
                        else
                        {
                            properties[i] = "spawn-monsters=false";
                        }
                    }

                    if (properties[i].Contains("online-mode="))
                    {
                        if (checkOnline.Checked)
                        {
                            properties[i] = "online-mode=true";
                        }
                        else
                        {
                            properties[i] = "online-mode=false";
                        }
                    }

                    if (properties[i].Contains("hardcore="))
                    {
                        if (checkHardcore.Checked)
                        {
                            properties[i] = "hardcore=true";
                        }
                        else
                        {
                            properties[i] = "hardcore=false";
                        }
                    }
                }
            }

            DialogResult dialogResult = MessageBox.Show("Save Settings?", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                StreamWriter clear = new StreamWriter("versions\\" + Data.curentVersion + "\\server.properties", false);
                clear.WriteLineAsync(header[0]);
                clear.WriteLineAsync(header[1]);
                clear.Close();

                StreamWriter writePr = new StreamWriter("versions\\" + Data.curentVersion + "\\server.properties", true);

                for (int i = 0; i < properties.Length; i++)
                {
                    writePr.WriteLine(properties[i]);
                }
                writePr.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //...
            }
        }

        private void LunchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (TreyLunchCheak.Checked)
            {
                Form TF = new TrayForm();
                TF.Show();
                this.Hide();
            } else
            {
                Process ServerM = new Process();

                ProcessStartInfo StartConf = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c chcp 65001 && " +
                    "cd " + Data.curentPath + " &&" +
                    "java -Xmx" + Data.usedRam + "M -Xms" + Data.usedRam + "M -jar server_" + Data.curentVersion + ".jar\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardInput = true,
                };

                ServerM.StartInfo = StartConf;

                ServerM.Start();

                Application.Exit();
            }
        }
    }
}