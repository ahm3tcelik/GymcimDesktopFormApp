
using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using MetroFramework;

namespace Gymcim.FormUI.Views
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        IUserService userService;

        public frmLogin()
        {
            InitializeComponent();
            userService = InstanceFactory.GetInstance<IUserService>();
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            tbxEmail.Text = "";
            tbxPassword.Text = "";
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            User user = userService.LoginWithEmailAndPassword(tbxEmail.Text.Trim(), tbxPassword.Text.Trim());
            if (user != null)
            {
                Session.currentUser = user;
                NavigationTool.Open(this, new frmHome());
            }
            else
            {
                MetroMessageBox.Show(this,
                    "Bu bilgilere ait bir kullanıcı bulunamadı.", 
                    "Hata!", 
                    System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
            }
                
        }

        private void lbForgetPass_Click(object sender, System.EventArgs e)
        {
            MetroMessageBox.Show(this,
                    "Bu özellik aktif değil.",
                    "Uyarı!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information,
                    100);
        }
    }
}
