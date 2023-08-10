using Desafio.Core.Dominio.Base;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Desafio.Database.Repositorios.Interfaces.Base
{
    public interface IBaseRepositorio<T> where T : BaseEntidade
    {
        Task CreateAsync(T Obj);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid Id);
        Task UpdateAsync(T Obj);
        Task DeleteAsync(T Obj);
        Task DeleteByIdAsync(Guid Id);
    }
}
