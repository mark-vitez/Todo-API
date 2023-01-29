using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoAPI.Migrations
{
    public partial class createDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lists_AspNetUsers_UserId",
                table: "Lists");

            migrationBuilder.DropIndex(
                name: "IX_Lists_UserId",
                table: "Lists");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6396e770-01ed-4ee8-8a51-de5eecd18a0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec7311a6-b076-4e4c-a134-7c9f317859ab");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Lists",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5000b253-74cb-4cc3-91be-6d4d74ccaf50", "db18df15-4927-425c-bb68-29c12fa6c6a1", "Administrator", "ADMINISTRATOR" },
                    { "8bd815e7-a99e-4f7e-bf66-7843326fecd1", "86270906-cf69-45ab-9299-6d47a38bfa6e", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 1, 19, 23, 20, 33, 609, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 1, 18, 23, 20, 33, 609, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 1, 19, 23, 20, 33, 609, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 1, 19, 23, 20, 33, 609, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 1, 19, 23, 20, 33, 609, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 1, 19, 23, 20, 33, 609, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 1, 19, 23, 20, 33, 609, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 1, 19, 23, 20, 33, 609, DateTimeKind.Local).AddTicks(8256));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5000b253-74cb-4cc3-91be-6d4d74ccaf50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bd815e7-a99e-4f7e-bf66-7843326fecd1");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Lists",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6396e770-01ed-4ee8-8a51-de5eecd18a0f", "3be16908-3ae6-48e9-bac8-3a8f18dbad0a", "Administrator", "ADMINISTRATOR" },
                    { "ec7311a6-b076-4e4c-a134-7c9f317859ab", "51f66109-8826-43d3-97ed-6e568f9e02e6", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 19, 17, 53, 901, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 6, 19, 19, 17, 53, 901, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 19, 17, 53, 901, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 19, 17, 53, 901, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 19, 17, 53, 901, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 19, 17, 53, 901, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 19, 17, 53, 901, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 19, 17, 53, 901, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.CreateIndex(
                name: "IX_Lists_UserId",
                table: "Lists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lists_AspNetUsers_UserId",
                table: "Lists",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
