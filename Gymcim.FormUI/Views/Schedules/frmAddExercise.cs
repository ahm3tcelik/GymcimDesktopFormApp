using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.DataAccess.ValidationRules.FluentValidation;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Schedules
{
    public partial class frmAddExercise : MetroFramework.Forms.MetroForm
    {
        private Exercise exercise;
        private Schedule schedule;
        private List<Part> parts;
        private IExerciseService exerciseService;
        private IPartService partService;
        public frmAddExercise(Schedule schedule, Exercise exercise = null)
        {
            InitializeComponent();
            this.exercise = exercise;
            this.schedule = schedule;
            exerciseService = InstanceFactory.GetInstance<IExerciseService>();
            partService = InstanceFactory.GetInstance<IPartService>();
        }

        private void frmAddExercise_Load(object sender, EventArgs e)
        {
            LoadParts();
            if (exercise != null)
            {
                SetData();
            }
        }

        private void LoadParts()
        {
            try
            {
                parts = partService.GetAll(Session.currentUser);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            cbxParts.DataSource = parts;
            cbxParts.DataSource = parts;
            cbxParts.DisplayMember = "PartName";
            cbxParts.ValueMember = "PartID";
        }

        private void SetData()
        {
            exercise.ScheduleID = schedule.ScheduleID;
            cbxParts.SelectedItem = exercise.Part;
            tbxExerciseDay.Text = exercise.ExerciseDay.ToString();
            tbxExerciseDesc.Text = exercise.ExerciseDesc;
            tbxExerciseName.Text = exercise.ExerciseName;
            tbxExerciseRep.Text = exercise.ExerciseRep.ToString();
            tbxExerciseSet.Text = exercise.ExerciseSet.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(exercise != null) // UPDATE
            {
                exercise.Schedule = null;
                exercise.Part = null;
                try
                {
                    GetDataFromViews();
                    ValidationTool.Validate(new ExerciseValidator(), exercise);
                    exerciseService.Update(exercise, Session.currentUser);
                    MessageBox.Show("Egzersiz başarıyla güncellendi.", "Başarılı!");
                    this.Close();

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata!");
                    System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                }
            }
            else // CREATE
            {
                exercise = new Exercise { ScheduleID = schedule.ScheduleID };
    
                try
                {
                    GetDataFromViews();
                    ValidationTool.Validate(new ExerciseValidator(), exercise);
                    exerciseService.Add(exercise, Session.currentUser);
                    MessageBox.Show("Egzersiz başarıyla oluşturuldu.", "Başarılı!");
                    this.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata!");
                    System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetDataFromViews()
        {
            exercise.ExerciseName = tbxExerciseName.Text.Trim();
            exercise.ExerciseRep = Convert.ToInt32(tbxExerciseRep.Text.Trim());
            exercise.ExerciseSet = Convert.ToInt32(tbxExerciseSet.Text.Trim());
            exercise.ExerciseDay = Convert.ToInt32(tbxExerciseDay.Text.Trim());
            exercise.ExerciseDesc = tbxExerciseDesc.Text.Trim();
            exercise.PartID = Convert.ToInt32(cbxParts.SelectedValue);
        }
    }
}
