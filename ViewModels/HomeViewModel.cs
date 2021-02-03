using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetStore.Models;

namespace NetStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> BooksOfTheWeek { get; set; }
    }
}
