using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheShop.Migrations
{
    /// <inheritdoc />
    public partial class ShopingcartItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopingCartItems",
                columns: table => new
                {
                    ShopingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopItemProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopingCartItems", x => x.ShopingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShopingCartItems_Products_ShopItemProductId",
                        column: x => x.ShopItemProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopingCartItems_ShopItemProductId",
                table: "ShopingCartItems",
                column: "ShopItemProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopingCartItems");
        }
    }
}
