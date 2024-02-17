using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class BlogPostViewEntity // Blog yazılarının kaç kez görüntülendiğini takip eden entity.
    {
        [Key]
        public int BlogPostViewId { get; set; }
        public int BlogPostId { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime ViewedAt { get; set; }
    }
}
