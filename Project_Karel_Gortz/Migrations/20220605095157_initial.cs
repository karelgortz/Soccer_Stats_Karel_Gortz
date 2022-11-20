using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Karel_Gortz.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeagueDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VenueDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenueId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FixtureDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Referee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Season = table.Column<int>(type: "int", nullable: true),
                    Round = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<int>(type: "int", nullable: true),
                    HomeGoals = table.Column<int>(type: "int", nullable: true),
                    Awaygoals = table.Column<int>(type: "int", nullable: true),
                    LeagueDbId = table.Column<int>(type: "int", nullable: true),
                    VenueDbId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixtureDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FixtureDb_LeagueDb_LeagueDbId",
                        column: x => x.LeagueDbId,
                        principalTable: "LeagueDb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FixtureDb_VenueDb_VenueDbId",
                        column: x => x.VenueDbId,
                        principalTable: "VenueDb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TeamDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FixtureDbId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamDb_FixtureDb_FixtureDbId",
                        column: x => x.FixtureDbId,
                        principalTable: "FixtureDb",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "FixtureDb",
                columns: new[] { "Id", "Awaygoals", "Date", "HomeGoals", "LeagueDbId", "Referee", "Round", "Season", "Timestamp", "VenueDbId" },
                values: new object[,]
                {
                    { 719349, 1, "2021-08-13T18:30:00+00:00", 1, null, "M. Fritz", "Regular Season - 1", 2021, 1628879400, null },
                    { 719358, 2, "2021-08-22T15:30:00+00:00", 3, null, "M. Petersen", "Regular Season - 2", 2021, 1629646200, null },
                    { 719367, 0, "2021-08-28T16:30:00+00:00", 5, null, "S. Jablonski", "Regular Season - 3", 2021, 1630168200, null },
                    { 719376, 4, "2021-09-11T16:30:00+00:00", 1, null, "D. Aytekin", "Regular Season - 4", 2021, 1631377800, null },
                    { 719385, 0, "2021-09-18T13:30:00+00:00", 7, null, "T. Welz", "Regular Season - 5", 2021, 1631971800, null },
                    { 719402, 3, "2021-09-24T18:30:00+00:00", 1, null, "R. Schröder", "Regular Season - 6", 2021, 1632508200, null },
                    { 719403, 2, "2021-10-03T15:30:00+00:00", 1, null, "F. Badstübner", "Regular Season - 7", 2021, 1633275000, null },
                    { 719414, 5, "2021-10-17T13:30:00+00:00", 1, null, "S. Jablonski", "Regular Season - 8", 2021, 1634477400, null },
                    { 719421, 0, "2021-10-23T13:30:00+00:00", 4, null, "M. Jöllenbeck", "Regular Season - 9", 2021, 1634995800, null },
                    { 719433, 5, "2021-10-30T13:30:00+00:00", 2, null, "H. Osmers", "Regular Season - 10", 2021, 1635600600, null },
                    { 719439, 1, "2021-11-06T14:30:00+00:00", 2, null, "S. Stegemann", "Regular Season - 11", 2021, 1636209000, null },
                    { 719455, 1, "2021-11-19T19:30:00+00:00", 2, null, "D. Siebert", "Regular Season - 12", 2021, 1637350200, null },
                    { 719457, 0, "2021-11-27T17:30:00+00:00", 1, null, "M. Fritz", "Regular Season - 13", 2021, 1638034200, null },
                    { 719466, 3, "2021-12-04T17:30:00+00:00", 2, null, "F. Zwayer", "Regular Season - 14", 2021, 1638639000, null },
                    { 719475, 1, "2021-12-11T14:30:00+00:00", 2, null, "B. Cortus", "Regular Season - 15", 2021, 1639233000, null },
                    { 719489, 5, "2021-12-14T17:30:00+00:00", 0, null, "R. Schröder", "Regular Season - 16", 2021, 1639503000, null },
                    { 719493, 0, "2021-12-17T19:30:00+00:00", 4, null, "T. Welz", "Regular Season - 17", 2021, 1639769400, null },
                    { 719502, 2, "2022-01-07T19:30:00+00:00", 1, null, "D. Siebert", "Regular Season - 18", 2021, 1641583800, null },
                    { 719519, 4, "2022-01-15T14:30:00+00:00", 0, null, "T. Welz", "Regular Season - 19", 2021, 1642257000, null },
                    { 719526, 4, "2022-01-23T16:30:00+00:00", 1, null, "B. Dankert", "Regular Season - 20", 2021, 1642955400, null },
                    { 719529, 2, "2022-02-05T17:30:00+00:00", 3, null, "S. Jablonski", "Regular Season - 21", 2021, 1644082200, null },
                    { 719545, 2, "2022-02-12T14:30:00+00:00", 4, null, "R. Schröder", "Regular Season - 22", 2021, 1644676200, null },
                    { 719547, 1, "2022-02-20T14:30:00+00:00", 4, null, "R. Hartmann", "Regular Season - 23", 2021, 1645367400, null },
                    { 719556, 1, "2022-02-26T17:30:00+00:00", 0, null, "F. Badstübner", "Regular Season - 24", 2021, 1645896600, null },
                    { 719565, 1, "2022-03-05T14:30:00+00:00", 1, null, "D. Siebert", "Regular Season - 25", 2021, 1646490600, null },
                    { 719580, 1, "2022-03-12T14:30:00+00:00", 1, null, "R. Schröder", "Regular Season - 26", 2021, 1647095400, null },
                    { 719583, 0, "2022-03-19T17:30:00+00:00", 4, null, "H. Osmers", "Regular Season - 27", 2021, 1647711000, null },
                    { 719597, 4, "2022-04-02T13:30:00+00:00", 1, null, "C. Dingert", "Regular Season - 28", 2021, 1648906200, null },
                    { 719601, 0, "2022-04-09T13:30:00+00:00", 1, null, "P. Ittrich", "Regular Season - 29", 2021, 1649511000, null },
                    { 719618, 3, "2022-04-17T13:30:00+00:00", 0, null, "M. Jöllenbeck", "Regular Season - 30", 2021, 1650202200, null },
                    { 719619, 1, "2022-04-23T16:30:00+00:00", 3, null, "D. Siebert", "Regular Season - 31", 2021, 1650731400, null },
                    { 719634, 1, "2022-04-30T13:30:00+00:00", 3, null, "S. Stegemann", "Regular Season - 32", 2021, 1651325400, null },
                    { 719637, 2, "2022-05-08T15:30:00+00:00", 2, null, "D. Aytekin", "Regular Season - 33", 2021, 1652023800, null },
                    { 719647, 2, "2022-05-14T13:30:00+00:00", 2, null, "R. Hartmann", "Regular Season - 34", 2021, 1652535000, null }
                });

            migrationBuilder.InsertData(
                table: "LeagueDb",
                columns: new[] { "Id", "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 2, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 3, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 4, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 5, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 6, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 7, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 8, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" }
                });

            migrationBuilder.InsertData(
                table: "LeagueDb",
                columns: new[] { "Id", "Country", "Flag", "LeagueId", "Logo", "Name" },
                values: new object[,]
                {
                    { 9, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 10, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 11, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 12, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 13, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 14, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 15, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 16, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 17, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 18, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 19, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 20, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 21, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 22, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 23, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 24, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 25, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 26, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 27, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 28, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 29, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 30, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 31, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 32, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 33, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" },
                    { 34, "Germany", "https://media.api-sports.io/flags/de.svg", 78, "https://media.api-sports.io/football/leagues/78.png", "Bundesliga 1" }
                });

            migrationBuilder.InsertData(
                table: "TeamDb",
                columns: new[] { "Id", "FixtureDbId", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 2, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 3, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 4, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 5, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 6, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 7, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 8, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 9, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 10, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 11, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 12, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 13, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 14, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 15, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 16, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 }
                });

            migrationBuilder.InsertData(
                table: "TeamDb",
                columns: new[] { "Id", "FixtureDbId", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 17, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 18, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 19, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 20, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 21, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 22, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 23, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 },
                    { 24, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 25, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 26, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 27, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 28, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 29, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 30, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 31, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 32, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 33, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 34, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 35, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 36, null, "https://media.api-sports.io/football/teams/163.png", "Borussia Monchengladbach", 163 },
                    { 37, null, "https://media.api-sports.io/football/teams/192.png", "FC Koln", 192 },
                    { 38, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 39, null, "https://media.api-sports.io/football/teams/159.png", "Hertha Berlin", 159 },
                    { 40, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 41, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 42, null, "https://media.api-sports.io/football/teams/173.png", "RB Leipzig", 173 },
                    { 43, null, "https://media.api-sports.io/football/teams/176.png", "VfL BOCHUM", 176 },
                    { 44, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 45, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 46, null, "https://media.api-sports.io/football/teams/178.png", "SpVgg Greuther Furth", 178 },
                    { 47, null, "https://media.api-sports.io/football/teams/169.png", "Eintracht Frankfurt", 169 },
                    { 48, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 49, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 50, null, "https://media.api-sports.io/football/teams/168.png", "Bayer Leverkusen", 168 },
                    { 51, null, "https://media.api-sports.io/football/teams/167.png", "1899 Hoffenheim", 167 },
                    { 52, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 53, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 54, null, "https://media.api-sports.io/football/teams/182.png", "Union Berlin", 182 },
                    { 55, null, "https://media.api-sports.io/football/teams/160.png", "SC Freiburg", 160 },
                    { 56, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 57, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 58, null, "https://media.api-sports.io/football/teams/170.png", "FC Augsburg", 170 }
                });

            migrationBuilder.InsertData(
                table: "TeamDb",
                columns: new[] { "Id", "FixtureDbId", "Logo", "Name", "TeamId" },
                values: new object[,]
                {
                    { 59, null, "https://media.api-sports.io/football/teams/188.png", "Arminia Bielefeld", 188 },
                    { 60, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 61, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 62, null, "https://media.api-sports.io/football/teams/165.png", "Borussia Dortmund", 165 },
                    { 63, null, "https://media.api-sports.io/football/teams/164.png", "FSV Mainz 05", 164 },
                    { 64, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 65, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 },
                    { 66, null, "https://media.api-sports.io/football/teams/172.png", "VfB Stuttgart", 172 },
                    { 67, null, "https://media.api-sports.io/football/teams/161.png", "VfL Wolfsburg", 161 },
                    { 68, null, "https://media.api-sports.io/football/teams/157.png", "Bayern Munich", 157 }
                });

            migrationBuilder.InsertData(
                table: "VenueDb",
                columns: new[] { "Id", "City", "Name", "VenueId" },
                values: new object[,]
                {
                    { 1, "Mönchengladbach", "Stadion im BORUSSIA-PARK", 703 },
                    { 2, "München", "Allianz Arena", 700 },
                    { 3, "München", "Allianz Arena", 700 },
                    { 4, "Leipzig", "Red Bull Arena", 738 },
                    { 5, "München", "Allianz Arena", 700 },
                    { 6, "Fürth", "Sportpark Ronhof Thomas Sommer", 718 },
                    { 7, "München", "Allianz Arena", 700 },
                    { 8, "Leverkusen", "BayArena", 699 },
                    { 9, "München", "Allianz Arena", 700 },
                    { 10, "Berlin", "Stadion An der Alten Försterei", 748 },
                    { 11, "München", "Allianz Arena", 700 },
                    { 12, "Augsburg", "WWK Arena", 698 },
                    { 13, "München", "Allianz Arena", 700 },
                    { 14, "Dortmund", "Signal-Iduna-Park", 702 },
                    { 15, "München", "Allianz Arena", 700 },
                    { 16, "Stuttgart", "Mercedes-Benz-Arena", 750 },
                    { 17, "München", "Allianz Arena", 700 },
                    { 18, "München", "Allianz Arena", 700 },
                    { 19, "Köln", "RheinEnergieStadion", 731 },
                    { 20, "Berlin", "Olympiastadion Berlin", 694 },
                    { 21, "München", "Allianz Arena", 700 },
                    { 22, "Bochum", "Vonovia Ruhrstadion", 751 },
                    { 23, "München", "Allianz Arena", 700 },
                    { 24, "Frankfurt am Main", "Deutsche Bank Park", 10491 },
                    { 25, "München", "Allianz Arena", 700 },
                    { 26, "Sinsheim", "PreZero Arena", 724 },
                    { 27, "München", "Allianz Arena", 700 },
                    { 28, "Freiburg im Breisgau", "Europa-Park Stadion", 12717 },
                    { 29, "München", "Allianz Arena", 700 },
                    { 30, "Bielefeld", "SchücoArena", 697 },
                    { 31, "München", "Allianz Arena", 700 },
                    { 32, "Mainz", "MEWA ARENA", 11899 }
                });

            migrationBuilder.InsertData(
                table: "VenueDb",
                columns: new[] { "Id", "City", "Name", "VenueId" },
                values: new object[] { 33, "München", "Allianz Arena", 700 });

            migrationBuilder.InsertData(
                table: "VenueDb",
                columns: new[] { "Id", "City", "Name", "VenueId" },
                values: new object[] { 34, "Wolfsburg", "VOLKSWAGEN ARENA", 752 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FixtureDb_LeagueDbId",
                table: "FixtureDb",
                column: "LeagueDbId");

            migrationBuilder.CreateIndex(
                name: "IX_FixtureDb_VenueDbId",
                table: "FixtureDb",
                column: "VenueDbId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamDb_FixtureDbId",
                table: "TeamDb",
                column: "FixtureDbId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "TeamDb");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "FixtureDb");

            migrationBuilder.DropTable(
                name: "LeagueDb");

            migrationBuilder.DropTable(
                name: "VenueDb");
        }
    }
}
