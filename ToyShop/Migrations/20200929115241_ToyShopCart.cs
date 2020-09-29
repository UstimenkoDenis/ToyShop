using Microsoft.EntityFrameworkCore.Migrations;

namespace ToyShop.Migrations
{
    public partial class ToyShopCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToyShopCartItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    toyid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    ToyShopCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToyShopCartItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_ToyShopCartItem_Toy_toyid",
                        column: x => x.toyid,
                        principalTable: "Toy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToyShopCartItem_toyid",
                table: "ToyShopCartItem",
                column: "toyid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToyShopCartItem");
        }
    }
}
