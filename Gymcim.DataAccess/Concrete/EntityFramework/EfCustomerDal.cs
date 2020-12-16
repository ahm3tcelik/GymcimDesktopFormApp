using Gymcim.Core.DataAccess.EntityFramework;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Gymcim.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, GymcimContext>, ICustomerDal
    {
        public List<Customer> GetAllWithAbstract()
        {
            using (GymcimContext context = new GymcimContext())
            {
                string query = "SELECT " +
                    "CustomerID, CustomerName, CustomerSurname, CustomerGsm, Duration," +
                    "StarterDate, DATEADD(day, Duration, GETDATE()) AS EndDate," +
                    "Duration - DATEDIFF(day, StarterDate, GETDATE()) AS DaysLeft, ScheduleID " +
                    "FROM Customers";
                var result = context.Database.SqlQuery<Customer>(query).ToList<Customer>();
                return result;
            }
            /*
            SELECT * 
                FROM Customers c 
                JOIN Schedules sc ON c.ScheduleID = sc.ScheduleId
                JOIN Stats st ON c.CustomerID = st.CustomerID
                WHERE c.CustomerID = 2
             */
        }
        public Customer GetCustomerWithScheduleAndStats(int customerID)
        {
            using (GymcimContext context = new GymcimContext())
            {
                string query = "SELECT * " +
                    "FROM Customers c " + "JOIN Schedules sc ON c.ScheduleID = sc.ScheduleID " +
                    "JOIN Stats st ON c.CustomerID = st.CustomerID " +
                    "WHERE c.CustomerID  = @customerID";
                var result = context
                    .Customers
                    .SqlQuery(query, new SqlParameter("customerID", customerID))
                    .SingleOrDefault();
                return result;
            }
        } 
    }
}
