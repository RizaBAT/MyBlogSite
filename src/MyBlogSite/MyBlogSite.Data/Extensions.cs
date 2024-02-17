using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyBlogSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data
{
    public static class Extensions
    {
        public static void AddMyBlogData(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DbContext, AppDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<IRepository<UserEntity>, Repository<UserEntity>>();
            services.AddScoped<IRepository<BlogPostEntity>, Repository<BlogPostEntity>>();
            services.AddScoped<IRepository<CategoryEntity>, Repository<CategoryEntity>>();
            services.AddScoped<IRepository<RoleEntity>, Repository<RoleEntity>>();

            services.AddScoped<IRepository<CommentEntity>, Repository<CommentEntity>>();

            services.AddScoped<IRepository<BlogPostLikeEntity>, Repository<BlogPostLikeEntity>>();
        }
    }
}
