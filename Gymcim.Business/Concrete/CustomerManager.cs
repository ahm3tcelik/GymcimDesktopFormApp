using Gymcim.Business.Abstract;
using Gymcim.Business.Utilities;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Gymcim.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal customerDal;
        
        public CustomerManager(ICustomerDal customerDal) 
        {
            this.customerDal = customerDal;
        }
        public void Add(Customer ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.addCustomer);
            customerDal.Add(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_CREATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Müşteri eklendi."
            });
        }
        public void Delete(Customer ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.delCustomer);
            customerDal.Delete(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_DELETE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Müşteri silindi."
            });
        }
        public List<Customer> GetAll(User authority)
        {
            return customerDal.GetAll();
        }

        public Customer GetById(int id)
        {
            return customerDal.Get(c => c.CustomerID == id);
        }

        public List<Customer> SearchByName(string name)
        {
            return customerDal.GetAll(c => (c.CustomerName + c.CustomerSurname).Contains(name));
        }
        public void Update(Customer ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.editCustomer);
            customerDal.Update(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_UPDATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Müşteri güncellendi."
            });
        }
    }
}
