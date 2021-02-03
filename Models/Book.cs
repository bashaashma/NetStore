using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetStore.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsBookOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
