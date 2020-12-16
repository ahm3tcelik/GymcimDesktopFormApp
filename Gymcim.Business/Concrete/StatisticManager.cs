using Gymcim.Business.Abstract;
using Gymcim.Business.Utilities;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Gymcim.Business.Concrete
{
    public class StatisticManager : IStatisticService
    {
        private IStatisticDal statisticDal;

        public StatisticManager(IStatisticDal statisticDal)
        {
            this.statisticDal = statisticDal;
        }

        public void Add(Statistic ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.editCustomer);
            statisticDal.Add(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_CREATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "İstatistik eklendi."
            });
        }

        public void Delete(Statistic ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.editCustomer);
            statisticDal.Delete(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_DELETE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "İstatistik silindi."
            });
        }

        public List<Statistic> GetAll(User authority)
        {
            return statisticDal.GetAll();
        }

        public List<Statistic> GetAllByCustomerId(int customerID)
        {
            return statisticDal.GetAll(e => e.CustomerID == customerID);
        }

        public Statistic GetById(int id)
        {
            return statisticDal.Get(e => e.StatisticID == id);
        }

        public void Update(Statistic ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.editCustomer);
            statisticDal.Update(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_UPDATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "İstatistik güncellendi."
            });
        }
    }
}
