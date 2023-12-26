using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DAL
{
    public class VolunteerDTO
    {
        public string VolunteerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int WardId { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string AccountID { get; set; }
        public bool Gender { get; set; }
        public string Description { get; set; }
        public int PrestigeScore { get; set; }
        public int RewardPoint { get; set; }
        public bool state { get; set; }
        public string AddressDetail { get; set; }
        public string RankId { get; set; }
    }
}
