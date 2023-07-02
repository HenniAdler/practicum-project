
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
    internal class ChildService :IDataServices<Child>
    {
        private readonly IDataRepository<Child> repository;
       

        public ChildService(IDataRepository<Child> repository)
        {
            this.repository = repository;
           
        }

        public async Task<Child> AddAsync(Child entity)
        {
            //Child child=mapper.Map<Child>(entity);
            //var c=await repository.AddAsync(child);
            //var newChild=mapper.Map<Child>(child);
            //return newChild;

            return await repository.AddAsync(entity);
        }


        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);   
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await repository.GetAllAsync();    
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task<Child> UpdateAsync(Child entity)
        {
            
            return await repository.UpdateAsync(entity);
        }

       
    }
}
