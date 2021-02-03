using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetStore.Models;
using Microsoft.AspNetCore.Mvc;

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
