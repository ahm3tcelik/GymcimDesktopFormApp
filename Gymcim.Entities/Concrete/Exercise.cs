using Gymcim.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymcim.Entities.Concrete
{
    public class Exercise : IEntity
    {
        public int ExerciseID { get; set; }
        public string ExerciseName { get; set; }
        public int ExerciseSet { get; set; }
        public int ExerciseRep { get; set; }
        public int ExerciseDay { get; set; }
        public string ExerciseDesc { get; set; }
        public int PartID { get; set; }
        [ForeignKey("PartID")]
        public Part Part { get; set; }
        public int ScheduleID { get; set; }
        [ForeignKey("ScheduleID")]
        public Schedule Schedule { get; set; }
    }
}
