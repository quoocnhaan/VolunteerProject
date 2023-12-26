using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DTO
{
    public class EventDTO
    {
        public string EventID { get; set; }
        public string EventName { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public int? WardId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public string CategoryId { get; set; }
        public bool state { get; set; }
        public string description { get; set; }
        public string purpose { get; set; }
        public string time { get; set; }

        public string DetailAddress { get; set; }
        public byte[] EventImage { get; set; }

        public int RegisterCount { get; set; }

        public int LikeCount { get; set; }

        public string cityName { get; set; }

        public string districtName { get; set; }

        public string wardName { get; set; }

        public string OrganizationName { get; set; }

        public string OrganizationID { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public string status { get; set; }

        public string isBackTo { get; set; }
    }
}
