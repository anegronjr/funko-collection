using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FunkoCollection.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Funkos",
                columns: table => new
                {
                    FunkoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funkos", x => x.FunkoId);
                    table.ForeignKey(
                        name: "FK_Funkos_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "Naruto" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "Game of Thrones" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "Star Wars" });

            migrationBuilder.InsertData(
                table: "Funkos",
                columns: new[] { "FunkoId", "CategoryId", "Image", "Name" },
                values: new object[,]
                {
                    { 1, 1, "/images/naruto.jpg", "Naruto" },
                    { 2, 1, "/images/sasuke.jpg", "Sasuke" },
                    { 3, 1, "/images/sakura.jpg", "Sakura" },
                    { 4, 1, "/images/kakashi.jpg", "Kakashi" },
                    { 5, 2, "/images/jonsnow.jpeg", "Jon Snow" },
                    { 6, 2, "/images/daenerys.jpeg", "Daenerys" },
                    { 7, 2, "/images/naruto.jpeg", "Cersei" },
                    { 8, 2, "/images/nightking.jpeg", "The Night King" },
                    { 9, 3, "/images/darthvader.jpg", "Darth Vader" },
                    { 10, 3, "/images/stormtrooper.jpg", "Storm Trooper" },
                    { 11, 3, "/images/chewbacca.jpg", "Chewbacca" },
                    { 12, 3, "/images/yoda.jpg", "Yoda" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funkos_CategoryId",
                table: "Funkos",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funkos");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
