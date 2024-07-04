using CarLoanManagementAPI.Core.Database;
using CarLoanManagementAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarLoanManagementAPI.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

      

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }

}
