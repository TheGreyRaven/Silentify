//using Octokit;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silentify
{
    public partial class Silentify : Form
    {
        public Silentify()
        {
            InitializeComponent();
        }

        //GitHubClient client = new GitHubClient(new ProductHeaderValue("Silentify"));
        CancellationTokenSource cts = new CancellationTokenSource();
        SelectForm selectform = new SelectForm();
        WebClient webClient = new WebClient();

        private void Silentify_Load(object sender, System.EventArgs e)
        {
            if (Variables.SkipPreloading == false)
            {
                Transition.Show(spotifyLogo, false);
                Transition.Show(loadingProgress, false);
                Transition.Show(loadingLabel, false);
                _ = FetchData();
            }
            else
            {
                this.Controls.Clear();
                selectform.Hide();
                selectform.Parent = this;
                selectform.Dock = DockStyle.Fill;
                Transition.ShowSync(selectform, false);
            }
        }

        #region AidsFest
        private async Task FetchData()
        {
            while (!loadingProgress.Visible)
            {
                await Task.Delay(100);
            }

            loadingProgress.Value = 50;

            while (!loadingLabel.Visible)
            {
                await Task.Delay(100);
            }

            Transition.HideSync(loadingLabel, false);
            loadingLabel.Text = Variables.loadingWords[0];
            loadingLabel.Left = (ClientSize.Width - loadingLabel.Width) / 2;
            Transition.ShowSync(loadingLabel, false);

            try
            {
                cts.CancelAfter(5000);
                //var releases = await client.Repository.Release.GetAll("TheGreyRaven", "WinActive");
                //var latest = releases[0];
                //Variables.Version = latest.TagName;
            }
            catch (Exception)
            {
                Transition.HideSync(loadingLabel, false);
                loadingLabel.Text = "Failed to fetch update...";
                loadingLabel.Left = (ClientSize.Width - loadingLabel.Width) / 2;
                Transition.ShowSync(loadingLabel, false);
                cts = null;
                await Task.Delay(3000);
            }

            Transition.HideSync(loadingLabel, false);
            loadingLabel.Text = Variables.loadingWords[1];
            loadingLabel.Left = (ClientSize.Width - loadingLabel.Width) / 2;
            Transition.ShowSync(loadingLabel, false);

            for (int i = loadingProgress.Value; loadingProgress.Value < 100; i++)
            {
                loadingProgress.Value = i;
                await Task.Delay(10);
            }

            Transition.HideSync(loadingLabel, false);
            Transition.HideSync(loadingProgress, false);
            Transition.HideSync(spotifyLogo, false);

            loadingLabel.Dispose();
            loadingProgress.Dispose();
            spotifyLogo.Dispose();

            selectform.Hide();
            selectform.Parent = this;
            selectform.Dock = DockStyle.Fill;
            Transition.ShowSync(selectform, false);
        }
        #endregion
    }
}
