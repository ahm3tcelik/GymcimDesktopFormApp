namespace Gymcim.FormUI.Views.Customers
{
    partial class frmCustomers
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerGsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StarterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbxSearch = new MetroFramework.Controls.MetroTextBox();
            this.tbxHome = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.tbxCounter = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.CustomerSurname,
            this.CustomerGsm,
            this.DaysLeft,
            this.StarterDate,
            this.EndDate,
            this.Duration,
            this.Show,
            this.Edit,
            this.Delete});
            this.dgvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomers.Location = new System.Drawing.Point(20, 64);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(760, 359);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerID.FillWeight = 101.5229F;
            this.CustomerID.HeaderText = "#";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 39;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.FillWeight = 99.8308F;
            this.CustomerName.HeaderText = "Ad";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerSurname
            // 
            this.CustomerSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerSurname.FillWeight = 99.8308F;
            this.CustomerSurname.HeaderText = "Soyad";
            this.CustomerSurname.Name = "CustomerSurname";
            this.CustomerSurname.ReadOnly = true;
            // 
            // CustomerGsm
            // 
            this.CustomerGsm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerGsm.FillWeight = 99.8308F;
            this.CustomerGsm.HeaderText = "GSM";
            this.CustomerGsm.Name = "CustomerGsm";
            this.CustomerGsm.ReadOnly = true;
            this.CustomerGsm.Width = 56;
            // 
            // DaysLeft
            // 
            this.DaysLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DaysLeft.FillWeight = 99.8308F;
            this.DaysLeft.HeaderText = "Kalan Gün";
            this.DaysLeft.Name = "DaysLeft";
            this.DaysLeft.ReadOnly = true;
            this.DaysLeft.Width = 76;
            // 
            // StarterDate
            // 
            this.StarterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StarterDate.FillWeight = 99.8308F;
            this.StarterDate.HeaderText = "Başlangıç Tarihi";
            this.StarterDate.Name = "StarterDate";
            this.StarterDate.ReadOnly = true;
            this.StarterDate.Width = 98;
            // 
            // EndDate
            // 
            this.EndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EndDate.FillWeight = 99.8308F;
            this.EndDate.HeaderText = "Bitiş Tarihi";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 74;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Duration.FillWeight = 99.8308F;
            this.Duration.HeaderText = "Kayıt Süresi";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 80;
            // 
            // Show
            // 
            this.Show.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Show.HeaderText = "";
            this.Show.Name = "Show";
            this.Show.ReadOnly = true;
            this.Show.Text = "Detay";
            this.Show.UseColumnTextForButtonValue = true;
            this.Show.Width = 5;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.FillWeight = 99.8308F;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Düzenle";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Sil";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 5;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbxSearch.CustomButton.Image = null;
            this.tbxSearch.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.tbxSearch.CustomButton.Name = "";
            this.tbxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxSearch.CustomButton.TabIndex = 1;
            this.tbxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxSearch.CustomButton.UseSelectable = true;
            this.tbxSearch.CustomButton.Visible = false;
            this.tbxSearch.Lines = new string[0];
            this.tbxSearch.Location = new System.Drawing.Point(523, 35);
            this.tbxSearch.MaxLength = 32767;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PasswordChar = '\0';
            this.tbxSearch.PromptText = "Ara...";
            this.tbxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxSearch.SelectedText = "";
            this.tbxSearch.SelectionLength = 0;
            this.tbxSearch.SelectionStart = 0;
            this.tbxSearch.ShortcutsEnabled = true;
            this.tbxSearch.Size = new System.Drawing.Size(121, 23);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.UseSelectable = true;
            this.tbxSearch.WaterMark = "Ara...";
            this.tbxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // tbxHome
            // 
            this.tbxHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHome.BackColor = System.Drawing.Color.White;
            this.tbxHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxHome.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.tbxHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.tbxHome.Location = new System.Drawing.Point(20, 32);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(103, 24);
            this.tbxHome.TabIndex = 2;
            this.tbxHome.Text = "Ana Sayfa";
            this.tbxHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxHome.UseCustomForeColor = true;
            this.tbxHome.UseSelectable = true;
            this.tbxHome.Click += new System.EventHandler(this.tbxHome_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.metroLink1.Location = new System.Drawing.Point(114, 34);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(112, 24);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "/ Müşteriler";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // tbxCounter
            // 
            this.tbxCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxCounter.AutoSize = true;
            this.tbxCounter.FontSize = MetroFramework.MetroLabelSize.Small;
            this.tbxCounter.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tbxCounter.Location = new System.Drawing.Point(20, 426);
            this.tbxCounter.Name = "tbxCounter";
            this.tbxCounter.Size = new System.Drawing.Size(42, 15);
            this.tbxCounter.TabIndex = 4;
            this.tbxCounter.Text = "Satır: 6";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(650, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Müşteri Ekle";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxCounter);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.tbxHome);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgvCustomers);
            this.DisplayHeader = false;
            this.Name = "frmCustomers";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private MetroFramework.Controls.MetroTextBox tbxSearch;
        private MetroFramework.Controls.MetroLink tbxHome;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel tbxCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerGsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewButtonColumn Show;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private MetroFramework.Controls.MetroButton btnAdd;
    }
}