using Gymcim.Core.Entities;

namespace Gymcim.Entities.Concrete
{
    public class Schedule : IEntity
    {
        public int ScheduleID { get; set; }
        public string ScheduleName { get; set; }
        public string ScheduleDesc { get; set; }
    }
}
