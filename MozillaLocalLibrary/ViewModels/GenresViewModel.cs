using MozillaLocalLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.ViewModels
{
    public class GenresViewModel
    {
        [Required]
        [StringLength(60, ErrorMessage = "The {0} property shoud have {0} max characters")]
        public string Nome { get; set; }

        // Nav prop
        public Book  Book { get; set; }
    }
}
