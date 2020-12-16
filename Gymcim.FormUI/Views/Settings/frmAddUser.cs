using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.Business.Utilities;
using Gymcim.DataAccess.ValidationRules.FluentValidation;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using System;
using System.Text;
using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Settings
{
    public partial class frmAddUser : MetroFramework.Forms.MetroForm
    {
        private User user;
        private IUserService userService;
        public frmAddUser(User user = null)
        {
            InitializeComponent();
            userService = InstanceFactory.GetInstance<IUserService>();
            this.user = user;
        }
        private void frmAddUser_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                SetData();
            }
        }
        private void SetData()
        {
            tbxMail.Text = user.UserMail;
            tbxUsername.Text = user.UserName;
            tbxPassword.Text = user.UserPassword;
            tbxPassword2.Text = user.UserPassword;

            // Access Flags
            cbAddAuthority.Checked = user.AccessFlags.Contains(PermissionHelper.addAuthorities);
            cbAddCustomer.Checked = user.AccessFlags.Contains(PermissionHelper.addCustomer);
            cbAddSchedule.Checked = user.AccessFlags.Contains(PermissionHelper.addSchedule);
            cbDelAuthority.Checked = user.AccessFlags.Contains(PermissionHelper.delAuthorities);
            cbDelCustomer.Checked = user.AccessFlags.Contains(PermissionHelper.delCustomer);
            cbDelSchedule.Checked = user.AccessFlags.Contains(PermissionHelper.delSchedule);
            cbEditAuthority.Checked = user.AccessFlags.Contains(PermissionHelper.editAuthorities);
            cbEditCustomer.Checked = user.AccessFlags.Contains(PermissionHelper.editCustomer);
            cbEditSchedule.Checked = user.AccessFlags.Contains(PermissionHelper.editSchedule);
            cbImmunity.Checked = user.AccessFlags.Contains(PermissionHelper.immunity);
            cbShowAuthority.Checked = user.AccessFlags.Contains(PermissionHelper.showAuthorities);
            cbShowLog.Checked = user.AccessFlags.Contains(PermissionHelper.showLog);
            cbUnlimitedAccess.Checked = user.AccessFlags.Contains(PermissionHelper.unlimitedAccess);
        }
        private void GetDataFromViews()
        {
            user.UserMail = tbxMail.Text.Trim();
            user.UserName = tbxUsername.Text.Trim();
            user.UserPassword = tbxPassword.Text.Trim();
            StringBuilder flags = new StringBuilder();
            if (cbAddAuthority.Checked)
                flags.Append(PermissionHelper.addAuthorities);
            if (cbAddCustomer.Checked)
                flags.Append(PermissionHelper.addCustomer);
            if (cbAddSchedule.Checked)
                flags.Append(PermissionHelper.addSchedule);
            if (cbDelAuthority.Checked)
                flags.Append(PermissionHelper.delAuthorities);
            if (cbDelCustomer.Checked)
                flags.Append(PermissionHelper.delCustomer);
            if (cbDelSchedule.Checked)
                flags.Append(PermissionHelper.delSchedule);
            if (cbEditAuthority.Checked)
                flags.Append(PermissionHelper.editAuthorities);
            if (cbEditCustomer.Checked)
                flags.Append(PermissionHelper.editCustomer);
            if (cbEditSchedule.Checked)
                flags.Append(PermissionHelper.editSchedule);
            if (cbImmunity.Checked)
                flags.Append(PermissionHelper.immunity);
            if (cbShowAuthority.Checked)
                flags.Append(PermissionHelper.showAuthorities);
            if (cbShowLog.Checked)
                flags.Append(PermissionHelper.showLog);
            if (cbUnlimitedAccess.Checked)
                flags.Append(PermissionHelper.unlimitedAccess);

            user.AccessFlags = flags.ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbxPassword.Text.Trim() != tbxPassword2.Text.Trim())
            {
                MessageBox.Show("Parolalar eşleşmiyor.");
            }
            else
            {
                if (user != null) // UPDATE OPERATION
                {
                    GetDataFromViews();
                    updateUser();
                }
                else // CREATE Operation
                {
                    user = new User();
                    GetDataFromViews();
                    createUser();
                }
            }
        }
        private void updateUser()
        {
            try
            {
                ValidationTool.Validate(new UserValidator(), user);
                userService.Update(user, Session.currentUser);
                MessageBox.Show("Yetkili başarıyla güncellendi!", "Başarılı!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!");
            }
        }
        private void createUser()
        {
            try
            {
                ValidationTool.Validate(new UserValidator(), user);
                userService.Add(user, Session.currentUser);
                MessageBox.Show("Yetkili başarıyla eklendi!", "Başarılı!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}