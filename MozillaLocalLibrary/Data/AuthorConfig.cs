using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MozillaLocalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.Data
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            PropertyTypeConfig(builder);
        }

        public void PropertyTypeConfig(EntityTypeBuilder<Author> builder)
        {
            builder
                .HasKey(it => it.AuthorId);

            builder
                .Property(it => it.Name)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            builder
                .Property(it => it.DateOfBirth)
                .HasColumnType("datetime");

            builder
               .Property(it => it.DateOfDeath)
               .HasColumnType("datetime");

        }
    }
}
