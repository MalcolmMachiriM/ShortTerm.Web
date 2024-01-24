using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class newmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "614bb5d0-77c7-4c90-b96c-9fcf1a0a80ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "e871fbf8-5f53-4bb7-9936-397ffe65d098");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9baf3f13-7b06-4bb5-96fd-154bf11da2e1", "AQAAAAEAACcQAAAAEIuSdhnEZ2/FGNp2QkyDc962XMfCC6rabWygryh9TnjY3BSc01Ec4yTQEHcuv7Cihg==", "62903b7a-82e2-44da-8273-f568541d6221" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbed8b34-ee00-4347-97a2-0b243968237b", "AQAAAAEAACcQAAAAEPSAR+1X+OQNR2n+LXarKK7OwPN2p7B0egnxGEE2Tvp5YxtOSvfdl2YbwmvCzxurmw==", "6ca73388-e1db-4d9c-a842-119b0ea9d943" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "7882e39e-6859-414f-bf15-5ff3fcd307c1", "AQAAAAEAACcQAAAAEBUaZH8E1GcBCRNkjkODX8I3uv5YqJqu64xUCi/gPN5nrG11Nf3NbRgqrqLenuf4zA==", "ac119476-85d7-40f4-a960-ab55ac8c236b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09009dd5-ae7e-4cac-8859-ac21fc07761d", "AQAAAAEAACcQAAAAEDgRwd04QhWtX8K/VhRsE/jR0l2lyeOFQaYE5PSkC/OD19IgSZDZ+oWe7XmKWeTQHA==", "6fb50049-41f4-435e-a6e0-3289bc3b305c" });
        }
    }
}
