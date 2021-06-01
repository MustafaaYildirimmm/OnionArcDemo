using OnionArcDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcDemo.Application.Interfaces.Repository
{
    public interface IProductRepository : IRepositoryBaseAsync<Product>
    {
        
    }
}
