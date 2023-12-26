using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject.Data.DTO
{
    public class RankingDTO
    {
        public string RankId { get; set; }
        public string RankName { get; set; }
        public byte[] RankImage { get; set; }
        public int PointRequire { get; set; }
        public bool? state { get; set; }
    }
}
