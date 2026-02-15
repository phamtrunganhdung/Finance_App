using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinanceApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "icons/food.png", "Chi tiêu ăn uống chính", "Thực phẩm" },
                    { 2, "icons/rent.png", "Chi phí nhà ở", "Tiền thuê nhà" },
                    { 3, "icons/snack.png", "Cá viên, trà sữa...", "Đồ ăn vặt" },
                    { 4, "icons/clothes.png", "Chi phí mua sắm quần áo", "Quần áo" },
                    { 5, "icons/home.png", "Vật dụng trong nhà", "Đồ gia dụng" },
                    { 6, "icons/outside-food.png", "Đi ăn bên ngoài", "Ăn ngoài" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
