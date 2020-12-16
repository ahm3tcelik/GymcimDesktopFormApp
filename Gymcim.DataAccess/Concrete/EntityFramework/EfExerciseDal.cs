using Gymcim.Core.DataAccess.EntityFramework;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Gymcim.DataAccess.Concrete.EntityFramework
{
    public class EfExerciseDal : EfEntityRepositoryBase<Exercise, GymcimContext>, IExerciseDal
    {
        public List<dynamic> GetAllWithPartBySchedule(int scheduleID)
        {
            using (GymcimContext context = new GymcimContext())
            {
                string fields = "ExerciseID, ExerciseName, ExerciseSet, ExerciseRep, ExerciseDay, ExerciseDesc, " +
                "e.PartID, ScheduleID, PartName";

                string query = "SELECT " + fields + " FROM Exercises e JOIN Parts p" +
                    " ON e.PartID = p.PartID" +
                    " WHERE ScheduleID = @id";

                return DynamicResult.DynamicListFromSql(context, query, new Dictionary<string, object> { { "id", scheduleID } }).ToList();
            }
        }
    }
}
