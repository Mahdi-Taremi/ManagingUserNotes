using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagingUserNotes.API.Migrations
{
    public partial class ok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 41, 53, 657, DateTimeKind.Local).AddTicks(5356), new DateTime(2023, 11, 17, 16, 41, 53, 657, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 41, 53, 657, DateTimeKind.Local).AddTicks(5359), new DateTime(2023, 11, 17, 16, 41, 53, 657, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 41, 53, 657, DateTimeKind.Local).AddTicks(5361), new DateTime(2023, 11, 17, 16, 41, 53, 657, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 41, 53, 657, DateTimeKind.Local).AddTicks(5364), new DateTime(2023, 11, 17, 16, 41, 53, 657, DateTimeKind.Local).AddTicks(5365) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 41, 10, 65, DateTimeKind.Local).AddTicks(225), new DateTime(2023, 11, 17, 16, 41, 10, 65, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 41, 10, 65, DateTimeKind.Local).AddTicks(229), new DateTime(2023, 11, 17, 16, 41, 10, 65, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 41, 10, 65, DateTimeKind.Local).AddTicks(231), new DateTime(2023, 11, 17, 16, 41, 10, 65, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 41, 10, 65, DateTimeKind.Local).AddTicks(233), new DateTime(2023, 11, 17, 16, 41, 10, 65, DateTimeKind.Local).AddTicks(233) });
        }
    }
}
