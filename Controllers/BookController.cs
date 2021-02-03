using Microsoft.AspNetCore.Mvc;
using NetStore.Models;
using NetStore.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace NetStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IGenreRepository _genreRepository;

        public BookController(IBookRepository bookRepository, IGenreRepository genreRepository)
        {
            _bookRepository = bookRepository;
            _genreRepository = genreRepository;
        }

        public ViewResult List(string genre)
        {
            IEnumerable<Book> books;
            string currentGenre;

            if (string.IsNullOrEmpty(genre))
            {
                books = _bookRepository.AllBooks.OrderBy(p => p.BookId);
                currentGenre = "All books";
            }
            else
            {
                books = _bookRepository.AllBooks.Where(p => p.Genre.GenreName == genre)
                    .OrderBy(p => p.BookId);
                currentGenre = _genreRepository.AllGenres.FirstOrDefault(c => c.GenreName == genre)?.GenreName;
            }

            return View(new BooksListViewModel
            {
                Books = books,
                CurrentGenre = currentGenre
            });
        }

        public IActionResult Details(int id)
        {
            var book = _bookRepository.GetBookById(id);
            if (book == null)
                return NotFound();

            return View(book);
        }
    }
}
