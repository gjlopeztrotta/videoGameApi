namespace videoGameApi.Model
{
    public class VideoGameMercado
    {
        public int Id { get; set; }
        public required  string NombreMercado { get; set; }
       
        public int VideoGameId { get; set; }
    }
}
