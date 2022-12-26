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
        void Delete(T entity);
        void Insert(T entity);
        T GetById(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter);
    }
}