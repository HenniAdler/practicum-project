using Microsoft.Extensions.DependencyInjection;
using Repository.entities;
using Repository.interfaces;
using Repository.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class ServicesRepositoryCollectionExtension
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IDataRepository<User>, UserRepository>();
            services.AddScoped<IDataRepository<Child>, ChildRepository>();
        }
    }
}
