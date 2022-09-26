using Internship.DAL.Interfaces;
using Internship.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Internship.DAL.Repositories
{
    public class TextRepository : ITextRepository
    {
        readonly DbContext db;
        public TextRepository(DbContext context)
        {
            db = context;
        }
        public void Create(Text text)
        {
            db.Set<Text>().Add(text);
        }

        public void Save(Text text)
        {
            throw new NotImplementedException();
        }
    }
}
