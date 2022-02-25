using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Astraea
{
    class Updater
    {
        public static bool CheckForUpdates()
        {
            WebClient coolClient = new WebClient();
            string CurrentVersion = coolClient.DownloadString("https://raw.githubusercontent.com/CynicalSoftworks/Astraea/main/Version");
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\auth"))
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\auth\downloaded"))
                {
                    if (File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\auth\downloaded") == "true")
                    {
                        if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\auth\version"))
                        {
                            WebClient vc = new WebClient();
                            if (File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\auth\version") != CurrentVersion)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        public static string CheckList()
        {
            WebClient coolClient = new WebClient();
            string UpdateList = coolClient.DownloadString("https://raw.githubusercontent.com/CynicalSoftworks/Astraea/main/Update%20List");
            if (UpdateList.Contains("DLL"))
            {
                return "DLL";
            }
            else if (UpdateList.Contains("UI"))
            {
                return "UI";
            }
            else if (UpdateList.Contains("BIN"))
            {
                return "BIN";
            }
            return "";
        }
        public static void UpdateDLL()
        {
            WebClient coolClient = new WebClient();
            coolClient.DownloadFile("https://github.com/CynicalSoftworks/Astraea/blob/main/Astraea.dll", "Astraea.dll");
        }
        public static void UpdateBIN()
        {
            if(Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\BIN"))
            {
                Directory.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\BIN");
            }
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\BIN");
            
        }
        public static void UpdateUI()
        {
            
        }
        
    }
    class Installer
    {
        public static bool CheckInstalled() 
        {
            if(!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\bin"))
            {
                return false;
            }
            else if(!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\auth"))
            {
                return false;
            }
            else if(!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\workspace"))
            {
                return false;
            }
            else if(!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\scripts"))
            {
                return false;
            }
            else if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\autoexe"))
            {
                return false;
            }
            return true;
        }
        public static void InstallAll()
        {
            InstallBIN();
            InstallAuth();
            InstallOthers();
        }
        public static void SmartInstall()
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\bin"))
            {
                InstallBIN();
            }
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\auth"))
            {
                InstallAuth();
            }
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\workspace"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\workspace");
            }
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\scripts"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\scripts");
            }
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\autoexe"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\autoexe");
            }
        }
        public static void InstallBIN()
        {
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\bin");
        }
        public static void InstallAuth()
        {
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\auth");
        }
        public static void InstallOthers()
        {
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\autoexe");
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\scripts");
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\workspace");
        }
    }
}
