using Desafio.Database.Repositorios.Interfaces.Base;
using Desafio.Core.Dominio.Base;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Desafio.Database.Repositorios.Base
{
    public abstract class BaseRepositorio<T> : IBaseRepositorio<T> where T : BaseEntidade
    {
        protected readonly DesafioContext _context;
        public DbSet<T> _dbSet { get; set; }

        public BaseRepositorio(DesafioContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async virtual Task CreateAsync(T obj)
        {
            _dbSet.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async virtual Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async virtual Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async virtual Task UpdateAsync(T obj)
        {
            _dbSet.Update(obj);
            await _context.SaveChangesAsync();
        }

        public async virtual Task DeleteAsync(T obj)
        {
            _dbSet.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async virtual Task DeleteByIdAsync(Guid id)
        {
            var obj = _dbSet.Find(id);
            if (obj != null)
            {
                await DeleteAsync(obj);
            }
        }
    }
}
