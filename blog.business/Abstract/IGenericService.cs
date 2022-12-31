using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.business.Abstract
{
    public interface IGenericService<TEntity>
    {
        void Update(TEntity entity);
        List<TEntity> GetAllList();
        TEntity GetById(int id);
        void Delete(TEntity entity);
        void Add(TEntity entity);
    }
}