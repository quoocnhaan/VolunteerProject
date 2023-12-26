using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{
    public class VolunteerRewardDAL
    {
        public static bool AddVolunteerReward(VolunteerRewardDTO volunteerRewardDTO, string volunteerID, int point)
        {
            if (volunteerRewardDTO != null)
            {
                VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
                VolunteerReward volunteerReward = new VolunteerReward();

                volunteerReward.RewardID = volunteerRewardDTO.RewardID;
                volunteerReward.VolunteerID = volunteerRewardDTO.VolunteerID;
                volunteerReward.RedeemDate = volunteerRewardDTO.RedeemDate;
                volunteerReward.RedeemCount = volunteerRewardDTO.RedeemCount;
                volunteerReward.state = volunteerRewardDTO.state;
                volunteerDBEntities.VolunteerRewards.Add(volunteerReward);

                var volunteer = volunteerDBEntities.Volunteers.Where(x => x.VolunteerID == volunteerID).FirstOrDefault();
                volunteer.RewardPoint -= point;

                return volunteerDBEntities.SaveChanges() > 0;
            }
            return false;
        }
    }
}
