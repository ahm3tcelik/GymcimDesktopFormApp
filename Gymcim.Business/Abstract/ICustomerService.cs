using Gymcim.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Gymcim.Business.Abstract
{
    public interface ICustomerService : IRepositoryService<Customer>
    {
        List<Customer> SearchByName(string name);
    }
}
