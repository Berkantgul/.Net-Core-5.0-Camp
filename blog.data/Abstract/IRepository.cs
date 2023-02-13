using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace blog.data.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Update(T entity);
        Task UpdateAsync(T entity); 
        void Delete(T entity);
        Task DeleteAsync(T entity);
        void Insert(T entity);
        Task InsertAsync(T entity);
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter);
        Task<List<T>> ApiGetAll();

    }
}