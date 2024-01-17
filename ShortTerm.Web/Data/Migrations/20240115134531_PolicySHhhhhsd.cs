using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class PolicySHhhhhsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "5e5aa057-dc59-47b1-8f44-f4dd0f63a13d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "afbb5622-c74b-4b8f-957c-0c3f89581a8f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4244d6a-bbb9-469e-86f6-b5d0ef4d8902", "AQAAAAEAACcQAAAAECEAhnkRckBZdXTUeFfjhTzMImgTRa7oaNVVf/NeM1/2L5GanAOokOAubMX0LFlucg==", "cfc627b8-6b02-439a-ba9c-c5d55dc0a99c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b1d2958-c740-4705-8359-525642c15a23", "AQAAAAEAACcQAAAAEKTwgpHoH2J/xG7py40BNyzi6xxrv1fzk7hZcNUnC28P/DDNuo8BdjvgS/G/4Hpfjg==", "bae17c06-88b1-4151-bba9-a92330eeb928" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "33917122-d389-49af-b10f-0bf6bac442b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "9cb47be7-2150-473d-8e2d-e06bb7a3dd9a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b284bfb-90e7-4498-9cd6-ef0016fdc3a9", "AQAAAAEAACcQAAAAEBWxuJSwFDIjc1fMRLwAFFTd8W93OAlvAgDR8qHkg6EGeVO2TlKjZewsgT3M6lCK8Q==", "d9af48ce-33fd-410a-9be5-0e049e4fe507" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b6a7c01-3d2a-47fd-acd4-aa39fc09a7e7", "AQAAAAEAACcQAAAAEF1lZHBfmprzxcod2cWf0bAQp6l/6ZgqM9OIepdlB4of6ZiLCh86DO0DkWXcV4oK/Q==", "4fa21317-c73a-47e6-9120-14b5721751ba" });
        }
    }
}
