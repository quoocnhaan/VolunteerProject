using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DTO
{
    public class PostDTO
    {
        public string PostID { get; set; }
        public string VolunteerID { get; set; }
        public string Caption { get; set; }
        public System.DateTime CreateDate { get; set; }
        public byte[] Image { get; set; }
        public int PostLike { get; set; }
        public bool? State { get; set; }
    }
}
