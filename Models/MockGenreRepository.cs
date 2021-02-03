using System.Collections.Generic;

namespace NetStore.Models
{
    public class MockGenreRepository : IGenreRepository
    {
        public IEnumerable<Genre> AllGenres =>
            new List<Genre>
            {
                new Genre{GenreId=1, GenreName="Fantasy", Description="Books of of speculative fiction set in a fictional universe, often inspired by real world myth and folklore"},
                new Genre{GenreId=2, GenreName="Science Ficton", Description="Books of speculative fiction that typically deals with imaginative and futuristic concepts such as advanced science and technology, space exploration, time travel, parallel universes, and extraterrestrial life"},
                new Genre{GenreId=3, GenreName="Romance", Description="Books that place its primary focus on the relationship and romantic love between two people"}
            };
    }
}
