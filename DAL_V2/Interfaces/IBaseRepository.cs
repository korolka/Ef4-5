using DAL_V2.Entity;
using System.Linq.Expressions;

namespace DAL_V2.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public Task<bool> Create(T entity);
        Task<bool> Create(T[] entity);
        public Task<bool> Delete(T entity);
        public Task<T> Update(T entity);
        public Task<IEnumerable<T>> Select();
        public Task<T> GetById(Guid id);
        public Task<T> GetFiltered(Expression<Func<T, bool>> expression);
    }
}