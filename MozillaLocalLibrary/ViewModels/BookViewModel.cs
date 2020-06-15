using MozillaLocalLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.ViewModels
{
    public class BookViewModel
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "The {0} property shoud have at least {2} chars up to {1}", MinimumLength = 10)]
        public string Title { get; set; }

        [StringLength(800, ErrorMessage = "The {0} property shoud have at least {2} chars up to {1}", MinimumLength = 10)]
        public string Summary { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "The {0} property shoud have at least {2} chars up to {1}", MinimumLength = 10)]
        public string Imprint { get; set; }

        [Required]
        [StringLength(13, ErrorMessage = "The {0} property shoud have at least {1} chars", MinimumLength = 13)]
        public string ISBN { get; set; }

        public Genre genre { get; set; }
        [Required]
        public List<BookAuthor> BookAuthors { get; set; }
        [Required]
        public List<Language> Languages { get; set; }

        // nav prop
        public List<BookInstance> BookInstances { get; set; }
    }
}
