namespace Gymcim.FormUI.Views.Schedules
{
    partial class frmSchedules
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
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.tbxHome = new MetroFramework.Controls.MetroLink();
            this.tbxSearch = new MetroFramework.Controls.MetroTextBox();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.ScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbxCounter = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(647, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Program Ekle";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.metroLink1.Location = new System.Drawing.Point(111, 48);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(163, 24);
            this.metroLink1.TabIndex = 9;
            this.metroLink1.Text = "/ Çalışma Programları";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // tbxHome
            // 
            this.tbxHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHome.BackColor = System.Drawing.Color.White;
            this.tbxHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxHome.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.tbxHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.tbxHome.Location = new System.Drawing.Point(17, 46);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(103, 24);
            this.tbxHome.TabIndex = 8;
            this.tbxHome.Text = "Ana Sayfa";
            this.tbxHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxHome.UseCustomForeColor = true;
            this.tbxHome.UseSelectable = true;
            this.tbxHome.Click += new System.EventHandler(this.tbxHome_Click);
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
            this.tbxSearch.Location = new System.Drawing.Point(520, 49);
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
            this.tbxSearch.TabIndex = 7;
            this.tbxSearch.UseSelectable = true;
            this.tbxSearch.WaterMark = "Ara...";
            this.tbxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AllowUserToAddRows = false;
            this.dgvSchedules.AllowUserToDeleteRows = false;
            this.dgvSchedules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedules.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduleID,
            this.ScheduleName,
            this.ScheduleDesc,
            this.Show,
            this.Edit,
            this.Delete});
            this.dgvSchedules.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSchedules.Location = new System.Drawing.Point(17, 78);
            this.dgvSchedules.MultiSelect = false;
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.ReadOnly = true;
            this.dgvSchedules.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSchedules.Size = new System.Drawing.Size(760, 349);
            this.dgvSchedules.TabIndex = 6;
            this.dgvSchedules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedules_CellClick);
            // 
            // ScheduleID
            // 
            this.ScheduleID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ScheduleID.FillWeight = 101.5229F;
            this.ScheduleID.HeaderText = "#";
            this.ScheduleID.Name = "ScheduleID";
            this.ScheduleID.ReadOnly = true;
            this.ScheduleID.Width = 39;
            // 
            // ScheduleName
            // 
            this.ScheduleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScheduleName.FillWeight = 99.8308F;
            this.ScheduleName.HeaderText = "Program Adı";
            this.ScheduleName.Name = "ScheduleName";
            this.ScheduleName.ReadOnly = true;
            // 
            // ScheduleDesc
            // 
            this.ScheduleDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScheduleDesc.FillWeight = 99.8308F;
            this.ScheduleDesc.HeaderText = "Açıklama";
            this.ScheduleDesc.Name = "ScheduleDesc";
            this.ScheduleDesc.ReadOnly = true;
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
            // tbxCounter
            // 
            this.tbxCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxCounter.AutoSize = true;
            this.tbxCounter.FontSize = MetroFramework.MetroLabelSize.Small;
            this.tbxCounter.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tbxCounter.Location = new System.Drawing.Point(17, 430);
            this.tbxCounter.Name = "tbxCounter";
            this.tbxCounter.Size = new System.Drawing.Size(42, 15);
            this.tbxCounter.TabIndex = 11;
            this.tbxCounter.Text = "Satır: 6";
            // 
            // frmSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxCounter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.tbxHome);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgvSchedules);
            this.DisplayHeader = false;
            this.Name = "frmSchedules";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Load += new System.EventHandler(this.frmSchedules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink tbxHome;
        private MetroFramework.Controls.MetroTextBox tbxSearch;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private MetroFramework.Controls.MetroLabel tbxCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleDesc;
        private System.Windows.Forms.DataGridViewButtonColumn Show;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}