using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.business.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        public AdminManager(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public void Add(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Admin>> ApiGetAll()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Admin entity)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAllList()
        {
            return _adminRepository.GetAll();
        }

        public void TDelete(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Admin TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}
