using Gymcim.Core.DataAccess.EntityFramework;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;

namespace Gymcim.DataAccess.Concrete.EntityFramework
{
    public class EfStatisticDal : EfEntityRepositoryBase<Statistic, GymcimContext>, IStatisticDal
    {
    }
}
