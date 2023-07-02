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
    internal class ChildRepository : IDataRepository<Child>
    {
        IContext _context;

        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(Child entity)
        {
            var newItem = _context.Children.Add(entity);
            await _context.SaveChangesAsync();
            return newItem.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Children.Remove(_context.Children.FirstOrDefault(e => e.ChildId == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _context.Children.FindAsync();
        }

        public async Task<Child> UpdateAsync(Child entity)
        {
            var updateItem=_context.Children.Update(entity);
            await _context.SaveChangesAsync();
            return updateItem.Entity;
        }


       
    }
}
