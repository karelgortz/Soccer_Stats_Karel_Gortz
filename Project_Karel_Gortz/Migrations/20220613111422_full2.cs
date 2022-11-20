using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Karel_Gortz.Migrations
{
    public partial class full2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 705941);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 723341);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 736012);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 736024);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 736031);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 736039);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 787562);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 787586);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 787602);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 787610);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 787624);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 787650);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 788043);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 816244);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 816245);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 851370);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 851371);

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719349,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 2, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719358,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 20, 19, 10, 10 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719367,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 38, 37, 19, 19 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719376,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 56, 55, 28, 28 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719385,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 74, 73, 37, 37 });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Awaygoals", "Date", "HomeGoals", "HomeTeamId", "LeagueId", "Referee", "Round", "Season", "Timestamp", "VenueId" },
                values: new object[,]
                {
                    { 719350, 4, 2, "2021-08-14T16:30:00+00:00", 5, 3, 2, "T. Stieler", "Regular Season - 1", 2021, 1628958600, 2 },
                    { 719351, 6, 0, "2021-08-14T13:30:00+00:00", 1, 5, 3, "F. Willenborg", "Regular Season - 1", 2021, 1628947800, 3 },
                    { 719352, 8, 1, "2021-08-14T13:30:00+00:00", 1, 7, 4, "T. Reichel", "Regular Season - 1", 2021, 1628947800, 4 },
                    { 719353, 10, 1, "2021-08-14T13:30:00+00:00", 5, 9, 5, "F. Zwayer", "Regular Season - 1", 2021, 1628947800, 5 },
                    { 719354, 12, 0, "2021-08-15T13:30:00+00:00", 1, 11, 6, "D. Siebert", "Regular Season - 1", 2021, 1629034200, 6 },
                    { 719355, 14, 4, "2021-08-14T13:30:00+00:00", 0, 13, 7, "F. Brych", "Regular Season - 1", 2021, 1628947800, 7 },
                    { 719356, 16, 0, "2021-08-14T13:30:00+00:00", 0, 15, 8, "S. Jablonski", "Regular Season - 1", 2021, 1628947800, 8 },
                    { 719357, 18, 1, "2021-08-15T15:30:00+00:00", 3, 17, 9, "R. Hartmann", "Regular Season - 1", 2021, 1629041400, 9 },
                    { 719359, 22, 0, "2021-08-20T18:30:00+00:00", 4, 21, 11, "F. Badstübner", "Regular Season - 2", 2021, 1629484200, 11 },
                    { 719360, 24, 0, "2021-08-21T13:30:00+00:00", 0, 23, 12, "H. Osmers", "Regular Season - 2", 2021, 1629552600, 12 },
                    { 719361, 26, 0, "2021-08-21T16:30:00+00:00", 4, 25, 13, "D. Aytekin", "Regular Season - 2", 2021, 1629563400, 13 },
                    { 719362, 28, 1, "2021-08-21T13:30:00+00:00", 2, 27, 14, "R. Schröder", "Regular Season - 2", 2021, 1629552600, 14 },
                    { 719363, 30, 2, "2021-08-22T13:30:00+00:00", 2, 29, 15, "S. Stegemann", "Regular Season - 2", 2021, 1629639000, 15 },
                    { 719364, 32, 2, "2021-08-21T13:30:00+00:00", 1, 31, 16, "M. Jöllenbeck", "Regular Season - 2", 2021, 1629552600, 16 },
                    { 719365, 34, 0, "2021-08-21T13:30:00+00:00", 2, 33, 17, "P. Ittrich", "Regular Season - 2", 2021, 1629552600, 17 },
                    { 719366, 36, 1, "2021-08-21T13:30:00+00:00", 1, 35, 18, "D. Schlager", "Regular Season - 2", 2021, 1629552600, 18 },
                    { 719368, 40, 2, "2021-08-27T18:30:00+00:00", 3, 39, 20, "F. Zwayer", "Regular Season - 3", 2021, 1630089000, 20 },
                    { 719369, 42, 0, "2021-08-29T15:30:00+00:00", 1, 41, 21, "T. Stieler", "Regular Season - 3", 2021, 1630251000, 21 },
                    { 719370, 44, 1, "2021-08-29T13:30:00+00:00", 2, 43, 22, "F. Brych", "Regular Season - 3", 2021, 1630243800, 22 },
                    { 719371, 46, 3, "2021-08-28T13:30:00+00:00", 2, 45, 23, "F. Willenborg", "Regular Season - 3", 2021, 1630157400, 23 },
                    { 719372, 48, 0, "2021-08-28T13:30:00+00:00", 3, 47, 24, "T. Reichel", "Regular Season - 3", 2021, 1630157400, 24 },
                    { 719373, 50, 4, "2021-08-28T13:30:00+00:00", 1, 49, 25, "B. Brand", "Regular Season - 3", 2021, 1630157400, 25 },
                    { 719374, 52, 1, "2021-08-28T13:30:00+00:00", 1, 51, 26, "B. Dankert", "Regular Season - 3", 2021, 1630157400, 26 },
                    { 719375, 54, 1, "2021-08-28T13:30:00+00:00", 2, 53, 27, "B. Cortus", "Regular Season - 3", 2021, 1630157400, 27 },
                    { 719377, 58, 1, "2021-09-12T13:30:00+00:00", 1, 57, 29, "M. Jöllenbeck", "Regular Season - 4", 2021, 1631453400, 29 },
                    { 719378, 60, 4, "2021-09-11T13:30:00+00:00", 3, 59, 30, "D. Siebert", "Regular Season - 4", 2021, 1631367000, 30 },
                    { 719379, 62, 0, "2021-09-11T13:30:00+00:00", 0, 61, 31, "M. Petersen", "Regular Season - 4", 2021, 1631367000, 31 },
                    { 719380, 64, 1, "2021-09-12T17:30:00+00:00", 3, 63, 32, "S. Stegemann", "Regular Season - 4", 2021, 1631467800, 32 },
                    { 719381, 66, 1, "2021-09-11T13:30:00+00:00", 1, 65, 33, "H. Osmers", "Regular Season - 4", 2021, 1631367000, 33 },
                    { 719382, 68, 2, "2021-09-11T13:30:00+00:00", 0, 67, 34, "M. Fritz", "Regular Season - 4", 2021, 1631367000, 34 },
                    { 719383, 70, 3, "2021-09-12T15:30:00+00:00", 1, 69, 35, "R. Schröder", "Regular Season - 4", 2021, 1631460600, 35 },
                    { 719384, 72, 2, "2021-09-11T13:30:00+00:00", 0, 71, 36, "R. Hartmann", "Regular Season - 4", 2021, 1631367000, 36 },
                    { 719386, 76, 2, "2021-09-19T15:30:00+00:00", 4, 75, 38, "S. Jablonski", "Regular Season - 5", 2021, 1632065400, 38 },
                    { 719387, 78, 1, "2021-09-19T17:30:00+00:00", 1, 77, 39, "F. Zwayer", "Regular Season - 5", 2021, 1632072600, 39 },
                    { 719388, 80, 3, "2021-09-19T13:30:00+00:00", 1, 79, 40, "B. Cortus", "Regular Season - 5", 2021, 1632058200, 40 },
                    { 719389, 82, 0, "2021-09-18T13:30:00+00:00", 0, 81, 41, "B. Brand", "Regular Season - 5", 2021, 1631971800, 41 },
                    { 719390, 84, 0, "2021-09-18T13:30:00+00:00", 1, 83, 42, "F. Badstübner", "Regular Season - 5", 2021, 1631971800, 42 }
                });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Awaygoals", "Date", "HomeGoals", "HomeTeamId", "LeagueId", "Referee", "Round", "Season", "Timestamp", "VenueId" },
                values: new object[,]
                {
                    { 719391, 86, 1, "2021-09-17T18:30:00+00:00", 2, 85, 43, "T. Stieler", "Regular Season - 5", 2021, 1631903400, 43 },
                    { 719392, 88, 0, "2021-09-18T13:30:00+00:00", 0, 87, 44, "P. Ittrich", "Regular Season - 5", 2021, 1631971800, 44 },
                    { 719393, 90, 1, "2021-09-18T16:30:00+00:00", 1, 89, 45, "F. Brych", "Regular Season - 5", 2021, 1631982600, 45 },
                    { 719394, 92, 0, "2021-09-25T13:30:00+00:00", 6, 91, 46, "S. Stegemann", "Regular Season - 6", 2021, 1632576600, 46 },
                    { 719395, 94, 1, "2021-09-25T13:30:00+00:00", 1, 93, 47, "M. Petersen", "Regular Season - 6", 2021, 1632576600, 47 },
                    { 719396, 96, 0, "2021-09-25T13:30:00+00:00", 1, 95, 48, "B. Dankert", "Regular Season - 6", 2021, 1632576600, 48 },
                    { 719397, 98, 0, "2021-09-25T13:30:00+00:00", 1, 97, 49, "M. Fritz", "Regular Season - 6", 2021, 1632576600, 49 },
                    { 719398, 100, 0, "2021-09-25T16:30:00+00:00", 1, 99, 50, "D. Aytekin", "Regular Season - 6", 2021, 1632587400, 50 },
                    { 719399, 102, 0, "2021-09-26T15:30:00+00:00", 3, 101, 51, "D. Schlager", "Regular Season - 6", 2021, 1632670200, 51 }
                });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LeagueId", "Logo", "Name" },
                values: new object[] { 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "LeagueId", "Logo", "Name" },
                values: new object[] { 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "LeagueId", "Logo", "Name" },
                values: new object[] { 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[,]
                {
                    { 52, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 53, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 54, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 55, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 56, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 57, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 58, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 59, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 60, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 61, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 62, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 63, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 64, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 65, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 66, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 67, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" }
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[,]
                {
                    { 68, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 69, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 70, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 71, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 72, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 73, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 74, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 75, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 76, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 77, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 78, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 79, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 80, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 81, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 82, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 83, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 84, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 85, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 86, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 87, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 88, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 89, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 90, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 91, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 92, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 93, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 94, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 95, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 96, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 97, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 98, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 99, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 100, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 101, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 102, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 103, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 104, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 105, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 106, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 107, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 108, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 109, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" }
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[,]
                {
                    { 110, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 111, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 112, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 113, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 114, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 115, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 116, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 117, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 118, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 119, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 120, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 121, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 122, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 123, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 124, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 125, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 126, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 127, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 128, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 129, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 130, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 131, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 132, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 133, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 134, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 135, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 136, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 137, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 138, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 139, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 140, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 141, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 142, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 143, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 144, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 145, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 146, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 147, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 148, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 149, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 150, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 151, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" }
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[,]
                {
                    { 152, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 153, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 154, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 155, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 156, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 157, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 158, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 159, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 160, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 161, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 162, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 163, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 164, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 165, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 166, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 167, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 168, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 169, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 170, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 171, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 172, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 173, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 174, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 175, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 176, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 177, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 178, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 179, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 180, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 181, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 182, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 183, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 184, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 185, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 186, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 187, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 188, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 189, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 190, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 191, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 192, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 193, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" }
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[,]
                {
                    { 194, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 195, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 196, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 197, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 198, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 199, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 200, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 201, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 202, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 203, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 204, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 205, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 206, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 207, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 208, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 209, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 210, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 211, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 212, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 213, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 214, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 215, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 216, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 217, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 218, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 219, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 220, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 221, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 222, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 223, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 224, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 225, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 226, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 227, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 228, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 229, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 230, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 231, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 232, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 233, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 234, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 235, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" }
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[,]
                {
                    { 236, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 237, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 238, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 239, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 240, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 241, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 242, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 243, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 244, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 245, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 246, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 247, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 248, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 249, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 250, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 251, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 252, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 253, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 254, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 255, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 256, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 257, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 258, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 259, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 260, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 261, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 262, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 263, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 264, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 265, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 266, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 267, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 268, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 269, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 270, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 271, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 272, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 273, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 274, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 275, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 276, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 277, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" }
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[,]
                {
                    { 278, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 279, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 280, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 281, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 282, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 283, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 284, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 285, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 286, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 287, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 288, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 289, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 290, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 291, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 292, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 293, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 294, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 295, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 296, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 297, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 298, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 299, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 300, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 301, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 302, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 303, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 304, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 305, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 306, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 307, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 308, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" }
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 103, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 104, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 105, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 106, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 107, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 108, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 109, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 110, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 111, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 112, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 113, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 114, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 115, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 116, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 117, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 118, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 119, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 120, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 121, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 122, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 123, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 124, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 125, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 126, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 127, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 128, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 129, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 130, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 131, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 132, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 133, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 134, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 135, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 136, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 137, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 138, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 139, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 140, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 141, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 142, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 143, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 144, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 145, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 146, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 147, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 148, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 149, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 150, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 151, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 152, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 153, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 154, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 155, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 156, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 157, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 158, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 159, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 160, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 161, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 162, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 163, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 164, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 165, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 166, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 167, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 168, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 169, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 170, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 171, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 172, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 173, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 174, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 175, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 176, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 177, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 178, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 179, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 180, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 181, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 182, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 183, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 184, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 185, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 186, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 187, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 188, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 189, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 190, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 191, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 192, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 193, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 194, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 195, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 196, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 197, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 198, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 199, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 200, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 201, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 202, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 203, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 204, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 205, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 206, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 207, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 208, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 209, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 210, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 211, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 212, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 213, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 214, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 215, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 216, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 217, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 218, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 219, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 220, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 221, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 222, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 223, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 224, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 225, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 226, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 227, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 228, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 229, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 230, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 231, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 232, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 233, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 234, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 235, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 236, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 237, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 238, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 239, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 240, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 241, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 242, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 243, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 244, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 245, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 246, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 247, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 248, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 249, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 250, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 251, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 252, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 253, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 254, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 255, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 256, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 257, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 258, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 259, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 260, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 261, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 262, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 263, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 264, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 265, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 266, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 267, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 268, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 269, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 270, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 271, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 272, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 273, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 274, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 275, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 276, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 277, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 278, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 279, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 280, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 281, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 282, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 283, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 284, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 285, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 286, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 287, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 288, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 289, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 290, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 291, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 292, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 293, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 294, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 295, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 296, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 297, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 298, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 299, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 300, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 301, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 302, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 303, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 304, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 305, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 306, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 307, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 308, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 309, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 310, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 311, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 312, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 313, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 314, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 315, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 316, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 317, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 318, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 319, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 320, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 321, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 322, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 323, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 324, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 325, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 326, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 327, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 328, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 329, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 330, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 331, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 332, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 333, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 334, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 335, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 336, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 337, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 338, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 339, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 340, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 341, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 342, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 343, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 344, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 345, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 346, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 347, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 348, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 349, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 350, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 351, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 352, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 353, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 354, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 355, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 356, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 357, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 358, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 359, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 360, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 361, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 362, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 363, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 364, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 365, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 366, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 367, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 368, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 369, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 370, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 371, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 372, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 373, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 374, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 375, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 376, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 377, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 378, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 379, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 380, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 381, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 382, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 383, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 384, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 385, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 386, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 387, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 388, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 389, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 390, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 391, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 392, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 393, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 394, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 395, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 396, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 397, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 398, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 399, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 400, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 401, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 402, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 403, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 404, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 405, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 406, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 407, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 408, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 409, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 410, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 411, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 412, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 413, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 414, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 415, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 416, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 417, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 418, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 419, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 420, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 421, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 422, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 423, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 424, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 425, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 426, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 427, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 428, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 429, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 430, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 431, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 432, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 433, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 434, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 435, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 436, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 437, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 438, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 439, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 440, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 441, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 442, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 443, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 444, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 445, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 446, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 447, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 448, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 449, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 450, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 451, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 452, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 453, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 454, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 455, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 456, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 457, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 458, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 459, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 460, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 461, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 462, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 463, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 464, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 465, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 466, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 467, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 468, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 469, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 470, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 471, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 472, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 473, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 474, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 475, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 476, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 477, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 478, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 479, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 480, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 481, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 482, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 483, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 484, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 485, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 486, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 487, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 488, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 489, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 490, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 491, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 492, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 493, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 494, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 495, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 496, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 497, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 498, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 499, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 500, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 501, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 502, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 503, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 504, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 505, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 506, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 507, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 508, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 509, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 510, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 511, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 512, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 513, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 514, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 515, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 516, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 517, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 518, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 519, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 520, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 521, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 522, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 523, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 524, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 525, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 526, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 527, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 528, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 529, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 530, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 531, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 532, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 533, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 534, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 535, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 536, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 537, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 538, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 539, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 540, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 541, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 542, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 543, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 544, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 545, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 546, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 547, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 548, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 549, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 550, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 551, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 552, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 553, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 554, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 555, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 556, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 557, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 558, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 559, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 560, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 561, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 562, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 563, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 564, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 565, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 566, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 567, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 568, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 569, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 570, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 571, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 572, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 573, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 574, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 575, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 576, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 577, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 578, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 579, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 580, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 581, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 582, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 583, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 584, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 585, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 586, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 587, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 588, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 589, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 590, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 591, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 592, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 593, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 594, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 595, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 596, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 597, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 598, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 599, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 600, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 601, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 602, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 603, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Fixtureid", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 604, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 605, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 606, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 607, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 608, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 609, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 610, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 611, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 612, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 613, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 614, null, "https://media.api-sports.io/football/teams/175.png", "Hamburger SV", 175 },
                    { 615, null, "https://media.api-sports.io/football/teams/175.png", "Hamburger SV", 175 },
                    { 616, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 }
                });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Dortmund", "Signal-Iduna-Park", 702 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Wolfsburg", "VOLKSWAGEN ARENA", 752 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Berlin", "Stadion An der Alten Försterei", 748 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Stuttgart", "Mercedes-Benz-Arena", 750 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Mainz", "MEWA ARENA", 11899 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Augsburg", "WWK Arena", 698 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Bielefeld", "SchücoArena", 697 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Köln", "RheinEnergieStadion", 731 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Leipzig", "Red Bull Arena", 738 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Frankfurt am Main", "Deutsche Bank Park", 10491 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Leverkusen", "BayArena", 699 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Freiburg im Breisgau", "Dreisamstadion", 12274 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Sinsheim", "PreZero Arena", 724 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Berlin", "Olympiastadion Berlin", 694 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Bochum", "Vonovia Ruhrstadion", 751 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Fürth", "Sportpark Ronhof Thomas Sommer", 718 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Dortmund", "Signal-Iduna-Park", 702 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Wolfsburg", "VOLKSWAGEN ARENA", 752 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Berlin", "Stadion An der Alten Försterei", 748 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Stuttgart", "Mercedes-Benz-Arena", 750 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Mainz", "MEWA ARENA", 11899 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Augsburg", "WWK Arena", 698 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Bielefeld", "SchücoArena", 697 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Köln", "RheinEnergieStadion", 731 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Leipzig", "Red Bull Arena", 738 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Frankfurt am Main", "Deutsche Bank Park", 10491 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Leverkusen", "BayArena", 699 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Berlin", "Stadion An der Alten Försterei", 748 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Freiburg im Breisgau", "Dreisamstadion", 12274 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Sinsheim", "PreZero Arena", 724 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Bochum", "Vonovia Ruhrstadion", 751 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Fürth", "Sportpark Ronhof Thomas Sommer", 718 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Dortmund", "Signal-Iduna-Park", 702 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Wolfsburg", "VOLKSWAGEN ARENA", 752 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Stuttgart", "Mercedes-Benz-Arena", 750 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Mainz", "MEWA ARENA", 11899 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Augsburg", "WWK Arena", 698 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Berlin", "Olympiastadion Berlin", 694 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Bielefeld", "SchücoArena", 697 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Köln", "RheinEnergieStadion", 731 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Leipzig", "Red Bull Arena", 738 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Frankfurt am Main", "Deutsche Bank Park", 10491 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Leverkusen", "BayArena", 699 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Berlin", "Stadion An der Alten Försterei", 748 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Freiburg im Breisgau", "Dreisamstadion", 12274 });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Name", "VenueId" },
                values: new object[,]
                {
                    { 52, "Sinsheim", "PreZero Arena", 724 },
                    { 53, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 54, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 55, "München", "Allianz Arena", 700 },
                    { 56, "Leipzig", "Red Bull Arena", 738 },
                    { 57, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 58, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 59, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 60, "Mainz", "MEWA ARENA", 11899 },
                    { 61, "Berlin", "Olympiastadion Berlin", 694 },
                    { 62, "Bielefeld", "SchücoArena", 697 },
                    { 63, "Köln", "RheinEnergieStadion", 731 },
                    { 64, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 65, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 66, "Leverkusen", "BayArena", 699 },
                    { 67, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 68, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 69, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 70, "Sinsheim", "PreZero Arena", 724 },
                    { 71, "Augsburg", "WWK Arena", 698 },
                    { 72, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 73, "München", "Allianz Arena", 700 }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Name", "VenueId" },
                values: new object[,]
                {
                    { 74, "Leipzig", "Red Bull Arena", 738 },
                    { 75, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 76, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 77, "Mainz", "MEWA ARENA", 11899 },
                    { 78, "Berlin", "Olympiastadion Berlin", 694 },
                    { 79, "Bielefeld", "SchücoArena", 697 },
                    { 80, "Köln", "RheinEnergieStadion", 731 },
                    { 81, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 82, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 83, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 84, "Leverkusen", "BayArena", 699 },
                    { 85, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 86, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 87, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 88, "Sinsheim", "PreZero Arena", 724 },
                    { 89, "Augsburg", "WWK Arena", 698 },
                    { 90, "Bielefeld", "SchücoArena", 697 },
                    { 91, "München", "Allianz Arena", 700 },
                    { 92, "Leipzig", "Red Bull Arena", 738 },
                    { 93, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 94, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 95, "Mainz", "MEWA ARENA", 11899 },
                    { 96, "Berlin", "Olympiastadion Berlin", 694 },
                    { 97, "Köln", "RheinEnergieStadion", 731 },
                    { 98, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 99, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 100, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 101, "Leverkusen", "BayArena", 699 },
                    { 102, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 103, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 104, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 105, "Sinsheim", "PreZero Arena", 724 },
                    { 106, "Mainz", "MEWA ARENA", 11899 },
                    { 107, "Augsburg", "WWK Arena", 698 },
                    { 108, "Bielefeld", "SchücoArena", 697 },
                    { 109, "München", "Allianz Arena", 700 },
                    { 110, "Leipzig", "Red Bull Arena", 738 },
                    { 111, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 112, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 113, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 114, "Berlin", "Olympiastadion Berlin", 694 },
                    { 115, "Köln", "RheinEnergieStadion", 731 }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Name", "VenueId" },
                values: new object[,]
                {
                    { 116, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 117, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 118, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 119, "Leverkusen", "BayArena", 699 },
                    { 120, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 121, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 122, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 123, "Sinsheim", "PreZero Arena", 724 },
                    { 124, "Mainz", "MEWA ARENA", 11899 },
                    { 125, "Augsburg", "WWK Arena", 698 },
                    { 126, "Bielefeld", "SchücoArena", 697 },
                    { 127, "München", "Allianz Arena", 700 },
                    { 128, "Leipzig", "Red Bull Arena", 738 },
                    { 129, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 130, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 131, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 132, "Berlin", "Olympiastadion Berlin", 694 },
                    { 133, "Köln", "RheinEnergieStadion", 731 },
                    { 134, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 135, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 136, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 137, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 138, "Leverkusen", "BayArena", 699 },
                    { 139, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 140, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 141, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 142, "Mainz", "MEWA ARENA", 11899 },
                    { 143, "Augsburg", "WWK Arena", 698 },
                    { 144, "Bielefeld", "SchücoArena", 697 },
                    { 145, "München", "Allianz Arena", 700 },
                    { 146, "Leipzig", "Red Bull Arena", 738 },
                    { 147, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 148, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 149, "Sinsheim", "PreZero Arena", 724 },
                    { 150, "Berlin", "Olympiastadion Berlin", 694 },
                    { 151, "Köln", "RheinEnergieStadion", 731 },
                    { 152, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 153, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 154, "München", "Allianz Arena", 700 },
                    { 155, "Leipzig", "Red Bull Arena", 738 },
                    { 156, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 157, "Leverkusen", "BayArena", 699 }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Name", "VenueId" },
                values: new object[,]
                {
                    { 158, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 159, "Sinsheim", "PreZero Arena", 724 },
                    { 160, "Berlin", "Olympiastadion Berlin", 694 },
                    { 161, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 162, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 163, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 164, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 165, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 166, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 167, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 168, "Mainz", "MEWA ARENA", 11899 },
                    { 169, "Augsburg", "WWK Arena", 698 },
                    { 170, "Bielefeld", "SchücoArena", 697 },
                    { 171, "Köln", "RheinEnergieStadion", 731 },
                    { 172, "Leipzig", "Red Bull Arena", 738 },
                    { 173, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 174, "Leverkusen", "BayArena", 699 },
                    { 175, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 176, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 177, "Sinsheim", "PreZero Arena", 724 },
                    { 178, "Berlin", "Olympiastadion Berlin", 694 },
                    { 179, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 180, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 181, "München", "Allianz Arena", 700 },
                    { 182, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 183, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 184, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 185, "Mainz", "MEWA ARENA", 11899 },
                    { 186, "Augsburg", "WWK Arena", 698 },
                    { 187, "Berlin", "Olympiastadion Berlin", 694 },
                    { 188, "Bielefeld", "SchücoArena", 697 },
                    { 189, "Köln", "RheinEnergieStadion", 731 },
                    { 190, "Leipzig", "Red Bull Arena", 738 },
                    { 191, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 192, "Leverkusen", "BayArena", 699 },
                    { 193, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 194, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 195, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 196, "Sinsheim", "PreZero Arena", 724 },
                    { 197, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 198, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 199, "München", "Allianz Arena", 700 }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Name", "VenueId" },
                values: new object[,]
                {
                    { 200, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 201, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 202, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 203, "Mainz", "MEWA ARENA", 11899 },
                    { 204, "Augsburg", "WWK Arena", 698 },
                    { 205, "Berlin", "Olympiastadion Berlin", 694 },
                    { 206, "Bielefeld", "SchücoArena", 697 },
                    { 207, "Köln", "RheinEnergieStadion", 731 },
                    { 208, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 209, "Leverkusen", "BayArena", 699 },
                    { 210, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 211, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 212, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 213, "Sinsheim", "PreZero Arena", 724 },
                    { 214, "Augsburg", "WWK Arena", 698 },
                    { 215, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 216, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 217, "München", "Allianz Arena", 700 },
                    { 218, "Leipzig", "Red Bull Arena", 738 },
                    { 219, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 220, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 221, "Mainz", "MEWA ARENA", 11899 },
                    { 222, "Berlin", "Olympiastadion Berlin", 694 },
                    { 223, "Bielefeld", "SchücoArena", 697 },
                    { 224, "Köln", "RheinEnergieStadion", 731 },
                    { 225, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 226, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 227, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 228, "Leverkusen", "BayArena", 699 },
                    { 229, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 230, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 231, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 232, "Sinsheim", "PreZero Arena", 724 },
                    { 233, "Augsburg", "WWK Arena", 698 },
                    { 234, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 235, "München", "Allianz Arena", 700 },
                    { 236, "Leipzig", "Red Bull Arena", 738 },
                    { 237, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 238, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 239, "Mainz", "MEWA ARENA", 11899 },
                    { 240, "Berlin", "Olympiastadion Berlin", 694 },
                    { 241, "Köln", "RheinEnergieStadion", 731 }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Name", "VenueId" },
                values: new object[,]
                {
                    { 242, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 243, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 244, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 245, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 246, "Leverkusen", "BayArena", 699 },
                    { 247, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 248, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 249, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 250, "Sinsheim", "PreZero Arena", 724 },
                    { 251, "Augsburg", "WWK Arena", 698 },
                    { 252, "Bielefeld", "SchücoArena", 697 },
                    { 253, "München", "Allianz Arena", 700 },
                    { 254, "Leipzig", "Red Bull Arena", 738 },
                    { 255, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 256, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 257, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 258, "Berlin", "Olympiastadion Berlin", 694 },
                    { 259, "Köln", "RheinEnergieStadion", 731 },
                    { 260, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 261, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 262, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 263, "Leverkusen", "BayArena", 699 },
                    { 264, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 265, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 266, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 267, "Sinsheim", "PreZero Arena", 724 },
                    { 268, "Mainz", "MEWA ARENA", 11899 },
                    { 269, "Augsburg", "WWK Arena", 698 },
                    { 270, "Bielefeld", "SchücoArena", 697 },
                    { 271, "München", "Allianz Arena", 700 },
                    { 272, "Leipzig", "Red Bull Arena", 738 },
                    { 273, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 274, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 275, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 276, "Berlin", "Olympiastadion Berlin", 694 },
                    { 277, "Köln", "RheinEnergieStadion", 731 },
                    { 278, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 279, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 280, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 281, "Leverkusen", "BayArena", 699 },
                    { 282, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 283, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Name", "VenueId" },
                values: new object[,]
                {
                    { 284, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 285, "Sinsheim", "PreZero Arena", 724 },
                    { 286, "Mainz", "MEWA ARENA", 11899 },
                    { 287, "Augsburg", "WWK Arena", 698 },
                    { 288, "Bielefeld", "SchücoArena", 697 },
                    { 289, "München", "Allianz Arena", 700 },
                    { 290, "Leipzig", "Red Bull Arena", 738 },
                    { 291, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 292, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 293, "Sinsheim", "PreZero Arena", 724 },
                    { 294, "Berlin", "Olympiastadion Berlin", 694 },
                    { 295, "Köln", "RheinEnergieStadion", 731 },
                    { 296, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 297, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 298, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 299, "Wolfsburg", "VOLKSWAGEN ARENA", 752 },
                    { 300, "Leverkusen", "BayArena", 699 },
                    { 301, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 302, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 303, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 304, "Mainz", "MEWA ARENA", 11899 },
                    { 305, "Augsburg", "WWK Arena", 698 },
                    { 306, "Bielefeld", "SchücoArena", 697 },
                    { 307, "Berlin", "Olympiastadion Berlin", 694 },
                    { 308, "Hamburg", "Volksparkstadion", 720 }
                });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719402,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 108, 107, 54, 54 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719403,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 110, 109, 55, 55 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719414,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 132, 131, 66, 66 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719421,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 146, 145, 73, 73 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719433,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 170, 169, 85, 85 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719439,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 182, 181, 91, 91 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719455,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 214, 213, 107, 107 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719457,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 218, 217, 109, 109 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719466,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 236, 235, 118, 118 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719475,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 254, 253, 127, 127 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719489,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 282, 281, 141, 141 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719493,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 290, 289, 145, 145 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719502,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 308, 307, 154, 154 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719519,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 342, 341, 171, 171 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719526,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 356, 355, 178, 178 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719529,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 362, 361, 181, 181 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719545,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 394, 393, 197, 197 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719547,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 398, 397, 199, 199 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719556,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 416, 415, 208, 208 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719565,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 434, 433, 217, 217 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719580,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 464, 463, 232, 232 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719583,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 470, 469, 235, 235 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719597,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 498, 497, 249, 249 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719601,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 506, 505, 253, 253 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719618,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 540, 539, 270, 270 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719619,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 542, 541, 271, 271 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719634,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 572, 571, 286, 286 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719637,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 578, 577, 289, 289 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719647,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 598, 597, 299, 299 });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Awaygoals", "Date", "HomeGoals", "HomeTeamId", "LeagueId", "Referee", "Round", "Season", "Timestamp", "VenueId" },
                values: new object[,]
                {
                    { 719400, 104, 1, "2021-09-25T13:30:00+00:00", 3, 103, 52, "D. Siebert", "Regular Season - 6", 2021, 1632576600, 52 },
                    { 719401, 106, 0, "2021-09-26T13:30:00+00:00", 0, 105, 53, "C. Dingert", "Regular Season - 6", 2021, 1632663000, 53 },
                    { 719404, 112, 0, "2021-10-02T16:30:00+00:00", 3, 111, 56, "R. Hartmann", "Regular Season - 7", 2021, 1633192200, 56 },
                    { 719405, 114, 1, "2021-10-02T13:30:00+00:00", 2, 113, 57, "T. Welz", "Regular Season - 7", 2021, 1633181400, 57 },
                    { 719406, 116, 3, "2021-10-02T13:30:00+00:00", 1, 115, 58, "F. Willenborg", "Regular Season - 7", 2021, 1633181400, 58 },
                    { 719407, 118, 1, "2021-10-02T13:30:00+00:00", 3, 117, 59, "H. Osmers", "Regular Season - 7", 2021, 1633181400, 59 },
                    { 719408, 120, 2, "2021-10-03T13:30:00+00:00", 1, 119, 60, "T. Stieler", "Regular Season - 7", 2021, 1633267800, 60 },
                    { 719409, 122, 2, "2021-10-02T13:30:00+00:00", 1, 121, 61, "P. Ittrich", "Regular Season - 7", 2021, 1633181400, 61 },
                    { 719410, 124, 4, "2021-10-03T17:30:00+00:00", 0, 123, 62, "F. Zwayer", "Regular Season - 7", 2021, 1633282200, 62 },
                    { 719411, 126, 1, "2021-10-01T18:30:00+00:00", 3, 125, 63, "M. Jöllenbeck", "Regular Season - 7", 2021, 1633113000, 63 },
                    { 719412, 128, 1, "2021-10-16T13:30:00+00:00", 3, 127, 64, "D. Schlager", "Regular Season - 8", 2021, 1634391000, 64 },
                    { 719413, 130, 2, "2021-10-16T13:30:00+00:00", 1, 129, 65, "D. Aytekin", "Regular Season - 8", 2021, 1634391000, 65 },
                    { 719415, 134, 0, "2021-10-16T13:30:00+00:00", 2, 133, 67, "S. Stegemann", "Regular Season - 8", 2021, 1634391000, 67 }
                });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Awaygoals", "Date", "HomeGoals", "HomeTeamId", "LeagueId", "Referee", "Round", "Season", "Timestamp", "VenueId" },
                values: new object[,]
                {
                    { 719416, 136, 1, "2021-10-16T16:30:00+00:00", 1, 135, 68, "F. Brych", "Regular Season - 8", 2021, 1634401800, 68 },
                    { 719417, 138, 1, "2021-10-16T13:30:00+00:00", 1, 137, 69, "D. Siebert", "Regular Season - 8", 2021, 1634391000, 69 },
                    { 719418, 140, 0, "2021-10-15T18:30:00+00:00", 5, 139, 70, "T. Reichel", "Regular Season - 8", 2021, 1634322600, 70 },
                    { 719419, 142, 1, "2021-10-17T15:30:00+00:00", 1, 141, 71, "R. Schröder", "Regular Season - 8", 2021, 1634484600, 71 },
                    { 719420, 144, 1, "2021-10-16T13:30:00+00:00", 0, 143, 72, "B. Dankert", "Regular Season - 8", 2021, 1634391000, 72 },
                    { 719422, 148, 1, "2021-10-23T13:30:00+00:00", 4, 147, 74, "C. Dingert", "Regular Season - 9", 2021, 1634995800, 74 },
                    { 719423, 150, 2, "2021-10-23T13:30:00+00:00", 0, 149, 75, "T. Welz", "Regular Season - 9", 2021, 1634995800, 75 },
                    { 719424, 152, 1, "2021-10-24T15:30:00+00:00", 1, 151, 76, "F. Badstübner", "Regular Season - 9", 2021, 1635089400, 76 },
                    { 719425, 154, 1, "2021-10-22T18:30:00+00:00", 4, 153, 77, "R. Hartmann", "Regular Season - 9", 2021, 1634927400, 77 },
                    { 719426, 156, 0, "2021-10-23T16:30:00+00:00", 1, 155, 78, "B. Cortus", "Regular Season - 9", 2021, 1635006600, 78 },
                    { 719427, 158, 3, "2021-10-23T13:30:00+00:00", 1, 157, 79, "B. Brand", "Regular Season - 9", 2021, 1634995800, 79 },
                    { 719428, 160, 2, "2021-10-24T13:30:00+00:00", 2, 159, 80, "F. Zwayer", "Regular Season - 9", 2021, 1635082200, 80 },
                    { 719429, 162, 0, "2021-10-24T17:30:00+00:00", 2, 161, 81, "M. Fritz", "Regular Season - 9", 2021, 1635096600, 81 },
                    { 719430, 164, 0, "2021-10-30T13:30:00+00:00", 2, 163, 82, "M. Petersen", "Regular Season - 10", 2021, 1635600600, 82 },
                    { 719431, 166, 1, "2021-10-30T16:30:00+00:00", 1, 165, 83, "D. Schlager", "Regular Season - 10", 2021, 1635611400, 83 },
                    { 719432, 168, 2, "2021-10-30T13:30:00+00:00", 0, 167, 84, "D. Aytekin", "Regular Season - 10", 2021, 1635600600, 84 },
                    { 719434, 172, 1, "2021-10-31T16:30:00+00:00", 2, 171, 86, "T. Reichel", "Regular Season - 10", 2021, 1635697800, 86 },
                    { 719435, 174, 1, "2021-10-30T13:30:00+00:00", 3, 173, 87, "F. Brych", "Regular Season - 10", 2021, 1635600600, 87 },
                    { 719436, 176, 0, "2021-10-29T18:30:00+00:00", 2, 175, 88, "S. Jablonski", "Regular Season - 10", 2021, 1635532200, 88 },
                    { 719437, 178, 1, "2021-10-31T14:30:00+00:00", 4, 177, 89, "P. Ittrich", "Regular Season - 10", 2021, 1635690600, 89 },
                    { 719438, 180, 2, "2021-10-30T13:30:00+00:00", 1, 179, 90, "B. Dankert", "Regular Season - 10", 2021, 1635600600, 90 },
                    { 719440, 184, 1, "2021-11-06T17:30:00+00:00", 2, 183, 92, "F. Zwayer", "Regular Season - 11", 2021, 1636219800, 92 },
                    { 719441, 186, 0, "2021-11-06T14:30:00+00:00", 1, 185, 93, "M. Fritz", "Regular Season - 11", 2021, 1636209000, 93 },
                    { 719442, 188, 1, "2021-11-06T14:30:00+00:00", 0, 187, 94, "C. Dingert", "Regular Season - 11", 2021, 1636209000, 94 },
                    { 719443, 190, 1, "2021-11-05T19:30:00+00:00", 1, 189, 95, "R. Schröder", "Regular Season - 11", 2021, 1636140600, 95 },
                    { 719444, 192, 1, "2021-11-07T14:30:00+00:00", 1, 191, 96, "R. Hartmann", "Regular Season - 11", 2021, 1636295400, 96 },
                    { 719445, 194, 2, "2021-11-07T16:30:00+00:00", 2, 193, 97, "T. Stieler", "Regular Season - 11", 2021, 1636302600, 97 },
                    { 719446, 196, 0, "2021-11-06T14:30:00+00:00", 2, 195, 98, "F. Willenborg", "Regular Season - 11", 2021, 1636209000, 98 },
                    { 719447, 198, 2, "2021-11-07T18:30:00+00:00", 1, 197, 99, "D. Siebert", "Regular Season - 11", 2021, 1636309800, 99 },
                    { 719448, 200, 1, "2021-11-20T14:30:00+00:00", 2, 199, 100, "H. Osmers", "Regular Season - 12", 2021, 1637418600, 100 },
                    { 719449, 202, 0, "2021-11-20T14:30:00+00:00", 1, 201, 101, "D. Schlager", "Regular Season - 12", 2021, 1637418600, 101 },
                    { 719450, 204, 0, "2021-11-20T17:30:00+00:00", 2, 203, 102, "F. Brych", "Regular Season - 12", 2021, 1637429400, 102 },
                    { 719451, 206, 0, "2021-11-20T14:30:00+00:00", 4, 205, 103, "B. Brand", "Regular Season - 12", 2021, 1637418600, 103 },
                    { 719452, 208, 2, "2021-11-21T14:30:00+00:00", 0, 207, 104, "F. Badstübner", "Regular Season - 12", 2021, 1637505000, 104 },
                    { 719453, 210, 0, "2021-11-20T14:30:00+00:00", 2, 209, 105, "T. Welz", "Regular Season - 12", 2021, 1637418600, 105 },
                    { 719454, 212, 1, "2021-11-21T16:30:00+00:00", 1, 211, 106, "D. Aytekin", "Regular Season - 12", 2021, 1637512200, 106 },
                    { 719456, 216, 2, "2021-11-20T14:30:00+00:00", 2, 215, 108, "M. Petersen", "Regular Season - 12", 2021, 1637418600, 108 },
                    { 719458, 220, 3, "2021-11-28T16:30:00+00:00", 1, 219, 110, "B. Cortus", "Regular Season - 13", 2021, 1638117000, 110 },
                    { 719459, 222, 3, "2021-11-27T14:30:00+00:00", 1, 221, 111, "S. Jablonski", "Regular Season - 13", 2021, 1638023400, 111 },
                    { 719460, 224, 1, "2021-11-28T14:30:00+00:00", 2, 223, 112, "S. Stegemann", "Regular Season - 13", 2021, 1638109800, 112 },
                    { 719461, 226, 1, "2021-11-26T19:30:00+00:00", 2, 225, 113, "M. Jöllenbeck", "Regular Season - 13", 2021, 1637955000, 113 },
                    { 719462, 228, 1, "2021-11-27T14:30:00+00:00", 1, 227, 114, "F. Willenborg", "Regular Season - 13", 2021, 1638023400, 114 }
                });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Awaygoals", "Date", "HomeGoals", "HomeTeamId", "LeagueId", "Referee", "Round", "Season", "Timestamp", "VenueId" },
                values: new object[,]
                {
                    { 719463, 230, 1, "2021-11-27T14:30:00+00:00", 4, 229, 115, "R. Schröder", "Regular Season - 13", 2021, 1638023400, 115 },
                    { 719464, 232, 1, "2021-11-27T14:30:00+00:00", 2, 231, 116, "P. Ittrich", "Regular Season - 13", 2021, 1638023400, 116 },
                    { 719465, 234, 6, "2021-11-27T14:30:00+00:00", 3, 233, 117, "B. Dankert", "Regular Season - 13", 2021, 1638023400, 117 },
                    { 719467, 238, 1, "2021-12-04T14:30:00+00:00", 7, 237, 119, "T. Reichel", "Regular Season - 14", 2021, 1638628200, 119 },
                    { 719468, 240, 1, "2021-12-03T19:30:00+00:00", 2, 239, 120, "H. Osmers", "Regular Season - 14", 2021, 1638559800, 120 },
                    { 719469, 242, 6, "2021-12-05T16:30:00+00:00", 0, 241, 121, "R. Hartmann", "Regular Season - 14", 2021, 1638721800, 121 },
                    { 719470, 244, 2, "2021-12-05T14:30:00+00:00", 2, 243, 122, "B. Brand", "Regular Season - 14", 2021, 1638714600, 122 },
                    { 719471, 246, 2, "2021-12-04T14:30:00+00:00", 3, 245, 123, "D. Schlager", "Regular Season - 14", 2021, 1638628200, 123 },
                    { 719472, 248, 0, "2021-12-04T14:30:00+00:00", 3, 247, 124, "F. Badstübner", "Regular Season - 14", 2021, 1638628200, 124 },
                    { 719473, 250, 3, "2021-12-04T14:30:00+00:00", 2, 249, 125, "D. Aytekin", "Regular Season - 14", 2021, 1638628200, 125 },
                    { 719474, 252, 1, "2021-12-04T14:30:00+00:00", 1, 251, 126, "F. Brych", "Regular Season - 14", 2021, 1638628200, 126 },
                    { 719476, 256, 1, "2021-12-11T14:30:00+00:00", 4, 255, 128, "B. Dankert", "Regular Season - 15", 2021, 1639233000, 128 },
                    { 719477, 258, 2, "2021-12-11T17:30:00+00:00", 0, 257, 129, "S. Stegemann", "Regular Season - 15", 2021, 1639243800, 129 },
                    { 719478, 260, 2, "2021-12-12T16:30:00+00:00", 5, 259, 130, "M. Fritz", "Regular Season - 15", 2021, 1639326600, 130 },
                    { 719479, 262, 2, "2021-12-11T14:30:00+00:00", 1, 261, 131, "F. Willenborg", "Regular Season - 15", 2021, 1639233000, 131 },
                    { 719480, 264, 0, "2021-12-11T14:30:00+00:00", 2, 263, 132, "T. Welz", "Regular Season - 15", 2021, 1639233000, 132 },
                    { 719481, 266, 2, "2021-12-10T19:30:00+00:00", 0, 265, 133, "P. Ittrich", "Regular Season - 15", 2021, 1639164600, 133 },
                    { 719482, 268, 1, "2021-12-11T14:30:00+00:00", 1, 267, 134, "M. Jöllenbeck", "Regular Season - 15", 2021, 1639233000, 134 },
                    { 719483, 270, 0, "2021-12-12T14:30:00+00:00", 1, 269, 135, "S. Jablonski", "Regular Season - 15", 2021, 1639319400, 135 },
                    { 719484, 272, 0, "2021-12-15T19:30:00+00:00", 3, 271, 136, "D. Schlager", "Regular Season - 16", 2021, 1639596600, 136 },
                    { 719485, 274, 3, "2021-12-14T19:30:00+00:00", 2, 273, 137, "R. Hartmann", "Regular Season - 16", 2021, 1639510200, 137 },
                    { 719486, 276, 2, "2021-12-15T19:30:00+00:00", 2, 275, 138, "T. Stieler", "Regular Season - 16", 2021, 1639596600, 138 },
                    { 719487, 278, 0, "2021-12-15T19:30:00+00:00", 0, 277, 139, "D. Aytekin", "Regular Season - 16", 2021, 1639596600, 139 },
                    { 719488, 280, 3, "2021-12-15T17:30:00+00:00", 2, 279, 140, "M. Petersen", "Regular Season - 16", 2021, 1639589400, 140 },
                    { 719490, 284, 0, "2021-12-14T19:30:00+00:00", 4, 283, 142, "H. Osmers", "Regular Season - 16", 2021, 1639510200, 142 },
                    { 719491, 286, 1, "2021-12-15T19:30:00+00:00", 1, 285, 143, "F. Badstübner", "Regular Season - 16", 2021, 1639596600, 143 },
                    { 719492, 288, 0, "2021-12-14T19:30:00+00:00", 2, 287, 144, "B. Brand", "Regular Season - 16", 2021, 1639510200, 144 },
                    { 719494, 292, 2, "2021-12-18T14:30:00+00:00", 0, 291, 146, "F. Willenborg", "Regular Season - 17", 2021, 1639837800, 146 },
                    { 719495, 294, 0, "2021-12-18T14:30:00+00:00", 1, 293, 147, "F. Brych", "Regular Season - 17", 2021, 1639837800, 147 },
                    { 719496, 296, 1, "2021-12-19T14:30:00+00:00", 2, 295, 148, "B. Cortus", "Regular Season - 17", 2021, 1639924200, 148 },
                    { 719497, 298, 1, "2021-12-18T14:30:00+00:00", 1, 297, 149, "S. Jablonski", "Regular Season - 17", 2021, 1639837800, 149 },
                    { 719498, 300, 2, "2021-12-18T17:30:00+00:00", 3, 299, 150, "M. Fritz", "Regular Season - 17", 2021, 1639848600, 150 },
                    { 719499, 302, 0, "2021-12-19T16:30:00+00:00", 1, 301, 151, "B. Dankert", "Regular Season - 17", 2021, 1639931400, 151 },
                    { 719500, 304, 1, "2021-12-18T14:30:00+00:00", 0, 303, 152, "T. Reichel", "Regular Season - 17", 2021, 1639837800, 152 },
                    { 719501, 306, 0, "2021-12-18T14:30:00+00:00", 0, 305, 153, "S. Stegemann", "Regular Season - 17", 2021, 1639837800, 153 },
                    { 719503, 310, 1, "2022-01-08T14:30:00+00:00", 4, 309, 155, "D. Aytekin", "Regular Season - 18", 2021, 1641652200, 155 },
                    { 719504, 312, 3, "2022-01-08T17:30:00+00:00", 2, 311, 156, "R. Schröder", "Regular Season - 18", 2021, 1641663000, 156 },
                    { 719505, 314, 2, "2022-01-08T14:30:00+00:00", 2, 313, 157, "M. Jöllenbeck", "Regular Season - 18", 2021, 1641652200, 157 },
                    { 719506, 316, 2, "2022-01-08T14:30:00+00:00", 2, 315, 158, "H. Osmers", "Regular Season - 18", 2021, 1641652200, 158 },
                    { 719507, 318, 1, "2022-01-08T14:30:00+00:00", 3, 317, 159, "B. Cortus", "Regular Season - 18", 2021, 1641652200, 159 },
                    { 719508, 320, 3, "2022-01-09T14:30:00+00:00", 1, 319, 160, "T. Stieler", "Regular Season - 18", 2021, 1641738600, 160 },
                    { 719509, 322, 0, "2022-01-09T16:30:00+00:00", 1, 321, 161, "D. Schlager", "Regular Season - 18", 2021, 1641745800, 161 }
                });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Awaygoals", "Date", "HomeGoals", "HomeTeamId", "LeagueId", "Referee", "Round", "Season", "Timestamp", "VenueId" },
                values: new object[,]
                {
                    { 719510, 324, 0, "2022-01-08T14:30:00+00:00", 0, 323, 162, "F. Brych", "Regular Season - 18", 2021, 1641652200, 162 },
                    { 719511, 326, 1, "2022-01-14T19:30:00+00:00", 5, 325, 163, "F. Badstübner", "Regular Season - 19", 2021, 1642188600, 163 },
                    { 719512, 328, 0, "2022-01-15T14:30:00+00:00", 0, 327, 164, "R. Hartmann", "Regular Season - 19", 2021, 1642257000, 164 },
                    { 719513, 330, 1, "2022-01-15T14:30:00+00:00", 2, 329, 165, "M. Petersen", "Regular Season - 19", 2021, 1642257000, 165 },
                    { 719514, 332, 2, "2022-01-15T17:30:00+00:00", 1, 331, 166, "S. Stegemann", "Regular Season - 19", 2021, 1642267800, 166 },
                    { 719515, 334, 2, "2022-01-15T14:30:00+00:00", 0, 333, 167, "D. Schlager", "Regular Season - 19", 2021, 1642257000, 167 },
                    { 719516, 336, 0, "2022-01-15T14:30:00+00:00", 1, 335, 168, "F. Willenborg", "Regular Season - 19", 2021, 1642257000, 168 },
                    { 719517, 338, 1, "2022-01-16T14:30:00+00:00", 1, 337, 169, "S. Jablonski", "Regular Season - 19", 2021, 1642343400, 169 },
                    { 719518, 340, 2, "2022-01-16T16:30:00+00:00", 2, 339, 170, "C. Dingert", "Regular Season - 19", 2021, 1642350600, 170 },
                    { 719520, 344, 0, "2022-01-23T14:30:00+00:00", 2, 343, 172, "D. Siebert", "Regular Season - 20", 2021, 1642948200, 172 },
                    { 719521, 346, 2, "2022-01-21T19:30:00+00:00", 0, 345, 173, "T. Reichel", "Regular Season - 20", 2021, 1642793400, 173 },
                    { 719522, 348, 1, "2022-01-22T14:30:00+00:00", 5, 347, 174, "D. Schlager", "Regular Season - 20", 2021, 1642861800, 174 },
                    { 719523, 350, 2, "2022-01-22T14:30:00+00:00", 1, 349, 175, "F. Brych", "Regular Season - 20", 2021, 1642861800, 175 },
                    { 719524, 352, 0, "2022-01-22T14:30:00+00:00", 2, 351, 176, "T. Stieler", "Regular Season - 20", 2021, 1642861800, 176 },
                    { 719525, 354, 3, "2022-01-22T14:30:00+00:00", 2, 353, 177, "D. Aytekin", "Regular Season - 20", 2021, 1642861800, 177 },
                    { 719527, 358, 2, "2022-01-22T17:30:00+00:00", 2, 357, 179, "M. Jöllenbeck", "Regular Season - 20", 2021, 1642872600, 179 },
                    { 719528, 360, 1, "2022-01-22T14:30:00+00:00", 2, 359, 180, "R. Schröder", "Regular Season - 20", 2021, 1642861800, 180 },
                    { 719530, 364, 5, "2022-02-06T14:30:00+00:00", 2, 363, 182, "D. Siebert", "Regular Season - 21", 2021, 1644157800, 182 },
                    { 719531, 366, 1, "2022-02-06T16:30:00+00:00", 4, 365, 183, "M. Petersen", "Regular Season - 21", 2021, 1644165000, 183 },
                    { 719532, 368, 3, "2022-02-05T14:30:00+00:00", 2, 367, 184, "S. Stegemann", "Regular Season - 21", 2021, 1644071400, 184 },
                    { 719533, 370, 0, "2022-02-05T14:30:00+00:00", 2, 369, 185, "C. Dingert", "Regular Season - 21", 2021, 1644071400, 185 },
                    { 719534, 372, 0, "2022-02-05T14:30:00+00:00", 2, 371, 186, "H. Osmers", "Regular Season - 21", 2021, 1644071400, 186 },
                    { 719535, 374, 1, "2022-02-04T19:30:00+00:00", 1, 373, 187, "M. Fritz", "Regular Season - 21", 2021, 1644003000, 187 },
                    { 719536, 376, 1, "2022-02-05T14:30:00+00:00", 1, 375, 188, "B. Cortus", "Regular Season - 21", 2021, 1644071400, 188 },
                    { 719537, 378, 0, "2022-02-05T14:30:00+00:00", 1, 377, 189, "F. Brych", "Regular Season - 21", 2021, 1644071400, 189 },
                    { 719538, 380, 1, "2022-02-11T19:30:00+00:00", 3, 379, 190, "F. Badstübner", "Regular Season - 22", 2021, 1644607800, 190 },
                    { 719539, 382, 2, "2022-02-12T14:30:00+00:00", 0, 381, 191, "F. Willenborg", "Regular Season - 22", 2021, 1644676200, 191 },
                    { 719540, 384, 2, "2022-02-12T17:30:00+00:00", 4, 383, 192, "F. Brych", "Regular Season - 22", 2021, 1644687000, 192 },
                    { 719541, 386, 3, "2022-02-13T14:30:00+00:00", 0, 385, 193, "M. Jöllenbeck", "Regular Season - 22", 2021, 1644762600, 193 },
                    { 719542, 388, 2, "2022-02-12T14:30:00+00:00", 3, 387, 194, "T. Welz", "Regular Season - 22", 2021, 1644676200, 194 },
                    { 719543, 390, 1, "2022-02-12T14:30:00+00:00", 1, 389, 195, "D. Aytekin", "Regular Season - 22", 2021, 1644676200, 195 },
                    { 719544, 392, 0, "2022-02-13T16:30:00+00:00", 2, 391, 196, "R. Hartmann", "Regular Season - 22", 2021, 1644769800, 196 },
                    { 719546, 396, 1, "2022-02-12T14:30:00+00:00", 2, 395, 198, "D. Schlager", "Regular Season - 22", 2021, 1644676200, 198 },
                    { 719548, 400, 0, "2022-02-20T16:30:00+00:00", 6, 399, 200, "M. Fritz", "Regular Season - 23", 2021, 1645374600, 200 },
                    { 719549, 402, 2, "2022-02-19T14:30:00+00:00", 1, 401, 201, "F. Zwayer", "Regular Season - 23", 2021, 1645281000, 201 },
                    { 719550, 404, 1, "2022-02-19T14:30:00+00:00", 1, 403, 202, "H. Osmers", "Regular Season - 23", 2021, 1645281000, 202 },
                    { 719551, 406, 2, "2022-02-18T19:30:00+00:00", 3, 405, 203, "B. Cortus", "Regular Season - 23", 2021, 1645212600, 203 },
                    { 719552, 408, 2, "2022-02-19T14:30:00+00:00", 1, 407, 204, "D. Siebert", "Regular Season - 23", 2021, 1645281000, 204 },
                    { 719553, 410, 6, "2022-02-20T18:30:00+00:00", 1, 409, 205, "P. Ittrich", "Regular Season - 23", 2021, 1645381800, 205 },
                    { 719554, 412, 0, "2022-02-19T14:30:00+00:00", 1, 411, 206, "D. Schlager", "Regular Season - 23", 2021, 1645281000, 206 },
                    { 719555, 414, 0, "2022-02-19T17:30:00+00:00", 1, 413, 207, "C. Dingert", "Regular Season - 23", 2021, 1645291800, 207 },
                    { 719557, 418, 0, "2022-02-26T14:30:00+00:00", 3, 417, 209, "M. Petersen", "Regular Season - 24", 2021, 1645885800, 209 }
                });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Awaygoals", "Date", "HomeGoals", "HomeTeamId", "LeagueId", "Referee", "Round", "Season", "Timestamp", "VenueId" },
                values: new object[,]
                {
                    { 719558, 420, 1, "2022-02-26T14:30:00+00:00", 3, 419, 210, "B. Dankert", "Regular Season - 24", 2021, 1645885800, 210 },
                    { 719559, 422, 2, "2022-02-26T14:30:00+00:00", 2, 421, 211, "T. Reichel", "Regular Season - 24", 2021, 1645885800, 211 },
                    { 719560, 424, 0, "2022-02-26T14:30:00+00:00", 3, 423, 212, "S. Jablonski", "Regular Season - 24", 2021, 1645885800, 212 },
                    { 719561, 426, 1, "2022-02-25T19:30:00+00:00", 2, 425, 213, "M. Jöllenbeck", "Regular Season - 24", 2021, 1645817400, 213 },
                    { 719562, 428, 1, "2022-02-27T16:30:00+00:00", 1, 427, 214, "D. Aytekin", "Regular Season - 24", 2021, 1645979400, 214 },
                    { 719563, 430, 1, "2022-02-27T14:30:00+00:00", 0, 429, 215, "F. Brych", "Regular Season - 24", 2021, 1645972200, 215 },
                    { 719564, 432, 1, "2022-02-26T14:30:00+00:00", 1, 431, 216, "R. Schröder", "Regular Season - 24", 2021, 1645885800, 216 },
                    { 719566, 436, 1, "2022-03-05T14:30:00+00:00", 1, 435, 218, "F. Zwayer", "Regular Season - 25", 2021, 1646490600, 218 },
                    { 719567, 438, 0, "2022-03-05T14:30:00+00:00", 1, 437, 219, "P. Ittrich", "Regular Season - 25", 2021, 1646490600, 219 },
                    { 719568, 440, 2, "2022-03-05T17:30:00+00:00", 3, 439, 220, "C. Dingert", "Regular Season - 25", 2021, 1646501400, 220 },
                    { 719569, 442, 1, "2022-03-16T17:30:00+00:00", 0, 441, 221, "S. Stegemann", "Regular Season - 25", 2021, 1647451800, 221 },
                    { 719570, 444, 4, "2022-03-05T14:30:00+00:00", 1, 443, 222, "H. Osmers", "Regular Season - 25", 2021, 1646490600, 222 },
                    { 719571, 446, 1, "2022-03-04T19:30:00+00:00", 0, 445, 223, "F. Brych", "Regular Season - 25", 2021, 1646422200, 223 },
                    { 719572, 448, 1, "2022-03-06T16:30:00+00:00", 0, 447, 224, "M. Fritz", "Regular Season - 25", 2021, 1646584200, 224 },
                    { 719573, 450, 1, "2022-03-05T14:30:00+00:00", 2, 449, 225, "D. Schlager", "Regular Season - 25", 2021, 1646490600, 225 },
                    { 719574, 452, 0, "2022-03-13T16:30:00+00:00", 1, 451, 226, "B. Dankert", "Regular Season - 26", 2021, 1647189000, 226 },
                    { 719575, 454, 1, "2022-03-13T16:30:00+00:00", 2, 453, 227, "M. Fritz", "Regular Season - 26", 2021, 1647189000, 227 },
                    { 719576, 456, 1, "2022-03-13T14:30:00+00:00", 0, 455, 228, "S. Stegemann", "Regular Season - 26", 2021, 1647181800, 228 },
                    { 719577, 458, 1, "2022-03-12T14:30:00+00:00", 1, 457, 229, "R. Hartmann", "Regular Season - 26", 2021, 1647095400, 229 },
                    { 719578, 460, 0, "2022-03-12T17:30:00+00:00", 2, 459, 230, "F. Badstübner", "Regular Season - 26", 2021, 1647106200, 230 },
                    { 719579, 462, 2, "2022-03-12T14:30:00+00:00", 3, 461, 231, "M. Petersen", "Regular Season - 26", 2021, 1647095400, 231 },
                    { 719581, 466, 1, "2022-04-06T16:30:00+00:00", 2, 465, 233, "M. Jöllenbeck", "Regular Season - 26", 2021, 1649262600, 233 },
                    { 719582, 468, 6, "2022-03-13T18:30:00+00:00", 1, 467, 234, "S. Jablonski", "Regular Season - 26", 2021, 1647196200, 234 },
                    { 719584, 472, 0, "2022-03-20T14:30:00+00:00", 0, 471, 236, "C. Dingert", "Regular Season - 27", 2021, 1647786600, 236 },
                    { 719585, 474, 2, "2022-03-20T16:30:00+00:00", 0, 473, 237, "F. Brych", "Regular Season - 27", 2021, 1647793800, 237 },
                    { 719586, 476, 2, "2022-03-19T14:30:00+00:00", 3, 475, 238, "P. Ittrich", "Regular Season - 27", 2021, 1647700200, 238 },
                    { 719587, 478, 0, "2022-03-19T14:30:00+00:00", 4, 477, 239, "F. Zwayer", "Regular Season - 27", 2021, 1647700200, 239 },
                    { 719588, 480, 0, "2022-03-19T14:30:00+00:00", 3, 479, 240, "D. Schlager", "Regular Season - 27", 2021, 1647700200, 240 },
                    { 719589, 482, 1, "2022-03-20T18:30:00+00:00", 1, 481, 241, "D. Siebert", "Regular Season - 27", 2021, 1647801000, 241 },
                    { 719590, 484, 2, "2022-03-18T19:30:00+00:00", 0, 483, 242, "B. Cortus", "Regular Season - 27", 2021, 1647631800, 242 },
                    { 719591, 486, 0, "2022-03-19T14:30:00+00:00", 0, 485, 243, "T. Reichel", "Regular Season - 27", 2021, 1647700200, 243 },
                    { 719592, 488, 4, "2022-04-02T16:30:00+00:00", 1, 487, 244, "M. Fritz", "Regular Season - 28", 2021, 1648917000, 244 },
                    { 719593, 490, 0, "2022-04-02T13:30:00+00:00", 0, 489, 245, "B. Dankert", "Regular Season - 28", 2021, 1648906200, 245 },
                    { 719594, 492, 1, "2022-04-02T13:30:00+00:00", 2, 491, 246, "M. Jöllenbeck", "Regular Season - 28", 2021, 1648906200, 246 },
                    { 719595, 494, 0, "2022-04-01T18:30:00+00:00", 1, 493, 247, "F. Badstübner", "Regular Season - 28", 2021, 1648837800, 247 },
                    { 719596, 496, 1, "2022-04-03T15:30:00+00:00", 1, 495, 248, "D. Schlager", "Regular Season - 28", 2021, 1648999800, 248 },
                    { 719598, 500, 2, "2022-04-02T13:30:00+00:00", 1, 499, 250, "D. Siebert", "Regular Season - 28", 2021, 1648906200, 250 },
                    { 719599, 502, 0, "2022-04-03T13:30:00+00:00", 3, 501, 251, "S. Stegemann", "Regular Season - 28", 2021, 1648992600, 251 },
                    { 719600, 504, 1, "2022-04-02T13:30:00+00:00", 1, 503, 252, "P. Ittrich", "Regular Season - 28", 2021, 1648906200, 252 },
                    { 719602, 508, 0, "2022-04-10T17:30:00+00:00", 3, 507, 254, "B. Dankert", "Regular Season - 29", 2021, 1649611800, 254 },
                    { 719603, 510, 0, "2022-04-09T13:30:00+00:00", 4, 509, 255, "B. Brand", "Regular Season - 29", 2021, 1649511000, 255 },
                    { 719604, 512, 2, "2022-04-10T15:30:00+00:00", 1, 511, 256, "F. Brych", "Regular Season - 29", 2021, 1649604600, 256 }
                });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Awaygoals", "Date", "HomeGoals", "HomeTeamId", "LeagueId", "Referee", "Round", "Season", "Timestamp", "VenueId" },
                values: new object[,]
                {
                    { 719605, 514, 2, "2022-04-08T18:30:00+00:00", 0, 513, 257, "H. Osmers", "Regular Season - 29", 2021, 1649442600, 257 },
                    { 719606, 516, 4, "2022-04-09T16:30:00+00:00", 1, 515, 258, "S. Jablonski", "Regular Season - 29", 2021, 1649521800, 258 },
                    { 719607, 518, 2, "2022-04-09T13:30:00+00:00", 3, 517, 259, "M. Petersen", "Regular Season - 29", 2021, 1649511000, 259 },
                    { 719608, 520, 0, "2022-04-10T13:30:00+00:00", 0, 519, 260, "F. Zwayer", "Regular Season - 29", 2021, 1649597400, 260 },
                    { 719609, 522, 2, "2022-04-09T13:30:00+00:00", 0, 521, 261, "T. Stieler", "Regular Season - 29", 2021, 1649511000, 261 },
                    { 719610, 524, 1, "2022-04-16T13:30:00+00:00", 6, 523, 262, "R. Schröder", "Regular Season - 30", 2021, 1650115800, 262 },
                    { 719611, 526, 1, "2022-04-17T17:30:00+00:00", 0, 525, 263, "D. Siebert", "Regular Season - 30", 2021, 1650216600, 263 },
                    { 719612, 528, 0, "2022-04-17T15:30:00+00:00", 2, 527, 264, "F. Willenborg", "Regular Season - 30", 2021, 1650209400, 264 },
                    { 719613, 530, 3, "2022-04-16T16:30:00+00:00", 1, 529, 265, "D. Aytekin", "Regular Season - 30", 2021, 1650126600, 265 },
                    { 719614, 532, 0, "2022-04-16T13:30:00+00:00", 3, 531, 266, "S. Stegemann", "Regular Season - 30", 2021, 1650115800, 266 },
                    { 719615, 534, 0, "2022-04-17T15:30:00+00:00", 0, 533, 267, "F. Zwayer", "Regular Season - 30", 2021, 1650209400, 267 },
                    { 719616, 536, 0, "2022-04-16T13:30:00+00:00", 0, 535, 268, "F. Badstübner", "Regular Season - 30", 2021, 1650115800, 268 },
                    { 719617, 538, 1, "2022-04-16T13:30:00+00:00", 0, 537, 269, "M. Fritz", "Regular Season - 30", 2021, 1650115800, 269 },
                    { 719620, 544, 2, "2022-04-23T13:30:00+00:00", 1, 543, 272, "D. Schlager", "Regular Season - 31", 2021, 1650720600, 272 },
                    { 719621, 546, 0, "2022-04-22T18:30:00+00:00", 5, 545, 273, "H. Osmers", "Regular Season - 31", 2021, 1650652200, 273 },
                    { 719622, 548, 2, "2022-04-23T13:30:00+00:00", 2, 547, 274, "S. Jablonski", "Regular Season - 31", 2021, 1650720600, 274 },
                    { 719623, 550, 3, "2022-04-23T13:30:00+00:00", 3, 549, 275, "B. Brand", "Regular Season - 31", 2021, 1650720600, 275 },
                    { 719624, 552, 0, "2022-04-24T15:30:00+00:00", 2, 551, 276, "F. Brych", "Regular Season - 31", 2021, 1650814200, 276 },
                    { 719625, 554, 1, "2022-04-23T13:30:00+00:00", 3, 553, 277, "T. Stieler", "Regular Season - 31", 2021, 1650720600, 277 },
                    { 719626, 556, 2, "2022-04-24T13:30:00+00:00", 0, 555, 278, "B. Dankert", "Regular Season - 31", 2021, 1650807000, 278 },
                    { 719627, 558, 4, "2022-04-23T13:30:00+00:00", 1, 557, 279, "T. Reichel", "Regular Season - 31", 2021, 1650720600, 279 },
                    { 719628, 560, 4, "2022-04-30T13:30:00+00:00", 3, 559, 280, "R. Hartmann", "Regular Season - 32", 2021, 1651325400, 280 },
                    { 719629, 562, 0, "2022-05-02T18:30:00+00:00", 2, 561, 281, "B. Cortus", "Regular Season - 32", 2021, 1651516200, 281 },
                    { 719630, 564, 1, "2022-04-29T18:30:00+00:00", 1, 563, 282, "P. Ittrich", "Regular Season - 32", 2021, 1651257000, 282 },
                    { 719631, 566, 1, "2022-05-02T18:30:00+00:00", 3, 565, 283, "M. Petersen", "Regular Season - 32", 2021, 1651516200, 283 },
                    { 719632, 568, 1, "2022-04-30T13:30:00+00:00", 1, 567, 284, "S. Jablonski", "Regular Season - 32", 2021, 1651325400, 284 },
                    { 719633, 570, 4, "2022-04-30T16:30:00+00:00", 3, 569, 285, "M. Fritz", "Regular Season - 32", 2021, 1651336200, 285 },
                    { 719635, 574, 4, "2022-04-30T13:30:00+00:00", 1, 573, 287, "R. Schröder", "Regular Season - 32", 2021, 1651325400, 287 },
                    { 719636, 576, 1, "2022-04-30T13:30:00+00:00", 1, 575, 288, "D. Aytekin", "Regular Season - 32", 2021, 1651325400, 288 },
                    { 719638, 580, 0, "2022-05-08T17:30:00+00:00", 4, 579, 290, "B. Dankert", "Regular Season - 33", 2021, 1652031000, 290 },
                    { 719639, 582, 1, "2022-05-08T13:30:00+00:00", 1, 581, 291, "F. Zwayer", "Regular Season - 33", 2021, 1652016600, 291 },
                    { 719640, 584, 4, "2022-05-07T13:30:00+00:00", 1, 583, 292, "F. Brych", "Regular Season - 33", 2021, 1651930200, 292 },
                    { 719641, 586, 4, "2022-05-07T13:30:00+00:00", 2, 585, 293, "F. Willenborg", "Regular Season - 33", 2021, 1651930200, 293 },
                    { 719642, 588, 2, "2022-05-07T16:30:00+00:00", 1, 587, 294, "P. Ittrich", "Regular Season - 33", 2021, 1651941000, 294 },
                    { 719643, 590, 1, "2022-05-07T13:30:00+00:00", 0, 589, 295, "T. Stieler", "Regular Season - 33", 2021, 1651930200, 295 },
                    { 719644, 592, 1, "2022-05-06T18:30:00+00:00", 2, 591, 296, "R. Schröder", "Regular Season - 33", 2021, 1651861800, 296 },
                    { 719645, 594, 3, "2022-05-07T13:30:00+00:00", 1, 593, 297, "C. Dingert", "Regular Season - 33", 2021, 1651930200, 297 },
                    { 719646, 596, 1, "2022-05-14T13:30:00+00:00", 2, 595, 298, "T. Stieler", "Regular Season - 34", 2021, 1652535000, 298 },
                    { 719648, 600, 1, "2022-05-14T13:30:00+00:00", 2, 599, 300, "S. Jablonski", "Regular Season - 34", 2021, 1652535000, 300 },
                    { 719649, 602, 2, "2022-05-14T13:30:00+00:00", 3, 601, 301, "M. Fritz", "Regular Season - 34", 2021, 1652535000, 301 },
                    { 719650, 604, 1, "2022-05-14T13:30:00+00:00", 5, 603, 302, "H. Osmers", "Regular Season - 34", 2021, 1652535000, 302 },
                    { 719651, 606, 1, "2022-05-14T13:30:00+00:00", 2, 605, 303, "R. Schröder", "Regular Season - 34", 2021, 1652535000, 303 }
                });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Awaygoals", "Date", "HomeGoals", "HomeTeamId", "LeagueId", "Referee", "Round", "Season", "Timestamp", "VenueId" },
                values: new object[,]
                {
                    { 719652, 608, 2, "2022-05-14T13:30:00+00:00", 2, 607, 304, "M. Petersen", "Regular Season - 34", 2021, 1652535000, 304 },
                    { 719653, 610, 1, "2022-05-14T13:30:00+00:00", 2, 609, 305, "T. Reichel", "Regular Season - 34", 2021, 1652535000, 305 },
                    { 719654, 612, 1, "2022-05-14T13:30:00+00:00", 1, 611, 306, "D. Siebert", "Regular Season - 34", 2021, 1652535000, 306 },
                    { 862167, 614, 1, "2022-05-19T18:30:00+00:00", 0, 613, 307, "H. Osmers", "Relegation Round", 2021, 1652985000, 307 },
                    { 862168, 616, 2, "2022-05-23T18:30:00+00:00", 0, 615, 308, "D. Aytekin", "Relegation Round", 2021, 1653330600, 308 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719350);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719351);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719352);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719353);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719354);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719355);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719356);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719357);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719359);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719360);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719361);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719362);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719363);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719364);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719365);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719366);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719368);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719369);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719370);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719371);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719372);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719373);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719374);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719375);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719377);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719378);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719379);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719380);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719381);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719382);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719383);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719384);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719386);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719387);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719388);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719389);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719390);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719391);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719392);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719393);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719394);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719395);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719396);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719397);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719398);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719399);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719400);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719401);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719404);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719405);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719406);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719407);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719408);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719409);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719410);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719411);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719412);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719413);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719415);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719416);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719417);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719418);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719419);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719420);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719422);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719423);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719424);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719425);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719426);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719427);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719428);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719429);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719430);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719431);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719432);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719434);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719435);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719436);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719437);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719438);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719440);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719441);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719442);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719443);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719444);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719445);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719446);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719447);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719448);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719449);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719450);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719451);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719452);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719453);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719454);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719456);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719458);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719459);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719460);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719461);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719462);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719463);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719464);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719465);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719467);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719468);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719469);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719470);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719471);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719472);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719473);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719474);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719476);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719477);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719478);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719479);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719480);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719481);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719482);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719483);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719484);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719485);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719486);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719487);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719488);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719490);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719491);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719492);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719494);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719495);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719496);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719497);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719498);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719499);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719500);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719501);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719503);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719504);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719505);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719506);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719507);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719508);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719509);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719510);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719511);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719512);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719513);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719514);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719515);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719516);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719517);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719518);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719520);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719521);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719522);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719523);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719524);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719525);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719527);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719528);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719530);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719531);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719532);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719533);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719534);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719535);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719536);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719537);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719538);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719539);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719540);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719541);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719542);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719543);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719544);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719546);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719548);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719549);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719550);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719551);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719552);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719553);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719554);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719555);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719557);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719558);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719559);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719560);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719561);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719562);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719563);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719564);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719566);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719567);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719568);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719569);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719570);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719571);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719572);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719573);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719574);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719575);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719576);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719577);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719578);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719579);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719581);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719582);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719584);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719585);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719586);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719587);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719588);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719589);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719590);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719591);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719592);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719593);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719594);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719595);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719596);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719598);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719599);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719600);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719602);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719603);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719604);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719605);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719606);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719607);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719608);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719609);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719610);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719611);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719612);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719613);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719614);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719615);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719616);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719617);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719620);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719621);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719622);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719623);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719624);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719625);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719626);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719627);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719628);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719629);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719630);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719631);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719632);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719633);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719635);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719636);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719638);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719639);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719640);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719641);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719642);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719643);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719644);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719645);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719646);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719648);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719649);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719650);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719651);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719652);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719653);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719654);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 862167);

            migrationBuilder.DeleteData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 862168);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719349,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 4, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719358,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 6, 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719367,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 8, 7, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719376,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 10, 9, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719385,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 12, 11, 6, 6 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719402,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 14, 13, 7, 7 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719403,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 16, 15, 8, 8 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719414,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 18, 17, 9, 9 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719421,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 20, 19, 10, 10 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719433,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 22, 21, 11, 11 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719439,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 24, 23, 12, 12 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719455,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 26, 25, 13, 13 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719457,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 28, 27, 14, 14 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719466,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 30, 29, 15, 15 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719475,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 32, 31, 16, 16 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719489,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 34, 33, 17, 17 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719493,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 36, 35, 18, 18 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719502,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 38, 37, 19, 19 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719519,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 40, 39, 20, 20 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719526,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 42, 41, 21, 21 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719529,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 44, 43, 22, 22 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719545,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 46, 45, 23, 23 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719547,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 48, 47, 24, 24 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719556,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 50, 49, 25, 25 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719565,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 52, 51, 26, 26 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719580,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 54, 53, 27, 27 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719583,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 56, 55, 28, 28 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719597,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 58, 57, 29, 29 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719601,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 60, 59, 30, 30 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719618,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 62, 61, 31, 31 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719619,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 64, 63, 32, 32 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719634,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 66, 65, 33, 33 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719637,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 68, 67, 34, 34 });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 719647,
                columns: new[] { "AwayTeamId", "HomeTeamId", "LeagueId", "VenueId" },
                values: new object[] { 70, 69, 35, 35 });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Awaygoals", "Date", "HomeGoals", "HomeTeamId", "LeagueId", "Referee", "Round", "Season", "Timestamp", "VenueId" },
                values: new object[,]
                {
                    { 705941, 2, 3, "2021-08-17T18:30:00+00:00", 1, 1, 1, "S. Stegemann", "Final", 2021, 1629225000, 1 },
                    { 723341, 72, 12, "2021-08-25T18:15:00+00:00", 0, 71, 36, "N. Winter", "1st Round", 2021, 1629915300, 36 },
                    { 736012, 74, 2, "2021-07-17T14:00:00+00:00", 3, 73, 37, null, "Club Friendlies 1", 2021, 1626530400, 37 },
                    { 736024, 76, 2, "2021-07-24T14:30:00+00:00", 2, 75, 38, "T. Reichel", "Club Friendlies 1", 2021, 1627137000, 38 },
                    { 736031, 78, 2, "2021-07-28T16:00:00+00:00", 0, 77, 39, "R. Hartmann", "Club Friendlies 1", 2021, 1627488000, 39 },
                    { 736039, 80, 3, "2021-07-31T14:30:00+00:00", 0, 79, 40, "F. Brych", "Club Friendlies 1", 2021, 1627741800, 40 },
                    { 787562, 82, 3, "2021-09-14T19:00:00+00:00", 0, 81, 41, "M. Oliver", "Group Stage - 1", 2021, 1631646000, 41 },
                    { 787586, 84, 0, "2021-09-29T19:00:00+00:00", 5, 83, 42, "M. Guida", "Group Stage - 2", 2021, 1632942000, 42 }
                });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Awaygoals", "Date", "HomeGoals", "HomeTeamId", "LeagueId", "Referee", "Round", "Season", "Timestamp", "VenueId" },
                values: new object[,]
                {
                    { 787602, 86, 4, "2021-10-20T19:00:00+00:00", 0, 85, 43, "O. Hațegan", "Group Stage - 3", 2021, 1634756400, 43 },
                    { 787610, 88, 2, "2021-11-02T20:00:00+00:00", 5, 87, 44, "S. Marciniak", "Group Stage - 4", 2021, 1635883200, 44 },
                    { 787624, 90, 2, "2021-11-23T17:45:00+00:00", 1, 89, 45, "H. Meler", "Group Stage - 5", 2021, 1637689500, 45 },
                    { 787650, 92, 0, "2021-12-08T20:00:00+00:00", 3, 91, 46, "O. Hațegan", "Group Stage - 6", 2021, 1638993600, 46 },
                    { 788043, 94, 0, "2021-10-27T18:45:00+00:00", 5, 93, 47, "T. Stieler", "2nd Round", 2021, 1635360300, 47 },
                    { 816244, 96, 1, "2022-02-16T20:00:00+00:00", 1, 95, 48, "M. Oliver", "Round of 16", 2021, 1645041600, 48 },
                    { 816245, 98, 1, "2022-03-08T20:00:00+00:00", 7, 97, 49, "C. Turpin", "Round of 16", 2021, 1646769600, 49 },
                    { 851370, 100, 0, "2022-04-06T19:00:00+00:00", 1, 99, 50, "A. Taylor", "Quarter-finals", 2021, 1649271600, 50 },
                    { 851371, 102, 1, "2022-04-12T19:00:00+00:00", 1, 101, 51, "S. Vinčić", "Quarter-finals", 2021, 1649790000, 51 }
                });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LeagueId", "Logo", "Name" },
                values: new object[] { 529, "https://media.api-sports.io/football/leagues/529.png", "Super Cup" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "LeagueId", "Logo", "Name" },
                values: new object[] { 81, "https://media.api-sports.io/football/leagues/81.png", "DFB Pokal" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 667, "https://media.api-sports.io/football/leagues/667.png", "Friendlies Clubs" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 667, "https://media.api-sports.io/football/leagues/667.png", "Friendlies Clubs" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 667, "https://media.api-sports.io/football/leagues/667.png", "Friendlies Clubs" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 667, "https://media.api-sports.io/football/leagues/667.png", "Friendlies Clubs" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 2, "https://media.api-sports.io/football/leagues/2.png", "UEFA Champions League" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 2, "https://media.api-sports.io/football/leagues/2.png", "UEFA Champions League" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 2, "https://media.api-sports.io/football/leagues/2.png", "UEFA Champions League" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 2, "https://media.api-sports.io/football/leagues/2.png", "UEFA Champions League" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 2, "https://media.api-sports.io/football/leagues/2.png", "UEFA Champions League" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 2, "https://media.api-sports.io/football/leagues/2.png", "UEFA Champions League" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "LeagueId", "Logo", "Name" },
                values: new object[] { 81, "https://media.api-sports.io/football/leagues/81.png", "DFB Pokal" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 2, "https://media.api-sports.io/football/leagues/2.png", "UEFA Champions League" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 2, "https://media.api-sports.io/football/leagues/2.png", "UEFA Champions League" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 2, "https://media.api-sports.io/football/leagues/2.png", "UEFA Champions League" });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[] { "World", null, 2, "https://media.api-sports.io/football/leagues/2.png", "UEFA Champions League" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/1630.png", "Bremer Sv", 1630 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/194.png", "Ajax", 194 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/492.png", "Napoli", 492 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/529.png", "Barcelona", 529 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/572.png", "Dynamo Kyiv", 572 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/211.png", "Benfica", 211 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/211.png", "Benfica", 211 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/572.png", "Dynamo Kyiv", 572 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/529.png", "Barcelona", 529 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/571.png", "Red Bull Salzburg", 571 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/571.png", "Red Bull Salzburg", 571 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/533.png", "Villarreal", 533 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Logo", "Name", "TeamId" },
                values: new object[] { "https://media.api-sports.io/football/teams/533.png", "Villarreal", 533 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Dortmund", "Signal-Iduna-Park", 702 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Leipzig", "Red Bull Arena", 738 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Fürth", "Sportpark Ronhof Thomas Sommer", 718 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Leverkusen", "BayArena", 699 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Berlin", "Stadion An der Alten Försterei", 748 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Augsburg", "WWK Arena", 698 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Dortmund", "Signal-Iduna-Park", 702 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Stuttgart", "Mercedes-Benz-Arena", 750 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Köln", "RheinEnergieStadion", 731 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Berlin", "Olympiastadion Berlin", 694 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Bochum", "Vonovia Ruhrstadion", 751 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Frankfurt am Main", "Deutsche Bank Park", 10491 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Sinsheim", "PreZero Arena", 724 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Freiburg im Breisgau", "Europa-Park Stadion", 12717 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Bielefeld", "SchücoArena", 697 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Mainz", "MEWA ARENA", 11899 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Wolfsburg", "VOLKSWAGEN ARENA", 752 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Bremen", "wohninvest WESERSTADION", 755 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Villingen-Schwenningen", "MS Technologie Arena", null });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Barcelona", "Camp Nou", 1462 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Lisboa", "Estádio do Sport Lisboa e Benfica", null });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Kiev", "NSK Olimpijs'kyj", null });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Wals-Siezenheim", "Red Bull Arena", 148 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "Villarreal", "Estadio de la Cerámica", 1498 });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "City", "Name", "VenueId" },
                values: new object[] { "München", "Allianz Arena", 700 });
        }
    }
}
