using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DTO
{
    public class VolunteerRewardDTO
    {
        public string VolunteerID { get; set; }
        public string RewardID { get; set; }
        public System.DateTime RedeemDate { get; set; }
        public int RedeemCount { get; set; }
        public bool? state { get; set; }
    }
}
