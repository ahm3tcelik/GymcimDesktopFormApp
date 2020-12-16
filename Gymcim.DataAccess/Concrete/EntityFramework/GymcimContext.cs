using Gymcim.Entities.Concrete;
using System.Data.Entity;

namespace Gymcim.DataAccess.Concrete.EntityFramework
{
    public class GymcimContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Statistic> Stats { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
