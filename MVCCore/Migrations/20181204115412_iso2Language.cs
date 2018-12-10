using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCore.Migrations
{
    public partial class iso2Language : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "iso2",
                table: "Languages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iso2",
                table: "Languages");
        }
    }
}
