using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class CommentLikeEntity : EntityBase // Yapılan yorumlara beğeni eklemek için entity
    {
        public int UserId { get; set; }
        public int CommentId { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(UserId))]
        public UserEntity User { get; set; } = null!;

        [ForeignKey(nameof(CommentId))]
        public CommentEntity Comment { get; set; } = null!;
    }
}
