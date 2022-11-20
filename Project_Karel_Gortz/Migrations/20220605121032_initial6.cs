using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Karel_Gortz.Migrations
{
    public partial class initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PK_VenueDb",
                table: "VenueDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamDb",
                table: "TeamDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeagueDb",
                table: "LeagueDb");

            migrationBuilder.RenameTable(
                name: "VenueDb",
                newName: "Venues");

            migrationBuilder.RenameTable(
                name: "TeamDb",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "LeagueDb",
                newName: "Leagues");

            migrationBuilder.RenameIndex(
                name: "IX_TeamDb_Fixtureid",
                table: "Teams",
                newName: "IX_Teams_Fixtureid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venues",
                table: "Venues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leagues",
                table: "Leagues",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fixtures_Leagues_LeagueId",
                table: "Fixtures",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fixtures_Venues_VenueId",
                table: "Fixtures",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Fixtures_Fixtureid",
                table: "Teams",
                column: "Fixtureid",
                principalTable: "Fixtures",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fixtures_Leagues_LeagueId",
                table: "Fixtures");

            migrationBuilder.DropForeignKey(
                name: "FK_Fixtures_Venues_VenueId",
                table: "Fixtures");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Fixtures_Fixtureid",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venues",
                table: "Venues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leagues",
                table: "Leagues");

            migrationBuilder.RenameTable(
                name: "Venues",
                newName: "VenueDb");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "TeamDb");

            migrationBuilder.RenameTable(
                name: "Leagues",
                newName: "LeagueDb");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_Fixtureid",
                table: "TeamDb",
                newName: "IX_TeamDb_Fixtureid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VenueDb",
                table: "VenueDb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamDb",
                table: "TeamDb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeagueDb",
                table: "LeagueDb",
                column: "Id");

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
    }
}
