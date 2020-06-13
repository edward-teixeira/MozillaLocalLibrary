using System.Collections.Generic;

namespace MozillaLocalLibrary.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Nome { get; set; }

        // Nav prop
        public List<Book> Books { get; set; }
    }
}