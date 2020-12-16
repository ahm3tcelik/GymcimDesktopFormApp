using Gymcim.Business.Abstract;
using Gymcim.Business.Utilities;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Gymcim.Business.Concrete
{
    public class ExerciseManager : IExerciseService
    {
        private IExerciseDal exerciseDal;

        public ExerciseManager(IExerciseDal exerciseDal)
        {
            this.exerciseDal = exerciseDal;
        }

        public void Add(Exercise ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.addSchedule);
            exerciseDal.Add(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_CREATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Egzersiz eklendi."
            });
        }

        public void Delete(Exercise ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.delSchedule);
            exerciseDal.Delete(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_DELETE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Egzersiz silindi."
            });
        }

        public List<Exercise> GetAll(User authority)
        {
            return exerciseDal.GetAll();
        }

        public List<Exercise> GetAllBySchedule(int scheduleID)
        {
            return exerciseDal.GetAll(e => e.ScheduleID == scheduleID);
        }

        public List<dynamic> GetAllWithPartBySchedule(int scheduleID)
        {
            return exerciseDal.GetAllWithPartBySchedule(scheduleID);
        }

        public Exercise GetById(int id)
        {
            return exerciseDal.Get(e => e.ExerciseID == id);
        }

        public void Update(Exercise ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.editSchedule);
            exerciseDal.Update(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_UPDATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Egzersiz güncellendi."
            });
        }
    }
}
