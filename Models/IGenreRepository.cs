using System.Collections.Generic;

namespace NetStore.Models
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> AllGenres { get; }
    }
}
