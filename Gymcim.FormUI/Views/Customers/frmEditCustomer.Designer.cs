namespace Gymcim.FormUI.Views.Customers
{
    partial class frmEditCustomer
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
            this.lvlStats = new System.Windows.Forms.ListView();
            this.StatisticID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatisticDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatisticDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kilo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Shoulder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Arm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Waist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Calf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSchedules = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbxDuration = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dtStarter = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbxGsm = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbxSurname = new MetroFramework.Controls.MetroTextBox();
            this.tbxName = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvlStats
            // 
            this.lvlStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StatisticID,
            this.StatisticDesc,
            this.StatisticDate,
            this.Height,
            this.Kilo,
            this.Shoulder,
            this.Chest,
            this.Arm,
            this.Waist,
            this.Hip,
            this.Calf});
            this.lvlStats.FullRowSelect = true;
            this.lvlStats.GridLines = true;
            this.lvlStats.HideSelection = false;
            this.lvlStats.Location = new System.Drawing.Point(0, 47);
            this.lvlStats.MultiSelect = false;
            this.lvlStats.Name = "lvlStats";
            this.lvlStats.Size = new System.Drawing.Size(757, 93);
            this.lvlStats.TabIndex = 32;
            this.lvlStats.UseCompatibleStateImageBehavior = false;
            this.lvlStats.View = System.Windows.Forms.View.Details;
            this.lvlStats.SelectedIndexChanged += new System.EventHandler(this.lvlStats_SelectedIndexChanged);
            // 
            // StatisticID
            // 
            this.StatisticID.Text = "#";
            this.StatisticID.Width = 30;
            // 
            // StatisticDesc
            // 
            this.StatisticDesc.Text = "Açıklama";
            this.StatisticDesc.Width = 100;
            // 
            // StatisticDate
            // 
            this.StatisticDate.Text = "Tarih";
            this.StatisticDate.Width = 100;
            // 
            // Height
            // 
            this.Height.Text = "Boy";
            // 
            // Kilo
            // 
            this.Kilo.Text = "Kilo";
            // 
            // Shoulder
            // 
            this.Shoulder.Text = "Omuz";
            // 
            // Chest
            // 
            this.Chest.Text = "Göğüs";
            // 
            // Arm
            // 
            this.Arm.Text = "Kol";
            // 
            // Waist
            // 
            this.Waist.Text = "Bel";
            // 
            // Hip
            // 
            this.Hip.Text = "Kalça";
            // 
            // Calf
            // 
            this.Calf.Text = "Baldır";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxSchedules);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.tbxDuration);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.dtStarter);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.tbxGsm);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbxSurname);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 151);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // cbxSchedules
            // 
            this.cbxSchedules.FormattingEnabled = true;
            this.cbxSchedules.ItemHeight = 23;
            this.cbxSchedules.Location = new System.Drawing.Point(295, 100);
            this.cbxSchedules.Name = "cbxSchedules";
            this.cbxSchedules.Size = new System.Drawing.Size(317, 29);
            this.cbxSchedules.TabIndex = 30;
            this.cbxSchedules.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(295, 78);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Çalışma Programı";
            // 
            // tbxDuration
            // 
            // 
            // 
            // 
            this.tbxDuration.CustomButton.Image = null;
            this.tbxDuration.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.tbxDuration.CustomButton.Name = "";
            this.tbxDuration.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxDuration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxDuration.CustomButton.TabIndex = 1;
            this.tbxDuration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxDuration.CustomButton.UseSelectable = true;
            this.tbxDuration.CustomButton.Visible = false;
            this.tbxDuration.Lines = new string[0];
            this.tbxDuration.Location = new System.Drawing.Point(146, 100);
            this.tbxDuration.MaxLength = 32767;
            this.tbxDuration.Name = "tbxDuration";
            this.tbxDuration.PasswordChar = '\0';
            this.tbxDuration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxDuration.SelectedText = "";
            this.tbxDuration.SelectionLength = 0;
            this.tbxDuration.SelectionStart = 0;
            this.tbxDuration.ShortcutsEnabled = true;
            this.tbxDuration.Size = new System.Drawing.Size(123, 29);
            this.tbxDuration.TabIndex = 28;
            this.tbxDuration.UseSelectable = true;
            this.tbxDuration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxDuration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(146, 77);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(109, 19);
            this.metroLabel9.TabIndex = 23;
            this.metroLabel9.Text = "Kayıt Süresi (Gün)";
            // 
            // dtStarter
            // 
            this.dtStarter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStarter.Location = new System.Drawing.Point(7, 100);
            this.dtStarter.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStarter.Name = "dtStarter";
            this.dtStarter.Size = new System.Drawing.Size(123, 29);
            this.dtStarter.TabIndex = 1;
            this.dtStarter.Value = new System.DateTime(2020, 11, 19, 23, 8, 5, 588);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 77);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(97, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Başlangıç Tarihi";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(425, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "GSM";
            // 
            // tbxGsm
            // 
            this.tbxGsm.Culture = new System.Globalization.CultureInfo("tr-TR");
            this.tbxGsm.Location = new System.Drawing.Point(425, 39);
            this.tbxGsm.Mask = "+99 (999) 000-0000";
            this.tbxGsm.Name = "tbxGsm";
            this.tbxGsm.Size = new System.Drawing.Size(120, 20);
            this.tbxGsm.TabIndex = 4;
            this.tbxGsm.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(213, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Soyad";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 14);
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
            this.tbxSurname.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.tbxSurname.CustomButton.Name = "";
            this.tbxSurname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxSurname.CustomButton.TabIndex = 1;
            this.tbxSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxSurname.CustomButton.UseSelectable = true;
            this.tbxSurname.CustomButton.Visible = false;
            this.tbxSurname.Lines = new string[0];
            this.tbxSurname.Location = new System.Drawing.Point(213, 36);
            this.tbxSurname.MaxLength = 32767;
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.PasswordChar = '\0';
            this.tbxSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxSurname.SelectedText = "";
            this.tbxSurname.SelectionLength = 0;
            this.tbxSurname.SelectionStart = 0;
            this.tbxSurname.ShortcutsEnabled = true;
            this.tbxSurname.Size = new System.Drawing.Size(193, 29);
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
            this.tbxName.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.tbxName.CustomButton.Name = "";
            this.tbxName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxName.CustomButton.TabIndex = 1;
            this.tbxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxName.CustomButton.UseSelectable = true;
            this.tbxName.CustomButton.Visible = false;
            this.tbxName.Lines = new string[0];
            this.tbxName.Location = new System.Drawing.Point(8, 36);
            this.tbxName.MaxLength = 32767;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxName.SelectedText = "";
            this.tbxName.SelectionLength = 0;
            this.tbxName.SelectionStart = 0;
            this.tbxName.ShortcutsEnabled = true;
            this.tbxName.Size = new System.Drawing.Size(189, 29);
            this.tbxName.TabIndex = 0;
            this.tbxName.UseSelectable = true;
            this.tbxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(627, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "İstatistik Ekle";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(491, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 23);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "İstatistik Düzenle";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(355, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "İstatistik Sil";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.btnDelete);
            this.metroPanel1.Controls.Add(this.btnAdd);
            this.metroPanel1.Controls.Add(this.btnEdit);
            this.metroPanel1.Controls.Add(this.lvlStats);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 211);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 219);
            this.metroPanel1.TabIndex = 37;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Leave += new System.EventHandler(this.metroPanel1_Leave);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(0, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "İstatistikler";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.btnClose);
            this.metroPanel2.Controls.Add(this.btnSave);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 357);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(760, 73);
            this.metroPanel2.TabIndex = 38;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(601, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 36);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(439, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 36);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditCustomer";
            this.Text = "Müşteri Düzenle";
            this.Load += new System.EventHandler(this.frmEditCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvlStats;
        private System.Windows.Forms.ColumnHeader StatisticID;
        private System.Windows.Forms.ColumnHeader StatisticDesc;
        private System.Windows.Forms.ColumnHeader StatisticDate;
        private System.Windows.Forms.ColumnHeader Height;
        private System.Windows.Forms.ColumnHeader Kilo;
        private System.Windows.Forms.ColumnHeader Shoulder;
        private System.Windows.Forms.ColumnHeader Chest;
        private System.Windows.Forms.ColumnHeader Arm;
        private System.Windows.Forms.ColumnHeader Waist;
        private System.Windows.Forms.ColumnHeader Hip;
        private System.Windows.Forms.ColumnHeader Calf;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox tbxDuration;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroDateTime dtStarter;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MaskedTextBox tbxGsm;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbxSurname;
        private MetroFramework.Controls.MetroTextBox tbxName;
        private MetroFramework.Controls.MetroComboBox cbxSchedules;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}