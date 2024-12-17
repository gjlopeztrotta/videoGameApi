using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using videoGameApi.Model.Database;

namespace videoGameApi.Model.Repository
{
    public class VideoGameRepository(VideoGameDbContext context)
    {

        private readonly VideoGameDbContext _context = context;

        public async Task<ActionResult<List<VideoGame>>> RepositoryVideoGames()
        {
            return (await _context.VideoGames.ToListAsync());
        }


    }
}
