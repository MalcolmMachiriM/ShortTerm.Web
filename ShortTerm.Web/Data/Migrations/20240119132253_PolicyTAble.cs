using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class PolicyTAble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Policies");

            migrationBuilder.DropColumn(
                name: "NationalID",
                table: "Policies");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Policies");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "faa58a86-b2b4-4cc5-bfbf-93da85b59c83");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "3a90b9dd-f053-45a5-b684-1d1306ca2c6c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "229effe8-c588-46fc-960b-d2eb3bcf84d0", "AQAAAAEAACcQAAAAEPnf6Y6WUP0wAhgfUqLBdIMshVZrDu1nQ+PIzBTEEPlEB8GZVKKrX1m78uNYdSF/aQ==", "df1bc98d-a5f0-4b9b-8152-8af952a12ae5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13ea9bd0-3b16-4563-935b-4669bdb22f08", "AQAAAAEAACcQAAAAEIxko5hxXpJW9mTi0rJRtqwKYVQbXYGf5ucea8NeviKe8nm2ezGPYaVBTgqT7yYaAw==", "4f859a0c-1393-46b8-98a1-be3253330f10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Policies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalID",
                table: "Policies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Policies",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
