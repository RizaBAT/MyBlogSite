using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class BlogPostLikeEntity : EntityBase
    {
        public int BlogPostId { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(UserId))]
        public UserEntity User { get; set; } = null!;

        [ForeignKey(nameof(BlogPostId))]
        public BlogPostEntity Comment { get; set; } = null!;

    }
}
