using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class BlogPostCategoryEntity // Blog yazıları ile kategoriler arasındaki ilişkiyi temsil eden entity
        {
            public int BlogPostCategoryId { get; set; }
            public int BlogPostId { get; set; }
            public int CategoryId { get; set; }

            [ForeignKey(nameof(BlogPostId))]
            public RoleEntity BlogPost { get; set; } = null!;

            [ForeignKey(nameof(CategoryId))]
            public CategoryEntity Category { get; set; } = null!;
        }
    }
