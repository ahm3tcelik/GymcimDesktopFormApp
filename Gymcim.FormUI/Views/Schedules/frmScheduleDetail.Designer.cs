namespace Gymcim.FormUI.Views.Schedules
{
    partial class frmScheduleDetail
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
            this.flpSchedules = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpSchedules
            // 
            this.flpSchedules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSchedules.AutoScroll = true;
            this.flpSchedules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flpSchedules.Location = new System.Drawing.Point(20, 60);
            this.flpSchedules.Name = "flpSchedules";
            this.flpSchedules.Size = new System.Drawing.Size(760, 370);
            this.flpSchedules.TabIndex = 0;
            // 
            // frmScheduleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpSchedules);
            this.Name = "frmScheduleDetail";
            this.Text = "Çalışma Programı";
            this.Load += new System.EventHandler(this.frmScheduleDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSchedules;
    }
}