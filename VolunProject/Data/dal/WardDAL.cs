using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{
    public class WardDAL
    {
        public static ICollection<XaPhuong> Ward_List()
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.XaPhuongs.ToList();
        }
        public static ICollection<XaPhuong> Ward_ByDistrictId(int districtId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.XaPhuongs.Where(x => x.quanHuyenId == districtId).ToList();
        }
        public static XaPhuong Ward_ById(int wardId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.XaPhuongs.Where(x => x.ID == wardId).FirstOrDefault();
        }
    }
}
