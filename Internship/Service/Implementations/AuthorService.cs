using AutoMapper;
using Internship.Cotracts.Entity;
using Internship.DAL.Repositories;
using Internship.Domain.Entity;
using Internship.Migrations;
using Internship.Service.Entity;
using Internship.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Internship.Service.Implementations
{
    public class AuthorService : IAuthorService
    {
        readonly DbContext db;

        private readonly IMapper _mapper;
        private readonly AuthorRepository _authorRepository;

        public AuthorService(IMapper mapper, AuthorRepository authorRepository)
        {
            _mapper = mapper;
            _authorRepository = authorRepository;
        }
        public IEnumerable<string> GetEntitiesList()
        {
            return _authorRepository.GetEntitiesList();
        }
    }
}