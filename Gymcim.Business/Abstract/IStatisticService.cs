using Gymcim.Entities.Concrete;
using System.Collections.Generic;

namespace Gymcim.Business.Abstract
{
    public interface IStatisticService : IRepositoryService<Statistic>
    {
        List<Statistic> GetAllByCustomerId(int customerID);
    }
}
