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
    public class AccountBLL
    {
        public static bool SignUp(AccountDTO accountDTO, string email)
        {
            return AccountDAL.SignUp(accountDTO, email);
        }
        public static bool checkAccountName(string accountName)
        {
            return AccountDAL.checkAccountName(accountName);
        }
        public static bool LogIn(string userName, string passWord)
        {
            return AccountDAL.LogIn(userName,passWord);
        }
        public static bool changePassword(string accountName, string password)
        {
            return AccountDAL.changePassword(accountName,password);
        }
        public static Account GetAccountByID(string accountID)
        {
            return AccountDAL.GetAccountByID(accountID);
        }
        public static AccountDTO Account_ByLoginName(string accountName)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Account, AccountDTO>());
            var mapper = new Mapper(config);
            AccountDTO dto = mapper.Map<AccountDTO>(AccountDAL.Account_ByLoginName(accountName));
            return dto;
        }
        public static string GetPassword(string accountName)
        {
            return AccountDAL.GetPassword(accountName);
        }

        public static bool checkPassword(string account, string password)
        {
            return AccountDAL.checkPassword(account, password);
        }
    }
}
