using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class PolicyTableUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Policies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "eaf3fb5d-8d77-446f-a462-2bf4fb6325df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "14b2792c-9db7-4d80-bc37-62ee82b0b1c3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3765c4b-10dc-41d4-9c9d-c77e1ed0863a", "AQAAAAEAACcQAAAAEAG4dXel+vP4Z6HasUkw13fsiEJj2NSsYCo7yDTfK+IU/d+dnle68lq9BBFIfrZyBg==", "602e2853-ee99-4c07-9e0c-be65e392c7f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f390ef15-f317-4c11-aa2b-6bcd2e67f79f", "AQAAAAEAACcQAAAAELgvoviWORZBj/y7bJq6C+6dx+yGn4aKrE/lo9eMgvIczDf8L7Xw513gzdiwSV5lKw==", "633dd05c-2621-41a6-9621-9f8353b468b4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Policies");

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
