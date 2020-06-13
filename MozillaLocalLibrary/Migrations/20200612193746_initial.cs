using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MozillaLocalLibrary.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateOfDeath = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Imprint = table.Column<string>(maxLength: 60, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.BookId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookInstances",
                columns: table => new
                {
                    BookInstanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DueBack = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookInstances", x => x.BookInstanceId);
                    table.ForeignKey(
                        name: "FK_BookInstances_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_Languages_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "DateOfBirth", "DateOfDeath", "Name" },
                values: new object[] { 1, new DateTime(1821, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1881, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fiódor Dostoiévski" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Nome" },
                values: new object[] { 1, "Literatura Estrangeira" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "GenreId", "ISBN", "Imprint", "Summary", "Title" },
                values: new object[] { 1, 1, "9788573264098", "Editora 34", "Último romance de Dostoiévski, Os irmãos Karamázov representa uma síntese de toda sua produção e é tido por muitos como sua obra-prima.", "Os irmãos Karamázov" });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "BookId", "AuthorId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "BookId", "Nome" },
                values: new object[] { 1, 1, "Português-BR" });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookInstances_BookId",
                table: "BookInstances",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_BookId",
                table: "Languages",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BookInstances");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
