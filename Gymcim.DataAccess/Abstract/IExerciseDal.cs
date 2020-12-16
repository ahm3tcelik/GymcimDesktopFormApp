using Gymcim.Core.DataAccess;
using Gymcim.Entities.Concrete;
using System.Collections.Generic;

namespace Gymcim.DataAccess.Abstract
{
    public interface IExerciseDal : IEntityRepository<Exercise>
    {
        List<dynamic> GetAllWithPartBySchedule(int scheduleID);
    }
}
