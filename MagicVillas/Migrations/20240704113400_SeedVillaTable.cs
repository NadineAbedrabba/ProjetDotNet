using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillas.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 4, 13, 33, 59, 860, DateTimeKind.Local).AddTicks(1143), "This is the royal villa", "http://via.placeholder.com/400x300.png?text=Royal+Villa", "Royal villa", 0, 100000, 4.5, 400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 7, 4, 13, 33, 59, 860, DateTimeKind.Local).AddTicks(1192), "A beautiful villa with an ocean view", "http://via.placeholder.com/400x300.png?text=Ocean+View+Villa", "Ocean View Villa", 0, 150000, 4.7999999999999998, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 7, 4, 13, 33, 59, 860, DateTimeKind.Local).AddTicks(1195), "A serene villa in the mountains", "http://via.placeholder.com/400x300.png?text=Mountain+Retreat+Villa", "Mountain Retreat Villa", 0, 200000, 4.7000000000000002, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 7, 4, 13, 33, 59, 860, DateTimeKind.Local).AddTicks(1198), "A modern villa in the city center", "http://via.placeholder.com/400x300.png?text=City+Lights+Villa", "City Lights Villa", 0, 120000, 4.5999999999999996, 450, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 7, 4, 13, 33, 59, 860, DateTimeKind.Local).AddTicks(1202), "A charming villa in the countryside", "http://via.placeholder.com/400x300.png?text=Countryside+Villa", "Countryside Villa", 0, 110000, 4.9000000000000004, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
