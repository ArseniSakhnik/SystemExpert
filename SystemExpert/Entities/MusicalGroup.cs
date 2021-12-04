namespace SystemExpert.Entities
{
    public class MusicalGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}