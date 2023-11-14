using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL_V2.Repository
{
    public class WordRepository : BaseRepository<Word>, IWordRepository
    {
        public async Task<IEnumerable<Word>> SelectIncludeKeyParamsProducts()
        {
            using (var context = new EntityDatabase())
            {
                return await context.Words
                    .Include(w => w.ProductLinks)
                        .ThenInclude(pl => pl.Product)
                    .ToListAsync();
            }
        }
    }
}