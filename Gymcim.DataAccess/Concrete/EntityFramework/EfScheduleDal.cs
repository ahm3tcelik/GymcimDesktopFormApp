using Gymcim.Core.DataAccess.EntityFramework;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Gymcim.DataAccess.Concrete.EntityFramework
{
    public class EfScheduleDal : EfEntityRepositoryBase<Schedule, GymcimContext>, IScheduleDal
    {
        public List<Schedule> GetAllDistinct()
        {
            using (GymcimContext context = new GymcimContext())
            {
                var result = context.Database.SqlQuery<Schedule>("SELECT DISTINCT * FROM Schedules")
                    .ToList<Schedule>();
                return result;
            }
        }
    }
}
