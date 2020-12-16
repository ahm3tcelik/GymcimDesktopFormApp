namespace Gymcim.FormUI.Views.Schedules
{
    partial class frmAddExercise
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
            this.cbxParts = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbxExerciseDesc = new MetroFramework.Controls.MetroTextBox();
            this.tbxExerciseName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbxExerciseDay = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbxExerciseSet = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbxExerciseRep = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.tbxExerciseRep);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.tbxExerciseSet);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.tbxExerciseDay);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cbxParts);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbxExerciseDesc);
            this.groupBox1.Controls.Add(this.tbxExerciseName);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(168, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 36);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(6, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxParts
            // 
            this.cbxParts.FormattingEnabled = true;
            this.cbxParts.ItemHeight = 23;
            this.cbxParts.Location = new System.Drawing.Point(7, 158);
            this.cbxParts.Name = "cbxParts";
            this.cbxParts.Size = new System.Drawing.Size(155, 29);
            this.cbxParts.TabIndex = 12;
            this.cbxParts.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 135);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Etkili Bölge";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(168, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Açıklama";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Egzersiz Adı";
            // 
            // tbxExerciseDesc
            // 
            // 
            // 
            // 
            this.tbxExerciseDesc.CustomButton.Image = null;
            this.tbxExerciseDesc.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbxExerciseDesc.CustomButton.Name = "";
            this.tbxExerciseDesc.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxExerciseDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxExerciseDesc.CustomButton.TabIndex = 1;
            this.tbxExerciseDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxExerciseDesc.CustomButton.UseSelectable = true;
            this.tbxExerciseDesc.CustomButton.Visible = false;
            this.tbxExerciseDesc.Lines = new string[0];
            this.tbxExerciseDesc.Location = new System.Drawing.Point(168, 39);
            this.tbxExerciseDesc.MaxLength = 32767;
            this.tbxExerciseDesc.Name = "tbxExerciseDesc";
            this.tbxExerciseDesc.PasswordChar = '\0';
            this.tbxExerciseDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxExerciseDesc.SelectedText = "";
            this.tbxExerciseDesc.SelectionLength = 0;
            this.tbxExerciseDesc.SelectionStart = 0;
            this.tbxExerciseDesc.ShortcutsEnabled = true;
            this.tbxExerciseDesc.Size = new System.Drawing.Size(156, 29);
            this.tbxExerciseDesc.TabIndex = 1;
            this.tbxExerciseDesc.UseSelectable = true;
            this.tbxExerciseDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxExerciseDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxExerciseName
            // 
            // 
            // 
            // 
            this.tbxExerciseName.CustomButton.Image = null;
            this.tbxExerciseName.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbxExerciseName.CustomButton.Name = "";
            this.tbxExerciseName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxExerciseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxExerciseName.CustomButton.TabIndex = 1;
            this.tbxExerciseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxExerciseName.CustomButton.UseSelectable = true;
            this.tbxExerciseName.CustomButton.Visible = false;
            this.tbxExerciseName.Lines = new string[0];
            this.tbxExerciseName.Location = new System.Drawing.Point(6, 39);
            this.tbxExerciseName.MaxLength = 32767;
            this.tbxExerciseName.Name = "tbxExerciseName";
            this.tbxExerciseName.PasswordChar = '\0';
            this.tbxExerciseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxExerciseName.SelectedText = "";
            this.tbxExerciseName.SelectionLength = 0;
            this.tbxExerciseName.SelectionStart = 0;
            this.tbxExerciseName.ShortcutsEnabled = true;
            this.tbxExerciseName.Size = new System.Drawing.Size(156, 29);
            this.tbxExerciseName.TabIndex = 0;
            this.tbxExerciseName.UseSelectable = true;
            this.tbxExerciseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxExerciseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(168, 136);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Egzersiz Günü";
            // 
            // tbxExerciseDay
            // 
            // 
            // 
            // 
            this.tbxExerciseDay.CustomButton.Image = null;
            this.tbxExerciseDay.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbxExerciseDay.CustomButton.Name = "";
            this.tbxExerciseDay.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxExerciseDay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxExerciseDay.CustomButton.TabIndex = 1;
            this.tbxExerciseDay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxExerciseDay.CustomButton.UseSelectable = true;
            this.tbxExerciseDay.CustomButton.Visible = false;
            this.tbxExerciseDay.Lines = new string[0];
            this.tbxExerciseDay.Location = new System.Drawing.Point(168, 158);
            this.tbxExerciseDay.MaxLength = 32767;
            this.tbxExerciseDay.Name = "tbxExerciseDay";
            this.tbxExerciseDay.PasswordChar = '\0';
            this.tbxExerciseDay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxExerciseDay.SelectedText = "";
            this.tbxExerciseDay.SelectionLength = 0;
            this.tbxExerciseDay.SelectionStart = 0;
            this.tbxExerciseDay.ShortcutsEnabled = true;
            this.tbxExerciseDay.Size = new System.Drawing.Size(156, 29);
            this.tbxExerciseDay.TabIndex = 15;
            this.tbxExerciseDay.UseSelectable = true;
            this.tbxExerciseDay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxExerciseDay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Set Sayısı";
            // 
            // tbxExerciseSet
            // 
            // 
            // 
            // 
            this.tbxExerciseSet.CustomButton.Image = null;
            this.tbxExerciseSet.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.tbxExerciseSet.CustomButton.Name = "";
            this.tbxExerciseSet.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxExerciseSet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxExerciseSet.CustomButton.TabIndex = 1;
            this.tbxExerciseSet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxExerciseSet.CustomButton.UseSelectable = true;
            this.tbxExerciseSet.CustomButton.Visible = false;
            this.tbxExerciseSet.Lines = new string[0];
            this.tbxExerciseSet.Location = new System.Drawing.Point(7, 96);
            this.tbxExerciseSet.MaxLength = 32767;
            this.tbxExerciseSet.Name = "tbxExerciseSet";
            this.tbxExerciseSet.PasswordChar = '\0';
            this.tbxExerciseSet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxExerciseSet.SelectedText = "";
            this.tbxExerciseSet.SelectionLength = 0;
            this.tbxExerciseSet.SelectionStart = 0;
            this.tbxExerciseSet.ShortcutsEnabled = true;
            this.tbxExerciseSet.Size = new System.Drawing.Size(155, 29);
            this.tbxExerciseSet.TabIndex = 17;
            this.tbxExerciseSet.UseSelectable = true;
            this.tbxExerciseSet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxExerciseSet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(168, 74);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(79, 19);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "Tekrar Sayısı";
            // 
            // tbxExerciseRep
            // 
            // 
            // 
            // 
            this.tbxExerciseRep.CustomButton.Image = null;
            this.tbxExerciseRep.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.tbxExerciseRep.CustomButton.Name = "";
            this.tbxExerciseRep.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxExerciseRep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxExerciseRep.CustomButton.TabIndex = 1;
            this.tbxExerciseRep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxExerciseRep.CustomButton.UseSelectable = true;
            this.tbxExerciseRep.CustomButton.Visible = false;
            this.tbxExerciseRep.Lines = new string[0];
            this.tbxExerciseRep.Location = new System.Drawing.Point(168, 96);
            this.tbxExerciseRep.MaxLength = 32767;
            this.tbxExerciseRep.Name = "tbxExerciseRep";
            this.tbxExerciseRep.PasswordChar = '\0';
            this.tbxExerciseRep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxExerciseRep.SelectedText = "";
            this.tbxExerciseRep.SelectionLength = 0;
            this.tbxExerciseRep.SelectionStart = 0;
            this.tbxExerciseRep.ShortcutsEnabled = true;
            this.tbxExerciseRep.Size = new System.Drawing.Size(155, 29);
            this.tbxExerciseRep.TabIndex = 19;
            this.tbxExerciseRep.UseSelectable = true;
            this.tbxExerciseRep.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxExerciseRep.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAddExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 336);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddExercise";
            this.Resizable = false;
            this.Text = "Egzersiz Ekle/Düzenle";
            this.Load += new System.EventHandler(this.frmAddExercise_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbxExerciseRep;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbxExerciseSet;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbxExerciseDay;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroComboBox cbxParts;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbxExerciseDesc;
        private MetroFramework.Controls.MetroTextBox tbxExerciseName;
    }
}