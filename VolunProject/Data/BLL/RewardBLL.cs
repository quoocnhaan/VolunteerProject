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
    public class RewardBLL
    {
        public static bool createReward(RewardDTO rewardDTO)
        {
            return RewardDAL.createReward(rewardDTO);
        }
        public static ICollection<RewardDTO> getRewardsByVolunteerID(string volunteerID)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Reward, RewardDTO>());
            var mapper = new Mapper(config);
            List<RewardDTO> dto = mapper.Map<List<RewardDTO>>(RewardDAL.getRewardsByVolunteerID(volunteerID));
            return dto;
        }
        public static bool updateState(string RewardID)
        {
            return RewardDAL.updateState(RewardID);
        }

        public static ICollection<RewardDTO> getAllRewards()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Reward, RewardDTO>());
            var mapper = new Mapper(config);
            List<RewardDTO> dto = mapper.Map<List<RewardDTO>>(RewardDAL.getAllRewards());
            return dto;
        }
        public static VolunteerReward getVolunteerRewardByID(string volunteerID, string rewardID)
        {
            return RewardDAL.getVolunteerRewardByID(volunteerID, rewardID);
        }
    }
}
