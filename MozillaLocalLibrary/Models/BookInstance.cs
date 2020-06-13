using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.Models
{
    public class BookInstance
    {
        public int BookInstanceId { get; set; }
        public DateTime DueBack { get; set; }
        public LoanStatus Status { get; set; }

        //ef
        public int BookId { get; set; }
        public Book Book { get; set; }

        public string DueBackFormatted() => DueBack.ToString("dd/MM/yyyy");
    }
}
