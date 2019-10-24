using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository
    {
        void Add<TEntity>(TEntity entity) where TEntity : class;
        Task AddAsync(string sql, object[] args = null);
        void AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
        Task AddRangeAsync<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
        List<TEntity> Find<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        TEntity Find<TEntity>(string id) where TEntity : class;
        Task<List<TEntity>> FindAsync<TEntity>(string sql, object[] args = null) where TEntity : class;
        IEnumerable<TEntity> FindOptimised<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        Task<List<TEntity>> FindOptimisedAsync<TEntity>(string sql, object[] args = null) where TEntity : class;
        List<TEntity> FindOptimisedNoAsync<TEntity>(string sql, object[] args = null) where TEntity : class;
        TEntity FirstOrDefault<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        Task<TEntity> FirstOrDefaultAsync<TEntity>(string sql, object[] args = null) where TEntity : class;
        TEntity FirstOrDefaultOptimised<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        Task InsertAsync<TEntity>(TEntity entity) where TEntity : class;
        void ProcessProcedure(string sql, params object[] args);
        void Remove<TEntity>(TEntity entity) where TEntity : class;
        void RemoveRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
        void SaveChanges();
        Task<int> SaveChangesAsync();
        IEnumerable<TEntity> ToList<TEntity>() where TEntity : class;
        Task<IEnumerable<TEntity>> ToListAsync<TEntity>() where TEntity : class;
        Task<IEnumerable<TEntity>> ToListAsyncOptimised<TEntity>() where TEntity : class;
        IEnumerable<TEntity> ToListOptimised<TEntity>() where TEntity : class;
        Task UpdateAsync(string sql, object[] args = null);
    }
}