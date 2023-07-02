using Microsoft.Extensions.DependencyInjection;
using MyDbContext.entities;
using Repository;
using Repository.entities;
using Repository.interfaces;
using Services.interfaces;
using Services.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServicesCollectionsExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositoryServices();
            services.AddSingleton<IContext, PractiSqlContext>();
            services.AddScoped<IDataServices<User>, UserService>();
            services.AddScoped<IDataServices<Child>, ChildService>();
        }
    }
}
