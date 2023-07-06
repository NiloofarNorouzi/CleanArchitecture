using HR.LeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : BaseEntity
{
    public Task<T> GetAsync(int id);
    public Task<T> AddEntity(T entity);
    public Task<T> UpdateEntity(T entity);
    public Task DeleteEntity(int id);
    public Task<List<T>> GetAll();

}

