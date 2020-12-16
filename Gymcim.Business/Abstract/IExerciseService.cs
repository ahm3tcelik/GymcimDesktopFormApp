using Gymcim.Entities.Concrete;
using System.Collections.Generic;

namespace Gymcim.Business.Abstract
{
    public interface IExerciseService : IRepositoryService<Exercise>
    {
        List<Exercise> GetAllBySchedule(int scheduleID);
        List<dynamic> GetAllWithPartBySchedule(int scheduleID);
    }
}
