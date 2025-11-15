using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Daycare.Infrastructure.Context;
using Daycare.Domain.Entities;
using Daycare.Domain.Core;

namespace Daycare.Infrastructure.Core
{
    public class BaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DayCareContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(DayCareContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var existing = await GetByIdAsync(id);
            if (existing == null)
                return false;

            _dbSet.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
