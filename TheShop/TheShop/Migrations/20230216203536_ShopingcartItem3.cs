using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheShop.Migrations
{
    /// <inheritdoc />
    public partial class ShopingcartItem3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Products_ShopItemProductId",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "ShopItemProductId",
                table: "ShoppingCartItems",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_ShopItemProductId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductId",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ShoppingCartItems",
                newName: "ShopItemProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_ShopItemProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Products_ShopItemProductId",
                table: "ShoppingCartItems",
                column: "ShopItemProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
