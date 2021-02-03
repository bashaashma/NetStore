using Microsoft.AspNetCore.Mvc;
using NetStore.Models;
using NetStore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                BooksOfTheWeek = _bookRepository.BooksOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
