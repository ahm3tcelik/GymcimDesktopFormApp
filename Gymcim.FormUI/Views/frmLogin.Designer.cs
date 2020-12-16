namespace Gymcim.FormUI.Views
{
    partial class frmLogin
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

        #endregion
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.lbForgetPass = new MetroFramework.Controls.MetroLink();
            this.tbxPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbxEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroPanel2);
            this.panel1.Controls.Add(this.lbForgetPass);
            this.panel1.Controls.Add(this.tbxPassword);
            this.panel1.Controls.Add(this.tbxEmail);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(23, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 280);
            this.panel1.TabIndex = 1;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroPanel2.Controls.Add(this.btnLogin);
            this.metroPanel2.Controls.Add(this.btnReset);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 179);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(314, 37);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnLogin.DisplayFocus = true;
            this.btnLogin.Location = new System.Drawing.Point(0, 3);
            this.btnLogin.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 31);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.White;
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseCustomBackColor = true;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.UseStyleColors = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnReset.DisplayFocus = true;
            this.btnReset.Location = new System.Drawing.Point(159, 3);
            this.btnReset.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(155, 32);
            this.btnReset.Style = MetroFramework.MetroColorStyle.White;
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Sıfırla";
            this.btnReset.UseCustomBackColor = true;
            this.btnReset.UseSelectable = true;
            this.btnReset.UseStyleColors = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbForgetPass
            // 
            this.lbForgetPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbForgetPass.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lbForgetPass.Location = new System.Drawing.Point(0, 147);
            this.lbForgetPass.Name = "lbForgetPass";
            this.lbForgetPass.Size = new System.Drawing.Size(107, 16);
            this.lbForgetPass.TabIndex = 6;
            this.lbForgetPass.Text = "Parolamı Unuttum";
            this.lbForgetPass.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbForgetPass.UseSelectable = true;
            this.lbForgetPass.Click += new System.EventHandler(this.lbForgetPass_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbxPassword.CustomButton.Image = null;
            this.tbxPassword.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.tbxPassword.CustomButton.Name = "";
            this.tbxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPassword.CustomButton.TabIndex = 1;
            this.tbxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPassword.CustomButton.UseSelectable = true;
            this.tbxPassword.CustomButton.Visible = false;
            this.tbxPassword.Lines = new string[0];
            this.tbxPassword.Location = new System.Drawing.Point(0, 121);
            this.tbxPassword.MaxLength = 32767;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '•';
            this.tbxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPassword.SelectedText = "";
            this.tbxPassword.SelectionLength = 0;
            this.tbxPassword.SelectionStart = 0;
            this.tbxPassword.ShortcutsEnabled = true;
            this.tbxPassword.Size = new System.Drawing.Size(314, 23);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.UseSelectable = true;
            this.tbxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbxEmail.CustomButton.Image = null;
            this.tbxEmail.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.tbxEmail.CustomButton.Name = "";
            this.tbxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxEmail.CustomButton.TabIndex = 1;
            this.tbxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxEmail.CustomButton.UseSelectable = true;
            this.tbxEmail.CustomButton.Visible = false;
            this.tbxEmail.DisplayIcon = true;
            this.tbxEmail.Lines = new string[0];
            this.tbxEmail.Location = new System.Drawing.Point(0, 57);
            this.tbxEmail.MaxLength = 32767;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PasswordChar = '\0';
            this.tbxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxEmail.SelectedText = "";
            this.tbxEmail.SelectionLength = 0;
            this.tbxEmail.SelectionStart = 0;
            this.tbxEmail.ShortcutsEnabled = true;
            this.tbxEmail.Size = new System.Drawing.Size(314, 23);
            this.tbxEmail.TabIndex = 2;
            this.tbxEmail.UseSelectable = true;
            this.tbxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(0, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Parola (123456)";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(0, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(192, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "E-Posta (demo@gymcim.com)";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(74, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(208, 15);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Software && Design ❤️ by Ahmet ÇELİK";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 450);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(360, 30);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 480);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(23, 30, 23, 20);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox tbxPassword;
        private MetroFramework.Controls.MetroTextBox tbxEmail;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink lbForgetPass;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}