using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagingUserNotes.API.Migrations
{
    public partial class AddSeedDatafornoteandmodifytherelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Published", "UserId", "Views" },
                values: new object[] { 1, "This is First Note", new DateTime(2023, 11, 16, 17, 6, 25, 335, DateTimeKind.Local).AddTicks(9320), new DateTime(2023, 11, 16, 17, 6, 25, 335, DateTimeKind.Local).AddTicks(9321), true, 1, 0 });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Published", "UserId", "Views" },
                values: new object[] { 2, "This is Second Note", new DateTime(2023, 11, 16, 17, 6, 25, 335, DateTimeKind.Local).AddTicks(9323), new DateTime(2023, 11, 16, 17, 6, 25, 335, DateTimeKind.Local).AddTicks(9323), true, 2, 0 });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Published", "UserId", "Views" },
                values: new object[] { 3, "This is Third Note", new DateTime(2023, 11, 16, 17, 6, 25, 335, DateTimeKind.Local).AddTicks(9325), new DateTime(2023, 11, 16, 17, 6, 25, 335, DateTimeKind.Local).AddTicks(9325), true, 1, 0 });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Published", "UserId", "Views" },
                values: new object[] { 4, "Test", new DateTime(2023, 11, 16, 17, 6, 25, 335, DateTimeKind.Local).AddTicks(9327), new DateTime(2023, 11, 16, 17, 6, 25, 335, DateTimeKind.Local).AddTicks(9328), true, 1, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
