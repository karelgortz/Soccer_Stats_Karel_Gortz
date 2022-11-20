using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Karel_Gortz.Migrations
{
    public partial class posts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FixtureId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Fixtures_FixtureId",
                        column: x => x.FixtureId,
                        principalTable: "Fixtures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "FixtureId", "Title" },
                values: new object[,]
                {
                    { 1, null, 719349, null },
                    { 2, null, 719358, null },
                    { 3, null, 719367, null },
                    { 4, null, 719376, null },
                    { 5, null, 719385, null },
                    { 6, null, 719402, null },
                    { 7, null, 719403, null },
                    { 8, null, 719414, null },
                    { 9, null, 719421, null },
                    { 10, null, 719433, null },
                    { 11, null, 719439, null },
                    { 12, null, 719455, null },
                    { 13, null, 719457, null },
                    { 14, null, 719466, null },
                    { 15, null, 719475, null },
                    { 16, null, 719489, null },
                    { 17, null, 719493, null },
                    { 18, null, 719502, null },
                    { 19, null, 719519, null },
                    { 20, null, 719526, null },
                    { 21, null, 719529, null },
                    { 22, null, 719545, null },
                    { 23, null, 719547, null },
                    { 24, null, 719556, null },
                    { 25, null, 719565, null },
                    { 26, null, 719580, null },
                    { 27, null, 719583, null },
                    { 28, null, 719597, null },
                    { 29, null, 719601, null },
                    { 30, null, 719618, null },
                    { 31, null, 719619, null },
                    { 32, null, 719634, null },
                    { 33, null, 719637, null },
                    { 34, null, 719647, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_FixtureId",
                table: "Posts",
                column: "FixtureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
