using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.BLL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{
    public class CommentDAL
    {
        public static bool CreateComment(CommentDTO commentDTO)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            Comment comment = new Comment();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            int allCmt = volunteerDBEntities.Comments.Count();
            string newID = "CMT" + (allCmt + 1).ToString("0000000");
            comment.CommentContent = commentDTO.CommentContent;
            comment.CommentID = newID;
            comment.State = commentDTO.State;
            comment.VolunteerID = commentDTO.VolunteerID;
            comment.PostID = commentDTO.PostID;
            volunteerDBEntities.Comments.Add(comment);
            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static ICollection<Comment> GetAllCommentByID(string postID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var allComment = volunteerDBEntities.Comments.Where(x => x.PostID == postID && x.State == true).ToList();
            allComment.Reverse();
            return allComment;
        }
        public static bool deleteComment(string commentID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var comment = volunteerDBEntities.Comments.Where(x => x.CommentID == commentID && x.State == true).FirstOrDefault();
            if (comment != null)
            {
                comment.State = false;
            }
            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static bool updateComment(string id, string content)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var comment = volunteerDBEntities.Comments.Where(x => x.CommentID == id && x.State == true).FirstOrDefault();
            if (comment != null)
            {
                comment.CommentContent = content;
                return volunteerDBEntities.SaveChanges() > 0;
            }
            return false;
        }
    }
}
