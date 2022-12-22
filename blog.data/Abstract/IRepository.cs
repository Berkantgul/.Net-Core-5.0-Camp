using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}