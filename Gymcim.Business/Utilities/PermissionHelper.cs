using Gymcim.Business.Exceptions;
using Gymcim.Entities.Concrete;

namespace Gymcim.Business.Utilities
{
    public class PermissionHelper
    {
        public static string immunity = "a";
        public static string showAuthorities = "b";
        public static string addAuthorities = "c";
        public static string editAuthorities = "d";
        public static string delAuthorities = "e";
        public static string showLog = "f";
        public static string addCustomer = "g";
        public static string editCustomer = "h";
        public static string delCustomer = "i";
        public static string addSchedule = "j";
        public static string editSchedule = "k";
        public static string delSchedule = "l";
        public static string unlimitedAccess = "x";

        public static bool CheckPermission(User authorizer, string requiredFlags)
        {
            if (authorizer == null)
                return false;

            string accessFlags = authorizer.AccessFlags;
            if(!accessFlags.Contains(unlimitedAccess))
            {
                if(!accessFlags.Contains(requiredFlags))
                {
                    return false;
                }
            }
            return true;
        }
        public static void CheckPermissionAndThrow(User authorizer, string requiredFlags)
        {
            if (authorizer == null)
                throw new PermissionDeniedException("Maalesef bu işlem için gerekli izniniz yok.");

            string accesFlags = authorizer.AccessFlags;
            if(!accesFlags.Contains(unlimitedAccess))
            {
                if(!accesFlags.Contains(requiredFlags))
                {
                    throw new PermissionDeniedException("Maalesef bu işlem için gerekli izniniz yok.");
                }
            }
        }
    }
}
