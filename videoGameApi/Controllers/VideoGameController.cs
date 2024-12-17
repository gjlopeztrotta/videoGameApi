using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using videoGameApi.Model;
using videoGameApi.Model.Database;
using videoGameApi.Model.Repository;

namespace videoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController(VideoGameDbContext context) : ControllerBase
    {
        private readonly VideoGameDbContext _context = context;
        
        [HttpGet]
        private async Task<ActionResult<List<VideoGame>>> GetVideoGames()
        {
            return Ok(await _context.VideoGames.ToListAsync());
        }



        [HttpGet("{id}")]
        public IActionResult GetVideoGameById(int id)
        {


            return Ok();

        }

    }
}
