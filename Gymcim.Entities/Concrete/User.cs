using Gymcim.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymcim.Entities.Concrete
{
    public class User: IEntity
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        [Index(IsUnique = true)]
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public string AccessFlags { get; set; }
    }
}
