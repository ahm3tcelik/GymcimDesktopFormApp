using Gymcim.Core.DataAccess;
using Gymcim.Entities.Concrete;
using System.Collections.Generic;

namespace Gymcim.DataAccess.Abstract
{
    public interface ILogDal : IEntityRepository<Log>
    {
        List<string> GetEvents();
    }
}
