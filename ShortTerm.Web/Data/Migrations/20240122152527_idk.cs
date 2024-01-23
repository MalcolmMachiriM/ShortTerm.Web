using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class idk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "f06998c9-6324-4511-98f1-0c61a3acda8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "be84df05-d5b7-4ba5-8ef6-b9ea216d40cc");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "7d4ba881-3d2c-4129-9793-de1dbe6874b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "02b92f3f-f253-414e-8c52-8b7f6ca626ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db12daa7-1fd7-4866-8a22-2b27cd94ae42", "AQAAAAEAACcQAAAAEEKgJ1w0Gc7IEXNlcsQwPsdN4Glny7giBKOAH5b8ETYQUwnS+3zJa+WVUtcAbrr39g==", "bbc4ddf7-a1b9-404d-8fc3-e68a524b8108" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5365af4c-3a4c-4ad8-8df1-d686f29c3b25", "AQAAAAEAACcQAAAAEF+VdmJ9K8q9GKqiFakdSBNvQUHMWGGbv+AKn4f5IWK5JkAuIXiTQMZvcz6ZqKvYiQ==", "2484303c-013e-4851-a1b0-e35cb17ab01f" });
        }
    }
}
