using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.Business.Utilities;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Settings
{
    public partial class frmSettings : MetroFramework.Forms.MetroForm
    {
        private IUserService userService;
        private List<User> authorities;
        public frmSettings()
        {
            InitializeComponent();
            userService = InstanceFactory.GetInstance<IUserService>();
            BlockUnauthorizedViews();
        }
        private void BlockUnauthorizedViews()
        {
            btnAdd.Enabled = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.addAuthorities);
            btnEdit.Enabled = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.editAuthorities);
            btnDel.Enabled = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.delAuthorities);
        }
        private void SetData()
        {
            tbxUsername.Text = Session.currentUser.UserName;
            tbxMail.Text = Session.currentUser.UserMail;
        }
        private void LoadAuthorities()
        {
            try
            {
                authorities = userService.GetAll(Session.currentUser);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!");
            }

            lvlAuthorities.Items.Clear();

            foreach (User user in authorities)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(user.UserID));
                item.SubItems.Add(user.UserName);
                item.SubItems.Add(user.UserMail);
                item.SubItems.Add(user.AccessFlags);
                lvlAuthorities.Items.Add(item);

                if(user.UserID == Session.currentUser.UserID)
                {
                    Session.currentUser = user;
                }
            }
            lvlAuthorities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            SetData();
        }
        private void frmSettings_Load(object sender, System.EventArgs e)
        {
            LoadAuthorities();
        }

        private void tbxHome_Click(object sender, System.EventArgs e)
        {
            NavigationTool.Open(this, new frmHome());
        }

        private void btnDel_Click(object sender, System.EventArgs e)
        {
            if (lvlAuthorities.SelectedItems.Count < 1)
                return;

            User user = authorities[lvlAuthorities.SelectedItems[0].Index];
            DialogResult dialogResult = MessageBox.Show(user.UserName +
                " adlı yetkiliyi silmek istediğinizden emin misiniz?", "Yetkili Sil", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    userService.Delete(user, Session.currentUser);
                    MessageBox.Show("Yetkili başarıyla silindi!", "Başarılı!");
                    lvlAuthorities.Items.RemoveAt(lvlAuthorities.SelectedItems[0].Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata!");
                }
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (lvlAuthorities.SelectedItems.Count < 1)
                return;

            NavigationTool.OpenNewTab(new frmAddUser(authorities[lvlAuthorities.SelectedItems[0].Index]));
            LoadAuthorities();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            NavigationTool.OpenNewTab(new frmAddUser());
            LoadAuthorities();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbxPassword.Text.Trim() == Session.currentUser.UserPassword)
            {
                User user = new User
                {
                    UserID = Session.currentUser.UserID,
                    UserName = tbxUsername.Text.Trim(),
                    UserMail = tbxMail.Text.Trim(),
                    AccessFlags = Session.currentUser.AccessFlags
                };
                user.UserPassword = tbxPassword2.Text.Trim() != "" ? 
                    tbxPassword2.Text.Trim() : Session.currentUser.UserPassword;
               
                try
                {
                    userService.Update(user, Session.currentUser);
                    MessageBox.Show("Bilgileriniz başarıyla güncellendi.", "Başarılı!");
                    
                    tbxPassword.Text = "";
                    tbxPassword2.Text = "";
                    
                    LoadAuthorities();
                    
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata!");
                }
            }
            else
            {
                MessageBox.Show("Aktif parola hatalı.", "Hata!");
            }
        }

        private void lvlAuthorities_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDel.Visible = true;     
        }
    }
}
