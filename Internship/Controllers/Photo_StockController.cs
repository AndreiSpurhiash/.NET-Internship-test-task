using Internship.Contracts.Entity;
using Internship.Service.Entity;
using Internship.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Internship.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Photo_StockController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly IPhotoService _photoService;
        private readonly ITextService _textService;

        public Photo_StockController( IAuthorService authorService, IPhotoService photoService,
            ITextService textService)
        {
            _authorService = authorService;
            _photoService = photoService;
            _textService = textService;
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
        [Route("GetPhotoById/{id:guid}")]
        public async Task<IPhoto> GetPhotoByIDAsync([FromRoute] Guid id)
        {
            return await _photoService.GetPhotoByIDAsync(id).ConfigureAwait(false);
        }

        [HttpGet]
        [Route("CSVPhotos")]
        public async Task GetCSVPhotosAsync()
        {
            await _photoService.CreateCVSAsync().ConfigureAwait(false);
        }

        [HttpGet]
        [Route("CSVTexts")]
        public async Task GetCSVTextsAsync()
        {
            await _textService.CreateCVSAsync().ConfigureAwait(false);
        }

        [HttpPut]
        [Route("UpdatePhoto")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task UdatePhoto(PhotoModel photo)
        {
            await _photoService.Update(photo).ConfigureAwait(false);
        }

        [HttpPost]
        [Route("CreateText")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task CreateText(TextModel textModel)
        {
            await _textService.CreateText(textModel).ConfigureAwait(false);
        }

        [HttpPut]
        [Route("AddRatingPhoto/{id:guid}")]
        public async Task AddRatingPhotoAsync([FromRoute] Guid id, int rating)
        {
            await _photoService.AddRaitingPhotoAsync(id, rating).ConfigureAwait(false);
        }
    }
}