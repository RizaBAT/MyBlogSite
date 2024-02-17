using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class SearchEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SearchId { get; set; }

        [Required, MinLength(1)]
        public string SearchTerm { get; set; }

        [DataType(DataType.Date)]
        public DateTime SearchDate { get; set; }
    }
}
