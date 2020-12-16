using Gymcim.Business.Abstract;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Gymcim.Business.Concrete
{
    public class PartManager : IPartService
    {
        private IPartDal partDal;

        public PartManager(IPartDal partDal)
        {
            this.partDal = partDal;
        }

        public void Add(Part ent, User authority)
        {
            partDal.Add(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_CREATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Part güncellendi."
            });
        }

        public void Delete(Part ent, User authority)
        {
            partDal.Delete(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_DELETE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Part silindi."
            });
        }

        public List<Part> GetAll(User authority)
        {
            return partDal.GetAll();
        }

        public Part GetById(int id)
        {
            return partDal.Get(e => e.PartID == id);
        }

        public void Update(Part ent, User authority)
        {
            partDal.Update(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_UPDATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Part güncellendi."
            });
        }
    }
}
