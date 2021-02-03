using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetStore.Models;

namespace NetStore.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public string CurrentGenre { get; set; }
    }
}
