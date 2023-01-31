using blog.data.Abstract;
using blog.entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.data.Concrete
{
    public class EfCoreAdminRepository : EfCoreGenericRepository<Admin>, IAdminRepository
    {
    }
}
