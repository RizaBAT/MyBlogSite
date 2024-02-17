using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class BlogPostEntity : EntityBase // Blog içeriklerini temsil eden bir entity
    {

        [Required, MinLength(10), MaxLength(50)]
        public string Title { get; set; } = string.Empty;
        [Required, MinLength(50), MaxLength(1500)]
        public string Content { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int PostView { get; set; }
        public int PostLikeCount { get; set; }

        // Navigation Properties
        public UserEntity User { get; set; }
        public CategoryEntity Category { get; set; }
    }

    public class BlogPostEntityConfiguration : IEntityTypeConfiguration<BlogPostEntity>
    {
        public void Configure(EntityTypeBuilder<BlogPostEntity> builder)
        {
            builder.HasOne(b => b.User)
               .WithMany(u => u.BlogPosts)
               .HasForeignKey(b => b.UserId)
               .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(b => b.Category)
               .WithMany(c => c.BlogPosts)
               .HasForeignKey(b => b.CategoryId)
               .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
