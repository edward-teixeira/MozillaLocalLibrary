using System;
using System.Collections;
using System.Collections.Generic;

namespace MozillaLocalLibrary.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }

        // EF Relations
        public List<BookAuthor> BookAuthors { get; set; }
    }
}