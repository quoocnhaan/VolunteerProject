using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DTO
{
    public class RegisterVolunteerFormDTO
    {
        public string EventID { get; set; }
        public string EventName { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int WardId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public bool state { get; set; }
        public string time { get; set; }
        public string DetailAddress { get; set; }
        public string cityName { get; set; }

        public string districtName { get; set; }

        public string wardName { get; set; }

        public string VolunteerID { get; set; }

        public string accountID { get; set; }
        public string VolunteerName { get; set; }
        public byte[] VolunteerImage { get; set; }

        public DateTime registerDate { get; set; }



    }
}
