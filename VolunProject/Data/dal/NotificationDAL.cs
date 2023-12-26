using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{   
    
    public class NotificationDAL
    {
        public static bool Notification_Add(NotificationDTO notificationDTO)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            int allUserCount = volunteerDBEntities.Notifications.Count();
            string newAccountID = "NOF" + (allUserCount + 1).ToString("0000000");
            Notification notification = new Notification();
            notification.AccountID = notificationDTO.AccountID;
            notification.NotificationID = newAccountID;
            notification.NotificationContent = notificationDTO.NotificationContent;
            notification.createDate = DateTime.Now;
            notification.state = true;
            notification.NotiImg = notificationDTO.NotiImg;
            volunteerDBEntities.Notifications.Add(notification);
            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static ICollection<Notification> Notification_ByAccountID(string accountID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.Notifications.Where(x => x.AccountID == accountID)
                .OrderByDescending(x => x.createDate)
                .ThenBy(x => x.createDate.HasValue ? x.createDate.Value.Hour : 0)
                 .ThenBy(x => x.createDate.HasValue ? x.createDate.Value.Minute : 0)
                  .ThenBy(x => x.createDate.HasValue ? x.createDate.Value.Second : 0)
                .ToList();
        }
    }
    
}
