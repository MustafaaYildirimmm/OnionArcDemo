using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArcDemo.Application.Interfaces.Repository;
using OnionArcDemo.Persistence.Context;
using OnionArcDemo.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcDemo.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("applicationInMemoryDb"));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();

        }
    }
}
