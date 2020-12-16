using Gymcim.Entities.Concrete;

namespace Gymcim.Business.Abstract
{
    public interface IUserService : IRepositoryService<User>
    {
        User LoginWithEmailAndPassword(string email, string password);
        void Logout(User user);
    }
}
