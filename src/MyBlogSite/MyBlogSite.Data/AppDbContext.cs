using Microsoft.EntityFrameworkCore;
using MyBlogSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<BlogPostLikeEntity> Blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var roles = new RoleEntity[]
            {
               new RoleEntity {Id=1, Name="Üye"},
               new RoleEntity {Id=2, Name ="Yazar"},
               new RoleEntity {Id=3, Name = "Admin"}
            };
            var categories = new CategoryEntity[]
            {
                new CategoryEntity {Id=1, Name= "Bilim"},
                new CategoryEntity {Id=2, Name="Eğitim"}
            };
            modelBuilder.Entity<RoleEntity>().HasData(roles);
            modelBuilder.Entity<CategoryEntity>().HasData(categories);
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new BlogPostEntityConfiguration());
            base.OnModelCreating(modelBuilder);

        }
    }
}
