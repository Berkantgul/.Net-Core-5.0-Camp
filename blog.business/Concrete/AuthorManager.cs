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
            _authorRepository.Delete(entity);
        }

        public List<Author> GetAllList()
        {
            return _authorRepository.GetAll();
        }

        public Author TGetById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public void Update(Author entity)
        {
            _authorRepository.Update(entity);

        }

        public List<Author> GetAllAuthor(int id)
        {
            return _authorRepository.GetAll(i => i.AuthorId == id);
        }

        public async Task<List<Author>> ApiGetAll()
        {
            return await _authorRepository.ApiGetAll();
        }

        public async Task DeleteAsync(Author entity)
        {
            await _authorRepository.DeleteAsync(entity);
        }

        public async Task AddAsync(Author entity)
        {
            await _authorRepository.InsertAsync(entity);
        }
    }
}