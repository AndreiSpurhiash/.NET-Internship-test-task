using Internship.Contracts.Entity;
using Internship.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Internship.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IAuthorService _authorService;
        private readonly IPhotoService _photoService;

        public AuthorController(ILogger<AuthorController> logger, 
            IAuthorService authorService, IPhotoService photoService)
        {
            _logger = logger;
            _authorService = authorService;
            _photoService = photoService;
        }

        [HttpGet(Name = "GetPhotos")]
        public async Task<IEnumerable<IPhoto>> GetAsync()
        {
            return await _photoService.GetListAsync().ConfigureAwait(false);
        }

        [HttpGet(Name = "GetEntities")]
        public IEnumerable<string> Get()
        {
            return _authorService.GetEntitiesList();
        }
    }
}