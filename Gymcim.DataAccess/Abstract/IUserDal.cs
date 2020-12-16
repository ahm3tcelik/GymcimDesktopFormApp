using Gymcim.Core.DataAccess;
using Gymcim.Entities.Concrete;

namespace Gymcim.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        User Login(string email, string password);
    }
}
