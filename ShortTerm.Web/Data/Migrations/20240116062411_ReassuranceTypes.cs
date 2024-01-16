using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class ReassuranceTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReassuranceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descriptiom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReassuranceTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "d39bb513-089b-467a-ae5c-8e6fe33ac5f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "07677ae6-7187-4f9a-8c1e-14b99c0db40d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9015c1df-34a5-42da-8c84-1db31d1a9f00", "AQAAAAEAACcQAAAAEHkAB4Mo+XcVmD3ysAgnA5axNhBvIMpHmB7JXn1GlkpIbqgmtZlyP5u+sc1j6gsQIg==", "df27bb71-fe51-48d1-88a2-06fb6279c37d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b35cfc53-0109-4af1-80ce-abfeadaa03fc", "AQAAAAEAACcQAAAAEKSPV7tol9XKsYj0/0ReA7R8phsSIgBGBVVsxL2GZ0SabTGqwxNSTWtNlOIe6xl1Ag==", "cacc3fc4-cda1-483a-8223-4752c98bf0a4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReassuranceTypes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "6388521d-e6b5-4cea-8c84-6656b6e54553");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "f5f433aa-3ec9-4762-8f96-9db75590d236");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35eb8ed3-89a9-4537-b00e-91b9fe1669b5", "AQAAAAEAACcQAAAAEMhS2/D85Bwtex1pRAedQsZsG7SX0c5k+E6P2YTZ53q0OjoU2AFfxnrKown2qmmxCw==", "091baebc-9c34-4271-8dd2-08e82aaf8aa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f61c97e-911a-4c10-a4c0-6365ca8b5e5e", "AQAAAAEAACcQAAAAEDTR9hnrnJY7547IrfHGcj4e4fU7n0hAcHCWKORXtjtL8DOWsZfJuYUht6+nclefBw==", "9b30f9b4-0980-4649-9896-833d06c9554c" });
        }
    }
}
