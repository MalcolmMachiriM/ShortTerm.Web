using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class ClaimTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateApproved",
                table: "Claims",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "Claims",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "6cc2b768-b983-45d9-a71e-518f031fa9c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "fe494f79-33f2-4408-a945-6023f6b15c3f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25b7c3e3-538b-4a6f-8427-e3bbc40848aa", "AQAAAAEAACcQAAAAEG/ciTWQvO7whC9cegj8fJ5CBu5PeDpIEHxUHZHdP2ZPYw0AskBG4tlUz2mAFWe8GQ==", "e9bde9c7-e953-4b1a-a816-5a839647198a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "982cde9d-7981-4d9e-b102-de0708c0f3ea", "AQAAAAEAACcQAAAAEGhb5Ltuy1bLg7rU+aUZdikGdH0u0TRTOeKROPWewKleXzFA6ufoSaArpYRlNDGiKg==", "648932ee-7f9f-4b31-895f-7c31d9385ff0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateApproved",
                table: "Claims",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "Claims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "08c69ab8-c477-4aaa-a85b-5945faa79702");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "21fe6684-497a-4fd1-9df5-4f17cd82880b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df180ea9-9c92-4a2c-8b2c-2b03466b2a70", "AQAAAAEAACcQAAAAEF/Y7JooSoXcdFNvRgGrIy/vfVctZj04lbwNrOegC0R79bmn6tfQxnaSSv9C3xk6FQ==", "2e85d965-d091-446d-a439-d53246342394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bde514b-9077-4280-b905-fc274317b4aa", "AQAAAAEAACcQAAAAEM2nxVxDVv+/RvU3rkS9rm2bN1HGCeHwS4EGZtpvZl6sloQG2BBJvuIiyTvZtY5f5A==", "54fbb116-fe48-4c6c-97c3-94921b7ea7f7" });
        }
    }
}
