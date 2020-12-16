namespace Gymcim.FormUI.Views
{
    partial class frmHome
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
        /// 
        #endregion
        private void InitializeComponent()
        {
            this.tileCustomers = new MetroFramework.Controls.MetroTile();
            this.tileSettings = new MetroFramework.Controls.MetroTile();
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.tileLog = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tileSchedule = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileCustomers
            // 
            this.tileCustomers.ActiveControl = null;
            this.tileCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileCustomers.AutoSize = true;
            this.tileCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.tileCustomers.Location = new System.Drawing.Point(3, 3);
            this.tileCustomers.Name = "tileCustomers";
            this.tileCustomers.Size = new System.Drawing.Size(245, 176);
            this.tileCustomers.TabIndex = 5;
            this.tileCustomers.Text = "MÜŞTERİ YÖNETİMİ";
            this.tileCustomers.TileImage = global::Gymcim.FormUI.Properties.Resources.customers;
            this.tileCustomers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCustomers.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCustomers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileCustomers.UseMnemonic = false;
            this.tileCustomers.UseSelectable = true;
            this.tileCustomers.UseTileImage = true;
            this.tileCustomers.Click += new System.EventHandler(this.tileCustomers_Click);
            // 
            // tileSettings
            // 
            this.tileSettings.ActiveControl = null;
            this.tileSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileSettings.AutoSize = true;
            this.tileSettings.Location = new System.Drawing.Point(3, 185);
            this.tileSettings.Name = "tileSettings";
            this.tileSettings.Size = new System.Drawing.Size(245, 176);
            this.tileSettings.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileSettings.TabIndex = 4;
            this.tileSettings.Text = "AYARLAR";
            this.tileSettings.TileImage = global::Gymcim.FormUI.Properties.Resources.admin;
            this.tileSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileSettings.UseSelectable = true;
            this.tileSettings.UseTileImage = true;
            this.tileSettings.Click += new System.EventHandler(this.tileSettings_Click);
            // 
            // tileLogout
            // 
            this.tileLogout.ActiveControl = null;
            this.tileLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileLogout.AutoSize = true;
            this.tileLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.tileLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileLogout.Location = new System.Drawing.Point(505, 185);
            this.tileLogout.Name = "tileLogout";
            this.tileLogout.Size = new System.Drawing.Size(246, 176);
            this.tileLogout.Style = MetroFramework.MetroColorStyle.Red;
            this.tileLogout.TabIndex = 6;
            this.tileLogout.Text = "ÇIKIŞ YAP";
            this.tileLogout.TileImage = global::Gymcim.FormUI.Properties.Resources.power;
            this.tileLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileLogout.UseCustomBackColor = true;
            this.tileLogout.UseSelectable = true;
            this.tileLogout.UseTileImage = true;
            this.tileLogout.Click += new System.EventHandler(this.tileLogout_Click);
            // 
            // tileLog
            // 
            this.tileLog.ActiveControl = null;
            this.tileLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileLog.AutoSize = true;
            this.tileLog.Location = new System.Drawing.Point(505, 3);
            this.tileLog.Name = "tileLog";
            this.tileLog.Size = new System.Drawing.Size(246, 176);
            this.tileLog.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileLog.TabIndex = 7;
            this.tileLog.Text = "LOG KAYITLARI";
            this.tileLog.TileImage = global::Gymcim.FormUI.Properties.Resources.log;
            this.tileLog.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLog.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLog.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileLog.UseSelectable = true;
            this.tileLog.UseTileImage = true;
            this.tileLog.Click += new System.EventHandler(this.tileLog_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tileLog, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tileLogout, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tileSettings, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tileCustomers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tileSchedule, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 364);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tileSchedule
            // 
            this.tileSchedule.ActiveControl = null;
            this.tileSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileSchedule.AutoSize = true;
            this.tileSchedule.Location = new System.Drawing.Point(254, 3);
            this.tileSchedule.Name = "tileSchedule";
            this.tableLayoutPanel1.SetRowSpan(this.tileSchedule, 2);
            this.tileSchedule.Size = new System.Drawing.Size(245, 358);
            this.tileSchedule.Style = MetroFramework.MetroColorStyle.Green;
            this.tileSchedule.TabIndex = 3;
            this.tileSchedule.Text = "ÇALIŞMA PROGRAMI";
            this.tileSchedule.TileImage = global::Gymcim.FormUI.Properties.Resources.schedule;
            this.tileSchedule.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSchedule.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSchedule.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileSchedule.UseSelectable = true;
            this.tileSchedule.UseTileImage = true;
            this.tileSchedule.Click += new System.EventHandler(this.tileSchedule_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmHome";
            this.Text = "Gymcim Yönetim Paneli";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private MetroFramework.Controls.MetroTile tileCustomers;
        private MetroFramework.Controls.MetroTile tileSettings;
        private MetroFramework.Controls.MetroTile tileLogout;
        private MetroFramework.Controls.MetroTile tileLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile tileSchedule;
    }
}