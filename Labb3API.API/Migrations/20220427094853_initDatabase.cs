using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb3API.API.Migrations
{
    public partial class initDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyTitle = table.Column<string>(nullable: false),
                    HobbyDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Age = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "JoinHobbyUser",
                columns: table => new
                {
                    JoinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    HobbyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinHobbyUser", x => x.JoinId);
                    table.ForeignKey(
                        name: "FK_JoinHobbyUser_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinHobbyUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkUrl = table.Column<string>(nullable: true),
                    LinkDescription = table.Column<string>(nullable: true),
                    HobbyId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkId);
                    table.ForeignKey(
                        name: "FK_Links_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Links_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "HobbyDescription", "HobbyTitle" },
                values: new object[,]
                {
                    { 1, "Floorball is a type of floor hockey with five players and a goalkeeper in each team.", "Floorboll" },
                    { 2, "Game Development is the art of creating games and describes the design, development and release of a game.", "Game Development" },
                    { 3, "Beekeeping (or apiculture) is the maintenance of bee colonies, commonly in man-made hives, by humans.", "Beekeeping" },
                    { 4, "Sleep is associated with a state of muscle relaxation and reduced perception of environmental stimuli.", "Sleeping" },
                    { 5, "Hiking is a long, vigorous walk, usually on trails or footpaths in the countryside.", "Hiking" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1992, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Klara.Berg@Email.com", "Klara", "Berg", "0731509837" },
                    { 2, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "NallePuh@Honung.com", "Nalle", "Puh", "0731121122" },
                    { 3, new DateTime(1997, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia.Walter@Email.com", "Olivia", "Walter", "0731502323" },
                    { 4, new DateTime(1996, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joakim.Bjorklund@Email.com", "Joakim", "Björklund", "0708893321" },
                    { 5, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zelda.Pyttepatte@Miaumail.com", "Zelda", "Pyttepatte", "0703332221" }
                });

            migrationBuilder.InsertData(
                table: "JoinHobbyUser",
                columns: new[] { "JoinId", "HobbyId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 6, 5, 1 },
                    { 4, 3, 2 },
                    { 3, 2, 3 },
                    { 2, 1, 4 },
                    { 5, 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkId", "HobbyId", "LinkDescription", "LinkUrl", "UserId" },
                values: new object[,]
                {
                    { 2, 1, "A Webside with all new about swedish floorball", "https://innebandymagazinet.se/", 1 },
                    { 4, 5, "A Webside for the best hiking trails in Sweden", "https://visitsweden.com/what-to-do/nature-outdoors/hiking/top-hiking-routes-sweden/", 1 },
                    { 6, 3, "A Webside with tips and tricks for beekeeping beginners", "https://beebuilt.com/pages/beekeeping-for-beginners", 2 },
                    { 5, 2, "A Website for all the latest news in game development", "https://www.gamedeveloper.com/", 3 },
                    { 1, 1, "A Webside to the national swedish floorball commitee", "https://www.innebandy.se/", 4 },
                    { 3, 4, "A Link to a Youtube-video with 10 music for deep sleep", "https://www.youtube.com/watch?v=rulvcTfez5w", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoinHobbyUser_HobbyId",
                table: "JoinHobbyUser",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinHobbyUser_UserId",
                table: "JoinHobbyUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_HobbyId",
                table: "Links",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_UserId",
                table: "Links",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinHobbyUser");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
