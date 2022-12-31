using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity.Concrete;

namespace blog.business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void Add(Contact entity)
        {
            _contactRepository.Insert(entity);
        }



        public void Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}