using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagingUserNotes.API.Migrations
{
    public partial class updatesedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1722), new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1724), new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1726), new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1728), new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Published", "UserId", "Views" },
                values: new object[] { 5, "Test new", new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1729), new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1730), true, 5, 0 });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Published", "UserId", "Views" },
                values: new object[] { 6, "Test new", new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1731), new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1731), true, 5, 0 });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Published", "UserId", "Views" },
                values: new object[] { 7, "Test new 4", new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1732), new DateTime(2023, 11, 17, 16, 45, 52, 801, DateTimeKind.Local).AddTicks(1733), true, 4, 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "LastName", "Website" },
                values: new object[] { 6, 42, "Test3@gmail.com", "hasan", "Taremi", "www.Test.ir" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "LastName", "Website" },
                values: new object[] { 7, 52, "Test4@gmail.com", "hossein", "Taremi", "www.Test.ir" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

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
    }
}
