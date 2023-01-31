using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.data.Abstract;
using blog.entity.Concrete;

namespace blog.data.Concrete
{
    public class EfCoreContactRepository : EfCoreGenericRepository<Contact>, IContactRepository
    {
        public int ContactCount()
        {
            using (var context = new BlogContext())
            {
                var count = context.Contacts.Count();
                return count;
            }
        }
    }
}