using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCore.Migrations
{
    public partial class cardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Languages",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "CardTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "setId",
                table: "CardSets",
                newName: "SetId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "CardReferenceTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "CardColours",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attack = table.Column<int>(nullable: false),
                    Armor = table.Column<int>(nullable: false),
                    HitPoints = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Languages",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CardTypes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "SetId",
                table: "CardSets",
                newName: "setId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CardReferenceTypes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CardColours",
                newName: "name");
        }
    }
}
