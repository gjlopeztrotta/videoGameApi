using System.Text.Json.Serialization;

namespace videoGameApi.Model
{
    public class VideoGameGenero
    {
        public int VideoGameGeneroId { get; set; }
        public required string name { get; set; }

        [JsonIgnore]
        public List<VideoGame>? VideoGames{ get; set; }

    }
}
