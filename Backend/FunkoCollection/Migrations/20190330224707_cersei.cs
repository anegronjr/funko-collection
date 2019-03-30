using Microsoft.EntityFrameworkCore.Migrations;

namespace FunkoCollection.Migrations
{
    public partial class cersei : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Funkos",
                keyColumn: "FunkoId",
                keyValue: 7,
                column: "Image",
                value: "/images/cersei.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Funkos",
                keyColumn: "FunkoId",
                keyValue: 7,
                column: "Image",
                value: "/images/naruto.jpeg");
        }
    }
}
