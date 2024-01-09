using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class ProductPolicyRequirements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ProductPolicyRequirements");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "26313bec-0aa0-4db8-9f2a-b36a6607e86b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a54d15ce-ddbd-4582-93a3-27aa36fe4fe6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60baf1c8-7178-4ebb-b622-973acbf6a84d", "AQAAAAEAACcQAAAAEPQxXIFod9gI1AuTszE4c3CyS/G2uhHtiAlcoPqpWXDjEPeS5kyQeiijqacjkKUlWg==", "83daf9fb-272c-4aab-84bd-9162bb3034db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77dec764-273d-472b-be7d-69dc4a2e584d", "AQAAAAEAACcQAAAAEBk4VOPmsyQIXQ3iUUljudVgdvTAQIjnaSBA19pCRejQ/TmUpDOrhIgV8p4Ru6G86w==", "2664d9c5-6eeb-4ac0-a359-44a6c11fb34f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "ProductPolicyRequirements",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a2edd5a2-dd51-4152-b009-b044042fbe0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "985e22d0-dca5-4529-80f3-b722ad79cded");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5103ff8e-19c1-45a6-a5f5-8aa563bd4a19", "AQAAAAEAACcQAAAAEI5j3OvLD11Dy9zZ7Qp6UMB/7De8nS7wcfc/wDi7kC/bCZx37PueoPqkSaD8qBz/iQ==", "adc89c9e-561d-4ed8-9781-0ab2db9ef2fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "495a1ff5-7497-4bf2-a712-5b72533106f4", "AQAAAAEAACcQAAAAEIDbVY8IyJdTxV1bPSrnksWMuVyORDgVrGxsGw2vfQ00rVBA4fe7Z3+h9kKTixhBVg==", "41a71daa-2b2e-4a83-adc4-c16698d1a0b3" });
        }
    }
}
