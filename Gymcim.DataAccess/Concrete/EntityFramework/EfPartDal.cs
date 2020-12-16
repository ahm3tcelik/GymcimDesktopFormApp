using Gymcim.Core.DataAccess.EntityFramework;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;

namespace Gymcim.DataAccess.Concrete.EntityFramework
{
    public class EfPartDal : EfEntityRepositoryBase<Part, GymcimContext>, IPartDal
    {
    }
}
