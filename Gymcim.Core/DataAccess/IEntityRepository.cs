using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Gymcim.Core.DataAccess
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T ent);
        void Update(T ent);
        void Delete(T ent);
    }
}
