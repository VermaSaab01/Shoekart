using Microsoft.EntityFrameworkCore.Migrations;

namespace Shoe_Kart_Shopping_DataAccess.Migrations
{
    public partial class Add_columnSelector_To_ShopCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShoeSizeSelectorId",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ShoeSizeSelectorId",
                table: "ShoppingCarts",
                column: "ShoeSizeSelectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_ShoeSizeSelectors_ShoeSizeSelectorId",
                table: "ShoppingCarts",
                column: "ShoeSizeSelectorId",
                principalTable: "ShoeSizeSelectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_ShoeSizeSelectors_ShoeSizeSelectorId",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_ShoeSizeSelectorId",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "ShoeSizeSelectorId",
                table: "ShoppingCarts");
        }
    }
}
