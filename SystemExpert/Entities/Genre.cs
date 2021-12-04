using System.Collections.Generic;

namespace SystemExpert.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        
        public string Name { get; set; }//проверка
        
        public List<Genre> ChildGenres { get; set; }
        public int? ParentGenreId { get; set; }
        public Genre ParentGenre { get; set; }
        
        public List<MusicalGroup> Groups { get; set; }
    }
}