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
    public class CityBLL
    {
        public static ICollection<CityDTO> City_List()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TinhThanhPho, CityDTO>());
            var mapper = new Mapper(config);
            List<CityDTO> dto = mapper.Map<List<CityDTO>>(CityDAL.City_List());
            return dto;
        }
        public static CityDTO City_ById(int cityId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TinhThanhPho, CityDTO>());
            var mapper = new Mapper(config);
            CityDTO dto = mapper.Map<CityDTO>(CityDAL.City_ById(cityId));
            return dto;
        }
    }
}
