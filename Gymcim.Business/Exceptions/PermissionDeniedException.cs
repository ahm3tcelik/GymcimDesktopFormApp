using System;

namespace Gymcim.Business.Exceptions
{
    public class PermissionDeniedException : Exception
    {
        public PermissionDeniedException() { }

        public PermissionDeniedException(string message) : base(message)
        {

        }
    }
}
