using Repository.entities;
using Repository.interfaces;
using Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.services
{
    internal class UserService:IDataServices<User>
    {
        private readonly IDataRepository<User> repository;

        public UserService(IDataRepository<User> repository)
        {
            this.repository = repository;
        }

        public async Task<User> AddAsync(User entity)
        {
            //User user = mapper.Map<User>(entity);
            //var u = await repository.AddAsync(user);
            //return mapper.Map<User>(user);
            return await repository.AddAsync(entity);

        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task<User> UpdateAsync(User entity)
        {
            
            return await repository.UpdateAsync(entity);
        }

       

      
    }
}
