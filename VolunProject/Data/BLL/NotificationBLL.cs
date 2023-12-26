using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.BLL
{
    
    public class NotificationBLL
    {
        public static bool Notification_Add(NotificationDTO notificationDTO)
        {
          return NotificationDAL.Notification_Add(notificationDTO);
        }
        public static ICollection<NotificationDTO> Notification_ByAccountID(string accountID)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Notification, NotificationDTO>());
            var mapper = new Mapper(config);
            List<NotificationDTO> dto = mapper.Map<List<NotificationDTO>>(NotificationDAL.Notification_ByAccountID(accountID));
            return dto;
        }
    }
    
}
