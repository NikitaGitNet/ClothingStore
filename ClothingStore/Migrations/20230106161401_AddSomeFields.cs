using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothingStore.Migrations
{
    /// <inheritdoc />
    public partial class AddSomeFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfSale",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Sales");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleImagePath",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16179e73-8390-432a-8b7c-be073ab6dc12"),
                column: "Count",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80cee191-9b30-4830-9f9f-58cb88057b96"),
                column: "Count",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93a85753-c130-455f-83ec-6a90d3970d72"),
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aef66f8c-f6c5-4f4a-abf2-b31b89c25b51"),
                column: "Count",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6d60425-d2fd-4f8b-8e1b-f7c9def4a7ac"),
                column: "Count",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "TitleImagePath",
                table: "Sales");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfSale",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "Sales",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16179e73-8390-432a-8b7c-be073ab6dc12"),
                column: "Count",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80cee191-9b30-4830-9f9f-58cb88057b96"),
                column: "Count",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93a85753-c130-455f-83ec-6a90d3970d72"),
                column: "Count",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aef66f8c-f6c5-4f4a-abf2-b31b89c25b51"),
                column: "Count",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6d60425-d2fd-4f8b-8e1b-f7c9def4a7ac"),
                column: "Count",
                value: 1);
        }
    }
}
