using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DTO
{
    public class CommentDTO
    {
        public string CommentID { get; set; }
        public string PostID { get; set; }
        public string VolunteerID { get; set; }
        public string CommentContent { get; set; }
        public int CommentLike { get; set; }
        public bool? State { get; set; }
    }
}
