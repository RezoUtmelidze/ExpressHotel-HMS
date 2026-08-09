using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ExpressHotel.Application.Abstractions
{
    public interface IRepository<T> where T : class
    {
        Task<(IEnumerable<T> Items, int Quantity)> GetAllAsync(
            Expression<Func<T, bool>> filter = null!,
            int? PageNumber = null,
            int? PageSize = null,
            Expression<Func<T, object>> orderBy = null!,
            bool ascending = true,
            CancellationToken cancellationToken = default,
            bool tracking = true,
            params Expression<Func<T, object>>[] includes);
        Task<T?> GetAsync(
            Expression<Func<T, bool>> filter,
            bool tacking = true,
            CancellationToken cancellationToken = default,
            Func<IQueryable<T>, IQueryable<T>>? include = null);
        Task AddAsync(T entity);
        Task<bool> SaveAsync(CancellationToken cancellationToken = default);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
    }
}