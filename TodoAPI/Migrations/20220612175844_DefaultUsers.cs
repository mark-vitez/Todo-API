using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoAPI.Migrations
{
    public partial class DefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74c7228c-de6b-4ca5-991c-bc37f8a964b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cecee1b8-ef6c-4b00-8840-03eb0e8fd5af");

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 42, 9, 343, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Lists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 6, 11, 20, 42, 9, 343, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 42, 9, 343, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 42, 9, 343, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 42, 9, 343, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 42, 9, 343, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 42, 9, 343, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 6, 12, 20, 42, 9, 343, DateTimeKind.Local).AddTicks(2240));
        }
    }
}
