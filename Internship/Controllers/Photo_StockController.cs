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
        [ProducesResponseType(typeof(IEnumerable<string>), (int)HttpStatusCode.OK)]
        public IActionResult GetEntities()
        {
            var result = _authorService.GetEntitiesList();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetListPhotos")]
        [ProducesResponseType(typeof(IEnumerable<IPhoto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetPhotos()
        {
            var result = await _photoService.GetListAsync().ConfigureAwait(false);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetPhotoById/{id:guid}")]
        [ProducesResponseType(typeof(IPhoto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetPhotoByIDAsync([FromRoute] Guid id)
        {
            var result = await _photoService.GetPhotoByIDAsync(id).ConfigureAwait(false);
            return Ok(result);
        }

        [HttpGet]
        [Route("CSVPhotos")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> SaveCSVPhotosAsync()
        {
            await _photoService.CreateCVSAsync().ConfigureAwait(false);
            return Ok();
        }

        [HttpGet]
        [Route("CSVTexts")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> SaveCSVTextsAsync()
        {
            await _textService.CreateCVSAsync().ConfigureAwait(false);
            return Ok();
        }

        [HttpPut]
        [Route("UpdatePhoto")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> UdatePhoto(PhotoModel photo)
        {
            await _photoService.Update(photo).ConfigureAwait(false);
            return Ok();
        }

        [HttpPost]
        [Route("CreateText")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateText(TextModel textModel)
        {
            await _textService.CreateText(textModel).ConfigureAwait(false);
            await _textService.SaveAsync().ConfigureAwait(false);
            return Ok();
        }

        [HttpPut]
        [Route("AddRatingPhoto/{id:guid}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddRatingPhotoAsync([FromRoute] Guid id, int rating)
        {
            await _photoService.AddRaitingPhotoAsync(id, rating).ConfigureAwait(false);
            return Ok();
        }
    }
}