using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Gymcim.FormUI.Views.Schedules
{
    public partial class frmScheduleDetail : MetroFramework.Forms.MetroForm
    {
        private Schedule schedule;
        private List<Exercise> exercises = new List<Exercise>();
        private IExerciseService exerciseService;
        public frmScheduleDetail(Schedule schedule)
        {
            InitializeComponent();
            exerciseService = InstanceFactory.GetInstance<IExerciseService>();
            this.schedule = schedule;
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

            var groupExercises = exercises.GroupBy(e => e.ExerciseDay).Select(group => group.ToList()).ToList();
            
            
            foreach(var exercisesPerDay in groupExercises)
            {
                exerciseUserControl exerciseUserControl = new exerciseUserControl(exercisesPerDay);
                flpSchedules.Controls.Add(exerciseUserControl);
            }
        }
        private void frmScheduleDetail_Load(object sender, EventArgs e)
        {
            LoadExercises();
        }
    }
}
