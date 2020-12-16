using Gymcim.Core.DataAccess;
using Gymcim.Entities.Concrete;
using System.Collections.Generic;

namespace Gymcim.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<Customer> GetAllWithAbstract();
        Customer GetCustomerWithScheduleAndStats(int customerID);
    }
}
