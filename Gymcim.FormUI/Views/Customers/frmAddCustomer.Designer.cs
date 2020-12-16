namespace Gymcim.FormUI.Views.Customers
{
    partial class frmAddCustomer
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
            this.dtStarter = new MetroFramework.Controls.MetroDateTime();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.cbxSchedules = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbxDuration = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbxGsm = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbxSurname = new MetroFramework.Controls.MetroTextBox();
            this.tbxName = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtStarter);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cbxSchedules);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.tbxDuration);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.tbxGsm);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbxSurname);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(23, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // dtStarter
            // 
            this.dtStarter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStarter.Location = new System.Drawing.Point(7, 150);
            this.dtStarter.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStarter.Name = "dtStarter";
            this.dtStarter.Size = new System.Drawing.Size(155, 29);
            this.dtStarter.TabIndex = 1;
            this.dtStarter.Value = new System.DateTime(2020, 11, 14, 19, 16, 11, 942);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(168, 261);
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
            this.btnSave.Location = new System.Drawing.Point(6, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxSchedules
            // 
            this.cbxSchedules.FormattingEnabled = true;
            this.cbxSchedules.ItemHeight = 23;
            this.cbxSchedules.Location = new System.Drawing.Point(7, 214);
            this.cbxSchedules.Name = "cbxSchedules";
            this.cbxSchedules.Size = new System.Drawing.Size(317, 29);
            this.cbxSchedules.TabIndex = 12;
            this.cbxSchedules.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 191);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Çalışma Programı";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(168, 128);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Kayıt Süresi (Gün)";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 128);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(97, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Başlangıç Tarihi";
            // 
            // tbxDuration
            // 
            // 
            // 
            // 
            this.tbxDuration.CustomButton.Image = null;
            this.tbxDuration.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbxDuration.CustomButton.Name = "";
            this.tbxDuration.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxDuration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxDuration.CustomButton.TabIndex = 1;
            this.tbxDuration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxDuration.CustomButton.UseSelectable = true;
            this.tbxDuration.CustomButton.Visible = false;
            this.tbxDuration.Lines = new string[0];
            this.tbxDuration.Location = new System.Drawing.Point(168, 150);
            this.tbxDuration.MaxLength = 32767;
            this.tbxDuration.Name = "tbxDuration";
            this.tbxDuration.PasswordChar = '\0';
            this.tbxDuration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxDuration.SelectedText = "";
            this.tbxDuration.SelectionLength = 0;
            this.tbxDuration.SelectionStart = 0;
            this.tbxDuration.ShortcutsEnabled = true;
            this.tbxDuration.Size = new System.Drawing.Size(156, 29);
            this.tbxDuration.TabIndex = 7;
            this.tbxDuration.UseSelectable = true;
            this.tbxDuration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxDuration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "GSM";
            // 
            // tbxGsm
            // 
            this.tbxGsm.Culture = new System.Globalization.CultureInfo("tr-TR");
            this.tbxGsm.Location = new System.Drawing.Point(8, 102);
            this.tbxGsm.Mask = "+99 (999) 000-0000";
            this.tbxGsm.Name = "tbxGsm";
            this.tbxGsm.Size = new System.Drawing.Size(317, 20);
            this.tbxGsm.TabIndex = 4;
            this.tbxGsm.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(168, 21);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Soyad";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(26, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Ad";
            // 
            // tbxSurname
            // 
            // 
            // 
            // 
            this.tbxSurname.CustomButton.Image = null;
            this.tbxSurname.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbxSurname.CustomButton.Name = "";
            this.tbxSurname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxSurname.CustomButton.TabIndex = 1;
            this.tbxSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxSurname.CustomButton.UseSelectable = true;
            this.tbxSurname.CustomButton.Visible = false;
            this.tbxSurname.Lines = new string[0];
            this.tbxSurname.Location = new System.Drawing.Point(168, 43);
            this.tbxSurname.MaxLength = 32767;
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.PasswordChar = '\0';
            this.tbxSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxSurname.SelectedText = "";
            this.tbxSurname.SelectionLength = 0;
            this.tbxSurname.SelectionStart = 0;
            this.tbxSurname.ShortcutsEnabled = true;
            this.tbxSurname.Size = new System.Drawing.Size(156, 29);
            this.tbxSurname.TabIndex = 1;
            this.tbxSurname.UseSelectable = true;
            this.tbxSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.CustomButton.Image = null;
            this.tbxName.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbxName.CustomButton.Name = "";
            this.tbxName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxName.CustomButton.TabIndex = 1;
            this.tbxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxName.CustomButton.UseSelectable = true;
            this.tbxName.CustomButton.Visible = false;
            this.tbxName.Lines = new string[0];
            this.tbxName.Location = new System.Drawing.Point(6, 43);
            this.tbxName.MaxLength = 32767;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxName.SelectedText = "";
            this.tbxName.SelectionLength = 0;
            this.tbxName.SelectionStart = 0;
            this.tbxName.ShortcutsEnabled = true;
            this.tbxName.Size = new System.Drawing.Size(156, 29);
            this.tbxName.TabIndex = 0;
            this.tbxName.UseSelectable = true;
            this.tbxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 400);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCustomer";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox tbxName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbxSurname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MaskedTextBox tbxGsm;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbxDuration;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroComboBox cbxSchedules;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime dtStarter;
    }
}