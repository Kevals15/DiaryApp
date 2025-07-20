using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class insertDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { 1, "Hello Dummy content 1", new DateTime(2025, 7, 20, 15, 22, 30, 0, DateTimeKind.Unspecified), "Dummy title 1" },
                    { 2, "Hello Dummy content 2", new DateTime(2025, 7, 20, 15, 23, 30, 0, DateTimeKind.Unspecified), "Dummy title 2" },
                    { 3, "Hello Dummy Content 3", new DateTime(2025, 7, 20, 15, 24, 30, 0, DateTimeKind.Unspecified), "Dummy title 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
