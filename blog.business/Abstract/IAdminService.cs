using blog.entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.business.Abstract
{
    interface IAdminService : IGenericService<Admin>
    {
    }
}
