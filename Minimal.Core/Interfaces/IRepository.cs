using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Minimal.Core.Interfaces
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        Task CreateAsync(T entity);

        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> GetAllAsync();
    }
}