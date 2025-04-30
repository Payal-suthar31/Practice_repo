using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddNewChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "general",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_general", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    generalid = table.Column<int>(type: "int", nullable: false),
                    ReleaseDa = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_general_generalid",
                        column: x => x.generalid,
                        principalTable: "general",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "general",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "action" },
                    { 2, "Sci-fi" },
                    { 3, "fantasy" },
                    { 4, "horror" },
                    { 5, "romance" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Price", "ReleaseDa", "generalid" },
                values: new object[,]
                {
                    { 1, "inception", 12, new DateOnly(2003, 2, 3), 1 },
                    { 2, "dark host", 15, new DateOnly(2006, 3, 7), 2 },
                    { 3, "the matrix", 16, new DateOnly(2008, 8, 5), 3 },
                    { 4, "the lord", 18, new DateOnly(2009, 3, 8), 4 },
                    { 5, "god", 20, new DateOnly(2004, 6, 9), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_generalid",
                table: "Movies",
                column: "generalid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "general");
        }
    }
}
