using Microsoft.EntityFrameworkCore;
using MozillaLocalLibrary.Data.Seeds;
using MozillaLocalLibrary.Models;

namespace MozillaLocalLibrary.Data
{
    public class LocalLibraryContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookInstance> BookInstances { get; set; }
        public DbSet <Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }

        public LocalLibraryContext(DbContextOptions<LocalLibraryContext> options) :
            base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new BookAuthorConfig());
            modelBuilder.ApplyConfiguration(new BookInstanceConfig());

            modelBuilder.SeedBooks();
        }
    }
}
