using Internship.DAL.Interfaces;
using Internship.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Internship.DAL.Repositories
{
    public class TextRepository : BaseRepository<Text>
    {
        readonly DbContext db;
        public TextRepository(DbContext context) : base(context)
        {
            db = context;
        }
    }
}
