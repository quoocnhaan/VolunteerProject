using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.BLL
{
    public class PostBLL
    {
        public static bool CreatePost(PostDTO postDTO, bool state)
        {
            return PostDAL.CreatePost(postDTO, state);
        }
        public static ICollection<PostDTO> getAllPost()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Post, PostDTO>());
            var mapper = new Mapper(config);
            List<PostDTO> dto = mapper.Map<List<PostDTO>>(PostDAL.getAllPost());
            return dto;
        }
        public static bool? Event_LikePost(string postID)
        {
            return PostDAL.Event_LikePost(postID);
        }
        public static int countLike(string postID)
        {
            return PostDAL.countLike(postID);
        }
        public static bool? checkPostLike(string volunteerID, string postID)
        {
            return PostDAL.checkPostLike(volunteerID, postID);
        }
        public static bool deletePost(string postID)
        {
            return PostDAL.deletePost(postID);
        }
        public static bool updatePost(string id, string content)
        {
            return PostDAL.updatePost(id, content);
        }
    }
}
