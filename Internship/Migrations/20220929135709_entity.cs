using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Internship.Migrations
{
    public partial class entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    NickName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    DateOfRegistration = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "date", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Coast = table.Column<decimal>(type: "decimal", nullable: false),
                    NumberOfSales = table.Column<int>(type: "int", nullable: false),
                    Raiting = table.Column<double>(type: "float8", nullable: false),
                    OriginalSize = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Texts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "date", nullable: false),
                    Coast = table.Column<decimal>(type: "decimal", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    NumberOfSales = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Texts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateOfBirth", "DateOfRegistration", "FirstName", "LastName", "NickName" },
                values: new object[,]
                {
                    { new Guid("1395039e-c3d8-4afb-811e-6a69ab3245bd"), new DateTime(1995, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mike", "Luis", "Lu" },
                    { new Guid("14d5363b-0889-4b3d-aaa7-f456d7b0f195"), new DateTime(1994, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", "Ivanov", "Pushkin" },
                    { new Guid("ac898bde-ecc6-43c1-8f4b-a0d54dc17d47"), new DateTime(1989, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piter", "Brown", "Pity" },
                    { new Guid("b5f39d3b-4b8f-454b-8d20-a28be6271a40"), new DateTime(1979, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frenck", "Olsen", "Olsen" },
                    { new Guid("f51cccd8-4c11-4c96-aff3-24b1b4922de7"), new DateTime(1975, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jhon", "Simons", "Simon" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AuthorId", "Coast", "DateOfCreation", "Link", "Name", "NumberOfSales", "OriginalSize", "Raiting" },
                values: new object[,]
                {
                    { new Guid("28f03a22-537a-4e05-9a7b-d095ac017967"), new Guid("1395039e-c3d8-4afb-811e-6a69ab3245bd"), 500000m, new DateTime(2015, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "en.wikipedia.org/wiki/Portrait_of_a_Wounded_KNIL_Soldier#/media/File:Gewonde_KNIL-militair_door_Isaac_Israels.jpg", "Gewonde KNIL-militair door", 2, "1000x1500", 0.0 },
                    { new Guid("60386695-9fed-4807-981c-cb0b0c774b14"), new Guid("14d5363b-0889-4b3d-aaa7-f456d7b0f195"), 100000m, new DateTime(2010, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "en.wikipedia.org/wiki/Sunflowers_(Van_Gogh_series)#/media/File:Vincent_Willem_van_Gogh_127.jpg", "Sunflowers", 5, "100x100", 0.0 },
                    { new Guid("8836d2cd-e88f-49fd-afab-f0947982d8d0"), new Guid("f51cccd8-4c11-4c96-aff3-24b1b4922de7"), 200000m, new DateTime(2015, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "en.wikipedia.org/wiki/Isaac_Isra%C3%ABls#/media/File:Isaac_Israels_-_Donkeyride.jpg", "Riding Donkeys on the Beach", 10, "1000x1000", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Texts",
                columns: new[] { "Id", "AuthorId", "Coast", "DateOfCreation", "Name", "NumberOfSales", "text" },
                values: new object[,]
                {
                    { new Guid("1a6a68be-3643-49d6-b4a0-f04c393323ef"), new Guid("b5f39d3b-4b8f-454b-8d20-a28be6271a40"), 5000m, new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camouflaged", 50, "In all chaotic beauty lies a wounded work of art.\r\nBeautiful but torn, wreaking havoc on my heart.\r\n\r\nSource: https://www.familyfriendpoems.com/poem/camouflaged" },
                    { new Guid("e7fac413-61b1-40a0-a30d-499abcf6582e"), new Guid("ac898bde-ecc6-43c1-8f4b-a0d54dc17d47"), 10000m, new DateTime(2017, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Wounds", 5, "Time doesn’t heal wounds\r\nto make you forget." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AuthorId",
                table: "Photos",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Texts_AuthorId",
                table: "Texts",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Texts");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
