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
    public class RewardDAL
    {
        public static bool createReward(RewardDTO rewardDTO)
        {
            if (rewardDTO != null)
            {
                VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
                int allrewardCount = volunteerDBEntities.Rewards.Count();
                string newRewardID = "REW" + (allrewardCount + 1).ToString("0000000");
                Reward reward = new Reward();
                reward.RewardID = newRewardID;
                reward.RewardName = rewardDTO.RewardName;
                reward.state = true;
                reward.RewardImg = rewardDTO.RewardImg;
                reward.RedeemPoint = rewardDTO.RedeemPoint;
                volunteerDBEntities.Rewards.Add(reward);
                return volunteerDBEntities.SaveChanges() > 0;
            }
            return false;
        }
        public static ICollection<Reward> getRewardsByVolunteerID(string volunteerID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var listReward = volunteerDBEntities.VolunteerRewards.Include(x => x.Reward).Where(x => x.VolunteerID == volunteerID).Select(x => x.Reward).ToList();
            listReward.Reverse();
            return listReward;
        }
        public static ICollection<Reward> getAllRewards()
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var listAllReward = volunteerDBEntities.Rewards.ToList();
            return listAllReward;
        }

        public static bool updateState(string RewardID)
        {
            if (RewardID != null)
            {
                VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
                var reward = volunteerDBEntities.Rewards.Where(x => x.RewardID == RewardID).FirstOrDefault();
                reward.state = false;
                return volunteerDBEntities.SaveChanges() > 0;
            }
            return false;
        }
        public static VolunteerReward getVolunteerRewardByID(string volunteerID, string rewardID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.VolunteerRewards.Where(x => x.VolunteerID == volunteerID && x.RewardID == rewardID).FirstOrDefault();
        }
    }
}
