using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{
    public class DistrictDAL
    {
        public static ICollection<QuanHuyen> District_List()
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.QuanHuyens.ToList();
        }
        public static ICollection<QuanHuyen> District_ByCityId(int cityId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.QuanHuyens.Where(x => x.tinhThanhPhoId == cityId).ToList();
        }
        public static QuanHuyen District_ById(int districtId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.QuanHuyens.Where(x => x.ID == districtId).FirstOrDefault();
        }
    }
}
