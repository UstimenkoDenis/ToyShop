using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToyShop.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 25, nullable: false),
                    surname = table.Column<string>(maxLength: 25, nullable: false),
                    adress = table.Column<string>(maxLength: 35, nullable: false),
                    phone = table.Column<string>(maxLength: 20, nullable: false),
                    email = table.Column<string>(maxLength: 25, nullable: false),
                    orderTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderID = table.Column<int>(nullable: false),
                    toyID = table.Column<int>(nullable: false),
                    price = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_orderID",
                        column: x => x.orderID,
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Toy_toyID",
                        column: x => x.toyID,
                        principalTable: "Toy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_orderID",
                table: "OrderDetail",
                column: "orderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_toyID",
                table: "OrderDetail",
                column: "toyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
