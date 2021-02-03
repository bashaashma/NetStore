using Microsoft.AspNetCore.Mvc;
using NetStore.Models;
using System.Linq;

namespace NetStore.Components
{
    public class GenreMenu : ViewComponent
    {
        private readonly IGenreRepository _genreRepository;
        public GenreMenu(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public IViewComponentResult Invoke()
        {
            var genres = _genreRepository.AllGenres.OrderBy(c => c.GenreName);
            return View(genres);
        }
    }
}
