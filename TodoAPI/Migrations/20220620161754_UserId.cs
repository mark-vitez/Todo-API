using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoAPI.Migrations
{
    public partial class UserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74c7228c-de6b-4ca5-991c-bc37f8a964b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cecee1b8-ef6c-4b00-8840-03eb0e8fd5af");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Lists",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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
                columns: new[] { "CreationDate", "UserId" },
                values: new object[] { new DateTime(2022, 6, 20, 19, 17, 53, 901, DateTimeKind.Local).AddTicks(3484), "95595cef-679e-4eb0-b92a-d816dfe5bb32" });

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UserId" },
                values: new object[] { new DateTime(2022, 6, 19, 19, 17, 53, 901, DateTimeKind.Local).AddTicks(3513), "d5fcf5c6-f9f7-4225-ad57-a49a531e45c8" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Lists");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "74c7228c-de6b-4ca5-991c-bc37f8a964b4", "452bdf83-cfed-4f0b-bf49-b93a8d5c57bc", "User", "USER" },
                    { "cecee1b8-ef6c-4b00-8840-03eb0e8fd5af", "1fdd0ccb-1844-404c-a886-b12177e5d824", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 58, 44, 73, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 6, 11, 20, 58, 44, 73, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 58, 44, 73, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 58, 44, 73, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 58, 44, 73, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 58, 44, 73, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 58, 44, 73, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 58, 44, 73, DateTimeKind.Local).AddTicks(7173));
        }
    }
}
