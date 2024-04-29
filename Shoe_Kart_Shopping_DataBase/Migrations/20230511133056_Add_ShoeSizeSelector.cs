using Microsoft.EntityFrameworkCore.Migrations;

namespace Shoe_Kart_Shopping_DataAccess.Migrations
{
    public partial class Add_ShoeSizeSelector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "ShoeSizeId",
            //    table: "Products",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ShoeSizeSelectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoeSizeSelectors", x => x.Id);
                });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Products_ShoeSizeId",
            //    table: "Products",
            //    column: "ShoeSizeId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Products_ShoeSizes_ShoeSizeId",
            //    table: "Products",
            //    column: "ShoeSizeId",
            //    principalTable: "ShoeSizes",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ShoeSizes_ShoeSizeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ShoeSizeSelectors");

            migrationBuilder.DropIndex(
                name: "IX_Products_ShoeSizeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShoeSizeId",
                table: "Products");
        }
    }
}
