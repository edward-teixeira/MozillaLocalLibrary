using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MozillaLocalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.Data
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            PropertyTypeConfiguration(builder);
        }

        public void PropertyTypeConfiguration(EntityTypeBuilder<Genre> builder)
        {
            builder
                .HasKey(it => it.BookId);

            builder
                .Property(it => it.Nome)
                .HasColumnType("nvarchar(100)");


        }
    }
}
