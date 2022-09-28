using Internship.DAL.Repositories;
using Internship.Service.Entity;
using Internship.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Internship.Service.Implementations
{
    public class AuthorService : IAuthorService
    {
        private readonly BaseRepository<Author> AuthorRepository;
        private readonly DbContext _context;
        public AuthorService()
        {
        }

        public AuthorService(BaseRepository<Author> authorRepository)
        {
            AuthorRepository = authorRepository;
        }
        public async Task<IEnumerable<Author>> GetListAsync()
        {
            var authors = await authorRepository.GetListAsync().ConfigureAwait(false);
        }
}
