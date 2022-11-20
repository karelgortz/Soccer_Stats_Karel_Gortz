using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Karel_Gortz.Migrations
{
    public partial class initia5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FixtureDb_LeagueDb_LeagueId",
                table: "FixtureDb");

            migrationBuilder.DropForeignKey(
                name: "FK_FixtureDb_VenueDb_VenueId",
                table: "FixtureDb");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamDb_FixtureDb_Fixtureid",
                table: "TeamDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FixtureDb",
                table: "FixtureDb");

            migrationBuilder.RenameTable(
                name: "FixtureDb",
                newName: "Fixtures");

            migrationBuilder.RenameIndex(
                name: "IX_FixtureDb_VenueId",
                table: "Fixtures",
                newName: "IX_Fixtures_VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_FixtureDb_LeagueId",
                table: "Fixtures",
                newName: "IX_Fixtures_LeagueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fixtures",
                table: "Fixtures",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719349,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719358,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719367,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719376,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719385,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719402,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719403,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719414,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 8, 8 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719421,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719433,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719439,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719455,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 12, 12 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719457,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 13, 13 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719466,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 14, 14 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719475,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 15, 15 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719489,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 16, 16 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719493,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 17, 17 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719502,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 18, 18 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719519,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 19, 19 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719526,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 20, 20 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719529,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 21, 21 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719545,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 22, 22 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719547,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 23, 23 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719556,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 24, 24 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719565,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 25, 25 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719580,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 26, 26 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719583,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 27, 27 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719597,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 28, 28 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719601,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 29, 29 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719618,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 30, 30 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719619,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 31, 31 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719634,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 32, 32 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719637,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 33, 33 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719647,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 34, 34 });

            migrationBuilder.AddForeignKey(
                name: "FK_Fixtures_LeagueDb_LeagueId",
                table: "Fixtures",
                column: "LeagueId",
                principalTable: "LeagueDb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fixtures_VenueDb_VenueId",
                table: "Fixtures",
                column: "VenueId",
                principalTable: "VenueDb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamDb_Fixtures_Fixtureid",
                table: "TeamDb",
                column: "Fixtureid",
                principalTable: "Fixtures",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fixtures_LeagueDb_LeagueId",
                table: "Fixtures");

            migrationBuilder.DropForeignKey(
                name: "FK_Fixtures_VenueDb_VenueId",
                table: "Fixtures");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamDb_Fixtures_Fixtureid",
                table: "TeamDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fixtures",
                table: "Fixtures");

            migrationBuilder.RenameTable(
                name: "Fixtures",
                newName: "FixtureDb");

            migrationBuilder.RenameIndex(
                name: "IX_Fixtures_VenueId",
                table: "FixtureDb",
                newName: "IX_FixtureDb_VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_Fixtures_LeagueId",
                table: "FixtureDb",
                newName: "IX_FixtureDb_LeagueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FixtureDb",
                table: "FixtureDb",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719349,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 703 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719358,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719367,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719376,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 738 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719385,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719402,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 718 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719403,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719414,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 699 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719421,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719433,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 748 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719439,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719455,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 698 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719457,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719466,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 702 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719475,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719489,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 750 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719493,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719502,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719519,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 731 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719526,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 694 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719529,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719545,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 751 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719547,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719556,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 10491 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719565,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719580,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 724 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719583,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719597,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 12717 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719601,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719618,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 697 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719619,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719634,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 11899 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719637,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 700 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719647,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 78, 752 });

            migrationBuilder.AddForeignKey(
                name: "FK_FixtureDb_LeagueDb_LeagueId",
                table: "FixtureDb",
                column: "LeagueId",
                principalTable: "LeagueDb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FixtureDb_VenueDb_VenueId",
                table: "FixtureDb",
                column: "VenueId",
                principalTable: "VenueDb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamDb_FixtureDb_Fixtureid",
                table: "TeamDb",
                column: "Fixtureid",
                principalTable: "FixtureDb",
                principalColumn: "Id");
        }
    }
}
