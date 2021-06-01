using OnionArcDemo.Application.Interfaces.Repository;
using OnionArcDemo.Domain.Entities;
using OnionArcDemo.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcDemo.Persistence.Repositories
{
    public class ProductRepository : RepositoryBaseAsync<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
