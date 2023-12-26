using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DTO
{
    public class RegistrationVolunteerDTO
    {
        public string VolunteerID { get; set; }
        public string Name { get; set; }

        public byte[] VolunteerImg { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int WardId { get; set; }
        public string cityName { get; set; }
        public string districtName { get; set; }
        public string wardName { get; set; }
        public string AccountID { get; set; }
        public bool Gender { get; set; }
        public bool state { get; set; }
        public string status { get; set; }
        public bool? CheckIn { get; set; }
        public bool? CheckOut { get; set; }
        public DateTime? CheckInDate { get; set; }
        public System.DateTime? CheckOutDate { get; set; }
        public string AddressDetail { get; set; }

        public string EventID { get; set; }
    }
}
