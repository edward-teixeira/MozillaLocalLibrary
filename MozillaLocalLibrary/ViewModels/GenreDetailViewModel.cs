using MozillaLocalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.ViewModels
{
    public class GenreDetailViewModel
    {
        public int GenreId { get; set; }
        public string  GenreName { get; set; }
        public List<Book> Books { get; set; }
    }
}
