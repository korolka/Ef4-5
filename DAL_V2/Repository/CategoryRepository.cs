using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL_V2.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public async Task<IEnumerable<Category>> SelectIncludeProducts()
        {
            using (var context = new EntityDatabase())
            {
                return await context.Category
                    .Include(c => c.Products)                        
                    .ToListAsync();
            }
        }        
    }
}