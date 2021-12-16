using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LektionVinuylCollection.Migrations
{
    public partial class seed_data_for_artists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Created", "FavoriteCar", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 15, 19, 0, 34, 355, DateTimeKind.Local).AddTicks(390), "Benz", "Artist 1" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Created", "FavoriteCar", "Name" },
                values: new object[] { 2, new DateTime(2021, 12, 15, 19, 0, 34, 355, DateTimeKind.Local).AddTicks(1650), "Volvo", "Artist 2" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Created", "FavoriteCar", "Name" },
                values: new object[] { 3, new DateTime(2021, 12, 15, 19, 0, 34, 355, DateTimeKind.Local).AddTicks(1660), "Volkswagen", "Artist 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
