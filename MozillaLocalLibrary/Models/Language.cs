using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string Nome { get; set; }
       
        // nav
        public Book Book { get; set; }
        public int BookId { get; set; }

    }
}
