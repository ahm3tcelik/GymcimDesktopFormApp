namespace Gymcim.FormUI.Views.Schedules
{
    partial class frmEditSchedule
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
            this.btnDel = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.lvlExercises = new System.Windows.Forms.ListView();
            this.ExerciseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExerciseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExerciseSet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExerciseRep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExerciseDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExerciseDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.tbxHome = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(375, 59);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(130, 23);
            this.btnDel.TabIndex = 44;
            this.btnDel.Text = "Sil";
            this.btnDel.UseSelectable = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(511, 59);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 23);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(647, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 23);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvlExercises
            // 
            this.lvlExercises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlExercises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ExerciseID,
            this.ExerciseName,
            this.ExerciseSet,
            this.ExerciseRep,
            this.ExerciseDay,
            this.PartName,
            this.ExerciseDesc});
            this.lvlExercises.FullRowSelect = true;
            this.lvlExercises.GridLines = true;
            this.lvlExercises.HideSelection = false;
            this.lvlExercises.Location = new System.Drawing.Point(23, 88);
            this.lvlExercises.MultiSelect = false;
            this.lvlExercises.Name = "lvlExercises";
            this.lvlExercises.Size = new System.Drawing.Size(755, 339);
            this.lvlExercises.TabIndex = 41;
            this.lvlExercises.UseCompatibleStateImageBehavior = false;
            this.lvlExercises.View = System.Windows.Forms.View.Details;
            this.lvlExercises.SelectedIndexChanged += new System.EventHandler(this.lvlExercises_SelectedIndexChanged);
            // 
            // ExerciseID
            // 
            this.ExerciseID.Text = "#";
            this.ExerciseID.Width = 30;
            // 
            // ExerciseName
            // 
            this.ExerciseName.Text = "Egzersiz Adı";
            this.ExerciseName.Width = 120;
            // 
            // ExerciseSet
            // 
            this.ExerciseSet.Text = "Set";
            this.ExerciseSet.Width = 130;
            // 
            // ExerciseRep
            // 
            this.ExerciseRep.Text = "Tekrar";
            this.ExerciseRep.Width = 100;
            // 
            // ExerciseDay
            // 
            this.ExerciseDay.Text = "Gün";
            // 
            // ExerciseDesc
            // 
            this.ExerciseDesc.Text = "Açıklama";
            this.ExerciseDesc.Width = 230;
            // 
            // PartName
            // 
            this.PartName.Text = "Etkili Bölge";
            this.PartName.Width = 82;
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.metroLink1.Location = new System.Drawing.Point(117, 60);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(222, 24);
            this.metroLink1.TabIndex = 46;
            this.metroLink1.Text = "/ Çalışma Programı Düzenleme";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // tbxHome
            // 
            this.tbxHome.BackColor = System.Drawing.Color.White;
            this.tbxHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxHome.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.tbxHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.tbxHome.Location = new System.Drawing.Point(23, 58);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(98, 24);
            this.tbxHome.TabIndex = 45;
            this.tbxHome.Text = "Ana Sayfa";
            this.tbxHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxHome.UseCustomForeColor = true;
            this.tbxHome.UseSelectable = true;
            this.tbxHome.Click += new System.EventHandler(this.tbxHome_Click);
            // 
            // frmEditSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.tbxHome);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvlExercises);
            this.Name = "frmEditSchedule";
            this.Text = "Çalışma Programı Düzenle";
            this.Load += new System.EventHandler(this.frmEditSchedule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDel;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.ListView lvlExercises;
        private System.Windows.Forms.ColumnHeader ExerciseID;
        private System.Windows.Forms.ColumnHeader ExerciseName;
        private System.Windows.Forms.ColumnHeader ExerciseSet;
        private System.Windows.Forms.ColumnHeader ExerciseRep;
        private System.Windows.Forms.ColumnHeader ExerciseDay;
        private System.Windows.Forms.ColumnHeader ExerciseDesc;
        private System.Windows.Forms.ColumnHeader PartName;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink tbxHome;
    }
}