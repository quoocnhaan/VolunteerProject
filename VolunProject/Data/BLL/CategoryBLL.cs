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
    public class CategoryBLL
    {
        public static ICollection<CategoryDTO> EventCategory_List()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EventCategory, CategoryDTO>());
            var mapper = new Mapper(config);
            List<CategoryDTO> dto = mapper.Map<List<CategoryDTO>>(CategoryDAL.EventCategory_List());
            return dto;
        }
    }
}
