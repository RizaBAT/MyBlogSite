using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class CommentEntity : EntityBase // Blog yazılarına yapılan yorumları temsil eden entity.
    {
        public int BlogPostId { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public int UserId { get; set; }
        public DateTime CommentTime { get; set; }
        public bool IsActive { get; set; }

        //public ICollection<CommentLikeEntity> CommentLikes { get; } = null!;
    }
}

