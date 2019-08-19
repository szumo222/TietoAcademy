using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TietoAcademyDemo.Migrations
{
    public partial class BooksDatabaseCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    isbn = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    publishDate = table.Column<DateTime>(nullable: true),
                    publishPlace = table.Column<string>(nullable: true),
                    numberOfPages = table.Column<int>(nullable: false),
                    subject = table.Column<string>(nullable: true),
                    coverUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.isbn);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
