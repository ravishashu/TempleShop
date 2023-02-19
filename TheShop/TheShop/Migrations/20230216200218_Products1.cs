using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheShop.Migrations
{
    /// <inheritdoc />
    public partial class Products1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopItems_Categories_CategoryId",
                table: "ShopItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopItems",
                table: "ShopItems");

            migrationBuilder.RenameTable(
                name: "ShopItems",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItems_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "ShopItems");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "ShopItems",
                newName: "IX_ShopItems_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopItems",
                table: "ShopItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItems_Categories_CategoryId",
                table: "ShopItems",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
