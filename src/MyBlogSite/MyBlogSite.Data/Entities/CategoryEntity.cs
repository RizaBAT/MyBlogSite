using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class CategoryEntity : EntityBase  // Kategorilerin tanımlandığı entity 
    {

        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public ICollection<BlogPostEntity> BlogPosts { get; set; }
    }
}
