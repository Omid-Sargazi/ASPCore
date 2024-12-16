using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "ContactEmail", "Name" },
                values: new object[,]
                {
                    { 1, "tech@supplies.com", "Tech Supplies" },
                    { 2, "essentials@home.com", "Home Essentials" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "SupplierId" },
                values: new object[,]
                {
                    { 1, "Laptop", 1200m, 1 },
                    { 2, "Vacuum Cleaner", 300m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewerName" },
                values: new object[,]
                {
                    { 1, "Great product!", 1, 5, "John" },
                    { 2, "Works well!", 2, 4, "Jane" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
