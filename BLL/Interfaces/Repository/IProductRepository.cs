using BLL.Entity;

namespace BLL.Interfaces.Repository
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<IEnumerable<Product>> GetByIdIncludWord(string name);
    }
}
