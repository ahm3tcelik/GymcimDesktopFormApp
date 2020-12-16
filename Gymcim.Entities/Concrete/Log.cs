using Gymcim.Core.Entities;
using System;

namespace Gymcim.Entities.Concrete
{
    public class Log : IEntity
    {
        public static string EVENT_AUTH = "AUTH";
        // email (name) - Oturumu açıldı.
        // email (name) - Oturum kapatıldı.
        
        public static string EVENT_SETTINGS = "SETTINGS";
        // email (name) - Ayarlar düzenlendi.
        
        public static string EVENT_CREATE = "CREATE";
        // email (name) - Yeni müşteri eklendi.
        // email (name) - Yeni egzersiz eklendi.
        
        public static string EVENT_DELETE = "DELETE";
        // email (name) - Müşteri silindi.

        public static string EVENT_UPDATE = "UPDATE";
        // email (name) - Müşteri Güncellendi.

        public int LogID { get; set; }
        public string LogMessage { get; set; }
        public DateTime LogDate { get; set; }
        public string LogEvent { get; set; }
    }
}