using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Repository : IRepository
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }
        public async Task<int> SaveChangesAsync() => await Context.SaveChangesAsync();
        public async Task UpdateAsync(string sql, object[] args = null)
        {
            if (args == null)
                await Context.Database.ExecuteSqlRawAsync(sql);
            else
                await Context.Database.ExecuteSqlRawAsync(sql, args);
        }
        public async Task InsertAsync<TEntity>(TEntity entity) where TEntity : class
        {
            await Context.Set<TEntity>().AddAsync(entity);
        }
        public async Task<IEnumerable<TEntity>> ToListAsync<TEntity>() where TEntity : class => await Context.Set<TEntity>().ToListAsync();
        public async Task<IEnumerable<TEntity>> ToListAsyncOptimised<TEntity>() where TEntity : class => await Context.Set<TEntity>().AsNoTracking().ToListAsync();
        public async Task<List<TEntity>> FindAsync<TEntity>(string sql, object[] args = null) where TEntity : class
        {
            return args == null ? await Context.Set<TEntity>().FromSqlRaw(sql).ToListAsync() : await Context.Set<TEntity>().FromSqlRaw(sql, args).ToListAsync();

        }

        public async Task<List<TEntity>> FindOptimisedAsync<TEntity>(string sql, object[] args = null) where TEntity : class
        {
            return args == null ? await Context.Set<TEntity>().FromSqlRaw(sql).AsNoTracking().ToListAsync() : await Context.Set<TEntity>().FromSqlRaw(sql, args).AsNoTracking().ToListAsync();

        }
        public List<TEntity> FindOptimisedNoAsync<TEntity>(string sql, object[] args = null) where TEntity : class
        {
            return args == null ? Context.Set<TEntity>().FromSqlRaw(sql).AsNoTracking().ToList() : Context.Set<TEntity>().FromSqlRaw(sql, args).AsNoTracking().ToList();

        }
        public async Task<TEntity> FirstOrDefaultAsync<TEntity>(string sql, object[] args = null) where TEntity : class
        {
            return args == null ? await Context.Set<TEntity>().FromSqlRaw(sql).FirstOrDefaultAsync() : await Context.Set<TEntity>().FromSqlRaw(sql, args).FirstOrDefaultAsync();
        }
        public async Task AddAsync(string sql, object[] args = null)
        {
            if (args == null)
                await Context.Database.ExecuteSqlRawAsync(sql);
            else
                await Context.Database.ExecuteSqlRawAsync(sql, args);
        }
        public async Task AddRangeAsync<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            await Context.Set<TEntity>().AddRangeAsync(entities);
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Set<TEntity>().Remove(entity);
        }
        public void RemoveRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
        public TEntity Find<TEntity>(string id) where TEntity : class
        {
            return Context.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> ToList<TEntity>() where TEntity : class
        {
            return Context.Set<TEntity>();
        }
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
        public IEnumerable<TEntity> ToListOptimised<TEntity>() where TEntity : class
        {
            return Context.Set<TEntity>().AsNoTracking();
        }
        public void ProcessProcedure(string sql, params object[] args)
        {
            Context.Database.ExecuteSqlRaw(sql, args);
        }
        public List<TEntity> Find<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            return Context.Set<TEntity>().Where(predicate).ToList();
        }
        public IEnumerable<TEntity> FindOptimised<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            return Context.Set<TEntity>().AsNoTracking().Where(predicate);
        }
        public TEntity FirstOrDefault<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }
        public TEntity FirstOrDefaultOptimised<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            return Context.Set<TEntity>().AsNoTracking().SingleOrDefault(predicate);
        }
        public void Add<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Set<TEntity>().Add(entity);
        }
        public void AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            Context.Set<TEntity>().AddRange(entities);
        }

    }
}
