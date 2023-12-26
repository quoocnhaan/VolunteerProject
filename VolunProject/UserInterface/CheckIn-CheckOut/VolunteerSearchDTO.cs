using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.UserInterface.CheckIn_CheckOut
{
    public class VolunteerSearchDTO
    {
        public bool? CheckIn  { get; set; }
        public bool? CheckOut { get; set; }
        public string Name { get; set; }    
    }
}
