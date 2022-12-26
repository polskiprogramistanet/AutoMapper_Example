using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using libAutoMapper.Domain.Entities;

namespace libAutoMapper.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T: class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
