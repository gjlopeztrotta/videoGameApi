namespace videoGameApi.Model
{
    public class VideoGameTheme
    {
        public int VideoGameThemeId { get; set; }
        public required string VideoGameThemeName { get; set; }

        public int VideoGameId { get; set; }
    }
}
