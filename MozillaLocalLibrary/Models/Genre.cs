namespace MozillaLocalLibrary.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Nome { get; set; }

        // Nav prop
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}