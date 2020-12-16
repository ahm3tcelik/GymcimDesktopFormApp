using Gymcim.Business.Abstract;
using Gymcim.Business.Exceptions;
using Gymcim.Business.Utilities;
using Gymcim.DataAccess.Abstract;
using Gymcim.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Gymcim.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal userDal;

        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }

        public void Add(User ent, User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.addAuthorities);
            userDal.Add(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_CREATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Yetkili eklendi."
            });
        }

        public void Delete(User ent, User authority)
        {
            if(ent.UserID == authority.UserID)
            {
                throw new Exception("Kendi hesabınızı silemezsiniz.");
            }
            if ((ent.AccessFlags == PermissionHelper.immunity || ent.AccessFlags == PermissionHelper.unlimitedAccess) 
                && authority.AccessFlags != PermissionHelper.unlimitedAccess)
            {
                throw new PermissionDeniedException("İşlem başarısız. Yetkilinin dokunulmazlığı mevcut.");
            }
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.delAuthorities);
            userDal.Delete(ent);

            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_DELETE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Yetkili silindi."
            });
        }

        public List<User> GetAll(User authority)
        {
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.showAuthorities);
            return userDal.GetAll();
        }

        public User GetById(int id)
        {
            return userDal.Get(e => e.UserID == id);
        }

        public User LoginWithEmailAndPassword(string email, string password)
        {
            var result = userDal.Login(email, password);
            if(result != null)
            {

                LogManager.Log(new Log
                {
                    LogDate = DateTime.Now,
                    LogEvent = Log.EVENT_AUTH,
                    LogMessage = result.UserMail + " (" + result.UserName + ") " + "Oturumu açıldı."
                });
            }
            return result;
        }
        public void Logout(User user)
        {
            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_AUTH,
                LogMessage = user.UserMail + " (" + user.UserName + ") " + "Oturum kapatıldı."
            });
        }

        public void Update(User ent, User authority)
        {
            if((ent.AccessFlags == PermissionHelper.immunity || ent.AccessFlags == PermissionHelper.unlimitedAccess) 
                && authority.AccessFlags != PermissionHelper.unlimitedAccess)
            {
                throw new PermissionDeniedException("İşlem başarısız. Yetkilinin dokunulmazlığı mevcut.");
            }
            PermissionHelper.CheckPermissionAndThrow(authority, PermissionHelper.editAuthorities);
            userDal.Update(ent);
            
            LogManager.Log(new Log
            {
                LogDate = DateTime.Now,
                LogEvent = Log.EVENT_UPDATE,
                LogMessage = authority.UserMail + " (" + authority.UserName + ") " + "Yetkili güncellendi."
            });
        }
    }
}
