using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class updatemaritalstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "141a0faf-8d4f-49f7-90ce-0363b1c67a18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "bbca917e-8681-4873-850d-361940f39bb1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afbbe580-abad-4670-b0d1-2a2b431fbd04", "AQAAAAEAACcQAAAAEKTGi+iC8XwKZrCRMPBUo8KDMWLk0WfV04Bbc7XggMoLN2Erd4lJKVtWYWJYu+K/gg==", "4dc396bb-e91c-453a-af23-c32331b1239e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0788e57-dc2d-48f1-80c7-5d6d75d3a8d2", "AQAAAAEAACcQAAAAEFb24KPj9/VTlAUr5wJ92564ae4XgQ5wHDFOwvIwJk7o9K76MuPXxooCc2oBZk/kpw==", "b20d9e50-c94d-4d5e-9e15-0787a1c8956c" });
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
                values: new object[] { "adcb500e-b0fa-4d0a-a587-e1c6db7dbc20", "AQAAAAEAACcQAAAAEBkM/2KM4HwDYDe26aUiVL+BenAtDOU+9EAvXMhfyvaeWTUuzJnQ99iHhhfG10YIKg==", "1a4599cf-b5ad-4fcb-96d7-8973aca2be6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed1ba327-854b-4c73-8991-df6f77a20ad2", "AQAAAAEAACcQAAAAEFNPj0eRPwaNChqt3srux+S9cX7O980oNQhbDeNShTYvDXMxl/+N0bp6PLwYdfLrQg==", "c4d5ac75-4dbd-49a0-aea5-4daff68e9346" });
        }
    }
}
