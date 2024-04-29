using Prism.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Prism.Domain.Abstract
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetData(Expression<Func<T, bool>> expression = null);
        Task Insert(T entity);
        Task Insert(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> expression = null);
        Task Commit();
    }
}
