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
        Task<List<TEntity>> ApiGetAll();
        TEntity TGetById(int id);
        void TDelete(TEntity entity);
        Task DeleteAsync(TEntity entity);
        void Add(TEntity entity);
        Task AddAsync(TEntity entity);
    }
}