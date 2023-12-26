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
    public class CommentBLL
    {
        public static bool CreateComment(CommentDTO commentDTO)
        {
            return CommentDAL.CreateComment(commentDTO);
        }
        public static ICollection<CommentDTO> GetAllCommentByID(string postID)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, CommentDTO>());
            var mapper = new Mapper(config);
            List<CommentDTO> dto = mapper.Map<List<CommentDTO>>(CommentDAL.GetAllCommentByID(postID));
            return dto;
        }
        public static bool deleteComment(string commentID)
        {
            return CommentDAL.deleteComment(commentID);
        }
        public static bool updateComment(string id, string content)
        {
            return CommentDAL.updateComment(id, content);
        }
    }
}
