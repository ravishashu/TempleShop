using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheShop.Migrations
{
    /// <inheritdoc />
    public partial class ShopingcartItem1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopingCartItemId",
                table: "ShopingCartItems",
                newName: "ShoppingCartItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingCartItemId",
                table: "ShopingCartItems",
                newName: "ShopingCartItemId");
        }
    }
}
