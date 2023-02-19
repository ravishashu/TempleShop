using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheShop.Migrations
{
    /// <inheritdoc />
    public partial class ShopingcartItem2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCartItems_Products_ShopItemProductId",
                table: "ShopingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopingCartItems",
                table: "ShopingCartItems");

            migrationBuilder.RenameTable(
                name: "ShopingCartItems",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShopingCartItems_ShopItemProductId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_ShopItemProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Products_ShopItemProductId",
                table: "ShoppingCartItems",
                column: "ShopItemProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Products_ShopItemProductId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "ShopingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_ShopItemProductId",
                table: "ShopingCartItems",
                newName: "IX_ShopingCartItems_ShopItemProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopingCartItems",
                table: "ShopingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCartItems_Products_ShopItemProductId",
                table: "ShopingCartItems",
                column: "ShopItemProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
