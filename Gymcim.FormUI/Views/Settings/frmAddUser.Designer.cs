namespace Gymcim.FormUI.Views.Settings
{
    partial class frmAddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbxMail = new MetroFramework.Controls.MetroTextBox();
            this.tbxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbxPassword2 = new MetroFramework.Controls.MetroTextBox();
            this.cbImmunity = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbShowAuthority = new MetroFramework.Controls.MetroCheckBox();
            this.cbAddAuthority = new MetroFramework.Controls.MetroCheckBox();
            this.cbEditAuthority = new MetroFramework.Controls.MetroCheckBox();
            this.cbDelAuthority = new MetroFramework.Controls.MetroCheckBox();
            this.cbShowLog = new MetroFramework.Controls.MetroCheckBox();
            this.cbAddCustomer = new MetroFramework.Controls.MetroCheckBox();
            this.cbEditCustomer = new MetroFramework.Controls.MetroCheckBox();
            this.cbDelCustomer = new MetroFramework.Controls.MetroCheckBox();
            this.cbAddSchedule = new MetroFramework.Controls.MetroCheckBox();
            this.cbEditSchedule = new MetroFramework.Controls.MetroCheckBox();
            this.cbDelSchedule = new MetroFramework.Controls.MetroCheckBox();
            this.cbUnlimitedAccess = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUnlimitedAccess);
            this.groupBox1.Controls.Add(this.cbDelSchedule);
            this.groupBox1.Controls.Add(this.cbEditSchedule);
            this.groupBox1.Controls.Add(this.cbAddSchedule);
            this.groupBox1.Controls.Add(this.cbDelCustomer);
            this.groupBox1.Controls.Add(this.cbEditCustomer);
            this.groupBox1.Controls.Add(this.cbAddCustomer);
            this.groupBox1.Controls.Add(this.cbShowLog);
            this.groupBox1.Controls.Add(this.cbDelAuthority);
            this.groupBox1.Controls.Add(this.cbEditAuthority);
            this.groupBox1.Controls.Add(this.cbAddAuthority);
            this.groupBox1.Controls.Add(this.cbShowAuthority);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.cbImmunity);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.tbxPassword2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.tbxPassword);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbxMail);
            this.groupBox1.Controls.Add(this.tbxUsername);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 377);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetkli Bilgileri";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(168, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 36);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(6, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(168, 21);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "E-Posta";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Kullanıcı Adı";
            // 
            // tbxMail
            // 
            // 
            // 
            // 
            this.tbxMail.CustomButton.Image = null;
            this.tbxMail.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbxMail.CustomButton.Name = "";
            this.tbxMail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxMail.CustomButton.TabIndex = 1;
            this.tbxMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxMail.CustomButton.UseSelectable = true;
            this.tbxMail.CustomButton.Visible = false;
            this.tbxMail.Lines = new string[0];
            this.tbxMail.Location = new System.Drawing.Point(168, 43);
            this.tbxMail.MaxLength = 32767;
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.PasswordChar = '\0';
            this.tbxMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxMail.SelectedText = "";
            this.tbxMail.SelectionLength = 0;
            this.tbxMail.SelectionStart = 0;
            this.tbxMail.ShortcutsEnabled = true;
            this.tbxMail.Size = new System.Drawing.Size(156, 29);
            this.tbxMail.TabIndex = 1;
            this.tbxMail.UseSelectable = true;
            this.tbxMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxUsername
            // 
            // 
            // 
            // 
            this.tbxUsername.CustomButton.Image = null;
            this.tbxUsername.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbxUsername.CustomButton.Name = "";
            this.tbxUsername.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxUsername.CustomButton.TabIndex = 1;
            this.tbxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxUsername.CustomButton.UseSelectable = true;
            this.tbxUsername.CustomButton.Visible = false;
            this.tbxUsername.Lines = new string[0];
            this.tbxUsername.Location = new System.Drawing.Point(6, 43);
            this.tbxUsername.MaxLength = 32767;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.PasswordChar = '\0';
            this.tbxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxUsername.SelectedText = "";
            this.tbxUsername.SelectionLength = 0;
            this.tbxUsername.SelectionStart = 0;
            this.tbxUsername.ShortcutsEnabled = true;
            this.tbxUsername.Size = new System.Drawing.Size(156, 29);
            this.tbxUsername.TabIndex = 0;
            this.tbxUsername.UseSelectable = true;
            this.tbxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 85);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Parola";
            // 
            // tbxPassword
            // 
            // 
            // 
            // 
            this.tbxPassword.CustomButton.Image = null;
            this.tbxPassword.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbxPassword.CustomButton.Name = "";
            this.tbxPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPassword.CustomButton.TabIndex = 1;
            this.tbxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPassword.CustomButton.UseSelectable = true;
            this.tbxPassword.CustomButton.Visible = false;
            this.tbxPassword.Lines = new string[0];
            this.tbxPassword.Location = new System.Drawing.Point(6, 107);
            this.tbxPassword.MaxLength = 32767;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '•';
            this.tbxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPassword.SelectedText = "";
            this.tbxPassword.SelectionLength = 0;
            this.tbxPassword.SelectionStart = 0;
            this.tbxPassword.ShortcutsEnabled = true;
            this.tbxPassword.Size = new System.Drawing.Size(156, 29);
            this.tbxPassword.TabIndex = 15;
            this.tbxPassword.UseSelectable = true;
            this.tbxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(168, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Parola (Doğrulama)";
            // 
            // tbxPassword2
            // 
            // 
            // 
            // 
            this.tbxPassword2.CustomButton.Image = null;
            this.tbxPassword2.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbxPassword2.CustomButton.Name = "";
            this.tbxPassword2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxPassword2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPassword2.CustomButton.TabIndex = 1;
            this.tbxPassword2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPassword2.CustomButton.UseSelectable = true;
            this.tbxPassword2.CustomButton.Visible = false;
            this.tbxPassword2.Lines = new string[0];
            this.tbxPassword2.Location = new System.Drawing.Point(168, 107);
            this.tbxPassword2.MaxLength = 32767;
            this.tbxPassword2.Name = "tbxPassword2";
            this.tbxPassword2.PasswordChar = '•';
            this.tbxPassword2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPassword2.SelectedText = "";
            this.tbxPassword2.SelectionLength = 0;
            this.tbxPassword2.SelectionStart = 0;
            this.tbxPassword2.ShortcutsEnabled = true;
            this.tbxPassword2.Size = new System.Drawing.Size(156, 29);
            this.tbxPassword2.TabIndex = 17;
            this.tbxPassword2.UseSelectable = true;
            this.tbxPassword2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPassword2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbImmunity
            // 
            this.cbImmunity.AutoSize = true;
            this.cbImmunity.Location = new System.Drawing.Point(16, 194);
            this.cbImmunity.Name = "cbImmunity";
            this.cbImmunity.Size = new System.Drawing.Size(102, 15);
            this.cbImmunity.TabIndex = 20;
            this.cbImmunity.Text = "Dokunulmazlık";
            this.cbImmunity.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(6, 145);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Yetkiler";
            // 
            // cbShowAuthority
            // 
            this.cbShowAuthority.AutoSize = true;
            this.cbShowAuthority.Location = new System.Drawing.Point(16, 215);
            this.cbShowAuthority.Name = "cbShowAuthority";
            this.cbShowAuthority.Size = new System.Drawing.Size(109, 15);
            this.cbShowAuthority.TabIndex = 22;
            this.cbShowAuthority.Text = "Yetkilileri Görme";
            this.cbShowAuthority.UseSelectable = true;
            // 
            // cbAddAuthority
            // 
            this.cbAddAuthority.AutoSize = true;
            this.cbAddAuthority.Location = new System.Drawing.Point(16, 236);
            this.cbAddAuthority.Name = "cbAddAuthority";
            this.cbAddAuthority.Size = new System.Drawing.Size(95, 15);
            this.cbAddAuthority.TabIndex = 23;
            this.cbAddAuthority.Text = "Yetkili Ekleme";
            this.cbAddAuthority.UseSelectable = true;
            // 
            // cbEditAuthority
            // 
            this.cbEditAuthority.AutoSize = true;
            this.cbEditAuthority.Location = new System.Drawing.Point(16, 257);
            this.cbEditAuthority.Name = "cbEditAuthority";
            this.cbEditAuthority.Size = new System.Drawing.Size(116, 15);
            this.cbEditAuthority.TabIndex = 24;
            this.cbEditAuthority.Text = "Yetkili Düzenleme";
            this.cbEditAuthority.UseSelectable = true;
            // 
            // cbDelAuthority
            // 
            this.cbDelAuthority.AutoSize = true;
            this.cbDelAuthority.Location = new System.Drawing.Point(16, 278);
            this.cbDelAuthority.Name = "cbDelAuthority";
            this.cbDelAuthority.Size = new System.Drawing.Size(86, 15);
            this.cbDelAuthority.TabIndex = 25;
            this.cbDelAuthority.Text = "Yetkili Silme";
            this.cbDelAuthority.UseSelectable = true;
            // 
            // cbShowLog
            // 
            this.cbShowLog.AutoSize = true;
            this.cbShowLog.Location = new System.Drawing.Point(16, 299);
            this.cbShowLog.Name = "cbShowLog";
            this.cbShowLog.Size = new System.Drawing.Size(127, 15);
            this.cbShowLog.TabIndex = 26;
            this.cbShowLog.Text = "Log Kayıtları Görme";
            this.cbShowLog.UseSelectable = true;
            // 
            // cbAddCustomer
            // 
            this.cbAddCustomer.AutoSize = true;
            this.cbAddCustomer.Location = new System.Drawing.Point(178, 194);
            this.cbAddCustomer.Name = "cbAddCustomer";
            this.cbAddCustomer.Size = new System.Drawing.Size(104, 15);
            this.cbAddCustomer.TabIndex = 27;
            this.cbAddCustomer.Text = "Müşteri Ekleme";
            this.cbAddCustomer.UseSelectable = true;
            // 
            // cbEditCustomer
            // 
            this.cbEditCustomer.AutoSize = true;
            this.cbEditCustomer.Location = new System.Drawing.Point(178, 215);
            this.cbEditCustomer.Name = "cbEditCustomer";
            this.cbEditCustomer.Size = new System.Drawing.Size(125, 15);
            this.cbEditCustomer.TabIndex = 28;
            this.cbEditCustomer.Text = "Müşteri Düzenleme";
            this.cbEditCustomer.UseSelectable = true;
            // 
            // cbDelCustomer
            // 
            this.cbDelCustomer.AutoSize = true;
            this.cbDelCustomer.Location = new System.Drawing.Point(178, 236);
            this.cbDelCustomer.Name = "cbDelCustomer";
            this.cbDelCustomer.Size = new System.Drawing.Size(95, 15);
            this.cbDelCustomer.TabIndex = 29;
            this.cbDelCustomer.Text = "Müşteri Silme";
            this.cbDelCustomer.UseSelectable = true;
            // 
            // cbAddSchedule
            // 
            this.cbAddSchedule.AutoSize = true;
            this.cbAddSchedule.Location = new System.Drawing.Point(178, 257);
            this.cbAddSchedule.Name = "cbAddSchedule";
            this.cbAddSchedule.Size = new System.Drawing.Size(128, 15);
            this.cbAddSchedule.TabIndex = 30;
            this.cbAddSchedule.Text = "Program Oluşturma";
            this.cbAddSchedule.UseSelectable = true;
            // 
            // cbEditSchedule
            // 
            this.cbEditSchedule.AutoSize = true;
            this.cbEditSchedule.Location = new System.Drawing.Point(178, 278);
            this.cbEditSchedule.Name = "cbEditSchedule";
            this.cbEditSchedule.Size = new System.Drawing.Size(131, 15);
            this.cbEditSchedule.TabIndex = 31;
            this.cbEditSchedule.Text = "Program Düzenleme";
            this.cbEditSchedule.UseSelectable = true;
            // 
            // cbDelSchedule
            // 
            this.cbDelSchedule.AutoSize = true;
            this.cbDelSchedule.Location = new System.Drawing.Point(178, 299);
            this.cbDelSchedule.Name = "cbDelSchedule";
            this.cbDelSchedule.Size = new System.Drawing.Size(101, 15);
            this.cbDelSchedule.TabIndex = 32;
            this.cbDelSchedule.Text = "Program Silme";
            this.cbDelSchedule.UseSelectable = true;
            // 
            // cbUnlimitedAccess
            // 
            this.cbUnlimitedAccess.AutoSize = true;
            this.cbUnlimitedAccess.Location = new System.Drawing.Point(16, 173);
            this.cbUnlimitedAccess.Name = "cbUnlimitedAccess";
            this.cbUnlimitedAccess.Size = new System.Drawing.Size(172, 15);
            this.cbUnlimitedAccess.TabIndex = 33;
            this.cbUnlimitedAccess.Text = "Yetkisiz Erişim (Tüm Yetkiler)";
            this.cbUnlimitedAccess.UseSelectable = true;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 453);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUser";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Yetkili Ekle";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbxMail;
        private MetroFramework.Controls.MetroTextBox tbxUsername;
        private MetroFramework.Controls.MetroCheckBox cbImmunity;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbxPassword2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbxPassword;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroCheckBox cbUnlimitedAccess;
        private MetroFramework.Controls.MetroCheckBox cbDelSchedule;
        private MetroFramework.Controls.MetroCheckBox cbEditSchedule;
        private MetroFramework.Controls.MetroCheckBox cbAddSchedule;
        private MetroFramework.Controls.MetroCheckBox cbDelCustomer;
        private MetroFramework.Controls.MetroCheckBox cbEditCustomer;
        private MetroFramework.Controls.MetroCheckBox cbAddCustomer;
        private MetroFramework.Controls.MetroCheckBox cbShowLog;
        private MetroFramework.Controls.MetroCheckBox cbDelAuthority;
        private MetroFramework.Controls.MetroCheckBox cbEditAuthority;
        private MetroFramework.Controls.MetroCheckBox cbAddAuthority;
        private MetroFramework.Controls.MetroCheckBox cbShowAuthority;
    }
}