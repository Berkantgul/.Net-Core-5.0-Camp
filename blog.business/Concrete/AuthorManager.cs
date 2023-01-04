using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity.Concrete;

namespace blog.business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorRepository _authorRepository;
        public AuthorManager(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void Add(Author entity)
        {
            _authorRepository.Insert(entity);
        }


        public void TDelete(Author entity)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Author  TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}