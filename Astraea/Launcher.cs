using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astraea
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }
        bool AlreadyLoaded()
        {
            if (Process.GetProcessesByName("Astraea").Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Launcher_Load(object sender, EventArgs e)
        {
            if (AlreadyLoaded())
            {
                var result = MessageBox.Show("Astraea is already loaded\nWould you like to load it anyways?", "Astraea Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void SetLoadingLabel(string text, int x, int y)
        {
            LauncherLoadingLabel.Invoke((MethodInvoker)(() =>
            {
                LauncherLoadingLabel.Text = text;
                LauncherLoadingLabel.Location = new Point(x, y);
            }));
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Checks for whitelist
            Thread.Sleep(1 * 1000);
            SetLoadingLabel("Checking WhiteList...", 146, 74);
            Thread.Sleep(2 * 1000);
            WebClient wc = new WebClient();
            string WhiteLists = wc.DownloadString("https://raw.githubusercontent.com/CynicalSoftworks/Astraea/main/WhiteList");
            void needLogin()
            {
                var loginCheck = MessageBox.Show("You are not logged into Astraea, would you like to continue to the login screen?", "Astrea Alerts", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (loginCheck == DialogResult.Yes)
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        this.Hide();
                        Form loginScreen = new Astraea.Login();
                        loginScreen.Show();
                    }));
                    backgroundWorker1.CancelAsync();
                }
                else
                {
                    MessageBox.Show("You need to be logged in to use this...", "Astraea Alerts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\auth"))
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\auth\user.var"))
                {
                    if (!WhiteLists.Contains(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\auth\user.var")))
                    {
                        needLogin();
                    }
                }
                else
                {
                    needLogin();
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\auth\user.var");
                    Directory.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\auth");
                }
            }
            else
            {
                needLogin();
            }
            LauncherProgressBar.Invoke((MethodInvoker)(() => 
            {
                LauncherProgressBar.Maximum = 100;
                LauncherProgressBar.Value += 20;
            }));
            
                // Checks if out of date
            Thread.Sleep(300);
            SetLoadingLabel("Checking Version...",153, 74);
            Thread.Sleep(2 * 1000);
            if(Astraea.Updater.CheckForUpdates() == true)
            {
                SetLoadingLabel("Updating...", 195, 74);
                if (Astraea.Updater.CheckList() == "BIN")
                {
                    Astraea.Updater.UpdateBIN();
                }
                if(Astraea.Updater.CheckList() == "DLL")
                {
                    Astraea.Updater.UpdateDLL();
                }
                if (Astraea.Updater.CheckList() == "UI")
                {
                    Astraea.Updater.UpdateUI();
                }
            }
            LauncherProgressBar.Value += 20;
            SetLoadingLabel("Checking Data...", 168, 74);
            if(Astraea.Installer.CheckInstalled() == false)
            {
                SetLoadingLabel("Downloading Data...", 149, 74);
                Astraea.Installer.SmartInstall();
            }
            Thread.Sleep(1 * 1000);
            LauncherProgressBar.Value += 40;
            SetLoadingLabel("Loading Executor...", 154, 74);
            Thread.Sleep(1 * 1000);
            LauncherProgressBar.Value += 20;
            Thread.Sleep(1 * 1000);
            this.Invoke((MethodInvoker)(() =>
            {
                this.Hide();
                Thread.Sleep(1 * 1000);
                Form MainUI = new MainUI();
                MainUI.Show();
            }));
        }
    }
}
