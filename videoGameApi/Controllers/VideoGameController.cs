﻿using Microsoft.AspNetCore.Http;
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
        public async Task<ActionResult<List<VideoGame>>> GetVideoGames()
        {
            return Ok(await _context.VideoGames.Include(g => g.VideoGameDetails).ToListAsync());
        }
        
        

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetVideoGameById(int id)
        {
            var game = await _context.VideoGames.Include(g => g.VideoGameDetails).FirstOrDefaultAsync(x =>x.VideoGameId ==id);
            //var game= await _context.VideoGames.FindAsync(id);
            if (game==null)
                return NotFound();
            return Ok(game);

        }

        [HttpPost]
        public async Task<ActionResult<VideoGame>> addVideoGame(VideoGame newGame)
        {
            if (newGame == null)
            {
                return BadRequest();
            }
            _context.VideoGames.Add(newGame);
            await _context.SaveChangesAsync();

            return  CreatedAtAction(nameof(GetVideoGameById),new {id=newGame.VideoGameId }, newGame);

           // [HttpPut]

        }

    }
}
