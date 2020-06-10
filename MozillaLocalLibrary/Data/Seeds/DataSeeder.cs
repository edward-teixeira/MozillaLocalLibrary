using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using MozillaLocalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.Data.Seeds
{
    public static class DataSeeder
    {
        public static void SeedBooks(this ModelBuilder builder)
        {
            Livro1(builder);

        }
        private static void Livro1(this ModelBuilder builder)
        {
            
            
            builder.Entity<BookAuthor>().HasData(new { AuthorId = 1, BookId = 1});
            
            builder.Entity<Book>().HasData(new {
                Title = "Os irmãos Karamázov",
                Summary = "Último romance de Dostoiévski, Os irmãos Karamázov representa uma síntese de toda sua produção e é tido por muitos como sua obra-prima.",
                Imprint = "Editora 34",
                ISBN = "9788573264098",
                BookAuthors = new BookAuthor { AuthorId = 1, BookId = 1 } ,
                BookId = 1
            });

            builder.Entity<Author>().HasData(new {
                Name = "Fiódor Dostoiévski",
                DateOfBirth = new DateTime(1821, 11, 11),
                DateOfDeath = new DateTime(1881, 02, 9),
                AuthorId = 1,
                BookAuthors =  new BookAuthor { AuthorId = 1, BookId = 1  }
            });

            builder.Entity<Language>().HasData(new {

                Nome = "Português-BR",
                LanguageId = 1,
                BookId = 1
            });
            builder.Entity<Genre>().HasData(new
            {
                Nome = "Literatura Estrangeira",
                GenreId = 1,
                BookId = 1
            });
        }
    }
}
