using NetStore.Models;
using System.Collections.Generic;

namespace NetStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> BooksOfTheWeek { get; set; }
    }
}
