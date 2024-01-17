using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class BenefitTermCOlumn_Policy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BenefitTerm",
                table: "Policies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "229f0747-4911-485d-a27a-ddce74ca88b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "7ec4868f-cb53-4711-80c8-e97dc77cfc6c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39bac63f-c233-4d60-a4e2-fcda5c75ceca", "AQAAAAEAACcQAAAAENPTfIlE9ixJB4Wrx4nfc+AiEYiAGHnFvQhK+7uRsp0cTD6hik9kxcRpjgbGu01HTQ==", "1eefcd50-610d-4be3-99d0-773de573ac25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc37660a-fa95-43f1-8332-dd22ff14661d", "AQAAAAEAACcQAAAAED34ip4khLDIgrNaUQqUKmwUyArnpCvPXVPmHb2h7q0xk9fHXB6AJZeKEf4+6YTR3g==", "b9e07eb0-322a-4870-9792-1bbbbe7f4b67" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BenefitTerm",
                table: "Policies");

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
    }
}
