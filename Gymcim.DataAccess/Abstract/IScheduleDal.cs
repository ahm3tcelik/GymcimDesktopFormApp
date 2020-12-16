using Gymcim.Core.DataAccess;
using Gymcim.Entities.Concrete;
using System.Collections.Generic;

namespace Gymcim.DataAccess.Abstract
{
    public interface IScheduleDal : IEntityRepository<Schedule>
    {
        List<Schedule> GetAllDistinct();
    }
}
