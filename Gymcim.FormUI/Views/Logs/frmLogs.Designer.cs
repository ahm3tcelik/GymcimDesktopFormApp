using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Logs
{
    partial class frmLogs
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
            this.tbxSearch = new MetroFramework.Controls.MetroTextBox();
            this.tbxHome = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.tbxCounter = new MetroFramework.Controls.MetroLabel();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxEvents = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
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
            this.tbxSearch.Location = new System.Drawing.Point(656, 36);
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
            this.tbxHome.BackColor = System.Drawing.Color.White;
            this.tbxHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxHome.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.tbxHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.tbxHome.Location = new System.Drawing.Point(23, 33);
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
            this.metroLink1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.metroLink1.Location = new System.Drawing.Point(116, 35);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(112, 24);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "/ Log Kayıtları";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // tbxCounter
            // 
            this.tbxCounter.AutoSize = true;
            this.tbxCounter.FontSize = MetroFramework.MetroLabelSize.Small;
            this.tbxCounter.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tbxCounter.Location = new System.Drawing.Point(20, 396);
            this.tbxCounter.Name = "tbxCounter";
            this.tbxCounter.Size = new System.Drawing.Size(42, 15);
            this.tbxCounter.TabIndex = 4;
            this.tbxCounter.Text = "Satır: 6";
            // 
            // lvLogs
            // 
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvLogs.FullRowSelect = true;
            this.lvLogs.GridLines = true;
            this.lvLogs.HideSelection = false;
            this.lvLogs.Location = new System.Drawing.Point(23, 65);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(757, 358);
            this.lvLogs.TabIndex = 5;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mesaj";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Olay";
            // 
            // cbxEvents
            // 
            this.cbxEvents.FormattingEnabled = true;
            this.cbxEvents.Items.AddRange(new object[] {
            "AUTH",
            "LOGIN",
            "LOGOUT"});
            this.cbxEvents.Location = new System.Drawing.Point(529, 37);
            this.cbxEvents.Name = "cbxEvents";
            this.cbxEvents.Size = new System.Drawing.Size(121, 21);
            this.cbxEvents.TabIndex = 7;
            this.cbxEvents.Text = "Tümü";
            this.cbxEvents.SelectedIndexChanged += new System.EventHandler(this.cbxEvents_SelectedIndexChanged);
            // 
            // frmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxEvents);
            this.Controls.Add(this.lvLogs);
            this.Controls.Add(this.tbxCounter);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.tbxHome);
            this.Controls.Add(this.tbxSearch);
            this.DisplayHeader = false;
            this.Name = "frmLogs";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.frmLogs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbxSearch;
        private MetroFramework.Controls.MetroLink tbxHome;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel tbxCounter;
        private ListView lvLogs;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ComboBox cbxEvents;
    }
}