using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_SHOP.Migrations
{
    public partial class changemodeladdanotherentites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InfoProduct_Products_ProductId",
                table: "InfoProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_InfoProduct_WareHouse_WareHouseId",
                table: "InfoProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WareHouse",
                table: "WareHouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InfoProduct",
                table: "InfoProduct");

            migrationBuilder.RenameTable(
                name: "WareHouse",
                newName: "WareHouses");

            migrationBuilder.RenameTable(
                name: "InfoProduct",
                newName: "InfoProducts");

            migrationBuilder.RenameIndex(
                name: "IX_InfoProduct_WareHouseId",
                table: "InfoProducts",
                newName: "IX_InfoProducts_WareHouseId");

            migrationBuilder.RenameIndex(
                name: "IX_InfoProduct_ProductId",
                table: "InfoProducts",
                newName: "IX_InfoProducts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WareHouses",
                table: "WareHouses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InfoProducts",
                table: "InfoProducts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingBaskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Finished = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingBaskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingBaskets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfoBoughtProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ShoppingBasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoBoughtProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfoBoughtProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfoBoughtProducts_ShoppingBaskets_ShoppingBasketId",
                        column: x => x.ShoppingBasketId,
                        principalTable: "ShoppingBaskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InfoBoughtProducts_ProductId",
                table: "InfoBoughtProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoBoughtProducts_ShoppingBasketId",
                table: "InfoBoughtProducts",
                column: "ShoppingBasketId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBaskets_UserId",
                table: "ShoppingBaskets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_InfoProducts_Products_ProductId",
                table: "InfoProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfoProducts_WareHouses_WareHouseId",
                table: "InfoProducts",
                column: "WareHouseId",
                principalTable: "WareHouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InfoProducts_Products_ProductId",
                table: "InfoProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_InfoProducts_WareHouses_WareHouseId",
                table: "InfoProducts");

            migrationBuilder.DropTable(
                name: "InfoBoughtProducts");

            migrationBuilder.DropTable(
                name: "ShoppingBaskets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WareHouses",
                table: "WareHouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InfoProducts",
                table: "InfoProducts");

            migrationBuilder.RenameTable(
                name: "WareHouses",
                newName: "WareHouse");

            migrationBuilder.RenameTable(
                name: "InfoProducts",
                newName: "InfoProduct");

            migrationBuilder.RenameIndex(
                name: "IX_InfoProducts_WareHouseId",
                table: "InfoProduct",
                newName: "IX_InfoProduct_WareHouseId");

            migrationBuilder.RenameIndex(
                name: "IX_InfoProducts_ProductId",
                table: "InfoProduct",
                newName: "IX_InfoProduct_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WareHouse",
                table: "WareHouse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InfoProduct",
                table: "InfoProduct",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InfoProduct_Products_ProductId",
                table: "InfoProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfoProduct_WareHouse_WareHouseId",
                table: "InfoProduct",
                column: "WareHouseId",
                principalTable: "WareHouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
