using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL_V2.Repository
{
    public class KeyParamsRepository : BaseRepository<KeyParams>, IKeyParamsRepository
    {
        public async Task<IEnumerable<KeyParams>> SelectIncludeWords()
        {
            using (var context = new EntityDatabase())
            {
                return await context.KeyLink
                    .Include(k => k.KeyWord)
                    .Include(k => k.Product)
                    .ToListAsync();
            }
        }
    }
}