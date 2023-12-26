using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DTO
{
    public class AccountDTO
    {
        public string AccountID { get; set; }
        public string AccountName { get; set; }
        public string Email { get; set; }
        public byte[] ImageUS { get; set; }
        public string Password { get; set; }
        public string confirmPassword { get; set; }
        public string RoleName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool state { get; set; }
        public string OrganizationID { get; set; }
    }
}
