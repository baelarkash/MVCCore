using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCore.Migrations
{
    public partial class cardSetFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cardSetId",
                table: "Cards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_cardSetId",
                table: "Cards",
                column: "cardSetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardSets_cardSetId",
                table: "Cards",
                column: "cardSetId",
                principalTable: "CardSets",
                principalColumn: "CardSetId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardSets_cardSetId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_cardSetId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "cardSetId",
                table: "Cards");
        }
    }
}
