using Gymcim.Core.DataAccess.EntityFramework;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System.Linq;

namespace Gymcim.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, GymcimContext>, IUserDal
    {
        public User Login(string email, string password)
        {
            using (GymcimContext context = new GymcimContext())
            {
                return context.Set<User>().SingleOrDefault(e => e.UserMail == email && e.UserPassword == password);
            }
        }
    }
}
