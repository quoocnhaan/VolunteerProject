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
    public class OrganizationBLL
    {
        public static List<OrganizationDTO> getOrganization()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Organization, OrganizationDTO>());
            var mapper = new Mapper(config);
            List<OrganizationDTO> dto = mapper.Map<List<OrganizationDTO>>(OrganizationDAL.getOrganization());
            return dto;
        }
        public static bool SignUp(AccountDTO accountDTO)
        {
            return OrganizationDAL.SignUp(accountDTO);
        }
        public static OrganizationDTO getOrganizationByID(string ID)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Organization, OrganizationDTO>());
            var mapper = new Mapper(config);
            OrganizationDTO dto = mapper.Map<OrganizationDTO>(OrganizationDAL.getOrganizationByID(ID));
            return dto;
        }
    }
}
