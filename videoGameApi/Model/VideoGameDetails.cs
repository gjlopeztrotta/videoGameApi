namespace videoGameApi.Model
{
    public class VideoGameDetails
    {
        public int Id { get; set; } 
        public string Description { get; set; }
        public DateTime RealeseDate { get; set; }

        public int VideoGameId { get; set; }
    }
}
