using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity.Concrete;

namespace blog.business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;
        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public void Add(About entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(About entity)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAllList()
        {
            return _aboutRepository.GetAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(About entity)
        {
            throw new NotImplementedException();
        }
    }
}