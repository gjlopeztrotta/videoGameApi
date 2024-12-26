namespace videoGameApi.Model
{
    public class VideoGame
    {
        public int VideoGameId { get; set; }
        public string? Title { get; set; }
        public string? Platform { get; set; }
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        
        public VideoGameDetails? VideoGameDetails { get; set; }

        public int? IdVideoGameMercado{  get; set; }

        public VideoGameMercado? Mercado { get; set; }

        public int? IdVideoGameVersion { get; set; }

        public VideoGameVersion? VideoGameVersions { get; set; }  

        public int? VideGameThemeId { get; set; }

       public VideoGameTheme? VideGameThemes { get; set; }

        public int? VideoGameAccesoriesId { get; set; }
        public VideoGameAccesories?   videoGameAccesories { get; set; }

        public List<VideoGameGenero>? videoGameGeneros {  get; set; }    
    }
}
