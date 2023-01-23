using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSL2._0
{
    internal class PL
    {
        //
        //java -Xmx1024M -Xms1024M -jar minecraft_server.1.19.3.jar nogui
        //
        public static void firstStart() {
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

            ServerM.StartInfo = StartConf;

            ServerM.Start();

            StreamWriter ServerInput = ServerM.StandardInput;
            ServerInput.WriteLine("stop");
            ServerInput.Close();
        }
    }
}
