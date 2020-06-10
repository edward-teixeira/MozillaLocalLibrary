
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MozillaLocalLibrary.Models;

namespace MozillaLocalLibrary.Data
{
    public class BookInstanceConfig : IEntityTypeConfiguration<BookInstance>
    {
        public void Configure(EntityTypeBuilder<BookInstance> builder)
        {
            builder
                .HasKey(it => it.BookInstanceId);

            PropertyTypeConfiguration(builder);

            builder
                .HasOne<Book>(it => it.Book)
                .WithMany(it => it.BookInstances)
                .HasForeignKey(it => it.BookId);

        }

        public void PropertyTypeConfiguration(EntityTypeBuilder<BookInstance> builder)
        {

            builder
                .Property(it => it.DueBack)
                .HasColumnType("datetime");
        }
    }
}
