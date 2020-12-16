using Gymcim.FormUI.Utilities;
using Gymcim.FormUI.Views.Customers;
using Gymcim.FormUI.Views.Logs;
using Gymcim.FormUI.Views.Schedules;
using Gymcim.FormUI.Views.Settings;

namespace Gymcim.FormUI.Views
{
    public partial class frmHome : MetroFramework.Forms.MetroForm
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private void tileCustomers_Click(object sender, System.EventArgs e)
        {
            NavigationTool.Open(this, new frmCustomers());
        }
        private void tileSettings_Click(object sender, System.EventArgs e)
        {
            NavigationTool.Open(this, new frmSettings());
        }

        private void tileSchedule_Click(object sender, System.EventArgs e)
        {
            NavigationTool.Open(this, new frmSchedules());
        }

        private void tileLog_Click(object sender, System.EventArgs e)
        {
            NavigationTool.Open(this, new frmLogs());
        }

        private void tileLogout_Click(object sender, System.EventArgs e)
        {
            NavigationTool.Open(this, new frmLogin());
        }
    }
}
