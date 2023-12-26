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
    public class WardBLL
    {
        public static ICollection<WardDTO> Ward_List()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<XaPhuong, WardDTO>());
            var mapper = new Mapper(config);
            List<WardDTO> dto = mapper.Map<List<WardDTO>>(WardDAL.Ward_List());
            return dto;
        }
        public static ICollection<WardDTO> Ward_ByDistrictId(int districtId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<XaPhuong, WardDTO>());
            var mapper = new Mapper(config);
            List<WardDTO> dto = mapper.Map<List<WardDTO>>(WardDAL.Ward_ByDistrictId(districtId));
            return dto;
        }
        public static WardDTO Ward_ById(int wardId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<XaPhuong, WardDTO>());
            var mapper = new Mapper(config);
            WardDTO dto = mapper.Map<WardDTO>(WardDAL.Ward_ById(wardId));
            return dto;
        }
    }
}
