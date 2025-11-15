using System.Collections.Generic;
using System.Threading.Tasks;
using Daycare.Domain.Core;
using Daycare.Infrastructure.Context;
using Daycare.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Daycare.Infrastructure.Core
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DayCareContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(DayCareContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(TEntity entity)   
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
