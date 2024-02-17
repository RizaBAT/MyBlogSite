using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class UserEntity : EntityBase
    {
        [Required, MinLength(1), MaxLength(25)]
        public string Name { get; set; } = string.Empty;

        [Required, MinLength(1), MaxLength(25)]
        public string Surname { get; set; } = string.Empty;
        [Required, DataType(DataType.DateTime)]
        public DateTime BirthDay { get; set; }

        public int RoleId { get; set; }

        [Required, MinLength(10), MaxLength(50)]
        public string Email { get; set; } = string.Empty;

        [Required, DataType(DataType.Password)]
        public string PasswordHash { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsActive { get; set; }


        //Navigation Properties
        public RoleEntity Role { get; set; }

        public ICollection<BlogPostEntity> BlogPosts { get; set; }
    }
    public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }

        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
