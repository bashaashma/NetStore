using System.Collections.Generic;

namespace NetStore.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
