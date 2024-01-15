using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class SYstemVariables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeGroups", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "f120615f-bbcd-4c06-83c4-d030c2bbe7cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "278ccea0-a7ef-46e4-b75b-921d8bc218a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c26e360-e655-4633-b9d5-ec1ae8d2ecd0", "AQAAAAEAACcQAAAAEP56Cph5q+CEAMO3qU2SehPducKFNCvVdkAVX/VOyt95qMvQwuNpSDgmWUJ79yL1cQ==", "f2017e4f-5729-47dc-b018-c8a8bf6c12b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f221ce71-0220-422f-8715-5ae2386d60cc", "AQAAAAEAACcQAAAAEELpQwjovRwRoVKDHBNEaeS2qykYG6yAK8/XJiPkk9z+2n0Qfxgu2KcWwvomDQg/3g==", "445e90c6-72fa-48e1-8cac-40011556b49e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeGroups");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a332340e-e5f1-4205-aefe-46cf1c7e435f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "c563d81d-568f-4076-9718-0c20585efde3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d32e4c3-763a-41a9-9ba7-db7f72a1e9a3", "AQAAAAEAACcQAAAAEMetWDTDimPBhzOpAtwj0uRUbHLRqErDCc5d1N8aqb0n5KPoCJFJeZRbOtSe7ejbMw==", "a749735c-36ee-45ef-8a7e-541bbdbebdb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a25957b2-d087-4074-9eaf-6022360dddec", "AQAAAAEAACcQAAAAEODH8Zs2eDcYtJ5yYAY9g4oQxc9HZICXUTNNdYuiUuqlII0rb4w3q85MXOO21n64Rw==", "6be45fe6-3af8-42ae-976f-81ca75c93e04" });
        }
    }
}
