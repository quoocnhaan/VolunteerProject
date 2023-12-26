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
    
    public class EventBLL
    {
        public static bool Event_Add(EventDTO eventDTO)
        {
           return EventDAL.Event_Add(eventDTO);
        }
        public static EventDTO Event_ById(string eventId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Event, EventDTO>());
            var mapper = new Mapper(config);
            EventDTO dto = mapper.Map<EventDTO>(EventDAL.Event_ById(eventId));
            dto.LikeCount = EventDAL.Event_GetLikeCount(eventId);
            dto.RegisterCount = EventDAL.Event_CountRegister(eventId);
            dto.cityName = CityBLL.City_ById(dto.CityId ?? 0).tenTinhThanhPho;
            dto.districtName = DistrictBLL.District_ById(dto.DistrictId ?? 0).tenQuanHuyen;
            dto.wardName = WardBLL.Ward_ById(dto.WardId ?? 0).tenXaPhuong;
            return dto;
        }
        public static ICollection<EventDTO> Event_ByOrganizationId(string organizationId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Event, EventDTO>());
            var mapper = new Mapper(config);
            List<EventDTO> dto = mapper.Map<List<EventDTO>>(EventDAL.Event_ByOrganizationId(organizationId));
            dto.ForEach(x =>
            {
                x.LikeCount = EventDAL.Event_GetLikeCount(x.EventID);
                x.RegisterCount = EventDAL.Event_CountRegister(x.EventID);
                x.cityName = CityBLL.City_ById(x.CityId ?? 0).tenTinhThanhPho;
                x.districtName = DistrictBLL.District_ById(x.DistrictId ?? 0).tenQuanHuyen;
                x.wardName = WardBLL.Ward_ById(x.WardId ?? 0).tenXaPhuong;
            });
            return dto;
        }
        public static int Event_GetLikeCount(string eventId)
        {
            return EventDAL.Event_GetLikeCount(eventId);
        }

        public static bool Event_LikeEvent(string eventId)
        {
            return EventDAL.Event_LikeEvent(eventId);


        }
        public static bool Event_UnlikeEvent(string eventId)
        {
            return EventDAL.Event_UnlikeEvent(eventId);


        }
        public static int Event_CountRegister(string eventId)
        {
            return EventDAL.Event_CountRegister(eventId);
        }
        public static ICollection<EventDTO> Event_List(EventDTO eventDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Event, EventDTO>());
            var mapper = new Mapper(config);
            List<EventDTO> dto = mapper.Map<List<EventDTO>>(EventDAL.Event_List(eventDTO));
            dto.ForEach(x =>
            {
                x.LikeCount = EventDAL.Event_GetLikeCount(x.EventID);
                x.RegisterCount = EventDAL.Event_CountRegister(x.EventID);
                x.cityName = CityBLL.City_ById(x.CityId ?? 0).tenTinhThanhPho;
                x.districtName = DistrictBLL.District_ById(x.DistrictId ?? 0).tenQuanHuyen;
                x.wardName = WardBLL.Ward_ById(x.WardId ?? 0).tenXaPhuong;
            });
            return dto;
        }
        public static bool Event_CheckVolunteerLike(string eventId, string volunteerId)
        {
            return EventDAL.Event_CheckVolunteerLike(eventId, volunteerId);
        }
        public static bool Event_Register(string eventId, string volunteerId)
        {
          return EventDAL.Event_Register(eventId, volunteerId);

        }
        public static bool Event_CheckVolunteerRegister(string eventId, string volunteerId)
        {
            return EventDAL.Event_CheckVolunteerRegister(eventId, volunteerId);
        }
        public static ICollection<RegisterVolunteerFormDTO> Event_GetAllVolunteerRegistration_ByOranizationId(string organizationId, RegisterFormSearchDTO registerFormSearchDTO)
        {
            var items = EventDAL.Event_GetAllVolunteerRegistration_ByOranizationId(organizationId,registerFormSearchDTO).ToList();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            items.ForEach(item =>
            {
                item.VolunteerImage = AccountBLL.GetAccountByID(item.accountID).ImageUS;
                item.cityName = CityBLL.City_ById(item.CityId).tenTinhThanhPho;
                item.districtName = DistrictBLL.District_ById(item.DistrictId).tenQuanHuyen;
                item.wardName = WardBLL.Ward_ById(item.WardId).tenXaPhuong;
            });
            return items;
        }
        public static bool Event_Approve(string eventId, string volunteerId)
        {
            return EventDAL.Event_Approve(eventId, volunteerId);
        }
        public static bool Event_ParticipateChecking(string eventId, string volunteerId, string type)
        {
            return EventDAL.Event_ParticipateChecking(eventId, volunteerId, type);
        }
        public static bool Event_Reject(string eventId, string volunteerId)
        {

            return EventDAL.Event_Reject(eventId, volunteerId);
        }
        public static ICollection<EventDTO> SendApproveEventRegistration_ByVolunteerID(string volunteerID)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Event, EventDTO>());
            var mapper = new Mapper(config);
            List<EventDTO> dto = mapper.Map<List<EventDTO>>(EventDAL.SendApproveEventRegistration_ByVolunteerID(volunteerID));
            dto.ForEach(x =>
            {
                x.cityName = CityBLL.City_ById(x.CityId ?? 0).tenTinhThanhPho;
                x.districtName = DistrictBLL.District_ById(x.DistrictId ?? 0).tenQuanHuyen;
                x.wardName = WardBLL.Ward_ById(x.WardId ?? 0).tenXaPhuong;
                x.RegistrationDate = EventDAL.Registration_ByEventVolunID(x.EventID, volunteerID).RegistrationDate;
                x.status = EventDAL.Registration_ByEventVolunID(x.EventID, volunteerID).status;
            });
            return dto;
        }
        public static bool Registration_Cancel(string eventID, string volunteerID)
        {
           return EventDAL.Registration_Cancel(eventID, volunteerID);
        }
    }
    
}
