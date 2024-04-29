using Microsoft.EntityFrameworkCore.Migrations;

namespace Shoe_Kart_Shopping_DataAccess.Migrations
{
    public partial class AddSizeTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "ShoppingCarts");
        }
    }
}
