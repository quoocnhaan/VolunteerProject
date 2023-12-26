using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.BLL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{
    public class PostDAL
    {
        public static bool CreatePost(PostDTO postDTO, bool state)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            Post post = new Post();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            int allPost = volunteerDBEntities.Posts.Count();
            string newID = "POS" + (allPost + 1).ToString("0000000");
            post.Caption = postDTO.Caption;
            post.Image = postDTO.Image;
            post.PostID = newID;
            post.VolunteerID = curVol.VolunteerID;
            post.CreateDate = DateTime.Now;
            post.PostLike = 0;
            post.State = state;
            post.status = true;
            volunteerDBEntities.Posts.Add(post);
            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static ICollection<Post> getAllPost()
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var allPost = volunteerDBEntities.Posts.Where(x => x.status == true).ToList();
            allPost.Reverse();
            return allPost;
        }
        public static bool? checkPostLike(string volunteerID, string postID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var result = volunteerDBEntities.PostLikes.Where(x => x.VolunteerID == volunteerID && x.PostID == postID).FirstOrDefault();
            if (result != null) return result.state;
            return false;
        }
        public static bool? Event_LikePost(string postID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            Volunteer volunteer = volunteerDBEntities.Volunteers.Where(x => x.AccountID == curUser.AccountID).FirstOrDefault();
            bool result = false;
            if (volunteerDBEntities.PostLikes.Any(x => x.VolunteerID == volunteer.VolunteerID && x.PostID == postID))
            {
                var currentLikeEvent = volunteerDBEntities.PostLikes.Where(x => x.VolunteerID == volunteer.VolunteerID && x.PostID == postID).FirstOrDefault();
                //if (currentLikeEvent.state == null) currentLikeEvent.state = true;
                //else 
                currentLikeEvent.state = !currentLikeEvent.state;
                result = volunteerDBEntities.SaveChanges() > 0;
                return currentLikeEvent.state;
            }
            else
            {
                PostLike postLike = new PostLike();
                postLike.state = true;
                postLike.PostID = postID;
                postLike.VolunteerID = volunteer.VolunteerID;
                volunteerDBEntities.PostLikes.Add(postLike);
                result = volunteerDBEntities.SaveChanges() > 0;
                return true;
            }
        }
        public static int countLike(string postID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities(); 
            return volunteerDBEntities.PostLikes.Where(x => x.PostID == postID && x.state == true).Count();
        }
        public static bool deletePost(string postID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var post = volunteerDBEntities.Posts.Where(x => x.PostID == postID && x.status == true).FirstOrDefault();
            if (post != null)
            {
                post.status = false;
            }
            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static bool updatePost(string id, string content)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var post = volunteerDBEntities.Posts.Where(x => x.PostID == id && x.status == true).FirstOrDefault();
            if (post != null)
            {
                post.Caption = content;
                return volunteerDBEntities.SaveChanges() > 0;
            }
            return false;
        }
    }
}
