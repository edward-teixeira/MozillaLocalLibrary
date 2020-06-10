using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MozillaLocalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.Data
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            PropertyTypeConfiguration(builder);

            builder
               .HasKey(it => it.BookId);

            builder
                .HasMany(it => it.Genres)
                .WithOne(it => it.Book)
                .IsRequired();

            builder.
                HasMany<Language>(it => it.Languages)
                .WithOne(it => it.Book);

            builder
                .HasMany(it => it.BookInstances)
                .WithOne(it => it.Book);
        }

        public void PropertyTypeConfiguration(EntityTypeBuilder<Book> builder)
        {

            builder.Property(it => it.Title)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            builder.Property(it => it.Summary)
               .HasColumnType("nvarchar(800)")
               .IsRequired();

            builder.Property(it => it.Title)
               .HasColumnType("nvarchar(60)")
               .IsRequired();

            builder.Property(it => it.ISBN)
               .HasColumnType("nvarchar(13)")
               .IsRequired();
        }
    }
}
