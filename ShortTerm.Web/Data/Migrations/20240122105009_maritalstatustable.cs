using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class maritalstatustable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "MaritalStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "MaritalStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "d7d67292-fa6a-43fb-991b-c21aa0a0fcaa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "e83c83ca-928a-4272-a9e3-57e4dd428da6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adcb500e-b0fa-4d0a-a587-e1c6db7dbc20", "AQAAAAEAACcQAAAAEBkM/2KM4HwDYDe26aUiVL+BenAtDOU+9EAvXMhfyvaeWTUuzJnQ99iHhhfG10YIKg==", "1a4599cf-b5ad-4fcb-96d7-8973aca2be6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed1ba327-854b-4c73-8991-df6f77a20ad2", "AQAAAAEAACcQAAAAEFNPj0eRPwaNChqt3srux+S9cX7O980oNQhbDeNShTYvDXMxl/+N0bp6PLwYdfLrQg==", "c4d5ac75-4dbd-49a0-aea5-4daff68e9346" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "MaritalStatuses");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "MaritalStatuses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "586a0c3c-ac82-47fe-b908-544dff24456a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a6f93ad8-aeaa-4257-9e3b-bbbd8a308e1d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7ac20fe-493a-4242-8f5a-85d26ef850de", "AQAAAAEAACcQAAAAEAvAR5a9vIYekaegbEXmUYZr8Ih4xwZYMgytYw8uqxmK4+Ttuir/CfporBc1MyCqxw==", "8b3e3dcb-82f1-4642-9b3e-2d16dd181954" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6938d9a-c3ee-4f87-aa4b-4fe008bc453d", "AQAAAAEAACcQAAAAEIOlnIfW65gP8Y9WTV62PTI0YeOv3SVP8Ybtw2lOLHylnN4D3bRD/no74u2OrGbfJg==", "297d6d02-fcba-4f4e-8bde-14584b1988ec" });
        }
    }
}
