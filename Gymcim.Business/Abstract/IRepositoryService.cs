using Gymcim.Entities.Concrete;
using System.Collections.Generic;

namespace Gymcim.Business.Abstract
{
    public interface IRepositoryService<TEntity>
    {
        List<TEntity> GetAll(User authority);
        TEntity GetById(int id);
        void Add(TEntity ent, User authority);
        void Update(TEntity ent, User authority);
        void Delete(TEntity ent, User authority);
    }
}
