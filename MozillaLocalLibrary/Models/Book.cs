using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Imprint { get; set; }
        public string ISBN { get; set; }

        // Ef Relations
        public List<Genre> Genres { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        public List<Language> Languages { get; set; }

        // nav prop
        public List<BookInstance> BookInstances { get; set; }
    }
}
