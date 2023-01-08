using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClothingStore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClothingTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tariff = table.Column<float>(type: "real", nullable: false),
                    DateOfEmployment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnlineOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    DateOfSale = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChestCircumference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaistCircumference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HipCircumference = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClothingTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClothingTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnlineOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ClothingTypes_ClothingTypeId",
                        column: x => x.ClothingTypeId,
                        principalTable: "ClothingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_OnlineOrders_OnlineOrderId",
                        column: x => x.OnlineOrderId,
                        principalTable: "OnlineOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "ManufacturerCountry", "Name", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("457966e8-26e4-489b-978a-f903a07d3533"), "France", "Lacoste", "Brands/4.jpg" },
                    { new Guid("4d89fc13-6268-464f-8ecf-57acc7427b64"), "Italy", "Stone Island", "Brands/5.png" },
                    { new Guid("7efc9710-ed9f-460c-b29f-617a4a784269"), "USA", "Ralph Lauren", "Brands/3.png" },
                    { new Guid("e3927a70-e055-4e6c-a4fa-e10308a78a7d"), "USA", "Nike", "Brands/2.png" },
                    { new Guid("f0e9fd9d-67fe-4f99-ace4-7b403c57ab46"), "Germany", "Adidas", "Brands/3.png" }
                });

            migrationBuilder.InsertData(
                table: "ClothingTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("301b068b-c740-4f8e-93c9-5f08885dcbe8"), "Jacket" },
                    { new Guid("5b748d2f-e012-4150-b163-ad49a9b4c030"), "Shirt" },
                    { new Guid("726eb9ac-be00-4e75-b328-d732d433d432"), "Pants" },
                    { new Guid("a8080577-5efb-4339-867a-8ba2129ae766"), "Sweater" },
                    { new Guid("da3a3156-3593-4f37-a89d-293e126915c6"), "Blouse" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "ChestCircumference", "HipCircumference", "Name", "WaistCircumference" },
                values: new object[,]
                {
                    { new Guid("152d81c0-363c-4f6c-9a17-5a4edd969fd6"), "84-88", "82-86", "44 (XS)", "74-78" },
                    { new Guid("6650614b-a9ca-4d75-9407-1aa69a826ec1"), "108-114", "104-110", "52 (XL)", "97-102" },
                    { new Guid("6b4b71e1-ca7f-463e-ac67-16d32e00b0a7"), "88-96", "86-92", "46 (S)", "76-84" },
                    { new Guid("74923a8e-621d-4d5a-8980-5985a3983d31"), "102-108", "98-104", "50 (L)", "88-96" },
                    { new Guid("e3437214-5c5c-411b-84ca-9015f4804e74"), "114-120", "110-116", "54 (XXL)", "100-108" },
                    { new Guid("eecfb6cb-4f7f-4ca8-9dbc-ad18a0fbc7ff"), "96-102", "92-98", "48 (M)", "82-90" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "BrandName", "ClothingTypeId", "ClothingTypeName", "Count", "Name", "OnlineOrderId", "Price", "SizeId", "SizeName", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("16179e73-8390-432a-8b7c-be073ab6dc12"), new Guid("e3927a70-e055-4e6c-a4fa-e10308a78a7d"), "Nike", new Guid("da3a3156-3593-4f37-a89d-293e126915c6"), "Blouse", 7, "Кофта мужская", null, 4470f, new Guid("6650614b-a9ca-4d75-9407-1aa69a826ec1"), "52 (XL)", "Products/Nike/Blouse/4.jpeg" },
                    { new Guid("80cee191-9b30-4830-9f9f-58cb88057b96"), new Guid("457966e8-26e4-489b-978a-f903a07d3533"), "Lacoste", new Guid("726eb9ac-be00-4e75-b328-d732d433d432"), "Pants", 5, "Мужские брюки Sport Fleece Tennis", null, 12690f, new Guid("6650614b-a9ca-4d75-9407-1aa69a826ec1"), "52 (XL)", "Products/Lacoste/Pants/3.jpg" },
                    { new Guid("93a85753-c130-455f-83ec-6a90d3970d72"), new Guid("4d89fc13-6268-464f-8ecf-57acc7427b64"), "Stone Island", new Guid("301b068b-c740-4f8e-93c9-5f08885dcbe8"), "Jacket", 3, "Куртка", null, 30000f, new Guid("eecfb6cb-4f7f-4ca8-9dbc-ad18a0fbc7ff"), "48 (M)", "Products/Stone Island/Jacket/2.jpg" },
                    { new Guid("aef66f8c-f6c5-4f4a-abf2-b31b89c25b51"), new Guid("7efc9710-ed9f-460c-b29f-617a4a784269"), "Ralph Lauren", new Guid("5b748d2f-e012-4150-b163-ad49a9b4c030"), "Shirt", 5, "Хлопковая сорочка", null, 29100f, new Guid("74923a8e-621d-4d5a-8980-5985a3983d31"), "50 (L)", "Products/Ralph Lauren/Shirt/1.jpg" },
                    { new Guid("d6d60425-d2fd-4f8b-8e1b-f7c9def4a7ac"), new Guid("f0e9fd9d-67fe-4f99-ace4-7b403c57ab46"), "Adidas", new Guid("a8080577-5efb-4339-867a-8ba2129ae766"), "Sweater", 1, "Cвитер Adicolor Classics Beckenbauer Primeblue", null, 7690f, new Guid("e3437214-5c5c-411b-84ca-9015f4804e74"), "54 (XXL)", "Products/Adidas/Sweater/5.jpeg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ClothingTypeId",
                table: "Products",
                column: "ClothingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OnlineOrderId",
                table: "Products",
                column: "OnlineOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ClothingTypes");

            migrationBuilder.DropTable(
                name: "OnlineOrders");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
