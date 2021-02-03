using NetStore.Models;
using System.Collections.Generic;

namespace NetStore.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public string CurrentGenre { get; set; }
    }
}
