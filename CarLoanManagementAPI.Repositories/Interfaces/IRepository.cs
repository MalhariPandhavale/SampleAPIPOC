using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLoanManagementAPI.Repositories.Interfaces
{
    public interface IRepository<TEnity> where TEnity : class
    {
        Task<TEnity> GetByIdAsync(int id);
        Task<IEnumerable<TEnity>> GetAllAsync();
        void Add(TEnity entity);
        void Update(TEnity entity);
        void Delete(TEnity entity);
        Task<int> SaveChangesAsync();
    }
}
