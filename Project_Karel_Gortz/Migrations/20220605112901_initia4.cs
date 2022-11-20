using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Karel_Gortz.Migrations
{
    public partial class initia4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FixtureDb_LeagueDb_LeagueDbId",
                table: "FixtureDb");

            migrationBuilder.DropForeignKey(
                name: "FK_FixtureDb_VenueDb_VenueDbId",
                table: "FixtureDb");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamDb_FixtureDb_FixtureDbId",
                table: "TeamDb");

            migrationBuilder.RenameColumn(
                name: "FixtureDbId",
                table: "TeamDb",
                newName: "Fixtureid");

            migrationBuilder.RenameIndex(
                name: "IX_TeamDb_FixtureDbId",
                table: "TeamDb",
                newName: "IX_TeamDb_Fixtureid");

            migrationBuilder.RenameColumn(
                name: "VenueDbId",
                table: "FixtureDb",
                newName: "VenueId");

            migrationBuilder.RenameColumn(
                name: "LeagueDbId",
                table: "FixtureDb",
                newName: "LeagueId");

            migrationBuilder.RenameIndex(
                name: "IX_FixtureDb_VenueDbId",
                table: "FixtureDb",
                newName: "IX_FixtureDb_VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_FixtureDb_LeagueDbId",
                table: "FixtureDb",
                newName: "IX_FixtureDb_LeagueId");

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719349,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719358,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719367,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719376,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719385,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719402,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719403,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719414,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 8, 8 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719421,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719433,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719439,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719455,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 12, 12 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719457,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 13, 13 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719466,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 14, 14 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719475,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 15, 15 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719489,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 16, 16 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719493,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 17, 17 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719502,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 18, 18 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719519,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 19, 19 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719526,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 20, 20 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719529,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 21, 21 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719545,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 22, 22 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719547,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 23, 23 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719556,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 24, 24 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719565,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 25, 25 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719580,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 26, 26 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719583,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 27, 27 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719597,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 28, 28 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719601,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 29, 29 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719618,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 30, 30 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719619,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 31, 31 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719634,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 32, 32 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719637,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 33, 33 });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719647,
                columns: new[] { "LeagueId", "VenueId" },
                values: new object[] { 34, 34 });

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fixtureid",
                value: 719349);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fixtureid",
                value: 719349);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fixtureid",
                value: 719358);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fixtureid",
                value: 719358);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fixtureid",
                value: 719367);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 6,
                column: "Fixtureid",
                value: 719367);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 7,
                column: "Fixtureid",
                value: 719376);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 8,
                column: "Fixtureid",
                value: 719376);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 9,
                column: "Fixtureid",
                value: 719385);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 10,
                column: "Fixtureid",
                value: 719385);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 11,
                column: "Fixtureid",
                value: 719402);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 12,
                column: "Fixtureid",
                value: 719402);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 13,
                column: "Fixtureid",
                value: 719403);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 14,
                column: "Fixtureid",
                value: 719403);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 15,
                column: "Fixtureid",
                value: 719414);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 16,
                column: "Fixtureid",
                value: 719414);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 17,
                column: "Fixtureid",
                value: 719421);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 18,
                column: "Fixtureid",
                value: 719421);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 19,
                column: "Fixtureid",
                value: 719433);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 20,
                column: "Fixtureid",
                value: 719433);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 21,
                column: "Fixtureid",
                value: 719439);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 22,
                column: "Fixtureid",
                value: 719439);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 23,
                column: "Fixtureid",
                value: 719455);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 24,
                column: "Fixtureid",
                value: 719455);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 25,
                column: "Fixtureid",
                value: 719457);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 26,
                column: "Fixtureid",
                value: 719457);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 27,
                column: "Fixtureid",
                value: 719466);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 28,
                column: "Fixtureid",
                value: 719466);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 29,
                column: "Fixtureid",
                value: 719475);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 30,
                column: "Fixtureid",
                value: 719475);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 31,
                column: "Fixtureid",
                value: 719489);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 32,
                column: "Fixtureid",
                value: 719489);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 33,
                column: "Fixtureid",
                value: 719493);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 34,
                column: "Fixtureid",
                value: 719493);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 35,
                column: "Fixtureid",
                value: 719502);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 36,
                column: "Fixtureid",
                value: 719502);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 37,
                column: "Fixtureid",
                value: 719519);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 38,
                column: "Fixtureid",
                value: 719519);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 39,
                column: "Fixtureid",
                value: 719526);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 40,
                column: "Fixtureid",
                value: 719526);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 41,
                column: "Fixtureid",
                value: 719529);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 42,
                column: "Fixtureid",
                value: 719529);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 43,
                column: "Fixtureid",
                value: 719545);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 44,
                column: "Fixtureid",
                value: 719545);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 45,
                column: "Fixtureid",
                value: 719547);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 46,
                column: "Fixtureid",
                value: 719547);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 47,
                column: "Fixtureid",
                value: 719556);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 48,
                column: "Fixtureid",
                value: 719556);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 49,
                column: "Fixtureid",
                value: 719565);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 50,
                column: "Fixtureid",
                value: 719565);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 51,
                column: "Fixtureid",
                value: 719580);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 52,
                column: "Fixtureid",
                value: 719580);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 53,
                column: "Fixtureid",
                value: 719583);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 54,
                column: "Fixtureid",
                value: 719583);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 55,
                column: "Fixtureid",
                value: 719597);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 56,
                column: "Fixtureid",
                value: 719597);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 57,
                column: "Fixtureid",
                value: 719601);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 58,
                column: "Fixtureid",
                value: 719601);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 59,
                column: "Fixtureid",
                value: 719618);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 60,
                column: "Fixtureid",
                value: 719618);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 61,
                column: "Fixtureid",
                value: 719619);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 62,
                column: "Fixtureid",
                value: 719619);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 63,
                column: "Fixtureid",
                value: 719634);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 64,
                column: "Fixtureid",
                value: 719634);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 65,
                column: "Fixtureid",
                value: 719637);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 66,
                column: "Fixtureid",
                value: 719637);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 67,
                column: "Fixtureid",
                value: 719647);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 68,
                column: "Fixtureid",
                value: 719647);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Fixtureid",
                table: "TeamDb",
                newName: "FixtureDbId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamDb_Fixtureid",
                table: "TeamDb",
                newName: "IX_TeamDb_FixtureDbId");

            migrationBuilder.RenameColumn(
                name: "VenueId",
                table: "FixtureDb",
                newName: "VenueDbId");

            migrationBuilder.RenameColumn(
                name: "LeagueId",
                table: "FixtureDb",
                newName: "LeagueDbId");

            migrationBuilder.RenameIndex(
                name: "IX_FixtureDb_VenueId",
                table: "FixtureDb",
                newName: "IX_FixtureDb_VenueDbId");

            migrationBuilder.RenameIndex(
                name: "IX_FixtureDb_LeagueId",
                table: "FixtureDb",
                newName: "IX_FixtureDb_LeagueDbId");

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719349,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719358,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719367,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719376,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719385,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719402,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719403,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719414,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719421,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719433,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719439,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719455,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719457,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719466,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719475,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719489,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719493,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719502,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719519,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719526,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719529,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719545,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719547,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719556,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719565,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719580,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719583,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719597,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719601,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719618,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719619,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719634,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719637,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FixtureDb",
                keyColumn: "Id",
                keyValue: 719647,
                columns: new[] { "LeagueDbId", "VenueDbId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 1,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 2,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 3,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 4,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 5,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 6,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 7,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 8,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 9,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 10,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 11,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 12,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 13,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 14,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 15,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 16,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 17,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 18,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 19,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 20,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 21,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 22,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 23,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 24,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 25,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 26,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 27,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 28,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 29,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 30,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 31,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 32,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 33,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 34,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 35,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 36,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 37,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 38,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 39,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 40,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 41,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 42,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 43,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 44,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 45,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 46,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 47,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 48,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 49,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 50,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 51,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 52,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 53,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 54,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 55,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 56,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 57,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 58,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 59,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 60,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 61,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 62,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 63,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 64,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 65,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 66,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 67,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TeamDb",
                keyColumn: "Id",
                keyValue: 68,
                column: "FixtureDbId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_FixtureDb_LeagueDb_LeagueDbId",
                table: "FixtureDb",
                column: "LeagueDbId",
                principalTable: "LeagueDb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FixtureDb_VenueDb_VenueDbId",
                table: "FixtureDb",
                column: "VenueDbId",
                principalTable: "VenueDb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamDb_FixtureDb_FixtureDbId",
                table: "TeamDb",
                column: "FixtureDbId",
                principalTable: "FixtureDb",
                principalColumn: "Id");
        }
    }
}
