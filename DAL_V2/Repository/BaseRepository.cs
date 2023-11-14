using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL_V2.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        public async Task<bool> Create(TEntity entity)
        {
            using (var context = new EntityDatabase())
            {
                context.GetDbSet<TEntity>().Add(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> Create(TEntity[] entity)
        {
            using (var context = new EntityDatabase())
            {
                context.GetDbSet<TEntity>().AddRange(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async virtual Task<bool> Delete(TEntity entity)
        {
            using (var context = new EntityDatabase())
            {
                context.Remove(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async virtual Task<TEntity> GetById(Guid id)
        {
            using (var context = new EntityDatabase())
            {
                return await context.GetDbSet<TEntity>()
                    .SingleOrDefaultAsync(e => e.Id == id);
            }
        }

        public async virtual Task<TEntity> GetFiltered(Expression<Func<TEntity, bool>> expression)
        {
            using (var context = new EntityDatabase())
            {
                return await context.GetDbSet<TEntity>()
                    .SingleOrDefaultAsync(expression);
            }
        }

        public async virtual Task<IEnumerable<TEntity>> Select()
        {
            using (var context = new EntityDatabase())
            {
                return await context.GetDbSet<TEntity>()
                    .ToListAsync();
            }
        }

        public async virtual Task<TEntity> Update(TEntity entity)
        {
            using (var context = new EntityDatabase())
            {
                context.Update(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }
    }
}