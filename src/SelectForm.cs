using System.Windows.Forms;

namespace Silentify
{
    public partial class SelectForm : UserControl
    {
        public SelectForm()
        {
            InitializeComponent();
        }
  
        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, System.EventArgs e)
        {
            Form.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void MenuButton_Click(object sender, System.EventArgs e)
        {
            if (sidePanel.Width == 175)
            {
                sidePanel.Visible = false;
                sidePanel.Width = 50;
                MenuTransition.Show(sidePanel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
            {
                sidePanel.Visible = false;
                sidePanel.Width = 175;
                MenuTransition.Show(sidePanel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
            }
        }

        private void DashboardButton_Click(object sender, System.EventArgs e)
        {
            SpawnPanel.Controls.Clear();
            SpawnPanel.Controls.Add(new Dashboard());
        }
    }
}
