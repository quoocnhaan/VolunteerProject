using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{
    public class CityDAL
    {
        public CityDAL() {
             
        }
        public static ICollection<TinhThanhPho> City_List() 
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.TinhThanhPhoes.ToList();
        }
        public static TinhThanhPho City_ById(int cityId)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.TinhThanhPhoes.Where(x => x.ID == cityId).FirstOrDefault();
        }
    }
}
