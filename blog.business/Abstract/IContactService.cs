using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.entity.Concrete;

namespace blog.business.Abstract
{
    public interface IContactService
    {
        void AddContact(Contact contact);
    }
}