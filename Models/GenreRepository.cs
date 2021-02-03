﻿using System.Collections.Generic;

namespace NetStore.Models
{
    public class GenreRepository : IGenreRepository
    {
        private readonly AppDbContext _appDbContext;

        public GenreRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Genre> AllGenres => _appDbContext.Genres;

    }
}
