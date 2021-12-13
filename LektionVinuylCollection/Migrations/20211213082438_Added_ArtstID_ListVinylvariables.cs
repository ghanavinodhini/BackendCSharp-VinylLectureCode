using Microsoft.EntityFrameworkCore.Migrations;

namespace LektionVinuylCollection.Migrations
{
    public partial class Added_ArtstID_ListVinylvariables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Artist",
                table: "Vinyls",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ArtistID",
                table: "Vinyls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vinyls_ArtistID",
                table: "Vinyls",
                column: "ArtistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_Artists_ArtistID",
                table: "Vinyls",
                column: "ArtistID",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vinyls_Artists_ArtistID",
                table: "Vinyls");

            migrationBuilder.DropIndex(
                name: "IX_Vinyls_ArtistID",
                table: "Vinyls");

            migrationBuilder.DropColumn(
                name: "ArtistID",
                table: "Vinyls");

            migrationBuilder.AlterColumn<string>(
                name: "Artist",
                table: "Vinyls",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
