using AutoMapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.BLL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{
    
    public class EventDAL
    {
        public static bool Event_Add(EventDTO eventDTO)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var category = volunteerDBEntities.EventCategories.Where(x => x.CategoryID == eventDTO.CategoryId).FirstOrDefault();
            Account account = volunteerDBEntities.Accounts.Where(x => x.AccountID == curUser.AccountID).FirstOrDefault();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EventDTO, Event>());
            var mapper = new Mapper(config);
            Event dto = mapper.Map<Event>(eventDTO);
            int allUserCount = volunteerDBEntities.Events.Count();
            string newAccountID = "EVN" + (allUserCount + 1).ToString("0000000");
            dto.EventID = newAccountID;
            dto.EventCategory = category;
            dto.OrganizationID = account.OrganizationID;
            dto.state = true;
            volunteerDBEntities.Events.Add(dto);
            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static Event Event_ById(string eventId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var eve = volunteerDBEntities.Events.Where(x => x.EventID == eventId && x.state == true).FirstOrDefault();
            return eve ?? new Event();
        }
        public static ICollection<Event> Event_ByOrganizationId(string organizationId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var events = volunteerDBEntities.Events.Where(x => x.state == true && x.OrganizationID == curUser.OrganizationID).ToList();
            return events;
        }
        public static ICollection<Event> Event_List(EventDTO eventDTO)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var events = volunteerDBEntities.Events.Where(x => x.state == true)
                .Where(x => x.EventName.ToLower().Contains(eventDTO.EventName.ToLower()) || eventDTO.EventName == "" || eventDTO.EventName == null)
                 .Where(x => x.StartDate >= eventDTO.StartDate|| eventDTO.StartDate == null)
                   .Where(x => x.EndDate <= eventDTO.EndDate || eventDTO.EndDate == null)
                 .Where(x => x.CityId == eventDTO.CityId || eventDTO.CityId == null)
                   .Where(x => x.DistrictId == eventDTO.DistrictId || eventDTO.DistrictId == null)
                  .Where(x => x.CategoryId == eventDTO.CategoryId || eventDTO.CategoryId == "" || eventDTO.CategoryId == null)
                .ToList();
            return events;
        }
        public static int Event_GetLikeCount(string eventId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            int likecount = volunteerDBEntities.VolunteerLikeEvents.Where(x => x.EventID == eventId).Count();
            return likecount;
        }

        public static bool Event_LikeEvent(string eventId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            Volunteer volunteer = volunteerDBEntities.Volunteers.Where(x => x.AccountID == curUser.AccountID).FirstOrDefault();
            bool result = false;
            if (volunteerDBEntities.VolunteerLikeEvents.Any(x => x.VolunteerID == volunteer.VolunteerID && x.EventID == eventId))
            {
                var currentLikeEvent = volunteerDBEntities.VolunteerLikeEvents.Where(x => x.VolunteerID == volunteer.VolunteerID && x.EventID == eventId).FirstOrDefault();
                currentLikeEvent.LikeDate = DateTime.Now; 
                currentLikeEvent.LikeState = true;
                result = volunteerDBEntities.SaveChanges() > 0;
            }
            else
            {
                VolunteerLikeEvent volunteerLikeEvent = new VolunteerLikeEvent();
                volunteerLikeEvent.EventID = eventId;
                volunteerLikeEvent.VolunteerID = volunteer.VolunteerID;
                volunteerLikeEvent.LikeDate = DateTime.Now;
                volunteerLikeEvent.LikeState = true;
                volunteerDBEntities.VolunteerLikeEvents.Add(volunteerLikeEvent);
                result = volunteerDBEntities.SaveChanges() > 0;
            }
            return result;
        }
        public static bool Event_UnlikeEvent(string eventId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            Volunteer volunteer = volunteerDBEntities.Volunteers.Where(x => x.AccountID == curUser.AccountID).FirstOrDefault();
            bool result = false;
            if (volunteerDBEntities.VolunteerLikeEvents.Any(x => x.VolunteerID == volunteer.VolunteerID && x.EventID == eventId))
            {
                var currentLikeEvent = volunteerDBEntities.VolunteerLikeEvents.Where(x => x.VolunteerID == volunteer.VolunteerID && x.EventID == eventId).FirstOrDefault();
                currentLikeEvent.LikeState = false;
                result = volunteerDBEntities.SaveChanges() > 0;

            }
            return result;


        }
        public static int Event_CountRegister(string eventId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var volunteerCount = volunteerDBEntities.Registrations.Where(x => x.EventID == eventId).Count();
            return volunteerCount;
        }

        public static bool Event_CheckVolunteerLike(string eventId,string volunteerId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.VolunteerLikeEvents.Any(x => x.VolunteerID == volunteerId && x.EventID == eventId);
        }
        public static bool Event_CheckVolunteerRegister(string eventId, string volunteerId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.Registrations.Any(x => x.VolunteerID == volunteerId && x.EventID == eventId);
        }

        public static bool Event_Register(string eventId, string volunteerId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            int allUserCount = volunteerDBEntities.Registrations.Count();
            string newAccountID = "REG" + (allUserCount + 1).ToString("0000000");
            Registration registration   = new Registration();
            registration.RegistrationID = newAccountID;
            registration.EventID = eventId;
            registration.VolunteerID = volunteerId;
            registration.RegistrationDate = DateTime.Now;
            registration.CheckIn = false; 
            registration.CheckOut = false;
            registration.state = true;
            registration.status = "C";
            volunteerDBEntities.Registrations.Add(registration);
            return volunteerDBEntities.SaveChanges() > 0;

        }
        
        public static ICollection<RegisterVolunteerFormDTO> Event_GetAllVolunteerRegistration_ByOranizationId(string organizationId, RegisterFormSearchDTO registerFormSearchDTO)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var allRegis = volunteerDBEntities.Registrations
                .Include(x => x.Volunteer)
                .Include(x => x.Event)
                .Where(x => x.Event.OrganizationID == organizationId)
                .Select(x => new RegisterVolunteerFormDTO()
                {
                    EventID = x.EventID,
                    EventName = x.Event.EventName,
                    DistrictId = x.Event.DistrictId ?? 0,
                    CityId = x.Event.CityId ?? 0,
                    WardId = x.Event.WardId ?? 0,
                    StartDate = x.Event.StartDate ?? DateTime.Now,
                    EndDate = x.Event.EndDate ?? DateTime.Now,
                    Status = x.status,
                    state = x.state ?? false,
                    time  = x.Event.time,
                    DetailAddress = x.Event.DetailAddress,
                    VolunteerID = x.VolunteerID,
                    VolunteerName  = x.Volunteer.Name,
                    accountID = x.Volunteer.AccountID,
                  //  VolunteerImage = AccountBLL.GetAccountByID(x.Volunteer.AccountID).ImageUS,
                    registerDate = x.RegistrationDate ?? DateTime.Now

                })
                .Where(x => x.EventID == registerFormSearchDTO.eventID.Trim() || registerFormSearchDTO.eventID.Trim() == "" || registerFormSearchDTO.eventID == null)
                 .Where(x => x.Status == registerFormSearchDTO.status.Trim() || registerFormSearchDTO.status.Trim() == "" || registerFormSearchDTO.status == null)
                .ToList();
            return allRegis;
        }
        public static bool Event_Approve(string eventId, string volunteerId)
        {

            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var registration = volunteerDBEntities.Registrations.Where(x => x.VolunteerID == volunteerId && x.EventID == eventId).FirstOrDefault();
            registration.status = "A";
            registration.ApproveDate = DateTime.Now;
            registration.ApproveAccountID = curUser.AccountID;
            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static bool Event_ParticipateChecking(string eventId, string volunteerId, string type)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var registration = volunteerDBEntities.Registrations.Where(x => x.EventID == eventId && x.VolunteerID == volunteerId).FirstOrDefault();
            if (type == "I")
            {
                registration.CheckIn = true;
                registration.CheckInDate = DateTime.Now;

            }
            else
            {
                registration.CheckOut = true;
                registration.CheckOutDate = DateTime.Now;
            }
           return  volunteerDBEntities.SaveChanges() > 0;
        }
        public static bool Event_Reject(string eventId, string volunteerId)
        {

            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var registration = volunteerDBEntities.Registrations.Where(x => x.VolunteerID == volunteerId && x.EventID == eventId).FirstOrDefault();
            registration.status = "R";
            registration.ApproveDate = DateTime.Now;
            registration.ApproveAccountID = curUser.AccountID;
            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static ICollection<Event> SendApproveEventRegistration_ByVolunteerID(string volunteerID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.Registrations
                .Include(x => x.Event).
                Where(x => x.VolunteerID == volunteerID && x.state == true).
                Select(x => x.Event).
                ToList();
        }
        public static Registration Registration_ByEventVolunID(string eventID, string volunteerID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.Registrations.Where(x => x.EventID == eventID && x.VolunteerID == volunteerID).FirstOrDefault();
        }

        public static bool Registration_Cancel(string eventID, string volunteerID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var registration = volunteerDBEntities.Registrations.Where(x => x.VolunteerID == volunteerID && x.EventID == eventID).FirstOrDefault();
            registration.state = false;
            return volunteerDBEntities.SaveChanges() > 0;
        }

    }
    
}
