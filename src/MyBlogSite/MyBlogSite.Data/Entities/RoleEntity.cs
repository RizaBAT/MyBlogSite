using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class RoleEntity: EntityBase
    {
        [Required, MinLength(1), MaxLength(25)]
        public string Name { get; set; } = string.Empty;
        public ICollection<UserEntity> Users { get; set; }
    }
}
