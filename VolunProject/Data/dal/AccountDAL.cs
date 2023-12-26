using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VolunProject.Data.DAL
{
    public  class AccountDAL
    {
        public AccountDAL() {
        }

        public static bool checkAccountName(string accountName)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            if (volunteerDBEntities.Accounts.Where(x => x.AccountName == accountName).Any()) return true;
            return false;
        }
        public static Account Account_ByLoginName(string accountName)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.Accounts.Where(x => x.AccountName == accountName).FirstOrDefault();
        }
        public  static bool SignUp(AccountDTO accountDTO, string email)
        {         
            if (accountDTO != null)
            {
                VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
                int allUserCount = volunteerDBEntities.Accounts.Count();
                string newAccountID = "ACC" + (allUserCount + 1).ToString("0000000");
                Account account = new Account();
                account.AccountID = newAccountID;
                account.AccountName = accountDTO.AccountName;
                account.Password = accountDTO.Password;
                account.CreateDate = DateTime.Now;
                account.state = true;
                Image image = Properties.Resources.user;
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    account.ImageUS = ms.ToArray();
                }
                account.RoleName = "VOLUNTEER";
                volunteerDBEntities.Accounts.Add(account);
                if (volunteerDBEntities.SaveChanges() > 0)
                {
                    var accountUser = volunteerDBEntities.Accounts.Where(x => x.AccountID == newAccountID).FirstOrDefault();
                    int allVolunteerCount = volunteerDBEntities.Volunteers.Count();
                    Volunteer volunteer = new Volunteer();
                    volunteer.VolunteerID = "VOL" + (allVolunteerCount + 1).ToString("0000000");
                    volunteer.AccountID = newAccountID;
                    volunteer.Email = email;
                    volunteer.PhoneNumber = "";
                    volunteer.Name = "";
                    volunteer.Account = accountUser;
                    volunteer.state = true;
                    volunteer.status = false;
                    volunteer.Description = "";
                    volunteer.AddressDetail = "";
                    volunteer.PrestigeScore = 0;
                    volunteer.RewardPoint = 2000;
                    volunteerDBEntities.Volunteers.Add(volunteer);
                    volunteer.RankId = "BRONZE";

                    return volunteerDBEntities.SaveChanges() > 0;
                }                        
            }
            return false;
        }

        public static bool LogIn(string userName, string passWord)
        {         
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var currentUser =  volunteerDBEntities.Accounts.Where(x => x.AccountName == userName.Trim()).FirstOrDefault();
            if (currentUser != null)
            {
                if (currentUser.Password == passWord)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Account, AccountDTO>());
                    var mapper = new Mapper(config);
                    AccountDTO dto = mapper.Map<AccountDTO>(currentUser);
                    OtherFunction.SessionManager.SetSessionValue("curUser", dto);
                    return true;
                }
            }
            return false;
        }
        public static bool changePassword(string accountName, string password)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var currentUser = volunteerDBEntities.Accounts.Where(x => x.AccountName == accountName.Trim()).FirstOrDefault();
            currentUser.Password = password;
            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static Account GetAccountByID(string accountID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var account = volunteerDBEntities.Accounts.Where(x => x.AccountID == accountID).FirstOrDefault();
            return account;
        }
        public static string GetPassword(string accountName)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.Accounts.Where(x => x.AccountName == accountName).FirstOrDefault().Password;
        }
        public static bool checkPassword(string account, string password)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            if (volunteerDBEntities.Accounts.Where(x => x.AccountName == account && x.Password == password).Any()) return true;
            return false;
        }
    }
}
