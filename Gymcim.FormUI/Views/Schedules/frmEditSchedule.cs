using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.Business.Utilities;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Schedules
{
    public partial class frmEditSchedule : MetroFramework.Forms.MetroForm
    {
        private Schedule schedule;
        private List<Exercise> exercises = new List<Exercise>();
        private IExerciseService exerciseService;
        public frmEditSchedule(Schedule schedule)
        {
            InitializeComponent();
            exerciseService = InstanceFactory.GetInstance<IExerciseService>();
            this.schedule = schedule;
            BlockUnauthorizedViews();
        }

        private void BlockUnauthorizedViews()
        {
            btnAdd.Enabled = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.addSchedule);
            btnEdit.Enabled = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.editSchedule);
            btnDel.Enabled = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.delSchedule);
        }

        private void LoadExercises()
        {
            List<dynamic> dyamicExercises = exerciseService.GetAllWithPartBySchedule(schedule.ScheduleID);
            exercises.Clear();
            foreach (dynamic e in dyamicExercises)
            {
                Exercise exercise = new Exercise
                {
                    ExerciseID = e.ExerciseID,
                    ExerciseName = e.ExerciseName,
                    ExerciseSet = e.ExerciseSet,
                    ExerciseRep = e.ExerciseRep,
                    ExerciseDay = e.ExerciseDay,
                    ExerciseDesc = e.ExerciseDesc,
                    PartID = e.PartID,
                    Part = new Part { PartID = e.PartID, PartName = e.PartName },
                    ScheduleID = e.ScheduleID
                };

                exercises.Add(exercise);
            }

            lvlExercises.Items.Clear();
            foreach (Exercise exercise in exercises)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(exercise.ExerciseID));
                item.SubItems.Add(exercise.ExerciseName);
                item.SubItems.Add(exercise.ExerciseSet.ToString());
                item.SubItems.Add(exercise.ExerciseRep.ToString());
                item.SubItems.Add(exercise.ExerciseDay.ToString());
                item.SubItems.Add(exercise.Part.PartName);
                item.SubItems.Add(exercise.ExerciseDesc);

                lvlExercises.Items.Add(item);
            }
            lvlExercises.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void frmEditSchedule_Load(object sender, EventArgs e)
        {
            LoadExercises();
        }

        private void lvlExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDel.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvlExercises.SelectedItems.Count < 1)
                return;

            NavigationTool.OpenNewTab(new frmAddExercise(schedule, exercises[lvlExercises.SelectedItems[0].Index]));
            LoadExercises();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvlExercises.SelectedItems.Count < 1)
                return;

            Exercise ex = exercises[lvlExercises.SelectedItems[0].Index];
            DialogResult dialogResult = MessageBox.Show("#" + ex.ExerciseID + " " + ex.ExerciseName + 
                " adlı egzersizi silmek istediğinizden emin misiniz?", "Egzersiz Sil", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    exerciseService.Delete(ex, Session.currentUser);
                    MessageBox.Show("Egzersiz başarıyla silindi!", "Başarılı!");
                    lvlExercises.Items.RemoveAt(lvlExercises.SelectedItems[0].Index);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Hata!");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NavigationTool.OpenNewTab(new frmAddExercise(schedule, null));
            LoadExercises();
        }

        private void tbxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
