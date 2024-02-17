using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class BlogPostTagEntity // Blog yazıları ile etiketler arasındaki ilişkiyi temsil eden entity.
    {
        public int BlogPostTagId { get; set; }
        public int BlogPostId { get; set; }
        public int TagId { get; set; }

        [ForeignKey(nameof(BlogPostId))]
        public RoleEntity BlogPost { get; set; } = null!;

        [ForeignKey(nameof(TagId))]
        public TagEntity Tag { get; set; } = null!;
    }
}
