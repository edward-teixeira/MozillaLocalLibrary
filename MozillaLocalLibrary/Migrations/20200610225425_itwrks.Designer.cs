﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MozillaLocalLibrary.Data;

namespace MozillaLocalLibrary.Migrations
{
    [DbContext(typeof(LocalLibraryContext))]
    [Migration("20200610225425_itwrks")]
    partial class itwrks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MozillaLocalLibrary.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOfDeath")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new { AuthorId = 1, DateOfBirth = new DateTime(1821, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), DateOfDeath = new DateTime(1881, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Fiódor Dostoiévski" }
                    );
                });

            modelBuilder.Entity("MozillaLocalLibrary.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Imprint");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new { BookId = 1, ISBN = "9788573264098", Imprint = "Editora 34", Summary = "Último romance de Dostoiévski, Os irmãos Karamázov representa uma síntese de toda sua produção e é tido por muitos como sua obra-prima.", Title = "Os irmãos Karamázov" }
                    );
                });

            modelBuilder.Entity("MozillaLocalLibrary.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("AuthorId");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthors");

                    b.HasData(
                        new { BookId = 1, AuthorId = 1 }
                    );
                });

            modelBuilder.Entity("MozillaLocalLibrary.Models.BookInstance", b =>
                {
                    b.Property<int>("BookInstanceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<DateTime>("DueBack")
                        .HasColumnType("datetime");

                    b.Property<int>("Status");

                    b.HasKey("BookInstanceId");

                    b.HasIndex("BookId");

                    b.ToTable("BookInstances");
                });

            modelBuilder.Entity("MozillaLocalLibrary.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<string>("Nome");

                    b.HasKey("GenreId");

                    b.HasIndex("BookId");

                    b.ToTable("Genres");

                    b.HasData(
                        new { GenreId = 1, BookId = 1, Nome = "Literatura Estrangeira" }
                    );
                });

            modelBuilder.Entity("MozillaLocalLibrary.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<string>("Nome");

                    b.HasKey("LanguageId");

                    b.HasIndex("BookId");

                    b.ToTable("Languages");

                    b.HasData(
                        new { LanguageId = 1, BookId = 1, Nome = "Português-BR" }
                    );
                });

            modelBuilder.Entity("MozillaLocalLibrary.Models.BookAuthor", b =>
                {
                    b.HasOne("MozillaLocalLibrary.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MozillaLocalLibrary.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MozillaLocalLibrary.Models.BookInstance", b =>
                {
                    b.HasOne("MozillaLocalLibrary.Models.Book", "Book")
                        .WithMany("BookInstances")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MozillaLocalLibrary.Models.Genre", b =>
                {
                    b.HasOne("MozillaLocalLibrary.Models.Book", "Book")
                        .WithMany("Genres")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MozillaLocalLibrary.Models.Language", b =>
                {
                    b.HasOne("MozillaLocalLibrary.Models.Book", "Book")
                        .WithMany("Languages")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
