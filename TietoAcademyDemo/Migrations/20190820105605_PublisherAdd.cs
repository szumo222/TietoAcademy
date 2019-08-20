using Microsoft.EntityFrameworkCore.Migrations;

namespace TietoAcademyDemo.Migrations
{
    public partial class PublisherAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "publisher",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "publisher",
                table: "Books");
        }
    }
}
