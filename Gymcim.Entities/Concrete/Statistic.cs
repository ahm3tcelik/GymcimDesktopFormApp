using Gymcim.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymcim.Entities.Concrete
{
    [Table("Stats")]
    public class Statistic : IEntity
    {
        [Key]
        public int StatisticID { get; set; }
        public DateTime StatisticDate { get; set; }
        public string StatisticDesc { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
        public int Height { get; set; } // cm
        public int Kilo { get; set; } // kg
        public int Shoulder { get; set; }
        public int Chest { get; set; }
        public int Arm { get; set; }
        public int Waist { get; set; }
        public int Hip { get; set; }
        public int Calf { get; set; }
    }
}
