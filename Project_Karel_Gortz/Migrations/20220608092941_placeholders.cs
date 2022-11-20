using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Karel_Gortz.Migrations
{
    public partial class placeholders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "FixtureId", "Title" },
                values: new object[] { 50, "My first post", 719349, "First Post" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "FixtureId", "Title" },
                values: new object[] { 51, "My second post", 719349, "Second Post" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "PostId" },
                values: new object[] { 50, "My first comment", 50 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
