using Gymcim.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymcim.Entities.Concrete
{
    public class Customer : IEntity
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerGsm { get; set; }
        public DateTime StarterDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime EndDate => StarterDate.AddDays(Duration);
        public int Duration { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int DaysLeft => Duration - DateTime.Now.Subtract(StarterDate).Days;
        public int ScheduleID { get; set; }
        [ForeignKey("ScheduleID")]
        public Schedule Schedule { get; set; }
    }
}
