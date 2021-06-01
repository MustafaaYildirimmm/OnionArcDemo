using Microsoft.EntityFrameworkCore;
using OnionArcDemo.Application.Interfaces.Repository;
using OnionArcDemo.Domain;
using OnionArcDemo.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcDemo.Persistence.Repositories
{
    public class RepositoryBaseAsync<T> : IRepositoryBaseAsync<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public RepositoryBaseAsync(ApplicationDbContext context)
        {
            this._context = context;
        }


        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
