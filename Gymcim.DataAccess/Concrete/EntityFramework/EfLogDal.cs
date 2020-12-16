using Gymcim.Core.DataAccess.EntityFramework;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Gymcim.DataAccess.Concrete.EntityFramework
{
    public class EfLogDal : EfEntityRepositoryBase<Log, GymcimContext>, ILogDal
    {
        public List<string> GetEvents()
        {
            using (GymcimContext context = new GymcimContext())
            {
                var result = context.Database.SqlQuery<string>("SELECT DISTINCT LogEvent FROM Logs").ToList<string>();
                return result;
            }

        }
    }
}
