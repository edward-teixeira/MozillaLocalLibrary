using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MozillaLocalLibrary.Models;

namespace MozillaLocalLibrary.Data
{
    public class BookAuthorConfig : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder
                .HasKey(it => new { it.BookId, it.AuthorId });

            builder
                .HasOne<Book>(it => it.Book)
                .WithMany(it => it.BookAuthors)
                .HasForeignKey(it => it.BookId);

            builder
                .HasOne<Author>(it => it.Author)
                .WithMany(it => it.BookAuthors)
                .HasForeignKey(it => it.AuthorId);

        }
    }
}
