using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.entity.Concrete;

namespace blog.data.Abstract
{
    public interface IAuthorRepository : IRepository<Author>
    {
        
    }
}