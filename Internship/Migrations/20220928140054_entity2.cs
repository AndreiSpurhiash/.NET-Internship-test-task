using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Internship.Migrations
{
    public partial class entity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("2440da2f-69d7-472c-b926-1de1a7b07d8a"), new Guid("f51cccd8-4c11-4c96-aff3-24b1b4922de7"), 200000m, new DateTime(2015, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "en.wikipedia.org/wiki/Isaac_Isra%C3%ABls#/media/File:Isaac_Israels_-_Donkeyride.jpg", "Riding Donkeys on the Beach", 10, "1000x1000", 0.0 },
                    { new Guid("4d6ba9bb-f058-4066-b06e-34fc8953a2fb"), new Guid("1395039e-c3d8-4afb-811e-6a69ab3245bd"), 500000m, new DateTime(2015, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "en.wikipedia.org/wiki/Portrait_of_a_Wounded_KNIL_Soldier#/media/File:Gewonde_KNIL-militair_door_Isaac_Israels.jpg", "Gewonde KNIL-militair door", 2, "1000x1500", 0.0 },
                    { new Guid("6b2b6435-99a6-4cd1-b793-30386df7b651"), new Guid("14d5363b-0889-4b3d-aaa7-f456d7b0f195"), 100000m, new DateTime(2010, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "en.wikipedia.org/wiki/Sunflowers_(Van_Gogh_series)#/media/File:Vincent_Willem_van_Gogh_127.jpg", "Sunflowers", 5, "100x100", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Texts",
                columns: new[] { "Id", "AuthorId", "Coast", "DateOfCreation", "Name", "NumberOfSales", "text" },
                values: new object[,]
                {
                    { new Guid("a7cf62d8-cc35-46ac-b44b-1fd94916f88f"), new Guid("b5f39d3b-4b8f-454b-8d20-a28be6271a40"), 5000m, new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camouflaged", 50, "In all chaotic beauty lies a wounded work of art.\r\nBeautiful but torn, wreaking havoc on my heart.\r\n\r\nSource: https://www.familyfriendpoems.com/poem/camouflaged" },
                    { new Guid("c60feef0-ab1f-4c55-a6ee-7db72c9a72de"), new Guid("ac898bde-ecc6-43c1-8f4b-a0d54dc17d47"), 10000m, new DateTime(2017, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Wounds", 5, "Time doesn’t heal wounds\r\nto make you forget." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("2440da2f-69d7-472c-b926-1de1a7b07d8a"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("4d6ba9bb-f058-4066-b06e-34fc8953a2fb"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("6b2b6435-99a6-4cd1-b793-30386df7b651"));

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: new Guid("a7cf62d8-cc35-46ac-b44b-1fd94916f88f"));

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: new Guid("c60feef0-ab1f-4c55-a6ee-7db72c9a72de"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1395039e-c3d8-4afb-811e-6a69ab3245bd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("14d5363b-0889-4b3d-aaa7-f456d7b0f195"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac898bde-ecc6-43c1-8f4b-a0d54dc17d47"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5f39d3b-4b8f-454b-8d20-a28be6271a40"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f51cccd8-4c11-4c96-aff3-24b1b4922de7"));
        }
    }
}
