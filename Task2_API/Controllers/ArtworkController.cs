using Microsoft.AspNetCore.Mvc;
using Task2_API.Core.DTO;
using Task2_API.Data.Models;
using Task2_API.Service.Services.Artwork;

namespace Task2_API.Controllers
{

    public class ArtworkController : BaseController
    {
        private IArtworkService _artworkService;
        public ArtworkController(IArtworkService artworkService)
        {
            _artworkService = artworkService;
        }

        [HttpGet]
        // GET: ArtworkController

        public IActionResult Index()
        {
            var artworks = _artworkService.Index();
            return Ok(GetRespons(artworks));
        }
        [HttpGet]
        // GET: ArtworkController/Details/5

        public IActionResult Details(int id)
        {
            var artwork = _artworkService.Details(id);
            return Ok(GetRespons(artwork));
        }
        [HttpPost]
        // POST: ArtworkController/Create

        public IActionResult Create([FromBody] CreateArtworkDTO dTO)
        {
            _artworkService.Create(dTO);
            return Ok(GetRespons());
        }
        [HttpPut]
        // Put: ArtworkController/Update

        public IActionResult Update([FromBody] UpdateArtworkDTO dTO)
        {
            _artworkService.Update(dTO);
            return Ok(GetRespons());
        }
        // Delete: ArtworkController/Delete/5

        public IActionResult Delete(int id)
        {
            _artworkService.Delete(id);
            return Ok(GetRespons());
        }

    }
}
