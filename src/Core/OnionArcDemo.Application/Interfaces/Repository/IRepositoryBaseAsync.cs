using OnionArcDemo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcDemo.Application.Interfaces.Repository
{
    public interface IRepositoryBaseAsync<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(long id);
        Task<T> AddAsync(T entity);
    }
}
