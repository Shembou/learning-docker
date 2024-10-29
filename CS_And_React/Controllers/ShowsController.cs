using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Site_Api.DbContexts;
using Site_Api.Entities;
using Site_Api.Models;
using Site_Api.Services;
namespace Site_Api.Controllers
{
    [ApiController]
    [Route("api/shows")]
    public class ShowsController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly ShowsRepository _showsRepository;

        public ShowsController(ApplicationDbContext context, ShowsRepository showsRepository)
        {
            _context = context;
            _showsRepository = showsRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IList<Show>>> GetShows([FromQuery] string? type, [FromQuery] string? searchQuery)
        {
            var result = await _showsRepository.GetShows(type, searchQuery);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{showId}")]
        public async Task<ActionResult<IList<Show>>> GetShow(int showId)
        {
            var result = await _showsRepository.GetShow(showId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<Show>> AddShow([FromBody] MinifiedShow show)
        {
            var result = await _showsRepository.AddShow(show);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPut("{showId}")]
        public async Task<ActionResult<Show>> UpdateShow(int showId, [FromBody] MinifiedShow show)
        {
            var result = await _showsRepository.UpdateShow(showId, show);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPatch("{showId}")]
        public async Task<ActionResult<Show>> PartiallyUpdateShow(int showId, [FromBody] JsonPatchDocument<Show> patchDocument)
        {
            if (!(await _showsRepository.DoesShowExist(showId)))
            {
                return NotFound();
            }
            var result = await _showsRepository.PartiallyUpdateShow(showId, patchDocument, ModelState);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpDelete("{showId}")]
        public async Task<ActionResult<Show?>> DeleteShow(int showId)
        {
            var result = await _showsRepository.DeleteShow(showId);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(showId);
        }
    }
}
