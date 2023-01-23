using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSL2._0
{
    internal class Data
    {
        public static string curentVersion { get; set; }
        //
        public static string usedRam { get; set; }
        //
        public static string curentPath { get; set; } = Environment.CurrentDirectory + "\\versions\\";
        public static bool versionExist { get; set; } = true;

        public static Uri versionLink()
        {
            switch (curentVersion)
            {
                case "1.12.2":
                    return new Uri("https://launcher.mojang.com/mc/game/1.12.2/server/886945bfb2b978778c3a0288fd7fab09d315b25f/server.jar");
                case "1.7.10":
                    return new Uri("https://launcher.mojang.com/mc/game/1.7.10/server/952438ac4e01b4d115c5fc38f891710c4941df29/server.jar");
                default:
                    return new Uri("");
            }
        }
    }
}
