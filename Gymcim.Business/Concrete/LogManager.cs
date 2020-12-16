using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.Business.Utilities;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System.Collections.Generic;

namespace Gymcim.Business.Concrete
{
    public static class LogManager
    {
        private static ILogDal logDal = InstanceFactory.GetInstance<ILogDal>();

        public static void Log(Log log)
        {
            logDal.Add(log);
        }
        public static List<Log> GetAll(User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.showLog);
            return logDal.GetAll();
        }
        public static List<Log> SearchByMessage(string message, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.showLog);
            return logDal.GetAll(l => l.LogMessage.Contains(message));
        }

        public static List<Log> GetByEvent(string eventName, User authority) {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.showLog);
            return logDal.GetAll(l => l.LogEvent == eventName);
        }

        public static List<string> GetEvents()
        {
            return logDal.GetEvents();
        }
    }
}
