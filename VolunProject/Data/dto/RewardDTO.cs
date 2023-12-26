using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DTO
{
    public class RewardDTO
    {
        public string RewardID { get; set; }
        public string RewardName { get; set; }
        public int RedeemPoint { get; set; }
        public bool? state { get; set; }
        public byte[] RewardImg { get; set; }
        public System.DateTime? RedeemDate { get; set; }
    }
}
