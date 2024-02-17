using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class, IEntity<int>
    {
        TEntity? GetById(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Add(TEntity entity);
        TEntity? Update(TEntity entity);
        bool Delete(int id);
    }
    internal sealed class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity<int>
    {
        private readonly DbContext _dbContext;
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private DbSet<TEntity> Set => _dbContext.Set<TEntity>();
        private IQueryable<TEntity> Query => Set.Where(x => !x.IsDeleted);
        public TEntity? GetById(int id) =>Query.SingleOrDefault(x => x.Id == id);
        public IEnumerable<TEntity> GetAll() => Set;

    }
}
