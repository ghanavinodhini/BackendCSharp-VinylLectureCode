using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LektionVinuylCollection.Migrations
{
    public partial class seed_data_for_vinyls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 19, 6, 28, 576, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 15, 19, 6, 28, 576, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 15, 19, 6, 28, 576, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.InsertData(
                table: "Vinyls",
                columns: new[] { "Id", "ArtistID", "Created", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 12, 15, 19, 6, 28, 578, DateTimeKind.Local).AddTicks(3540), "Title 1" },
                    { 2, 2, new DateTime(2021, 12, 15, 19, 6, 28, 578, DateTimeKind.Local).AddTicks(5200), "Title 2" },
                    { 3, 3, new DateTime(2021, 12, 15, 19, 6, 28, 578, DateTimeKind.Local).AddTicks(5210), "Title 3" },
                    { 4, 3, new DateTime(2021, 12, 15, 19, 6, 28, 578, DateTimeKind.Local).AddTicks(5220), "Title 4" },
                    { 5, 3, new DateTime(2021, 12, 15, 19, 6, 28, 578, DateTimeKind.Local).AddTicks(5220), "Title 5" },
                    { 6, 3, new DateTime(2021, 12, 15, 19, 6, 28, 578, DateTimeKind.Local).AddTicks(5220), "Title 6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 15, 19, 0, 34, 355, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 15, 19, 0, 34, 355, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 15, 19, 0, 34, 355, DateTimeKind.Local).AddTicks(1660));
        }
    }
}
