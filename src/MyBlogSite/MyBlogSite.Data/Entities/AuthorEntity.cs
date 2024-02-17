using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class AuthorEntity // Blog yazılarını yazan yazarların tanımlandığı entity
    {
        [Required, Key]
        public int AuthorId { get; set; }

        [Required, MinLength(1), MaxLength(25)]
        public string Name { get; set; } = string.Empty;

        [Required, MinLength(1), MaxLength(1000)]
        public string Biography { get; set; } = string.Empty;

    }
}
