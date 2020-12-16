using Gymcim.Business.Abstract;
using Gymcim.Business.Utilities;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Gymcim.Business.Concrete
{
    public class ScheduleManager : IScheduleService
    {
        private IScheduleDal scheduleDal;

        public ScheduleManager(IScheduleDal scheduleDal)
        {
            this.scheduleDal = scheduleDal;
        }

        public void Add(Schedule ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.addSchedule);
            scheduleDal.Add(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_UPDATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Çalışma Programı eklendi."
            });
        }

        public void Delete(Schedule ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.delSchedule);
            scheduleDal.Delete(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_DELETE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Çalışma Programı silindi."
            });
        }

        public List<Schedule> GetAll(User authority)
        {
            return scheduleDal.GetAll();
        }

        public List<Schedule> GetAllDistinct()
        {   
            return scheduleDal.GetAllDistinct();
        }
        public Schedule GetById(int id)
        {
            return scheduleDal.Get(e => e.ScheduleID == id);
        }

        public List<Schedule> SearchByNameAndDesc(string key)
        {
            return scheduleDal.GetAll(e => e.ScheduleName.ToLower().Contains(key.ToLower()) || 
                e.ScheduleDesc.ToLower().Contains(key.ToLower()));
        }

        public void Update(Schedule ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.editSchedule);
            scheduleDal.Update(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_UPDATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Çalışma Programı güncellendi."
            });
        }
    }
}
