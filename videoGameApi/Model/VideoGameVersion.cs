using Microsoft.AspNetCore.Identity;

namespace videoGameApi.Model
{
    public class VideoGameVersion
    {
       public int Id { get; set; }
       public required string Version { get; set; }

       public int VideoGameId { get; set; }
    }
}
