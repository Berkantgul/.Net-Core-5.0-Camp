using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.entity.Concrete;

namespace blog.business.Abstract
{
    public interface IAuthorService : IGenericService<Author>
    {
        List<Author> GetAllAuthor(int id);
    }
}