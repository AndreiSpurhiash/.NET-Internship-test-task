using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Internship.Migrations
{
    public partial class raiting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("28f03a22-537a-4e05-9a7b-d095ac017967"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("60386695-9fed-4807-981c-cb0b0c774b14"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("8836d2cd-e88f-49fd-afab-f0947982d8d0"));

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: new Guid("1a6a68be-3643-49d6-b4a0-f04c393323ef"));

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: new Guid("e7fac413-61b1-40a0-a30d-499abcf6582e"));

            migrationBuilder.DropColumn(
                name: "Raiting",
                table: "Photos");

            migrationBuilder.AddColumn<int>(
                name: "AmountOfRaiting",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRaiting",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AmountOfRaiting", "AuthorId", "Coast", "DateOfCreation", "Link", "Name", "NumberOfRaiting", "NumberOfSales", "OriginalSize" },
                values: new object[,]
                {
                    { new Guid("1c9b0c4e-8c81-4664-91dc-2e10c54f1e2f"), 0, new Guid("14d5363b-0889-4b3d-aaa7-f456d7b0f195"), 100000m, new DateTime(2010, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "en.wikipedia.org/wiki/Sunflowers_(Van_Gogh_series)#/media/File:Vincent_Willem_van_Gogh_127.jpg", "Sunflowers", 0, 5, "100x100" },
                    { new Guid("743acd26-a04b-42d8-99ff-baa5427b6121"), 0, new Guid("1395039e-c3d8-4afb-811e-6a69ab3245bd"), 500000m, new DateTime(2015, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "en.wikipedia.org/wiki/Portrait_of_a_Wounded_KNIL_Soldier#/media/File:Gewonde_KNIL-militair_door_Isaac_Israels.jpg", "Gewonde KNIL-militair door", 0, 2, "1000x1500" },
                    { new Guid("ba571bd4-8757-45e2-aabb-d0da36979fbd"), 0, new Guid("f51cccd8-4c11-4c96-aff3-24b1b4922de7"), 200000m, new DateTime(2015, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "en.wikipedia.org/wiki/Isaac_Isra%C3%ABls#/media/File:Isaac_Israels_-_Donkeyride.jpg", "Riding Donkeys on the Beach", 0, 10, "1000x1000" }
                });

            migrationBuilder.InsertData(
                table: "Texts",
                columns: new[] { "Id", "AuthorId", "Coast", "DateOfCreation", "Name", "NumberOfSales", "text" },
                values: new object[,]
                {
                    { new Guid("5b199da0-c1ce-4638-9b58-e6e46fdbac88"), new Guid("ac898bde-ecc6-43c1-8f4b-a0d54dc17d47"), 10000m, new DateTime(2017, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Wounds", 5, "Time doesn’t heal wounds\r\nto make you forget." },
                    { new Guid("7cfd5aac-7ddd-491b-8602-c4543ab3bab1"), new Guid("b5f39d3b-4b8f-454b-8d20-a28be6271a40"), 5000m, new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camouflaged", 50, "In all chaotic beauty lies a wounded work of art.\r\nBeautiful but torn, wreaking havoc on my heart.\r\n\r\nSource: https://www.familyfriendpoems.com/poem/camouflaged" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("1c9b0c4e-8c81-4664-91dc-2e10c54f1e2f"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("743acd26-a04b-42d8-99ff-baa5427b6121"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("ba571bd4-8757-45e2-aabb-d0da36979fbd"));

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: new Guid("5b199da0-c1ce-4638-9b58-e6e46fdbac88"));

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: new Guid("7cfd5aac-7ddd-491b-8602-c4543ab3bab1"));

            migrationBuilder.DropColumn(
                name: "AmountOfRaiting",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "NumberOfRaiting",
                table: "Photos");

            migrationBuilder.AddColumn<double>(
                name: "Raiting",
                table: "Photos",
                type: "float8",
                nullable: false,
                defaultValue: 0.0);

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
        }
    }
}
