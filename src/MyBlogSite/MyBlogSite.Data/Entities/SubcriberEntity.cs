using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class SubcriberEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubscriberId { get; set; }

        [Required, MinLength(1), MaxLength(50)]
        public string Email { get; set; } = string.Empty;
    }
}
