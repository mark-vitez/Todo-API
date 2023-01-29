using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoAPI.Migrations
{
    public partial class CreateTablesWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Done = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Lists_ListId",
                        column: x => x.ListId,
                        principalTable: "Lists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Lists",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[] { 1, new DateTime(2022, 6, 7, 18, 50, 0, 178, DateTimeKind.Local).AddTicks(9792), "Shopping list" });

            migrationBuilder.InsertData(
                table: "Lists",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[] { 2, new DateTime(2022, 6, 6, 18, 50, 0, 178, DateTimeKind.Local).AddTicks(9823), "For today" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreationDate", "Description", "Done", "ListId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 7, 18, 50, 0, 178, DateTimeKind.Local).AddTicks(9920), "Milk", false, 1 },
                    { 2, new DateTime(2022, 6, 7, 18, 50, 0, 178, DateTimeKind.Local).AddTicks(9924), "Egg", false, 1 },
                    { 3, new DateTime(2022, 6, 7, 18, 50, 0, 178, DateTimeKind.Local).AddTicks(9926), "Butter", false, 1 },
                    { 4, new DateTime(2022, 6, 7, 18, 50, 0, 178, DateTimeKind.Local).AddTicks(9928), "Code", false, 2 },
                    { 5, new DateTime(2022, 6, 7, 18, 50, 0, 178, DateTimeKind.Local).AddTicks(9931), "Exercise", false, 2 },
                    { 6, new DateTime(2022, 6, 7, 18, 50, 0, 178, DateTimeKind.Local).AddTicks(9933), "Cook dinner", false, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ListId",
                table: "Tasks",
                column: "ListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Lists");
        }
    }
}
