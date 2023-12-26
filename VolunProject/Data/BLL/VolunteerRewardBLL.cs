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
    public class VolunteerRewardBLL
    {
        public static bool AddVolunteerReward(VolunteerRewardDTO volunteerRewardDTO, string volunteerID, int point)
        {
            return VolunteerRewardDAL.AddVolunteerReward(volunteerRewardDTO,volunteerID,point);
        }
    }
}
