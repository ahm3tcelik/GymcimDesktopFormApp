namespace Gymcim.FormUI.Views.Schedules
{
    partial class exerciseUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new MetroFramework.Controls.MetroPanel();
            this.lblDay = new MetroFramework.Controls.MetroLabel();
            this.tblExercises = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelHeader.Controls.Add(this.lblDay);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.HorizontalScrollbarBarColor = true;
            this.panelHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.panelHeader.HorizontalScrollbarSize = 10;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(360, 45);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.UseCustomBackColor = true;
            this.panelHeader.UseCustomForeColor = true;
            this.panelHeader.VerticalScrollbarBarColor = true;
            this.panelHeader.VerticalScrollbarHighlightOnWheel = false;
            this.panelHeader.VerticalScrollbarSize = 10;
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDay.AutoSize = true;
            this.lblDay.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDay.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(156, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(49, 25);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "GÜN";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDay.UseCustomBackColor = true;
            this.lblDay.UseCustomForeColor = true;
            // 
            // tblExercises
            // 
            this.tblExercises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblExercises.ColumnCount = 4;
            this.tblExercises.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblExercises.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblExercises.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblExercises.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblExercises.Location = new System.Drawing.Point(0, 45);
            this.tblExercises.Name = "tblExercises";
            this.tblExercises.RowCount = 1;
            this.tblExercises.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblExercises.Size = new System.Drawing.Size(360, 215);
            this.tblExercises.TabIndex = 1;
            // 
            // exerciseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tblExercises);
            this.Controls.Add(this.panelHeader);
            this.Name = "exerciseUserControl";
            this.Size = new System.Drawing.Size(360, 260);
            this.Load += new System.EventHandler(this.exerciseUserControl_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelHeader;
        private MetroFramework.Controls.MetroLabel lblDay;
        private System.Windows.Forms.TableLayoutPanel tblExercises;
    }
}
