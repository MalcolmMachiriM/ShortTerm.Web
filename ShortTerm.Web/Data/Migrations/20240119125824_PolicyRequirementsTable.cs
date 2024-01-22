using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class PolicyRequirementsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegNo",
                table: "ProductPolicyRequirements");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "c2b04b08-1c86-4ad8-ae63-e938f2a0fe81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "e00dd9ed-84ec-4b98-b631-406210647c20");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6601c42d-f58b-4903-9a89-02ba14d2aa0f", "AQAAAAEAACcQAAAAEGduX/RY+w0QIY+2IHo7YNUUSd9lxeQjGG7sWtHq2MQdPAbIZfCnl/Hbe4r+2Gc/yQ==", "b257dc51-6f34-4233-920c-4709c526d2d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f12c3b9-87dc-4ade-8e6c-6757cae34fed", "AQAAAAEAACcQAAAAEMpIWz/SP3sV9vAgBzZdhSFiuZxB9ducyFoNqWfIijnJNu9CZ3ziBEhWcvx+k//PNA==", "60e97f8d-d049-4729-b032-d26fbd56e962" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegNo",
                table: "ProductPolicyRequirements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "e28d874a-d50b-40e1-8f0f-9aa2461ba267");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "29de0ecd-0888-47a9-8713-b51c6e0d4766");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7841e73-bceb-47e4-b89d-f38ea8457fe6", "AQAAAAEAACcQAAAAEIcoTQ/lymB3ISj22t3dBEnpgwW4PegoPT+qObjZ9w8/BXFnpgmaosYb8qjQdqY36Q==", "bb091e9f-2b86-47a5-a961-a10a04b8ee1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ca4c168-86ef-4bba-8221-2bc164eb3b72", "AQAAAAEAACcQAAAAEOmRHQJrICzUHPbYoUOEOaZyllPX/Ym8dD/5Qit7OelNq07oeIhDv9ExGMd+PaC/QA==", "b894e3f2-2aad-426a-82c2-2cafcec28374" });
        }
    }
}
