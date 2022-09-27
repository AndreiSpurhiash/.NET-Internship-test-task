using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Internship.Migrations
{
    public partial class entityadd : Migration
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
                    DateOfRegistration = table.Column<DateTime>(type: "timestamp", nullable: false)
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
                    DateOfCreation = table.Column<DateTime>(type: "timestamp", nullable: false),
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
                    DateOfCreation = table.Column<DateTime>(type: "timestamp", nullable: false),
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
