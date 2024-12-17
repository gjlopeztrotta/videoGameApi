using Microsoft.EntityFrameworkCore;

namespace videoGameApi.Model.Database
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : DbContext(options)
    {
        public DbSet<VideoGame> VideoGames =>Set<VideoGame>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame { VideoGameId = 1, Title = "new", Platform = "OS", Developer = "9", Publisher = "Male" },
                new VideoGame { VideoGameId = 2, Title = "old", Platform = "WIN", Developer = "19", Publisher = "Male" },
                new VideoGame { VideoGameId = 3, Title = "teen", Platform = "LIN", Developer = "29", Publisher = "Male" },
                new VideoGame { VideoGameId = 4, Title = "child", Platform = "APP", Developer = "88", Publisher = "Male" }
                );
        }

    }
}
