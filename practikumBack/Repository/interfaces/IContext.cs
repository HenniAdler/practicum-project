using Microsoft.EntityFrameworkCore;
using Repository.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.interfaces
{
    public interface IContext
    {
        DbSet<Child> Children { get; set; }
        DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default/*(CancellationToken)*/);
    }
}
