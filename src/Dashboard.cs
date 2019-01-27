using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silentify
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            CheckForAdblock();
            VersionLabel.Text = "v" + System.Windows.Forms.Application.ProductVersion;
        }

        private void CheckForAdblock()
        {
            Task.Run(async () =>
            {
                await Task.Delay(0);
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Spotify/netutils.dll"))
                {
                    AdblockCard.Invoke(new Action(() => AdblockCard.color = Color.FromArgb(255, 30, 215, 97)));
                    AdblockStatusLabel.Invoke(new Action(() => AdblockStatusLabel.Text = "Adblock is installed!"));
                    InstallAdblock.Invoke(new Action(() => InstallAdblock.ButtonText = "Reinstall"));
                }
                else
                {
                    AdblockCard.Invoke(new Action(() => AdblockCard.color = Color.FromArgb(255, 255, 56, 56)));
                    AdblockStatusLabel.Invoke(new Action(() => AdblockStatusLabel.Text = "Adblock is not installed!"));
                    InstallAdblock.Invoke(new Action(() => InstallAdblock.ButtonText = "Install"));
                }
            });
        }

        private void InstallAdblock_Click(object sender, EventArgs e)
        {
            InstallAdblock.ButtonText = "Please wait...";
            InstallAdblock.Enabled = false;
            foreach (var process in Process.GetProcessesByName("Spotify"))
            {
                process.Kill();
            }

            foreach (var process in Process.GetProcessesByName("spotifywebhelper"))
            {
                process.Kill();
            }

            File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Spotify/netutils.dll", Properties.Resources.netutils);
            InstallAdblock.Enabled = true;
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Spotify/Spotify.exe");
            CheckForAdblock();
        }

        private void UpdateSilentify_Click(object sender, EventArgs e)
        {
            //Process.Start("https://github.com/TheGreyRaven/Silentify/");
        }

        private void GithubImageButton_Click(object sender, EventArgs e)
        {
            //Process.Start("https://github.com/TheGreyRaven/Silentify/");
        }
    }
}
