using Gymcim.Entities.Concrete;
using System.Collections.Generic;

namespace Gymcim.Business.Abstract
{
    public interface IScheduleService : IRepositoryService<Schedule>
    {
        List<Schedule> GetAllDistinct();
        List<Schedule> SearchByNameAndDesc(string key);
    }
}
