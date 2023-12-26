using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DTO
{
    public class NotificationDTO
    {
        public string NotificationID { get; set; }

        public byte[] NotiImg { get; set; }
        public string NotificationContent { get; set; }
        public DateTime createDate { get; set; }
        public string AccountID { get; set; }
        public bool state { get; set; }

    }
}
