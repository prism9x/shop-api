using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prism.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, "Danh mục tất cả các loại giường", true, "Giường" },
                    { 2, "Danh mục tất cả các loại tủ", true, "Tủ" },
                    { 3, "Danh mục tất cả các loại sập", true, "Sập" },
                    { 4, "Danh mục tất cả các loại ban thờ", true, "Ban Thờ" },
                    { 5, "Danh mục tất cả các loại vòng tay", true, "Vòng tay" },
                    { 6, "Danh mục tất cả các loại tượng gỗ", true, "Tượng gỗ" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsActive", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2001), "Sập trơn", true, "Sập trơn", 30000000.0, 10 },
                    { 2, 3, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2018), "Sập ngũ phúc", true, "Sập ngũ phúc", 32000000.0, 5 },
                    { 3, 3, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2020), "Sập ba bông", true, "Sập ba bông", 33500000.0, 3 },
                    { 4, 2, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2022), "Tủ 3 buồng 4 cánh", true, "Tủ 3 buồng 4 cánh", 22300000.0, 5 },
                    { 5, 2, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2024), "Tủ 2 buồng", true, "Tủ 2 buồng", 17500000.0, 2 },
                    { 6, 2, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2025), "Tủ chè cánh cong", true, "Tủ chè cánh cong", 16499000.0, 5 },
                    { 7, 2, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2027), "Tủ chè cánh thẳng", true, "Tủ chè cánh thẳng", 15499000.0, 6 },
                    { 8, 2, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2028), "Tủ chè khảm trai", true, "Tủ chè khảm trai", 55500000.0, 2 },
                    { 9, 5, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2030), "Vòng tay trầm", true, "Vòng tay trầm", 3500000.0, 50 },
                    { 10, 5, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2033), "Vòng tay sưa đỏ", true, "Vòng tay sưa đỏ", 1200000.0, 25 },
                    { 11, 6, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2034), "Tượng gỗ quan vũ", true, "Tượng gỗ quan vũ", 5600000.0, 8 },
                    { 12, 6, new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2036), "Tượng tam đa", true, "Tượng tam đa", 12999000.0, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
