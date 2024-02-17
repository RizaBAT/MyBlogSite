using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class UserPostLikeEntity // Kullanıcıların blog yazılarını beğenilerini temsil eden entity.
    {
        [Key]
        public int UserPostLikeId { get; set; }

        public int UserId { get; set; }

        public int BlogPostId { get; set; }

        [ForeignKey(nameof(UserId))]
        public UserEntity UserPost { get; set; } = null!;
        [ForeignKey(nameof(BlogPostId))]
        public RoleEntity BlogPost { get; set; } = null!;
    }
}