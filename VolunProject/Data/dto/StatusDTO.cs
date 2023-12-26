using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DTO
{
    public class StatusDTO
    {
        public string statusName {  get; set; }

        public string status { get; set; }

        public StatusDTO(string status, string statusName) {
                this.status = status;
            this.statusName = statusName;
        }

    }
}
