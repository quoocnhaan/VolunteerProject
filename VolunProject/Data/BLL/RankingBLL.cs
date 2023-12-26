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
    public class RankingBLL
    {
        public static RankingDTO getRankingByID(string ID)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ranking, RankingDTO>());
            var mapper = new Mapper(config);
            RankingDTO dto = mapper.Map<RankingDTO>(RankingDAL.getRankingByID(ID));
            return dto;
        }
    }
}
