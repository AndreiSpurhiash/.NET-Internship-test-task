using CsvHelper.Configuration;
using Internship.Contracts.Entity;
using Internship.Service.Entity;
using Internship.Service.Implementations;
using Internship.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using CsvHelper;
using Internship.Domain.Entity;
using System.Collections.Generic;

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

        [HttpGet]
        [Route("GetEntities")]
        public IEnumerable<string> GetEntities()
        {
            return _authorService.GetEntitiesList();
        }

        [HttpGet]
        [Route("GetListPhotos")]
        public async Task<IEnumerable<IPhoto>> GetPhotos()
        {
            return await _photoService.GetListAsync().ConfigureAwait(false);
        }

        [HttpGet]
        [Route("GetPhotoById")]
        public async Task<IPhoto> GetPhotoByIDAsync(Guid id)
        {
            return await _photoService.GetPhotoByIDAsync(Guid.Parse(input: Console.ReadLine())).ConfigureAwait(false);
        }

        [HttpGet]
        [Route("CSV")]
        public void GetCSV()
        {
            _photoService.CreateCVS();
        }
    }
}