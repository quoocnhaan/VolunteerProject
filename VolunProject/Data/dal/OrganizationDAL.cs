using AutoMapper.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{
    public class OrganizationDAL
    {
        public static List<Organization> getOrganization()
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var organization = volunteerDBEntities.Organizations.ToList();
            return organization;
        }
        public static bool SignUp(AccountDTO accountDTO)
        {
            if (accountDTO != null)
            {
                VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
                int allUserCount = volunteerDBEntities.Accounts.Count();
                string newAccountID = "ORG" + (allUserCount + 1).ToString("0000000");
                Account account = new Account();
                account.AccountID = newAccountID;
                account.AccountName = accountDTO.AccountName;
                account.Password = accountDTO.Password;
                account.CreateDate = DateTime.Now;
                account.state = true;
                account.Email = accountDTO.Email;
                account.ImageUS = OtherFunction.PathImage2Byte("D:\\git\\VolunteerProject\\VolunProject\\Resources\\user-default.png");
                account.RoleName = "ORGANIZATION";
                account.OrganizationID = accountDTO.OrganizationID;
                volunteerDBEntities.Accounts.Add(account);
                return volunteerDBEntities.SaveChanges() > 0;
            }
            return false;
        }
        public static Organization getOrganizationByID(string ID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.Organizations.Where(x => x.OrganizationID == ID).FirstOrDefault();
        }
    }
}
