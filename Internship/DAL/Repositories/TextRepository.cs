using Internship.DAL.Interfaces;
using Internship.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Internship.DAL.Repositories
{
    public class TextRepository : BaseRepository<Text>, ITextRepository
    {
        readonly DbContext db;
        public TextRepository(DbContext context) : base(context)
        {
            db = context;
        }

        public virtual async Task<IEnumerable<Text>> GetListAsync()
        {
            return await db.Set<Text>().Include(av => av.Author).ToListAsync().ConfigureAwait(false);
        }
    }
}
