using Microsoft.EntityFrameworkCore;
using Repository.entities;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.repository
{
    internal class UserRepository : IDataRepository<User>
    {
        IContext _context;
        public async Task<User> AddAsync(User entity)
        {
            var newItem=_context.Users.Add(entity);
            await _context.SaveChangesAsync();
            return newItem.Entity;
        }
       

        public async Task DeleteAsync(int id)
        {
            _context.Users.Remove(_context.Users.FirstOrDefault(e=>e.UserId == id));    
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User entity)
        {
            var updateItem=_context.Users.Update(entity);
            await _context.SaveChangesAsync();
            return updateItem.Entity;
        }
    }
}
