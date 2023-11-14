using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL_V2.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public async Task<IEnumerable<Product>> GetByIdIncludWord(string name)
        {
            using (var context = new EntityDatabase())
            {
                return await context.Product
                    .Include(p => p.KeyParams)
                        .ThenInclude(kp => kp.KeyWord)
                    .Where(p => p.KeyParams.Any(kp => kp.KeyWord.Keyword == name))
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<Product>> SelectIncludeCategory()
        {
            using (var context = new EntityDatabase())
            {
                return await context.Product
                    .Include(p => p.Category)
                    .Include(p => p.KeyParams)
                        .ThenInclude(kp => kp.KeyWord)
                    .ToListAsync();
            }
        }
    }
}