using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.data.Abstract;
using blog.entity.Concrete;

namespace blog.data.Concrete
{
    public class EfCoreCommentRepository : EfCoreGenericRepository<Comment>, ICommentRepository
    {

    }
}