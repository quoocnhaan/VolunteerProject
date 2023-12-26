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
    public class DistrictBLL
    {
        public static ICollection<DistrictDTO> District_List()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<QuanHuyen, DistrictDTO>());
            var mapper = new Mapper(config);
            List<DistrictDTO> dto = mapper.Map<List<DistrictDTO>>(DistrictDAL.District_List());
            return dto;
        }
        public static ICollection<DistrictDTO> District_ByCityId(int cityId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<QuanHuyen, DistrictDTO>());
            var mapper = new Mapper(config);
            List<DistrictDTO> dto = mapper.Map<List<DistrictDTO>>(DistrictDAL.District_ByCityId(cityId));
            return dto;
        }
        public static DistrictDTO District_ById(int districtId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<QuanHuyen, DistrictDTO>());
            var mapper = new Mapper(config);
            DistrictDTO dto = mapper.Map<DistrictDTO>(DistrictDAL.District_ById(districtId));
            return dto;
        }
    }
}
