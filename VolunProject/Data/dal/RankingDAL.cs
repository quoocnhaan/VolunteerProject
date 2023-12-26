using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{
    public class RankingDAL
    {
        public static bool createRank()
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            Ranking ranking1 = new Ranking();
            string newRankID = "BRONZE";
            ranking1.RankId = newRankID;
            ranking1.RankName = "Đồng";
            ranking1.RankImage = OtherFunction.PathImage2Byte("D:\\git\\VolunteerProject\\VolunProject\\Resources\\bronze-medal.png");
            ranking1.PointRequire = 500;
            ranking1.state = true;
            volunteerDBEntities.Rankings.Add(ranking1);

            Ranking ranking2 = new Ranking();
            newRankID = "SILVER";
            ranking2.RankId = newRankID;
            ranking2.RankName = "Bạc";
            ranking2.RankImage = OtherFunction.PathImage2Byte("D:\\git\\VolunteerProject\\VolunProject\\Resources\\silver-medal.png");
            ranking2.PointRequire = 1000;
            ranking2.state = true;
            volunteerDBEntities.Rankings.Add(ranking2);

            Ranking ranking3 = new Ranking();
            newRankID = "GOLD";
            ranking3.RankId = newRankID;
            ranking3.RankName = "Vàng";
            ranking3.RankImage = OtherFunction.PathImage2Byte("D:\\git\\VolunteerProject\\VolunProject\\Resources\\gold-medal.png");
            ranking3.PointRequire = 2000;
            ranking3.state = true;
            volunteerDBEntities.Rankings.Add(ranking3);

            Ranking ranking4 = new Ranking();
            newRankID = "DIAMOND";
            ranking4.RankId = newRankID;
            ranking4.RankName = "Kim cương";
            ranking4.RankImage = OtherFunction.PathImage2Byte("D:\\git\\VolunteerProject\\VolunProject\\Resources\\diamond-medal.png");
            ranking4.state = true;
            volunteerDBEntities.Rankings.Add(ranking4);

            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static Ranking getRankingByID(string ID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            return volunteerDBEntities.Rankings.Where(x => x.RankId == ID).FirstOrDefault();
        }
    }
}
