using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;
using VolunProject.UserInterface.CheckIn_CheckOut;

namespace VolunProject.Data.BLL
{
    public class VolunteerBLL
    {
        public static Volunteer GetVolunteer(string accountID)
        {
            return VolunteerDAL.GetVolunteer(accountID);
        }
        public static Volunteer GetVolunteerByVolunteerID(string volunteerID)
        {
            return VolunteerDAL.GetVolunteerByVolunteerID(volunteerID);
        }
        public static bool UpdateVolunteer(VolunteerDTO volunteerDTO, byte[] img)
        {
            var accountSession = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            bool result = VolunteerDAL.UpdateVolunteer(volunteerDTO,img);
            var account = AccountDAL.GetAccountByID(accountSession.AccountID);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Account, AccountDTO>());
            var mapper = new Mapper(config);
            AccountDTO dto = mapper.Map<AccountDTO>(account);
            OtherFunction.SessionManager.SetSessionValue("curUser", dto);
            return result;
        }
        public static bool checkEmail(string email)
        {
            return VolunteerDAL.checkEmail(email);
        }
        public static VolunteerDTO GetVolunteer_ByVolunId(string volunteerId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Volunteer, VolunteerDTO>());
            var mapper = new Mapper(config);
            VolunteerDTO dto = mapper.Map<VolunteerDTO>(VolunteerDAL.GetVolunteerByVolunteerID(volunteerId));
            return dto;
        }

        public static ICollection<RegistrationVolunteerDTO> Volunteer_ByEventID(string eventID, VolunteerSearchDTO volunteerSearchDTO)
        {
          var re =  VolunteerDAL.Volunteer_ByEventID(eventID, volunteerSearchDTO).ToList();
            re.ForEach(item =>
            {
                item.cityName = CityBLL.City_ById(item.CityId).tenTinhThanhPho;
                item.districtName = DistrictBLL.District_ById(item.DistrictId).tenQuanHuyen;
                item.wardName = WardBLL.Ward_ById(item.WardId).tenXaPhuong;
                item.VolunteerImg = AccountBLL.GetAccountByID(item.AccountID).ImageUS;
            });
            return re;
        }
        public static bool updatePoint(string volunteerID)
        {
            return VolunteerDAL.updatePoint(volunteerID);
        }
        public static bool checkEmail_Information(string volunteerID, string email)
        {
            return VolunteerDAL.checkEmail_Information(volunteerID, email);
        }
        public static bool confirmEmail(string account, string email)
        {
            return VolunteerDAL.confirmEmail(account, email);
        }
    }
}
